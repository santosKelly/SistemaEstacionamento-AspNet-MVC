using Estacionamento.Context;
using Estacionamento.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estacionamento.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly EstacionamentoContext _context;

        public VeiculoController(EstacionamentoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var veiculos = _context.Veiculos.ToList();
            return View(veiculos);
        }

        public IActionResult Criar()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Criar(Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                var placaExists = _context.Veiculos.Any(x => x.Placa == veiculo.Placa);
                if (placaExists)
                {
                    ModelState.AddModelError($"Placa","Essa placa já se encontra cadastrada");
                }
                else
                {
                    _context.Veiculos.Add(veiculo);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(veiculo); 
        }

        public IActionResult Editar(int id)
        {

            var veiculo = _context.Veiculos.Find(id);

            if (veiculo == null)
                return NotFound();

            return View(veiculo);
        }

        [HttpPost]
        public IActionResult Editar(Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                var placaExists = _context.Veiculos.Any(x => x.Placa == veiculo.Placa && x.Id != veiculo.Id);

                if (placaExists)
                {
                    ModelState.AddModelError($"Placa", "Essa placa já se encontra cadastrada");
                }
                else
                {
                    var veiculoBanco = _context.Veiculos.Find(veiculo.Id);

                    if (veiculoBanco != null)
                    {
                        veiculoBanco.Modelo = veiculo.Modelo;
                        veiculoBanco.Placa = veiculo.Placa;
                        veiculoBanco.PrecoInicial = veiculo.PrecoInicial;
                        veiculoBanco.PrecoHora = veiculo.PrecoHora;

                        _context.Veiculos.Update(veiculoBanco);
                        _context.SaveChanges();

                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        return NotFound(); 
                    }
                }
 
            }

            return View(veiculo);   
        }

        public IActionResult Detalhes(int id)
        {
            var veiculo = _context.Veiculos.Find(id);

            if (veiculo == null)
                return RedirectToAction(nameof(Index));

            return View(veiculo);
        }

        public IActionResult Deletar(int id, int horasEstacionado)
        {
            var deletarVeiculo = _context.Veiculos.Find(id);


            decimal totalHoras = CalcularValorTotalHora(deletarVeiculo, horasEstacionado);

            TempData["MensagemRemocao"] = $"O total cobrado é de  : {totalHoras:C}, por {horasEstacionado} hora(s) estacionado";


            return View(deletarVeiculo);
        }

        [HttpPost]
        public IActionResult Deletar(Veiculo veiculo)
        {

                var veiculoBanco = _context.Veiculos.Find(veiculo.Id);


                _context.Veiculos.Remove(veiculoBanco);
                _context.SaveChanges();



            return RedirectToAction(nameof(Index));
        }

        private decimal CalcularValorTotalHora(Veiculo veiculo, int horasEstacionado)
        {
            decimal valorTotal = (veiculo.PrecoHora * horasEstacionado) + veiculo.PrecoInicial ;
            return valorTotal;
        }
    }
}
