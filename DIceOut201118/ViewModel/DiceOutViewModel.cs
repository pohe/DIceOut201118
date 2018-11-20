using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIceOut201118.ViewModel
{
    class DiceOutViewModel
    {
        private Terning _terning1;
        private Terning _terning2;

        public Terning Terning1
        {
            get { return _terning1; }
            set { _terning1 = value; }
        }

        public Terning Terning2
        {
            get { return _terning2; }
            set { _terning2 = value; }
        }

        public DiceOutViewModel()
        {
            
        }
    }
}
