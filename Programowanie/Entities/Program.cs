using System;
using Programowanie.Entities;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Ewelina Cupak", 19, "546-876-954");

        student.TotalToPay = 3000.0;

        student.AddAddress("Rzeszów", "Rejtana", "13/5");

        student.AddCourse(1, "Programowanie");

        student.AddCourse(2, "Bazy Danych");

        student.AddGrade(1, 5);

        student.AddGrade(2, 4);

        student.AddTuition(500.0);

        Console.WriteLine("Student: " + student.FullName + " Wiek: " + student.Age + " Numer telefonu: " + student.PhoneNumber);
        Console.WriteLine("Adres: " + student.Address.City + " " + student.Address.Street + " " + student.Address.HomeNr);

        Console.WriteLine("\nLista Przedmiotów:");
        foreach (var item in student.Courses)
        {
            Console.WriteLine("- " + item.Name + ", Ocena: " + item.Grade);
        }

        Console.WriteLine("Historia czesnego:");
        foreach(var t in student.Tuitions)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Kwota: " + t.Amount);
            Console.WriteLine("Data wpłaty: " + t.PaymentDate);
            Console.WriteLine("Termin: " + t.Deadline);
            Console.WriteLine("Status: " + (t.IsPaid ? "Zapłacone" : "Nieopłacone"));
            Console.WriteLine("Pozostało do zapłaty: " + student.TotalToPay + "zł");
        }

        Console.WriteLine("\nKliknij cokolwiek, by zamknąć...");
        Console.ReadKey();
    }
}
