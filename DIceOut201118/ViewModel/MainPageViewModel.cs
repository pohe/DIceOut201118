using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DIceOut201118.Common;
using DIceOut201118.Model;

namespace DIceOut201118.ViewModel
{
    class MainPageViewModel
    {

        //TODO: Bind to Facevalues and Rollbutton
        public Spil Spil { get; set; }

        public string[] Faces = new string[6];

        public ICommand RollCommand { get; set; }

        public MainPageViewModel()
        {
            Faces[0] = "/Assets/die_1.png";
            Faces[1] = "/Assets/die_2.png";
            Faces[2] = "/Assets/die_3.png";
            Faces[3] = "/Assets/die_4.png";
            Faces[4] = "/Assets/die_5.png";
            Faces[5] = "/Assets/die_6.png";
            Spil = new Spil();
            RollCommand = new RelayCommand(Spil.RollAll);
        }
    }

}
