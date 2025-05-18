using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Entities
{
    public class Reader
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Reader()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;

        }

        public Reader(Guid id, string name, string email, string phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
        }   
    }
}
