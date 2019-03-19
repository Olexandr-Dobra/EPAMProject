using FirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Cimponents
{
    public class BestPhoneViewComponent
    {
        private readonly FirstWebAppContext _context;
        public BestPhoneViewComponent(FirstWebAppContext context)
        {
            _context = context;
        }
        public string Invoke()
        {


            



            var x = _context.MarkOfTeacher.Average(b => b.Mark);

            string result = x.ToString();

            return result;
        }
    }
}
