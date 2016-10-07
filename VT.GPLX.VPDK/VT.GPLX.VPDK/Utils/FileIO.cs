using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using log4net;

namespace VT.GPLX.VPDK.Utils
{
    public class FileIO
    {
        //public static string destFolder = Properties.Settings.Default.destFolder;
        private static readonly ILog log = LogManager.GetLogger(typeof(FileIO));
        public static string destFolder = "";

        public static bool MoveFiles(string fromFile,string toFile)
        {
            destFolder = toFile;
            if (!File.Exists(fromFile))
            {
                return false;
            }
            string[] arrPath = fromFile.Split('\\');
            string FileName = arrPath[arrPath.Length-1];
            string FolderAnh = arrPath[arrPath.Length - 2];
            
            //Kiem tra may dich da co duong folder chua anh chua
            if (!checkFolder(FolderAnh))
            {
                createFolder(FolderAnh);
            }
            //Kiem tra ten anh co ton tai khong
            if (checkFileName(FolderAnh, FileName))//da ton tai
            {
                FileName = FileName + DateTime.Now.ToString("hhmmss");
            }
            try
            {
                CopyFile(fromFile, FolderAnh, FileName);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void CopyFile(string sourceFileName, string folderAnh,string FileName)
        {
            string destFile = Path.Combine(destFolder, folderAnh, FileName);
            File.Copy(sourceFileName, destFile,true);
        }
        public static bool checkFolder(string folderName)
        {
            string path = Path.Combine(destFolder, folderName);
            return Directory.Exists(path);
        }
        private static bool checkFileName(string FolderAnh, string FileName)
        {
            string path = Path.Combine(destFolder, FolderAnh, FileName);
            return Directory.Exists(path);
        }
        public static void createFolder(string folderName)
        {
            string path = Path.Combine(destFolder, folderName);
            log.Debug(path);
            Directory.CreateDirectory(path);
        }
    }
}
