using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Controls;
using System.Windows;
using watykańczyk.Model;
using System.Windows.Input;

namespace watykańczyk.Viewmodel
{
    public class HelpingViewModel
    {
        private static Random rnd = new Random();

        private int rndPos;

        private Dictionary<string, double> memsDictionary = new Dictionary<string, double>()
        {
            {"1.png", 300 },
            {"2.png",300 },
            {"3.png",150 },
            {"4.png",500 },
            {"6.png",250 },
            {"7.png", 600 },
            {"8.png", 700 },
            {"9.png",400 },
            {"10.png",250 },
            {"11.png",600 },
            {"12.png", 700 },
            {"13.png",400 },
            {"14.png",450 },
            {"15.png",150 },
            {"16.png",350 },
            {"17.png",700 },
            {"18.png",800 },
            {"19.png",600 },
            {"20.png",500 },
        };

        public string ImageName
        {
            get
            {
                return "/watykańczyk;component/Memy/" + memsDictionary.ElementAt(rndPos).Key;
            }
        }

        public double ImageWidth
        {
            get
            {
                return memsDictionary.ElementAt(rndPos).Value;
            }
        }

        public ICommand Loaded { get; set; }
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        public HelpingViewModel()
        {
            Loaded = new IC_StalinWindowLoaded();
            rndPos = rnd.Next(0, memsDictionary.Count);
        }//------------------------------------------


    }//##################################################################
}
