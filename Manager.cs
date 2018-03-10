namespace HRSystem
{
    public class Manager : Calculate
    {
        public Manager()
        {
            base.Bsa = 50000;
            base.Bon = 10;
            this.Cpc = 5;
            this.Ppc = 3;
            this.Hi = true;
        }

        public Manager(int cpc, int ppc) : this()
        {
            base.Bsa = 50000;
            base.Bon = 10;
            this.Cpc = cpc;
            this.Ppc = ppc;
            this.Hi = true;
        }
    }
}