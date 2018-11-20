using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DIceOut201118.Annotations;

namespace DIceOut201118.Model
{
    class Spil : INotifyPropertyChanged
    {   //TODO: implement Inotifypropertychanged
        private Terning _terning1;
        private Terning _terning2;

        public Terning Terning1
        {
            get { return _terning1; }
            set
            {
                value = _terning1;
                OnPropertyChanged();
            }
        }

        public Terning Terning2
        {
            get { return _terning2; }
            set
            {
                value = _terning2;
                OnPropertyChanged();
            }
        }

        private int _score = 0;

        public int Score
        {
            get { return _score; }
            set
            {
                _score = value;
                OnPropertyChanged();
            }
        }

        public Spil()
        {
            _terning1 = new Terning();
            _terning2 = new Terning();
        }
        public void RollAll()
        {
            Terning1.Roll();
            Terning2.Roll();

            if (Terning1.FaceValue == Terning2.FaceValue)
            {
                Score = Score + 50;
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
