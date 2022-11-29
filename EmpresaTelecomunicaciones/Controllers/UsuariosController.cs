using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpresaTelecomunicaciones.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index(string data, int age)
        {
            ViewData["id"] = data+" "+age;
            return View();
        }
    }
}
