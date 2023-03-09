using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class DataClass
    {
        public static int Count = 0;
        public Form1? form1_main;
        public Form2? form2_search;
        public ErrorForm? errorForm;
        public FormReplace? formReplace;
        public FormGoTo? formGoTo;
        public DataClass() { Count++; }
    }
}
