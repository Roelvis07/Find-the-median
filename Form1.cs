using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_the_median
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<int> arr = new List<int>() { 1, 20, 5, 32, 40, 62, 73, 84, 9,55 };
            Console.WriteLine(findMedian(arr));
        }
        public static int findMedian(List<int> arr)
        {
            int median = 0;
            arr = arr.OrderBy(c => c).ToList<int>();
            int mid = arr.Count / 2;
            median = (arr.Count % 2 != 0) ? arr[mid] : (arr[mid - 1] + arr[mid]) / 2;

            return median;
        }
    }
}
