using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaasta;
            //programm kuvab sünniaasta konsoolis;
            //"oled sündinud aastal {yearOfBirth}"

            Console.WriteLine("Palun sisesta oma vanus.");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2021 - userAge;

            //Console.WriteLine("Oled sündinud " + yearOfBirth + " aastal.";

            //sting interpolation

            Console.WriteLine($"Oled sündinud {yearOfBirth} aastal.");




        }
    }
}
