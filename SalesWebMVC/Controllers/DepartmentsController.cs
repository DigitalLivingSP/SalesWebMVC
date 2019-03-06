﻿namespace SalesWebMVC.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using SalesWebMVC.Models;

    public class DepartmentsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });


            return View(list);
        }
    }
}
