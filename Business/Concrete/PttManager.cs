using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {//sonar gube
        private IApplicantService _applicantService;
        //time 4.11 -ctor 
        public PttManager(IApplicantService applicantService)
        {
                _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için kaydedildi");
            }
            else {

                Console.WriteLine(person.FirstName + " maske verilemedi");
            }
        }


    }
}
//bir iş sınıfı diğer bir iş sınıfını new lediyse direnç gösterir değişime.
//personmanager'a bağlı

//dependency injection-
//PersonManager personManager = new PersonManager();
//solid-o->yeni özellik geldiğinde mevcut koda dokunma.
//PttManager pttManager = new PttManager(new ForeignerManager());
//PttManager pttManager = new PttManager(new PersonManager());
//micro service