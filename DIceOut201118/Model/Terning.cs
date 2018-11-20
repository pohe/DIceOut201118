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
    class Terning : INotifyPropertyChanged
    {
        private int _faceValue;
        private Random _random;

        public int FaceValue
        {
            get { return _faceValue; }
            set
            {
                _faceValue = value;
                OnPropertyChanged();
            }
        }

        public Terning()
        {
            _random = new Random(DateTime.Now.Millisecond);

        }

        public void Roll()
        {
            

            FaceValue = _random.Next(1, 7);

        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
