using HTMLtoPDF.Models;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace HTMLtoPDF.Controllers
{
    public class HTMLtoPDFController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public Task<IActionResult> GenerarPDF()
        {
            List<Carros> carro = new List<Carros>()
            {
                new Carros(){ Placa = "Q3W4E5", Color = "Rojo", Modelo = "Hilux", Marca = "Toyota", Tipo = "Carga"},
                new Carros(){ Placa = "Q4W5E6", Color = "Verde", Modelo = "Hilux", Marca = "Toyota", Tipo = "Carga"},
                new Carros(){ Placa = "Q6W7E8", Color = "Azul", Modelo = "Hilux", Marca = "Toyota", Tipo = "Carga" }
            };

            return Task.FromResult<IActionResult>(new ViewAsPdf("GenerarPDF", carro)
            {
                FileName = $"HTMLtoPDF.pdf",
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                PageSize = Rotativa.AspNetCore.Options.Size.A4
            });
        }
    }
}
