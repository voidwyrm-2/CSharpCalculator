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

        public int AdditionResults;
        public int SubtractResults;
        public int MultiplyResults;
        public int DivideResults;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumberOne.Text)/* && !lstResults.Items.Contains(txtNumberOne.Text)*/)
            {
                AdditionResults = Convert.ToInt32(txtNumberOne.Text) + Convert.ToInt32(txtNumberTwo.Text);
                lstResults.Items.Add(AdditionResults);
                if (ClearInput)
                {
                    txtNumberOne.Clear();
                    txtNumberTwo.Clear();
                }
            }
        }

        private void ButtonSubtractName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumberOne.Text))
            {
                AdditionResults = Convert.ToInt32(txtNumberOne.Text) - Convert.ToInt32(txtNumberTwo.Text);
                lstResults.Items.Add(AdditionResults);
                if (ClearInput)
                {
                    txtNumberOne.Clear();
                    txtNumberTwo.Clear();
                }
            }
        }

        private void ButtonMultiplyName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumberOne.Text))
            {
                AdditionResults = Convert.ToInt32(txtNumberOne.Text) * Convert.ToInt32(txtNumberTwo.Text);
                lstResults.Items.Add(AdditionResults);
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
                AdditionResults = Convert.ToInt32(txtNumberOne.Text) / Convert.ToInt32(txtNumberTwo.Text);
                lstResults.Items.Add(AdditionResults);
                if (ClearInput)
                {
                    txtNumberOne.Clear();
                    txtNumberTwo.Clear();
                }
            }
        }

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

        private void ButtonClearInputOnName_Click(object sender, RoutedEventArgs e)
        {
            ClearInput = true;
            text.Text = "On";
        }

        private void ButtonClearInputOffName_Click(object sender, RoutedEventArgs e)
        {
            ClearInput = false;
            text.Text = "Off";
        }
    }
}
