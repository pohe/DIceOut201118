using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIceOut201118.Model
{
    class Spil
    {   //TODO: implement Inotifypropertychanged
        private Terning _terning1;
        private Terning _terning2;

        public Terning Terning1
        {
            get { return _terning1; }
            set { value = _terning1; }
        }

        public Terning Terning2
        {
            get { return _terning2; }
            set { value = _terning2; }
        }

        private int _score;

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public void RollAll()
        {
            Terning1.Roll();
            Terning2.Roll();
        }
    }
}
