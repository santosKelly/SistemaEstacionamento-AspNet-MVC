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
                _context.Veiculos.Add(veiculo);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
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
                var veiculoBanco = _context.Veiculos.Find(veiculo.Id);

                veiculoBanco.Modelo = veiculo.Modelo;
                veiculoBanco.Placa = veiculo.Placa;
                veiculoBanco.PrecoInicial = veiculo.PrecoInicial;
                veiculoBanco.PrecoHora = veiculo.PrecoHora;

                _context.Veiculos.Update(veiculoBanco);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
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
            //if (deletar == null)
            //return RedirectToAction(nameof(Index));

            decimal totalHoras = CalcularValorTotalHora(deletarVeiculo, horasEstacionado);

            TempData["MensagemRemocao"] = $"O valor cobrado é de: {totalHoras:C}";


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
            // Ajuste esta lógica de cálculo com base nos seus requisitos
            decimal valorTotal = (veiculo.PrecoHora * horasEstacionado) + veiculo.PrecoInicial ;
            return valorTotal;
        }
    }
}
