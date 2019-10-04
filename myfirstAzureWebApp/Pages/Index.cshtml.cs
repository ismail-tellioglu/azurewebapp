using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myfirstAzureWebApp.Context;

namespace myfirstAzureWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private CoreDbContext con;
        public List<Employee> employess { get; set; }
        public IndexModel (CoreDbContext _con)
        {
            con = _con;
        }
        public void OnGet()
        {
             employess = con.Employees.ToList();
            employess.ElementAt(0).Address = "Halkalı";
        }
    }
}
