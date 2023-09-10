using ApiDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProduitsController : Controller
    {
        private static List<Produit> produits = new()
        {
                new Produit { Id = 1, Nom = "Livre", Prix = 10 },
                new Produit { Id = 2, Nom = "Stylo", Prix = 2 },
                new Produit { Id = 3, Nom = "Cahier", Prix = 3 }
            };
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(produits);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var produit = produits.FirstOrDefault(x => x.Id == id);
            if (produit == null)
            {
                return NotFound($"Le produit avec id: {id} n'existe pas");
            }
            return Ok(produit);
        }

        [HttpPost]
        public IActionResult Post(Produit produit)
        {
            produit.Id = produits.Max(p => p.Id) + 1;
            produits.Add(produit);
            return Ok(produits);
        }
    }
}
