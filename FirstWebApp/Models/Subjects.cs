using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models
{
    public class Subjects
    {
        public int Id { get; set; }

        
        public string Title { get; set; }
        public int TeacherId { get; set; }

        public string Audithory { get; set; }
        public int Mark { get; set; }

    }
}
