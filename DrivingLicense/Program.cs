using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat;
            //Programm arvutab kasutaja vanust
            //Kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilube omada";
            //Kui kasutaja on vanem kui 18, siis programm kuvab konsoolis
            //"Oled piisavalt vana, et juhilube omada";
            //Kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne, nüüd saad juhilube taotleda!"

            Console.WriteLine("Palun sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube omada.");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube omada.");
            }
            else
            {
                Console.WriteLine("Palju õnne, nüüd saad juhilube taotleda!");
            }
        }
    }
}
