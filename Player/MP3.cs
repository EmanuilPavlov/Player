using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    internal class MP3
    {
        

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);
        public void open(string File)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);
        }
        public void play(int selectIndex, string s)
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void pause()
        {
            string command = "pause MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void close(string File)
        {
            string command = "close MediaFile";
            mciSendString(command, null, 0, 0);
        }

    }
}

