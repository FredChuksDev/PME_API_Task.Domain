using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PME_API_Task.Domain.Model
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;



    }
}
