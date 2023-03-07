using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class DataClass
    {
        public static int objectCounter = 0;
        public static List<Form1> form1_main = new List<Form1>();
        public static List<Form2> form2_search = new List<Form2>();
        public static List<ErrorForm> errorForm = new List<ErrorForm>();
        public static List<FormReplace> formReplace = new List<FormReplace>();
        public static List<FormGoTo> formGoTo = new List<FormGoTo>();

        public static void SetCapacity(int range)
        {
            form1_main.Capacity = range;
            form2_search.Capacity = range;
            errorForm.Capacity = range;
            formReplace.Capacity = range;
            formReplace.Capacity = range;
        }
        //public static Form1 form1_main = new Form1();
        //public static Form2? form2_search;
        //public static ErrorForm? errorForm;
        //public static FormReplace? formReplace;
        //public static FormGoTo? formGoTo;
    }
}
