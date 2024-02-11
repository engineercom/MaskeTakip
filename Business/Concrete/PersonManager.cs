using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;
namespace Business.Concrete
{//sektorde servis olarak da görülebilir
    public class PersonManager : IApplicantService
    {

        public void ApplyForMask(Person person)
        {



        }
        public List<Person> GetList()
        {
            return null;
        }
        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);


return client.TCKimlikNoDogrulaAsync(
    new TCKimlikNoDogrulaRequest(
        new TCKimlikNoDogrulaRequestBody(
person.NationalIdentity,person.FirstName, 
person.LastName, person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;

        }

    }
}
//fonksiyon,meethod,prosedür
//add reference entities for person
//a,b,c sayfalarında kullanacağımız yapıları oluşturuyouz
//encapsulation