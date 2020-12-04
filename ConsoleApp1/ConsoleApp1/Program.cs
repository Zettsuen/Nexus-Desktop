using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Permissions;
using System.Diagnostics;

namespace Captura.Base
{

    class Program
    {
        public static void Main()
        {
            Run();
        }
        private static void Run()
        {
            string args = "C:\\Users\\Panta\\OneDrive\\Documentos\\Captura\\2020-12-03";

            // If a directory is not specified, exit program.
            /*if (args.Length != 2)
            {
                // Display the proper way to call the program.
                Console.WriteLine("Usage: Watcher.exe (directory)");
                return;
            }*/

            // Create a new FileSystemWatcher and set its properties.
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = args;

                // Watch for changes in LastAccess and LastWrite times, and
                // the renaming of files or directories.
                watcher.NotifyFilter = NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;

                // Only watch text files.
                watcher.Filter = "*.mp4";

                // Add event handlers.
                watcher.Created += OnChanged;

                // Begin watching.
                watcher.EnableRaisingEvents = true;

                // Wait for the user to quit the program.
                Console.WriteLine("Press 'q' to quit the sample.");
                while (Console.Read() != 'q') ;
            }
        }

        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e) {
            String path = Path.GetFileName(e.FullPath);
            String directory = Path.GetDirectoryName(e.FullPath);
            int position = e.FullPath.IndexOf(path);
            String new_directory = e.FullPath.Substring(position);
            Console.WriteLine(new_directory);
            //Console.WriteLine(path);
            //Console.WriteLine(directory);
           /* Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine($"ffmpeg.exe -sseof -30 -i {e.FullPath} -vcodec libx264 -crf 28 {directory}\\jugada-nexus-{path}");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());*/
            //Console.Write($"ffmpeg.exe -sseof -30 -i {e.FullPath} -vcodec libx264 -crf 28 {directory}\\jugada-nexus-{path}");
            
            }
            // Specify what is done when a file is changed, created, or deleted.
            //Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
            
            //Process.Start($"ffmpeg.exe -sseof -30 -i {e.FullPath} -vcodec libx264 -crf 28 jugada-nexus-{e.FullPath}");
            

    }
}

