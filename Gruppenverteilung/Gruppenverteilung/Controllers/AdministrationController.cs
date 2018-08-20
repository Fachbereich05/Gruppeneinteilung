﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gruppenverteilung.Code;
using Gruppenverteilung.Models;

namespace Gruppenverteilung.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult AdministrationView(AdministrationModel model)
        {
            return View(model);
        }

        public IActionResult AdministrationImportView()
        {
            return View();
        }

        public IActionResult AdministrationEditView()
        {
            return View();
        }

        public IActionResult ShowGroups(AdministrationModel model)
        {
            return View();
        }
        
        public IActionResult RefreshGroups(AdministrationModel model)
        {
            model.groups = GlobalVariables.sorter.groups;
            return View("../Administration/AdministrationView", model);


        }

        public IActionResult SimulateGroups(AdministrationModel model)
        {
            GlobalVariables.sorter.SimulateByFile("grpdata_01.txt");
            model.groups = GlobalVariables.sorter.groups;

            return View("../Administration/AdministrationView", model);
        }
    }
}