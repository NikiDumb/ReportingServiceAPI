﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportingService.Persistence.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public Role Role { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
    }
}
