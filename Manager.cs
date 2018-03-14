using System.ComponentModel.Design;
using System.Dynamic;

namespace HRSystem
{
    public class Manager : IEmployee, IPension

    {
        public int Bsa
        {
            get;
            set;
        }
        public int Bon
        {
            get;
            set;
        }
        public int Cpc
        {
            get;
            set;
        }
        public int Ppc
        {
            get;
            set;
        }
        public bool Hi
        {
            get;
            set;
        }

        public Manager()
        {
            Bsa = 50000;
            Bon = 10;
            Cpc = 5;
            Ppc = 3;
            Hi = true;
        }


        public int GetTotalPension()
        {
            var totalpension = this.Cpc + this.Ppc;
            return totalpension;
        }

    
    }
}