using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Map.Models
{
    public class User
            {
        [Key]

        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
    }
}