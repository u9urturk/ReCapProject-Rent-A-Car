using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class UserFindeksPoint:IEntity
    {
        public int Id { get; set; }
        public int CustomerId{ get; set; }
        public int FindeksPoint { get; set; }
    }
}
