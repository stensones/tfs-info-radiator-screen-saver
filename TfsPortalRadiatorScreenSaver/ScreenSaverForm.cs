﻿namespace TfsPortalRadiatorScreenSaver
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Threading;
	using System.Windows.Forms;

	public partial class ScreenSaverForm : Form
	{
		private bool active;
		private Point mouseLocation;
		private Settings settings;
		private uint pageNumber;
		private List<Uri> pageUrls;

		public ScreenSaverForm()
		{
			this.InitializeComponent();

			// pretend to be IE 11 so pages aren't wingeing about us being an unsupported browser.
			var ua = "Mozilla/5.0 (IE 11.0; Windows NT 6.3; Trident/7.0; .NET4.0E; .NET4.0C; rv:11.0) like Gecko";
			NativeMethods.UrlMkSetSessionOption(NativeMethods.URLMON_OPTION_USERAGENT, ua, ua.Length, 0);
		}

		public ScreenSaverForm(IntPtr previewHandle)
			: base()
		{
			NativeMethods.SetParent(this.Handle, previewHandle);
			NativeMethods.SetWindowLong(this.Handle, -16, new IntPtr(NativeMethods.GetWindowLong(this.Handle, -16) | 0x40000000));
			Rectangle parentRect;
			NativeMethods.GetClientRect(previewHandle, out parentRect);
			this.Size = parentRect.Size;
			this.Location = new Point(0, 0);
			////this.previewMode = true;

			////webBrowser.Scale(new SizeF(0.1f, 0.1f));
		}

		private void ScreenSaverForm_Load(object sender, EventArgs e)
		{
			this.settings = new Settings();
			this.settings.LoadSettings();
			this.active = false;

			Cursor.Hide();

			this.pageNumber = 0;
			this.GeneratePageUrls();
			this.TimPageChange_Tick(null, EventArgs.Empty);

			this.timPageChange.Enabled = true;
		}

		private void ScreenSaverForm_MouseDown(object sender, MouseEventArgs e)
		{
			this.Close();
		}

		private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
		{
			// If the mouseLocation still points to 0,0, move it to its actual 
			// location and save the location. Otherwise, check to see if the user
			// has moved the mouse at least 10 pixels.
			if (!this.active)
			{
				this.mouseLocation = new Point(e.X, e.Y);
				this.active = true;
			}
			else
			{
				if ((Math.Abs(e.X - this.mouseLocation.X) > 10) ||
					(Math.Abs(e.Y - this.mouseLocation.Y) > 10))
				{
					this.Close();
				}
			}
		}

		private void GeneratePageUrls()
		{
			this.pageUrls = new List<Uri>();
			var baseUri = new Uri(string.Format(CultureInfo.InvariantCulture, "http://{0}:{1}/tfs/{2}/{3}/", this.settings.TfsServerName, this.settings.TfsPortNumber, this.settings.ColectionName, this.settings.ProjectName));

			if (this.settings.ShowPortalPage)
			{
				this.pageUrls.Add(baseUri);
			}

			if (this.settings.ShowBuilds)
			{
				this.pageUrls.Add(new Uri(baseUri, "_build"));
			}

			if (this.settings.ShowFeatures)
			{
				this.pageUrls.Add(new Uri(baseUri, "_backlogs/board/Features#fullScreen=true"));
			}

			if (this.settings.ShowBacklog)
			{
				if (this.settings.TemplteIsScrum)
				{
					this.pageUrls.Add(new Uri(baseUri, "_backlogs/board/Backlog%20items#fullScreen=true"));
				}
				else
				{
					this.pageUrls.Add(new Uri(baseUri, "_backlogs/board/Stories#fullScreen=true"));
				}
			}

			if (this.settings.ShowTaskBoard)
			{
				this.pageUrls.Add(new Uri(baseUri, "_backlogs/TaskBoard/#_a=requirements&fullScreen=true"));
			}

			if (this.settings.ShowSprintGoal)
			{
				this.pageUrls.Add(this.GenerateSprintGoalWebPage());
			}
		}

		private void TimPageChange_Tick(object sender, EventArgs e)
		{
			var nextPage = this.GetNextPageUri();
			this.webBrowser.Navigate(nextPage);
			this.WaitForBrowserReady();
		}

		private void WaitForBrowserReady()
		{
			try
			{
				while (this.webBrowser.ReadyState != WebBrowserReadyState.Complete)
				{
					Application.DoEvents();
					Thread.Sleep(30);
				}
			}
			catch (ObjectDisposedException)
			{
				// swallow
			}
		}

		private Uri GetNextPageUri()
		{
			var uri = this.pageUrls[(int)this.pageNumber];

			this.pageNumber++;
			this.pageNumber %= (uint)this.pageUrls.Count;

			return uri;
		}

		private Uri GenerateSprintGoalWebPage()
		{
			var filename = Path.GetTempFileName().Replace(".tmp", ".html");
			using (var file = new FileStream(filename, FileMode.CreateNew))
			{
				using (var txt = new StreamWriter(file))
				{
					txt.Write(this.CreateSpintGoalPageContent());
				}
			}

			return new Uri("file://" + filename);
		}

		private string CreateSpintGoalPageContent()
		{
			var pageContent = new StringBuilder(@"<HTML>
	<HEAD>
		<STYLE>
			body {
				font-family : ""Segoe UI"";
				text-align: center;
			}

			h1 {
				font-family : ""Segoe UI Black"";
				font-size : 10em;
			}

			UL {
				font-size : 4em;
				list-style-type: none;
			}
		</STYLE>
		<TITLE>Sprint Goals</TITLE>
	</HEAD>
	<BODY>
		<H1>Sprint Goals</H1>
		<UL>
");
			foreach (var goal in this.settings.SprintGoals)
			{
				pageContent.AppendFormat("<LI>{0}</LI>\r\n", goal);
			}

			pageContent.Append(@"		</UL>
	</BODY>
</HTML>");
			return pageContent.ToString();
		}

		private void WebBrowser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			this.Close();
		}
		
		private void Document_MouseDown(object sender, HtmlElementEventArgs e)
		{
			this.Close();
		}
		
		private void Document_MouseMove(object sender, HtmlElementEventArgs e)
		{
			// If the mouseLocation still points to 0,0, move it to its actual 
			// location and save the location. Otherwise, check to see if the user
			// has moved the mouse at least 10 pixels.
			if (!this.active)
			{
				this.mouseLocation = new Point(e.MousePosition.X, e.MousePosition.Y);
				this.active = true;
			}
			else
			{
				if ((Math.Abs(e.MousePosition.X - this.mouseLocation.X) > 10) ||
					(Math.Abs(e.MousePosition.Y - this.mouseLocation.Y) > 10))
				{
					this.Close();
				}
			}
		}

		private void WebBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
		{
			if (this.webBrowser.Document != null)
			{
				this.webBrowser.Document.MouseDown -= this.Document_MouseDown;
				this.webBrowser.Document.MouseMove -= this.Document_MouseMove;
			}
		}

		private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			if (this.webBrowser.Document != null)
			{
				this.webBrowser.Document.MouseDown += this.Document_MouseDown;
				this.webBrowser.Document.MouseMove += this.Document_MouseMove;
			}
		}
	}
}