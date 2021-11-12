using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Details details1 = new Details("Фланець", "З", 3, 450);
            Details details2 = new Details("Перехiдник", "К", 8, 74);
            Details details3 = new Details("Станина", "Про", 1, 117050);
            Console.WriteLine("Найменування    Тип    Кiлькiсть   Вага 1 деталi(г)");
            Console.WriteLine(details1.Details2());
            Console.WriteLine(details2.Details2());
            Console.WriteLine(details3.Details2());

        }
    }

    class Details
    {
        public string name { get; set; }
        public string type { get; set; }
        public short amount { get; set; }
        public int weight { get; set; }

        public Details(Details previousDetails)
        {
            name = previousDetails.name;
            type = previousDetails.type;
            amount = previousDetails.amount;
            weight = previousDetails.weight;
        }
        public Details(string Name, string Type, short Amount, int Weight)
        {
            name = Name;
            type = Type;
            amount = Amount;
            weight = Weight;
        }
        public string Details2()
        {
            return name + "         " + type + "      " + amount.ToString() + "           " + weight.ToString();
        }
    }
}
