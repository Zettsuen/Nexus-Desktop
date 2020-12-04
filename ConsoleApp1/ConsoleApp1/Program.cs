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
            string args = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"Captura");

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
            Console.WriteLine(directory.Length);
            String new_directory = e.FullPath.Substring(0,directory.Length - 7);
            new_directory += "NexusClips\\";
            Console.WriteLine(new_directory);
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(new_directory))
                {
                    Console.WriteLine("That path exists already.");

                }
                else {

                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(new_directory);
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(new_directory));

                }

                
            }
            catch (Exception a)
            {
                Console.WriteLine("The process failed: {0}", a.ToString());
            }
            finally { }
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine($"ffmpeg.exe -sseof -30 -i {e.FullPath} -vcodec libx264 -crf 28 {new_directory}jugada-nexus-{path}");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            File.Delete(e.FullPath);


        }



    }
}

