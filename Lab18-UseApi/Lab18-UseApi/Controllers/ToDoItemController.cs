﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab18_UseApi.Controllers
{
    public class ToDoItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}