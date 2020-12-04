using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using Accord.Video.FFMPEG;
using System.Runtime.InteropServices;

namespace Nexus
{
    class ScreenRecorder
    {
        //MINUTO 17:09
        //https://www.youtube.com/watch?v=kTCmjSFodpM&ab_channel=TermSpar
        //Video variables
        private Rectangle bounds;
        private string outputPath = "";
        private string tempPath = "";
        private int fileCount = 1;
        private List<string> inputImageSequence = new List<string>();

        //File variables
        private string audioName = "mic.wav";
        private string videoName = "video.mp4";
        private string finalName = "finalVideo.mp4";

        //Time variable
        Stopwatch watch = new Stopwatch();

        //Audio variables
        public static class NativeMethods
        {
            [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
            private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        }

        public ScreenRecorder(Rectangle b, string outPath)
        {
            CreateTempFolder("tmpNexus");

            bounds = b;
            outputPath = outPath;
        }

        private void CreateTempFolder(string name)
        {
            if (Directory.Exists("C:\\"))
            {
                string pathName = $"C:\\{name}";
                Directory.CreateDirectory(pathName);
                tempPath = pathName;
            }
        }

        private void DeletePath(string targetDir)
        {
            string[] files = Directory.GetFiles(targetDir);
            string[] dirs = Directory.GetDirectories(targetDir);

            foreach(string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }
            foreach (string dir in dirs)
            {
                DeletePath(dir);
            }
            Directory.Delete(targetDir,false);
        }
        private void DeleteFilesExcept(string targetFile, string excFile)
        {
            string[] files = Directory.GetFiles(targetFile);

            foreach (string file in files)
            {
                if (file != excFile)
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.Delete(file);
                }
            }
        }

    }
}
