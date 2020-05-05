using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200505
{
    class Palinka
    {
        private int _fok;
        public int Fok
        {
            get
            {
                return _fok;
            }
            set
            {
                if (value < 30 || value > 87)
                {
                    throw new Exception("a pálinka foka nem megfelelő");
                }
                _fok = value;
            }
        }

        private string _gyumolcs;
        public string Gyumolcs
        {
            get 
            { 
                return _gyumolcs;
            }
            set
            {
                if (value is null)
                {
                    throw new Exception("mindenképpen meg kell adni a gyümölcsöt");
                }
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new Exception("a gyümölcs nevének hossza nem megfelelő");
                }
                _gyumolcs = value;
            }
        }

        private int _mennyiseg;
        public int Mennyiseg 
        {
            get
            {
                return _mennyiseg;
            }
            set
            {
                if( value  < 0 || value > 50)
                    throw new Exception("ennyi pálinkád nem lehet!");
                _mennyiseg = value;
            }
        }
        private int _ev;
        public int Ev
        {
            get { return _ev; }
            set
            {
                if(value < 2000 || value > DateTime.Now.Year)
                    throw new Exception("nem jó készítési év!");
                _ev = value;
            }
        }
        private int _ar;
        public int Ar
        {
            get { return _ar; }
            set
            {
                if (value > 1000 || value < 50)
                    throw new Exception("nem jo ar");
                _ar = value;
            }
        }

    }
}
