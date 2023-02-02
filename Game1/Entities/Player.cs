using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game1.Abstract;

namespace Game1.Entity
{
    public class Player: IEntity

    {
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public string CreditCard { get; set; }
        public string UserName { get; set; }
        public string NationalityId { get; set; }

    }
}
