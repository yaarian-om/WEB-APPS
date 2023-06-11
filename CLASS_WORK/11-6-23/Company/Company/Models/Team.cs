using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.Models
{
    public class Team
    {
        public string Name { get; set; }
        public Member[] Members { get; set; }

    }
}