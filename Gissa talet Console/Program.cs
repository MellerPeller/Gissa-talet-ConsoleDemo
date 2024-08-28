namespace Gissa_talet_Console
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            int count = 0;
            Console.WriteLine("Gissa talet 1-20");
            int talet = Convert.ToInt32(Console.ReadLine());
            int random = rand.Next(21);


            while (true)
            {
                if (talet == random)
                {
                    Console.WriteLine("Du gissade rätt wow!");
                    Console.WriteLine("Vill du testa igen?");
                    talet = Convert.ToInt32(Console.ReadLine());
                    random = rand.Next(21);
                    count = 0;

                }
                else if (talet > random)
                {
                    Console.WriteLine("Talet är för högt");
                    talet = Convert.ToInt32(Console.ReadLine());
                    count++;

                }
                else if (talet < random)
                {
                    Console.WriteLine("Talet är för lågt");
                    talet = Convert.ToInt32(Console.ReadLine());
                    count++;

                }
                if (count == 2)
                {
                    Console.WriteLine("Wow du är dålig!");
                    Console.WriteLine("Här är ett nytt försök!");
                    talet = Convert.ToInt32(Console.ReadLine());
                    random = rand.Next(21);
                    count = 0;

                }

               

            }
           
           
        }
    }

}
