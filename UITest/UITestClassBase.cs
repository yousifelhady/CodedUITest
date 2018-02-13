using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest
{
    [CodedUITest]
    public class UITestClassBase
    {
        private const int TRIALS_TO_DELETE_LOCKED_FILES = 5;
        [TestInitialize]
        public void Initialize()
        {
            DeleteTempDirectory();
        }

        /// <summary>
        /// Files may be locked by OS for a while after process have been killed.
        /// This causes the test to fail, because files can't be deleted.
        /// Tests shows that 10 seconds are enough for files to be released.
        /// Instead of Thread.Sleep(10 seconds), 5 trials are done with 2 seconds between every trial
        /// </summary>
        private static void DeleteTempDirectory()
        {
            int trials = 0;
            while (trials < TRIALS_TO_DELETE_LOCKED_FILES)
            {
                try
                {
                    if (Directory.Exists(AutoLoader.TEMP_DIR))
                        DirectoryHelpers.DeleteDirectoryContents(AutoLoader.TEMP_DIR);

                    break;
                }
                catch
                {
                    System.Threading.Thread.Sleep(2000);
                    trials++;
                }
            }
        }
    }
}
