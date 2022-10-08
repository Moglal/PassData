using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PassData.Models
{
    public class Customers
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public double age { get; set; }
        public enum gender { male,female}   
        public gender _gender { get; set; }
    }
}