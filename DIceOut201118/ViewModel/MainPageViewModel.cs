using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DIceOut201118.Annotations;
using DIceOut201118.Common;
using DIceOut201118.Model;

namespace DIceOut201118.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {

        //TODO: Bind to Facevalues and Rollbutton
        private string _imageSource1;
        private string _imageSource2;
        public Spil Spil { get; set; }

        public string ImageSource1
        {
            get { return _imageSource1;}
            set
            {
                _imageSource1 = value; 
                OnPropertyChanged();
            }
        }

        public string ImageSource2
        {
            get { return _imageSource2; }
            set
            {
                _imageSource2 = value;
                OnPropertyChanged();
            }
        }

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
            RollCommand = new RelayCommand(RollDice);
        }

        private void RollDice()
        {
            Spil.RollAll();
            UpdateImages();
        }

        public void UpdateImages()
        {
            ImageSource1 = Faces[Spil.Terning1.FaceValue];
            ImageSource2 = Faces[Spil.Terning2.FaceValue];
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
