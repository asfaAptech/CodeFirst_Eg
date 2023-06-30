using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace CodeFirst_Eg.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }

    }
}