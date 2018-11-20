using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIceOut201118.Model
{
    class Terning
    {
        private int _faceValue;

        public int FaceValue
        {
            get { return _faceValue; }
            set { _faceValue = value; }
        }

        public Terning()
        {

        }

        public void Roll()
        {
            Random random = new Random();

            _faceValue = random.Next(1, 6);

        }

        


    }
}
