using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.ComponentModel;	

namespace Tools
{
	public class W32
	{
		////The use of SuppressUnmanagedCodeSecurity
		//[DllImport( "kernel32.dll" )/*, SuppressUnmanagedCodeSecurity*/]
		//private unsafe static extern int FormatMessage(
		//                                    int dwFlags,
		//                                    ref IntPtr lpSource,
		//                                    int dwMessageId,
		//                                    int dwLanguageId,
		//                                    ref String lpBuffer, int nSize,
		//                                    IntPtr* Arguments );
		
	}


	#region	FileLoader
	public class W32_FileLoader
	{
		public const short FILE_ATTRIBUTE_NORMAL = 0x80;
		public const short INVALID_HANDLE_VALUE = -1;
		public const uint GENERIC_READ = 0x80000000;
		public const uint GENERIC_WRITE = 0x40000000;
		public const uint CREATE_NEW = 1;
		public const uint CREATE_ALWAYS = 2;
		public const uint OPEN_EXISTING = 3;
		private SafeFileHandle handleValue = null;

		public W32_FileLoader( string Path )
		{
			Load( Path );
		}
		public void Load( string Path )
		{
			if( Path == null && Path.Length == 0 )
			{
				throw new ArgumentNullException( "Path" );
			}
			// try to open the file.
			handleValue = CreateFile( Path, GENERIC_WRITE, 0, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero );
			// and throw a Win32Exception.
			if( handleValue.IsInvalid )
			{
				Marshal.ThrowExceptionForHR( Marshal.GetLastWin32Error() );
			}
		}
		public SafeFileHandle Handle
		{
			get
			{
				// If the handle is	valid,
				if( !handleValue.IsInvalid )
				{
					return handleValue;
				}
				else
				{
					return null;
				}
			}
		}

		[DllImport( "KERNEL32", SetLastError = true )]
		private static extern void FlushFileBuffers( IntPtr handle );

		// Use interop to call the CreateFile function.
		[DllImport( "kernel32.dll", SetLastError = true )]
		static extern SafeFileHandle CreateFile( string lpFileName, uint dwDesiredAccess, uint dwShareMode,
												  IntPtr lpSecurityAttributes, uint dwCreationDisposition,
												  uint dwFlagsAndAttributes, IntPtr hTemplateFile );
	}
	#endregion
}
