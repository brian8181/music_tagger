using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Tools
{
	public static class FileMask
	{

        /// <summary>
        ///  returns a set of masked files, this makes a has any logic??
        /// </summary>
        /// <param name="files"></param>
        /// <param name="mask"></param>
        /// <returns></returns>
        public static List<FileSystemInfo> IncludeAttributes(List<FileSystemInfo> files, FileAttributes mask)
        {
            int len = files.Count;
            List<FileSystemInfo> ls = new List<FileSystemInfo>(len);
            for (int i = 0; i < len; ++i)
            {
                if ((files[i].Attributes & mask) != 0)
                {
                    ls.Add(files[i]); // included 
                }
            }

            return ls;
        }

        public static List<FileSystemInfo> IncludeAttributes(FileSystemInfo[] files, FileAttributes mask)
        {
            return IncludeAttributes(new List<FileSystemInfo>(files), mask);
        }

        // the logic the bitwise flags for this are not correct
        ///// <summary>
        /////  returns a set of masked files
        ///// </summary>
        ///// <param name="files"></param>
        ///// <param name="mask"></param>
        ///// <returns></returns>
        //public static List<FileSystemInfo> ExcludeAttributes(List<FileSystemInfo> files, FileAttributes mask)
        //{
        //    int len = files.Count;
        //    List<FileSystemInfo> ls = new List<FileSystemInfo>(len);
        //    for (int i = 0; i < len; ++i)
        //    {
        //        if ((files[i].Attributes & mask) == 0)
        //        {
        //            ls.Add(files[i]);
        //        }
        //    }

        //    return ls;
        //}

        //public static List<FileSystemInfo> ExcludeAttributes(FileSystemInfo[] files, FileAttributes mask)
        //{
        //    return ExcludeAttributes(new List<FileSystemInfo>(files), mask);        
        //}


		///// <summary>
		///// Exclusive
		///// </summary>
		///// <param name="files"></param>
		///// <param name="mask"></param>
		///// <returns></returns>
		//public static ArraySegment<FileSystemInfo> AppyMaskEx( FileSystemInfo[] files, FileAttributes mask )
		//{
		//    return ApplyMask( files, ~mask );
		//}

		/// <summary>
		///  returns a set of masked files
		/// </summary>
		/// <param name="files"></param>
		/// <param name="mask"></param>
		/// <returns></returns>
		public static List<FileSystemInfo> AppyMask( List<FileSystemInfo> files, FileAttributes mask )
		{
			int len = files.Count;
			List<FileSystemInfo> ls = new List<FileSystemInfo>(len); 
			for(int i = 0;i <	len;++i)
			{
				if((files[i].Attributes & mask) != 0)
				{
					ls.Add(files[i]);
				}
			}
			
			return ls;
		}
	}

	public static class Func<T>
	{
		public delegate void AsynDelegate( T[] objs, VoidDelegate del );
		public delegate void VoidDelegate( T obj );
		public delegate bool BoolDelegate( T obj );
	
		public static void FOR_EACH_ASYNC( T[] objs, VoidDelegate del )
		{
			AsynDelegate async_del = new AsynDelegate( FOR_EACH );
			async_del.BeginInvoke( objs, del, null, null );
		}

		public static void FOR_EACH( T[] objs, VoidDelegate del )
		{
			int c =	objs.Length;
			for(int i = 0;i <	c;++i)
			{
				del.Invoke( objs[i] );
			}
		}

		public static bool FOR_EACH_CK( T[] objs, BoolDelegate del )
		{
			int c =	objs.Length;
			for(int i = 0;i <	c;++i)
			{
				if(!del.Invoke( objs[i] ))
					return false;
			}
			return true;
		}
	}
}
