using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entities.Concrete
{
    public class Person
    {  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}
// ctrl+k+d=>kod düzenleme
// solid-single of responsibility=>her method,her if; tek bir iş yapar.
//abstract-concrete=>soyut-somut