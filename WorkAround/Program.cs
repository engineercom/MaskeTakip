using Business.Concrete;
using Entities.Concrete;

namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager() );
            pttManager.GiveMask(person1);




            Console.WriteLine("Hello ,World");
            Console.ReadLine();


        }
    }
}
