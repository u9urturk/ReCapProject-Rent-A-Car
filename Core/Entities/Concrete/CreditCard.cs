using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class CreditCard:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CardNumber { get; set; }
        public int ExpirationDate { get; set; }
        public string Name { get; set; }
        public int SecurityCode { get; set; }
    }
}
