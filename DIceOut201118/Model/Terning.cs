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
        private Random _random;

        public int FaceValue
        {
            get { return _faceValue; }
            set { _faceValue = value; }
        }

        public Terning()
        {
            _random = new Random(DateTime.Now.Millisecond);

        }

        public void Roll()
        {
            

            _faceValue = _random.Next(1, 6);

        }

        


    }
}
