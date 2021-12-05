﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace watykańczyk.Model
{
    public class IC_YesBtn : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ComingForYouWin win = new ComingForYouWin();
            win.Show();
            MainWindow.instance.Close();
        }
    }
}
