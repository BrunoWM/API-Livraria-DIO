using LivrariaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ToDoContext _context;

        public LivrosController(ToDoContext context)
        {
            _context = context;

            //mocando os dados
            _context.TodoLivros.Add(new Livro { ID = "1", Nome = "The Little Prince", Preco = 20.00, Categoria = "Clássico", Quantidade = 2, Img = "img01" });
            _context.TodoLivros.Add(new Livro { ID = "2", Nome = "Harry Potter 01", Preco = 15.00, Categoria = "Fantasia", Quantidade = 1, Img = "img02" });
            _context.TodoLivros.Add(new Livro { ID = "3", Nome = "1984", Preco = 25.00, Categoria = "Distopia", Quantidade = 3, Img = "img03" });
            _context.TodoLivros.Add(new Livro { ID = "4", Nome = "Essencialismo", Preco = 10.00, Categoria = "Auto-ajuda", Quantidade = 1, Img = "img04" });
            _context.TodoLivros.Add(new Livro { ID = "5", Nome = "Elantris", Preco = 20.00, Categoria = "Fantasia", Quantidade = 6, Img = "img05" });

            _context.SaveChanges();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livro>>> GetLivros()
        {
            return await _context.TodoLivros.ToListAsync();
        }
    }
}
