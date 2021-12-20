using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResidence.BL.Model
{
    class MyStudentRoom
    {
        public int StudentId { get; set; }
        public int RoomId { get; set; }

        public string StudentFullName { get; set; }

        public int RoomNumber { get; set; }
    }
}
