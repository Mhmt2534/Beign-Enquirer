using Business.Concrete;
using Entities.Concrete;

namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kişinin varlığını sorgula

            Person person = new Person(); 
            person. FirstName = "Mahmut";
            person.LastName = "Güneş";
            person.DateOfBirthYear = 2000;
            person.ID = 123;

            //PersonManager personManager = new PersonManager();
            //personManager.exist(person);

            //Eğerki yarın bir yabancıyıda sorgulamak için ekleme istenirse tıkanırız bu yüzden Bir 
            //SorguManager oluşturup oradan yöneticez

            EnquireManager enquireManager=new EnquireManager(new PersonManager());
            enquireManager.CheckOut(person);

        }
    }
}
