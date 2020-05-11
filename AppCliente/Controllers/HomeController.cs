using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppCliente.Models;

namespace AppCliente.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ClienteModel objClient = new ClienteModel();
            ViewBag.ListaClientes = objClient.ListarTodosClientes();
            return View();
        }

        [HttpGet]
        public IActionResult Registrar(int? id)
        {
            if (id != null)
            {
                ViewBag.Registro = new ClienteModel().Carregar(id);
            }
            return View();

        }

        [HttpPost]
        public IActionResult Registrar(ClienteModel dados)
        {
            dados.Inserir();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            ViewData["Cliente_Id"] = id.ToString();
            return View();
        }

       
        public IActionResult ExcluirCliente(int id)
        {
            new ClienteModel().Excluir(id);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
