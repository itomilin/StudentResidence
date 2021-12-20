using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResidence.BL.Model
{
    class MyFindResultView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public System.DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public int Course { get; set; }
        public string StudentGroup { get; set; }
        public int? NumberOfRoom { get; set; }
    }
}
