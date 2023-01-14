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

namespace Ryan_Lam_EQD2_Calculator
{
    public partial class MainWindow : Window
    {
        //MainView
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            double DPFTextx = 0.0;
            double ABRTextx = 0.0;
            double TDTextx = 0.0;
            //Data validation for letters and negative
            if (!double.TryParse(DPFText.Text, out DPFTextx)
                || !double.TryParse(TDText.Text, out TDTextx)
                || !double.TryParse(ABRText.Text, out ABRTextx)
                || DPFTextx < 0.0
                || ABRTextx < 0.0
                || TDTextx < 0.0)
            {
                MessageBox.Show("No alphabetical letters or negative numbers!");
                return;
            }

            EQD2Model modelObj = new EQD2Model(DPFTextx, TDTextx, ABRTextx);

            EQD2Text.Text = ViewModel.CalculateEQD2(modelObj).ToString();
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
                {
                    DPFText.Text = String.Empty;
                    TDText.Text = String.Empty;
                    ABRText.Text = String.Empty;
                    EQD2Text.Text = String.Empty;
                }

        private void DPFText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TD_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
