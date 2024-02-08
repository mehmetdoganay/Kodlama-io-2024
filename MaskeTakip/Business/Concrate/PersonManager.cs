using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using MernisServiceReference1;

namespace Business.Concrate
{
    public class PersonManager :IApplicantService
    {
        // Maske Başvuru fonksiyonu.

        public List<Person> GetList()
        {
            return null;
        }

        //Microservice ile Derğer kontrolü
        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client
                .TCKimlikNoDogrulaAsync(
                    new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName,person.LastName,person.DateOfBrirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }

        public void ApplyFormask(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
