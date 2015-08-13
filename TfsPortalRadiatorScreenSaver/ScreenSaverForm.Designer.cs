﻿namespace TfsPortalRadiatorScreenSaver
{
	partial class ScreenSaverForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.timPageChange = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// webBrowser
			// 
			this.webBrowser.AllowWebBrowserDrop = false;
			this.webBrowser.CausesValidation = false;
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser.Location = new System.Drawing.Point(0, 0);
			this.webBrowser.Margin = new System.Windows.Forms.Padding(50);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.ScriptErrorsSuppressed = true;
			this.webBrowser.ScrollBarsEnabled = false;
			this.webBrowser.Size = new System.Drawing.Size(723, 467);
			this.webBrowser.TabIndex = 0;
			this.webBrowser.WebBrowserShortcutsEnabled = false;
			this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser_DocumentCompleted);
			this.webBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.WebBrowser_Navigating);
			this.webBrowser.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.WebBrowser_PreviewKeyDown);
			// 
			// timPageChange
			// 
			this.timPageChange.Interval = 10000;
			this.timPageChange.Tick += new System.EventHandler(this.TimPageChange_Tick);
			// 
			// ScreenSaverForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(723, 467);
			this.Controls.Add(this.webBrowser);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ScreenSaverForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseMove);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.Timer timPageChange;
	}
}

