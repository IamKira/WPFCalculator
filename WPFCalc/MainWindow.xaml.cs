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

namespace WPFCalc
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Click_to_num(object sender, EventArgs e)
        {
            CalcField.CaretIndex = CalcField.Text.Length;
            int caret = CalcField.CaretIndex;
            CalcField.Text = CalcField.Text.Insert( caret, ((Button)sender).Content.ToString());
        }
        private void CleanField(object sender, EventArgs e)
        {
            CalcField.Text = "";
        }
        private void ClearSymbol(object sender, EventArgs e)
        {
            CalcField.Text = CalcField.Text.Substring(0, CalcField.Text.Length - 1);
        }
        private void Click_to_equally(object sender, EventArgs e)
        {
            string expression = CalcField.Text;
            CalcField.Text = Calculation(expression);
        }
        
        private string Calculation(string s)
        {
            StrCalc.Expression expr = new StrCalc.Expression(s);
            string result = expr.Calc().ToString();
            return result;
        }
    }
}
