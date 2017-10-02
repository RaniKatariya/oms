using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace OMS.Models
{
    public class Class1
    {
        [Key]
        public int eid { get; set; }
        public string  ename { get; set; }
        public string  dept { get; set; }
        public string  address { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
    public class Admin
    {
        [Key]
        public int admin_id { get; set; }
        public string  aname { get; set; }        
        public string email { get; set; }
        public string password { get; set; }
    }
}
