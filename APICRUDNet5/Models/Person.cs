using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICRUDNet5.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
    }
}
