using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Media;
using System.Timers;

namespace watykańczyk.Model
{
    public class IC_StalinWindowLoaded : ICommand
    {
        private const int minAppearTime = 100;
        private const int maxAppearTime = 500;


        Random rnd = new Random();

        public event EventHandler CanExecuteChanged;
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        public bool CanExecute(object parameter)
        {
            return true;
        }//-------------------------------------------------

        public void Execute(object parameter)
        {
            SoundPlayer player = new SoundPlayer("Wapiesz.wav");
            player.PlayLooping();

            Timer aTime = new Timer(5000);
            aTime.AutoReset = false;
            aTime.Elapsed += (object s, ElapsedEventArgs e) =>
            {
                ComingForYouWin.instance.Dispatcher.Invoke(() =>
                {
                    ComingForYouWin.instance.Hide();
                });
                StartVirus();
            };

            aTime.Start();
        }//----------------------------------------------

        private void StartVirus()
        {
            Timer aTime = new Timer(rnd.Next(minAppearTime, maxAppearTime + 1));
            aTime.AutoReset = false;
            aTime.Elapsed += (object Source, ElapsedEventArgs e) =>
              {
                  InitializeMem();

                  Timer s = (Timer)Source;
                  s.Interval = rnd.Next(minAppearTime, maxAppearTime + 1);
                  s.Start();
              };
            aTime.Start();
        }//----------------------------------------------

        private void InitializeMem()
        {
            ComingForYouWin.instance.Dispatcher.Invoke(() =>
            {
                PapieżMem mem = new PapieżMem();
                mem.WindowStartupLocation = WindowStartupLocation.Manual;
                int yPos = rnd.Next(0, (int)SystemParameters.PrimaryScreenHeight);
                int xPos = rnd.Next(0, (int)SystemParameters.PrimaryScreenWidth);

                mem.Top = yPos; mem.Left = xPos;
                mem.Show();
            });
        }//------------------------------------------------
    }//##################################################################
}
