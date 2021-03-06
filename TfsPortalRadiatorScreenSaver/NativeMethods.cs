﻿namespace TfsPortalRadiatorScreenSaver
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
		internal const int URLMON_OPTION_USERAGENT = 0x10000001;

		// Changes the parent window of the specified child window
		[DllImport("user32.dll")]
		internal static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		// Changes an attribute of the specified window
		[DllImport("user32.dll")]
		internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		// Retrieves information about the specified window
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		// Retrieves the coordinates of a window's client area
		[DllImport("user32.dll")]
		internal static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

		[DllImport("urlmon.dll", CharSet = CharSet.Unicode)]
		internal static extern int UrlMkSetSessionOption(int dwOption, StringBuilder pBuffer, int dwBufferLength, int dwReserved);
	}
}
