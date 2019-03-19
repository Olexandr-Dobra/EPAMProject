using FirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Components
{
    public class TeacherIdCountComponent
    {
        private readonly FirstWebAppContext _context;
        public TeacherIdCountComponent(FirstWebAppContext context)
        {
            _context = context;
        }
        public int Invoke()
        {

            var x = from i in _context.MarkOfTeacher
                    group i by i.TeacherId into TeacheridCount
                    select TeacheridCount.Count();

            int z = 0;
            foreach (var item in x)
            {
                z++;
            }
            return z;
        }
    }
}
