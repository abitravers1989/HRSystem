using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;

namespace HRSystem
{
    public class Calculate
    {
        protected int Bsa { get; set; }
        protected int Bon { get; set; }
        protected int Cpc { get; set; }
        protected int Ppc { get; set; }
        protected bool Hi { get; set; }

        public int GetTotalPension()
        {
            var totalpension = this.Cpc + this.Ppc;
            return totalpension;
        }
    }
}