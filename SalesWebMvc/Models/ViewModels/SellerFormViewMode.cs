using System;
using System.Collections.Generic;



namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewMode
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set;}
    }
}
