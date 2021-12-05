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
using System.Windows.Shapes;
using System.Timers;

namespace watykańczyk
{
    /// <summary>
    /// Logika interakcji dla klasy ComingForYouWin.xaml
    /// </summary>
    public partial class ComingForYouWin : Window
    {
        public static ComingForYouWin instance;
        public ComingForYouWin()
        {
            InitializeComponent();
            if(instance!=this) instance = this;
        }
    }
}
