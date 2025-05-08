using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Library
{   
    public class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }    
        public string Email { get; set; }
        public string? Phone { get; set; }
        public Boolean IsActive { get; set; }

    }
}
