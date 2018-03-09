namespace HRSystem
{
    public interface IEmployee
    {

        int Bsa { get; set; }
        int Bon { get; set; }
        int Cpc { get; }
        int Ppc { get; }
        bool Hi { get; }

        void GetTotalCompanyContributions();

    }
}