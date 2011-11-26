using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Linq_char01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = { 12, 56, 4, 152, 18, 19, 12 };
            IEnumerable ie = arr.Select(p => p).Where(p=>p>50);
            IEnumerator result = ie.GetEnumerator();
            while (result.MoveNext())
            {
                Console.WriteLine(result.Current);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s = "liu tianping";
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToPastal());
        }
       
    }
    public static class ExtraClas
    {
        public static String ToPastal(this String s)
        {
            return s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
        }
    }
}
