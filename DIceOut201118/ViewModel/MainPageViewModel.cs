using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIceOut201118.Model;

namespace DIceOut201118.ViewModel
{
    class MainPageViewModel
    {
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

        public MainPageViewModel()
        {
            
        }
    }

}
