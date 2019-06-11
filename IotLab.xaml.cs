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
        private string temp;
        private int hour;
        private string hour_s;

        public Page1()
        {
            var date = DateTime.Now;
            hour = date.Hour;
            hour_s = DateTime.Now.ToString("dddd, MMMM d, yyyy HH:mm:ss tt");

            InitializeComponent();

            this.DataContext = this;

            var Data = DatabaseAnalysis.getDailyData("Temperature", "Node2");
            var arr = DatabaseAnalysis.getGraphData(Data);

            for (int i = 0; i < 24; i+= 1)
            {
                /*
                if (hour - i > 0)
                {
                    temp += "\nTime: " + hour_s + " Temperature: " + arr[i];
                }
                else
                {
                    temp += "\nTime: " + (24 - i) + " Temperature: " + arr[i];
                }
                */
                temp += "\nTime: " + hour_s + " Temperature: " + arr[i];

            }

        }
     
        public string Test

        {

            get { return temp; }

            set { temp = value; }

        }
       
    }
}
