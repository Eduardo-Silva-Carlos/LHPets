using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()

    {
        //Instanciar do tipo Cliente
        Cliente cliente1 = new Cliente(01, "Calos", "222.333.666-89", "cavsr.@gmail.com", "Fernando Almeida");
        Cliente cliente2 = new Cliente(02, "Pedro", "222.356.656-99", "amarcatro.@gmail.com", "Amarildo Catros");
        Cliente cliente3 = new Cliente(03, "Joana", "222.333.666-89", "novavid6.@gmail.com", "Anan Paula de Amorin");
        Cliente cliente4 = new Cliente(04, "Maria", "222.333.666-89", "sophiammmm.@gmail.com", "Sophia Gabrielle da Silva");
        Cliente cliente5 = new Cliente(05, "Djavan", "222.333.666-89", "vasto2.@gmail.com", "Sara Emannulle Bezerra da silva");

        // Criando Lista 
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // Instacia do tipo Fornecedor
        Fornecedor fornecedor1 = new Fornecedor(10, "Jota R", "99.999.999/9999-99", "asdf@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(20, "Linus log", "12.365.654/7895-88", "linus@outlook.com");
        Fornecedor fornecedor3 = new Fornecedor(30, "SNK", "12.147.789/7412-66", "snk@hotemail.com");
        Fornecedor fornecedor4 = new Fornecedor(40, "tech7", "13.369.123/7456-77", "tech7@outlook.com");
        Fornecedor fornecedor5 = new Fornecedor(50, "LHPets", "55.654.456/7452-88", "lhpets@hotemail.com");

        // Lista Fornecedor 
        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        listaFornecedor.Add(fornecedor1);
        listaFornecedor.Add(fornecedor2);
        listaFornecedor.Add(fornecedor3);
        listaFornecedor.Add(fornecedor4);
        listaFornecedor.Add(fornecedor5);

        ViewBag.listaFornecedor = listaFornecedor;
        
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
