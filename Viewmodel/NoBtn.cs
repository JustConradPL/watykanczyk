using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using watykańczyk.Model;

namespace watykańczyk.Viewmodel
{
    class NoBtn : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand NoClicked { get; set; }

        public ICommand YesClicked { get; set; }
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

        public NoBtn()
        {
            NoClicked = new IC_NoBtn();
            YesClicked = new IC_YesBtn();
        }

        private void SubmitChanges([CallerMemberName] string name="")
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }//-----------------------------------

        
    }//###############################################################
}
