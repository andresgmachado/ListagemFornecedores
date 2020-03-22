using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fornecedores.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fornecedores.Controllers
{
    public class EmpresaController : Controller
    {
        public static Empresa _empresa = new Empresa();
        public IActionResult Index()
        {
            return View(_empresa.ListaEmpresa);
        }

        public ActionResult AdicionarEmpresa()
        {
            return View();
        }

        public ActionResult DetalharEmpresa(int id)
        {
            return View(_empresa.GetEmpresa(id));
        }

        [HttpPost]
        public ActionResult AdicionarEmpresa(EmpresaModel _empresamodel)
        {
            _empresa.CriaEmpresas(_empresamodel);
            return View();
        }

        public ViewResult AtualizarEmpresa(int id)
        {

            return View(_empresa.GetEmpresa(id));
        }
        [HttpPost]
        public RedirectToActionResult AtualizarEmpresa(EmpresaModel empresamodel, IFormCollection collection)
        {
            _empresa.AtualizarEmpresa(empresamodel);
            return RedirectToAction("Index");
        }

        public ViewResult DeletarEmpresa(int id)
        {

            return View(_empresa.GetEmpresa(id));
        }
        [HttpPost]
        public RedirectToActionResult DeletarEmpresa(int id, IFormCollection collection)
        {
            _empresa.DeletarEmpresa(id);
            return RedirectToAction("Index");
        }
    }
}