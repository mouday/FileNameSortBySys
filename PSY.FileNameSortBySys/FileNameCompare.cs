using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FileNameSortBySys
{
    ///<summary>
    ///主要用于文件名的比较，不要修改
    ///</summary>
    public class FileNameCompare : IComparer<object>
    {
        //调用DLL  
        [DllImport("Shlwapi.dll", CharSet = CharSet.Unicode)]
        private static extern int StrCmpLogicalW(string param1, string param2);


        //前后文件名进行比较 
        public int Compare(object obj1, object obj2)
        {
            if (null == obj1 && null == obj2)
            {
                return 0;
            }
            if (null == obj1)
            {
                return -1;
            }
            if (null == obj2)
            {
                return 1;
            }
            return StrCmpLogicalW(obj1.ToString(), obj2.ToString());
        }

    }
}
