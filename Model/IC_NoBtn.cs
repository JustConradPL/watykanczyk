using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows;

namespace watykańczyk.Model
{
    public class IC_NoBtn : ICommand
    {

        static Thickness[] Margins = new Thickness[]
        {
            new Thickness(500,276,93.6,44),
            new Thickness(408,210,185.6,110),
            new Thickness(529,210,64.6,110),
            new Thickness(554,310,39.6,10),
            new Thickness(406,310,187.6,10),
            new Thickness(360,250,233.6,70),
        };

        static int currentMargin = 0;

        Random rnd = new Random();

        public event EventHandler CanExecuteChanged;

        private int count = 0;
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        public bool CanExecute(object parameter)
        {
            return true;
        }//---------------------------------------------------

        public void Execute(object parameter)
        {
            if (count < 20)
            {
                Button btn = parameter as Button;
                if (btn != null)
                {
                    btn.Margin = GetRandomMargin();
                    count++;
                }
            }
            else
            {
                GoodEndingWin win = new GoodEndingWin();
                win.Show();
                MainWindow.instance.Close();
            }
        }//---------------------------------------------------

        private Thickness GetRandomMargin()
        {
            Start:
            int randomInteger = rnd.Next(0, Margins.Length);
            if (randomInteger == currentMargin) goto Start;

            return Margins[randomInteger];
        }//--------------------------------------------------
    }//#############################################################################3
}
