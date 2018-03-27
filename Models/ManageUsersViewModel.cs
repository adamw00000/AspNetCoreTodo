using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo
{
    public class ManageUsersViewModel
    {
        public IEnumerable<ApplicationUser> Administrators { get; set; }

        public IEnumerable<ApplicationUser> Everyone { get; set; }
    }
}
