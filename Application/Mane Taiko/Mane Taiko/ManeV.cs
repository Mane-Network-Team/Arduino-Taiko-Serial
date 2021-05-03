using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO.Ports;
using System.Windows.Input;
using System.ComponentModel;

namespace Mane_Taiko
{
    public class ManeV
    {
        public static string Language = "ZH";
        public static Frame UI_MainFrame { get; set; }

        public class USB
        {
            public static string COM = "";
            public static int Speed = 9600;
            public static SerialPort serial_port = null;
        }
        public class Keys
        {
            public static int ACode = (char)'z';
            public static int BCode = (char)'x';
            public static int CCode = (char)'c';
            public static int DCode = (char)'v';
        }
        public class Count
        {
            public static uint A = 0;
            public static uint B = 0;
            public static uint C = 0;
            public static uint D = 0;

        }
    }
}
