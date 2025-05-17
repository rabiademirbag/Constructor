using Constructor;

class Program
{
    public static void Main(string[] args)
    {
        Baby baby = new Baby();
        baby.DisplayBabyInfo();
        Baby baby2 = new Baby("Ayşe", "Gürel");
        baby2.DisplayBabyInfo();

    }
}
