using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Semana9.Models
{
    public class Person
    {
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public Boolean isTecsup { get; set; }
    }
}