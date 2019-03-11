using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }
        TeacherPosition curentTecherPosition;


    }
    public enum TeacherPosition
    {
        Professor , AssociateProfessor , SeniorLecturer,  Teacher , Assistant
    }
}
