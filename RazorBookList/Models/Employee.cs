using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorBookList.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContractType ContractType { get; set; }
        public string Photo { get; set; }
        public string Salary { get; set; }
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
    }
}
