namespace Captura
{
    public class CustomFFmpegCodec : PropertyStore
    {
        public string Name
        {
            get => Get("Custom");
            set => Set(value);
        }

        public string Args
        {
            get => Get("-vcodec libx264 -crf 30");
            set => Set(value);
        }

        public string Extension
        {
            get => Get(".mp4");
            set => Set(value);
        }

        public string AudioFormat
        {
            get => Get("Mp3");
            set => Set(value);
        }
    }
}