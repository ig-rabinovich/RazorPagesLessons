using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesLessons.Models;
using RazorPagesLessons.Services;

namespace RazorPagesGeneral.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepozitory _employeeRepozitory;
        public DetailsModel(IEmployeeRepozitory employeeRepozitory)
        {
            _employeeRepozitory = employeeRepozitory;
        }

        public Employee Employee { get; private set; }

        public void OnGet(int id)
        {
            Employee = _employeeRepozitory.GetEmployee(id);
        }
    }
}
