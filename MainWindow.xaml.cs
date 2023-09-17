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
using BakeryLibrary;
//using static BakeryLibrary.Baker;

namespace CSharpCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public string NumberOne;
        //public string NumberTwo;

        public bool ClearInput = false;

        //public int AdditionResults;
        //public int SubtractResults;
        //public int MultiplyResults;
        //public int DivideResults;
        public MainWindow()
        {
            InitializeComponent();
            //text1.Text = "Clear input on calculation: off";
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtNumberOne.Text)/* && !lstResults.Items.Contains(txtNumberOne.Text)*/)
            {
                //AdditionResults = Convert.ToInt32(txtNumberOne.Text) - Convert.ToInt32(txtNumberTwo.Text);
                lstResults.Items.Add( Baker.IntAdd(Convert.ToInt32(txtNumberOne.Text), Convert.ToInt32(txtNumberTwo.Text)) );
                if (ClearInput)
                {
                    txtNumberOne.Clear();
                    txtNumberTwo.Clear();
                }
            }
        }

        private void ButtonSubtractName_Click(object sender, RoutedEventArgs e)
        {
            /*
            if (!string.IsNullOrWhiteSpace(txtNumberOne.Text))
            {
                //AdditionResults = Convert.ToInt32(txtNumberOne.Text) - Convert.ToInt32(txtNumberTwo.Text);
                lstResults.Items.Add( Main.IntSub(Convert.ToInt32(txtNumberOne.Text), Convert.ToInt32(txtNumberTwo.Text)) );
                if (ClearInput)
                {
                    txtNumberOne.Clear();
                    txtNumberTwo.Clear();
                }
            }
            */
            lstResults.Items.Add(IntToPower(2, 2));
        }

        public static int IntToPower(int w, int x)
        {
            //return (w * w) * x;
            return (w * x) * x;
        }

        private void ButtonMultiplyName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumberOne.Text))
            {
                //AdditionResults = Convert.ToInt32(txtNumberOne.Text) * Convert.ToInt32(txtNumberTwo.Text);
                lstResults.Items.Add( Baker.IntMul(Convert.ToInt32(txtNumberOne.Text), Convert.ToInt32(txtNumberTwo.Text)) );
                if (ClearInput)
                {
                    txtNumberOne.Clear();
                    txtNumberTwo.Clear();
                }
            }
        }

        private void ButtonDivideName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumberOne.Text))
            {
                //AdditionResults = Convert.ToInt32(txtNumberOne.Text) / Convert.ToInt32(txtNumberTwo.Text);
                lstResults.Items.Add( Baker.IntDiv(Convert.ToInt32(txtNumberOne.Text), Convert.ToInt32(txtNumberTwo.Text)) );
                if (ClearInput)
                {
                    txtNumberOne.Clear();
                    txtNumberTwo.Clear();
                }
            }
        }

        /*
        private void ButtonRandomName_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            int w = Convert.ToInt32(txtNumberOne.Text);
            int x = Convert.ToInt32(txtNumberTwo.Text);
            int i = rand.Next(1, 10000);
            lstResults.Items.Add(Convert.ToString(i));
        }
        */

        private void ButtonClearResultsName_Click(object sender, RoutedEventArgs e)
        {
            lstResults.Items.Clear();
        }

        private void ButtonClearAllName_Click(object sender, RoutedEventArgs e)
        {
            lstResults.Items.Clear();
            txtNumberOne.Clear();
            txtNumberTwo.Clear();
        }

        private void ToggleClearInputOnName_Click(object sender, RoutedEventArgs e)
        {
            ClearInput = true;
            //ClearInputToggleIndicator();
            text2.Text = "Clear input on calculation: on";
        }

        private void ToggleClearInputOffName_Click(object sender, RoutedEventArgs e)
        {
            ClearInput = false;
            //ClearInputToggleIndicator();
            text2.Text = "Clear input on calculation: off";
        }

        /*
private void ClearInputToggleIndicator()
{
   //while (ClearInput || !ClearInput)
   //{}
   if(ClearInput)
   {
       text.Text = "On";
   }
   else if(!ClearInput)
   {
       text.Text = "Off";
   }
}
*/

    }
}
