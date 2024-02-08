using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrate
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;
        

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }


        public void GiveMask(Person person)
        {
            //PersonManager Classında tanımlı olan bool türündeki metodu Maske verilecekmi verilmeyecekmi kontrolü için PttMaskte Kontrol Ettik.
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi.");
            }
        }
    }
}
