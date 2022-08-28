using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC_1.Models;

namespace PC_1.Controllers
{

    public class RegistroController : Controller
    {
        private readonly ILogger<RegistroController> _logger;

        public RegistroController(ILogger<RegistroController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [HttpPost]
        public IActionResult Registrar(Registro objImpuesto)
        {
            int creditos = 0;
            double total = 0.0;
            double igv = 0;
            double totalIgv = 0.0;
            ViewData["Name"] = objImpuesto.Name;

            if(objImpuesto.curso1 == true){creditos = creditos +3;}else{creditos = creditos +0;}
            if(objImpuesto.curso2 == true){creditos = creditos +3;}else{creditos = creditos +0;}
            if(objImpuesto.curso3 == true){creditos = creditos +3;}else{creditos = creditos +0;}

            total = creditos * 300;
            igv = total * 0.18;
            totalIgv = total + igv;

            ViewData["cred"] = "Creditos inscritos: " + creditos;
            ViewData["tot"] = "Total sin IGV: " + total;
            ViewData["igv"] = "IGV: " + igv;
            ViewData["totigv"] = "Total con IGV: " + totalIgv ;

            return View("Index");
        }




    }
}