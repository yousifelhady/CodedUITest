using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest
{
    public enum Type
    {
        launchTestGUIApp
    }

    public class AutoLoader
    {
        public const string TEMP_DIR = "C:\\GUITest";
        public string WorkDirectory
        {
            get
            {
                return TEMP_DIR;
            }
        }

        // list of projects available for testing
        private static Dictionary<Type, AutoLoader> _files = new Dictionary<Type, AutoLoader>()
        {
            {Type.launchTestGUIApp, new AutoLoader {RelativePath = @"..\..\..\TestGUI\bin\Debug", AppExe = "TestGUI.exe" } },
        };

        public static AutoLoader PrepareLoader (Type type)
        {
            if (!_files.ContainsKey(type))
                throw new Exception("Project Not Found");

            var file = _files[type];

            // copy to test automation directory
            string filePath = getAbsolutePath(file.RelativePath, Directory.GetCurrentDirectory());
            DirectoryHelpers.DirectoryCopy(filePath, TEMP_DIR);

            return file;
        }

        public string AppExePath
        {
            get { return System.IO.Path.Combine(TEMP_DIR, AppExe); }
        }

        public string RelativePath { get; private set; }
        public string AppExe { get; private set; }

        private static string getAbsolutePath(string filespec, string folder)
        {
            Uri pathUri = new Uri(filespec, UriKind.Relative);

            // folder must end in a slash
            if (!folder.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()))
                folder += System.IO.Path.DirectorySeparatorChar;

            Uri folderUri = new Uri(folder, UriKind.Absolute);

            return new Uri(folderUri, pathUri).LocalPath;
        }
    }
}
