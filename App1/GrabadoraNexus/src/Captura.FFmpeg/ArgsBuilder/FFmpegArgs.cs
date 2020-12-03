using System.Collections.Generic;

namespace Captura.Models
{
    public abstract class FFmpegArgs
    {
        public readonly List<string> Args = new List<string>();

        public virtual string GetArgs()
        {
            return string.Join(" ", Args);
        }
    }
}