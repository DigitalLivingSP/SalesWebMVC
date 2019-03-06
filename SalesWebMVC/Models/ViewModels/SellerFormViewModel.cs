namespace SalesWebMVC.Models.ViewModels
{
    using System.Collections.Generic;

    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
