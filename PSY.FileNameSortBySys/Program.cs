using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileNameSortBySys
{
    class Program
    {
        public static void SortFiles()
        {
            //string filePath = @"D:\GitHub\FileNameSortBySys\PSY.FileNameSortBySys\测试文件\files";

            //方式一：通过文件信息排序

            //DirectoryInfo di = new DirectoryInfo(filePath);
            //FileInfo[] arrFiles = di.GetFiles("*.*");

            //Console.WriteLine("========原始=====");
            //for (int i = 0; i < arrFiles.Length; i++)
            //    Console.WriteLine(arrFiles[i].Name);

            //FileInfo[] newArrFiles = FileNameSort.sortFiles(arrFiles);

            //Console.WriteLine("========排序=====");
            //for (int i = 0; i < newArrFiles.Length; i++)
            //    Console.WriteLine(newArrFiles[i].Name);

            //方式二：通过文件名排序
            //string[] files = Directory.GetFiles(filePath);        
            string filename = @"D:\GitHub\FileNameSortBySys\PSY.FileNameSortBySys\测试文件\filenames.txt";

            string[] filenames = File.ReadAllLines(filename);
            
            //原始顺序
            List<string> filelist = filenames.ToList();
            Console.WriteLine("========原始=====");
            foreach (string file in filelist)
            {
                Console.WriteLine(file);
            }

            //普通排序
            filelist.Sort();
            Console.WriteLine("========普通排序=====");
            foreach (string file in filelist)
            {
                Console.WriteLine(file);
            }

            //文件排序
            List<string> newFiles = FileNameSort.sortFiles(filelist);
            Console.WriteLine("========文件排序=====");
            foreach (string file in filelist)
            {
                Console.WriteLine(file);
            }
        }
        static void Main(string[] args)
        {
            SortFiles();
        }
    }
}
