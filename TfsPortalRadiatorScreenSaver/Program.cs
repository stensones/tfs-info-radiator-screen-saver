namespace TfsPortalRadiatorScreenSaver
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Windows.Forms;

	public static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// <param name="args">Command line arguments</param>
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Program.ParseCommandLine(args);
		}

		private static void ParseCommandLine(string[] args)
		{
			/*
			 * ScreenSaver           - Show the Settings dialog box.
			 * ScreenSaver /c        - Show the Settings dialog box, modal to the foreground window.
			 * ScreenSaver /p <HWND> - Preview Screen Saver as child of window <HWND>.
			 * ScreenSaver /s        - Run the Screen Saver.
			 */
			if (args.Length > 0 && args[0].Length > 1)
			{
				switch (args[0].ToLowerInvariant().Substring(0, 2))
				{
					case "/c":
						Program.RunSettingsForm();
						break;
					case "/p":
						if (args.Length > 1)
						{
							long handle;
							if (long.TryParse(args[1], out handle))
							{
								Program.RunPreviewForm(new IntPtr(handle));
							}
						}

						break;
					case "/s":
					default:
						Program.RunScreenSaver();
						break;
				}
			}
			else
			{
				Program.RunSettingsForm();
			}
		}

		private static void RunPreviewForm(IntPtr handle)
		{
			var screenSaverForm = new ScreenSaverForm(handle);
			Application.Run(screenSaverForm);
		}

		private static void RunSettingsForm()
		{
			var settingsForm = new SettingsForm();
			Application.Run(settingsForm);
		}

		private static void RunScreenSaver()
		{
			var screenSaverForm = new ScreenSaverForm();
			Application.Run(screenSaverForm);
		}
	}
}
