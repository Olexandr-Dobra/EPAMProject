using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models
{
    public class Group
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string GroupName { get; set; }
        public string TeacherName { get; set; }
        public string Audithory { get; set; }
        public string Title { get; set; }

    }
}
