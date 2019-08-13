using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ConsomeRCL.Models;
using ProjetoRCL.Model;

namespace ConsomeRCL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            #region exemplo 1
            ////Criando uma instancia do Model da RCL
            //TesteModel testeModel = new TesteModel();

            ////Atribuindo um valor para a propriedade Nome
            //testeModel.Nome = "Petherson Vinicius";

            ////Colocando em um ViewData
            //ViewData["testeModel"] = testeModel;
            #endregion

            VagasSimilaresModel vagasSimilaresModel = new VagasSimilaresModel();

            vagasSimilaresModel.NomeFuncao = "Desenvolvedor";
            vagasSimilaresModel.Cidade = "Curitiba";
            vagasSimilaresModel.SiglaEstado = "PR";
            vagasSimilaresModel.Salario = 2000.00f;

            //ViewData["vagasSimilaresModel"] = vagasSimilaresModel;

            return View(vagasSimilaresModel);
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