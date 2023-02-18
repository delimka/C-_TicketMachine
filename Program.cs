using System;

namespace TicketMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ticket t1 = new Ticket("Sherlock Holmes");
            //Ticket t2 = new Ticket ("Mission Impossible");
            //Ticket t3 = new Ticket("Sherlock Holmes");
            //Ticket t4 = new Ticket("Mission Impossible");

            TicketMachine m1 = new TicketMachine(); // 1 avtomat
            TicketMachine m2 = new TicketMachine(); // 2 avtomat

            Ticket t1 = m1.BuyTicket("Sherlock Holmes"); 
            Ticket t2 = m2.BuyTicket("Mission Impossible");// покупаем билеты из раных автоматов
            Ticket t3 = m1.BuyTicket("Sherlock Holmes");
            Ticket t4 = m1.BuyTicket("Mission Impossible");

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);


            Console.WriteLine("{0,-40}-isValid(t1)-{1}", t1, m1.IsValid(t1));//-> true
            Console.WriteLine("{0,-40}-isValid(t2)-{1}", t2, m1.IsValid(t2));//-> true


            Ticket t5 = m1.BuyTicket("Mission Impossible");

            Console.WriteLine("{0,-40}-isValid(t1)-{1}", t5, m2.IsValid(t5));//-> false

            m1.UseTicket(t1); // -> "Have a nice day!!"
            m2.UseTicket(t2); // -> "Have a nice day!!"

            m2.UseTicket(t1); // ->"ALARM! ticket is not valid!"

            Console.ReadKey();
        }
    }
}
