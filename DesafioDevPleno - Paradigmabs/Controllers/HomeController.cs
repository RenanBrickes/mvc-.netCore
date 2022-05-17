using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DesafioDevPleno___Paradigmabs.Models;
using DesafioDevPleno___Paradigmabs.ModelsView;

namespace DesafioDevPleno___Paradigmabs.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/pegaSalario")]
        public IActionResult Salario()
        {
            new Pessoa().PegaSalario(_context);
            return View();
        }

        [HttpPost("/defineMatriz")]
        public IActionResult DefineMatriz(string array = "50,60,70")
        {
            //Verifia array vazio
            if (string.IsNullOrEmpty(array))
                return View(new RespostaView<MatrizView>(false, "O array não pode ser vazio"));
            
            //Verifia se elementos são todos números
            //Faz um verificação ai, fiquei sem tempo KKKK


            //Separa e converte para matriz de string
            List<int> matrizList = array.Split(",").Select(a => int.Parse(a)).ToList();

            MatrizView matrizResposta = new MatrizView().ProcessaArvore(matrizList);


            return View(new RespostaView<MatrizView>(true, "Operação realizada com sucesso!", matrizResposta));

        }
    }
}
