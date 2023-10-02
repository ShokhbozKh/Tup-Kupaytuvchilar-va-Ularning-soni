namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Satr ko'rinishda bir son berilgan. Bu sonni tub ko'paytuvchilarga ajrating va
            //quyidagi ko'rinishida listda saqlovchi dastur yozing.
            string number = "10";
            var number2 = int.Parse(number);
            var result = TupKupaytuvchi(number2);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
            //(tub son, soni)

            //"10"-> [(2, 1), (5, 1)](Eng qiyin)
        }
        static List<(int tubson, int soni)> TupKupaytuvchi(int number2)
        {
            List<(int, int)> values = new List<(int, int)>();

            for(int i=2; i<=number2; i++)
            {
                int count = 0;
                while (number2 % i == 0)
                {
                    count++;
                    number2 /= i;
                }
                if(count > 0)
                {
                    values.Add((i, count));
                }

 
            }
            return values;
        }
    }
}