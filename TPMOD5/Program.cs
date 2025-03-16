using TPMOD5;

class Program
{
    static void Main()
    {
        HaloGeneric.SapaUser("Raihan");

        DataGeneric<string> nimData = new DataGeneric<string>("103022330075");
        nimData.PrintData();

    }
}
