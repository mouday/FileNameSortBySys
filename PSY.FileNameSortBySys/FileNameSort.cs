using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileNameSortBySys
{
    public class FileNameSort
    {
        /// <summary>
        /// C#按文件名排序（顺序）
        /// </summary>
        /// <param name="files">文件信息列表</param>
        /// <returns>sortedFiles</returns>
        public static FileInfo[]  sortFiles(FileInfo[] files)
        {
            Array.Sort(files, new FileNameCompare());
            return files;
        }

        /// <summary>
        /// 文件名列表排序
        /// </summary>
        /// <param name="files">文件名列表</param>
        /// <returns></returns>
        public static List<string> sortFiles(List<string> files)
        {
            files.Sort(new FileNameCompare());
            return files;
        }
    }
}
