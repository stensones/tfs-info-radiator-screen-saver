namespace TfsPortalRadiatorScreenSaver
{
	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Linq;
	using System.Runtime.InteropServices;
	using System.Text;

	/// <summary>
	/// NativeMethods does what now?
	/// </summary>
	public static class NativeMethods
	{
		public const int URLMON_OPTION_USERAGENT = 0x10000001;

		// Changes the parent window of the specified child window
		[DllImport("user32.dll")]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		// Changes an attribute of the specified window
		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

		// Retrieves information about the specified window
		[DllImport("user32.dll", SetLastError = true)]
		public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		// Retrieves the coordinates of a window's client area
		[DllImport("user32.dll")]
		public static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

		[DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
		public static extern int UrlMkSetSessionOption(int dwOption, string pBuffer, int dwBufferLength, int dwReserved);
	}
}
