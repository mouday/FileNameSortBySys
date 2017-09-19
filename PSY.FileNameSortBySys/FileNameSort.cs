﻿using System;
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
        /// <param name="Files"></param>
        /// <returns>sortedFiles</returns>
        public static FileInfo[]  SortFiles(FileInfo[] Files)
        {
            Array.Sort(Files, new FileNameCompare());
            return Files;
        }
    }
}
