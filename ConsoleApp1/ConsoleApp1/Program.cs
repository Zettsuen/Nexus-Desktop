using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Permissions;
using System.Diagnostics;
using System.Linq;

namespace Captura.Base
{

    class Program
    {
        public static void Main()
        {
			Run(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Nexus/"));
		}

		private static void Run(string args)
		{

			DirectoryInfo f1 = new DirectoryInfo(args);
			var myFile = f1.GetFiles()
			 .OrderByDescending(f => f.LastWriteTime)
			 .First();
			var b = myFile.FullName;
			var a = myFile.Name;
			var c = b.Substring(0,b.Length - a.Length);
			Console.WriteLine(c);
			Process cmd = new Process();
			cmd.StartInfo.FileName = "cmd.exe";
			cmd.StartInfo.RedirectStandardInput = true;
			cmd.StartInfo.RedirectStandardOutput = true;
			cmd.StartInfo.CreateNoWindow = true;
			cmd.StartInfo.UseShellExecute = false;
			cmd.Start();
			cmd.StandardInput.WriteLine($"ffmpeg.exe -sseof -30 -i {b} -vcodec libx264 -crf 28 {c}jugada-nexus-{a}");
			cmd.StandardInput.Flush();
			cmd.StandardInput.Close();
			cmd.WaitForExit();
			Console.WriteLine(cmd.StandardOutput.ReadToEnd());
			myFile.Delete();


		}


	}
}

