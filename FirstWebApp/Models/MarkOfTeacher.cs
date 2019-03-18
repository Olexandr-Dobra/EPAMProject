using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models
{
    public class MarkOfTeacher
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }

    }
}
