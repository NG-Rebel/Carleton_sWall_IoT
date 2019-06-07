using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private string _test;
        private int hour;

        public Page1()
        {
            var date = DateTime.Now;
            hour = date.Hour;

            InitializeComponent();

            this.DataContext = this;

        }


        public string Test

        {

            get { return _test; }

            set { test = value; }

        }


        public int GetData
        {
            int avg = 0;
        //Temperature data into a string and get average temp
        int[] data = DatabaseAnalysis.GetGraphData("Temperature", "Node2");
            for (int i = 0; i< 24; i++)
            {
                avg += data[i];

                if (hour - i< 0)
                {
                    test += "TIME: " + (24 + hour - i) + ":00    Temp (°C):" + data[i].ToString() + "\n";
                }
                else
                {
                    test += "TIME: " + (hour - i) + ":00    Temp (°C):" + data[i].ToString() + "\n";
                }
                
            }

            //get average temperature of last 24 hours 
            return = avg / 24;
        
        }
    }
}
