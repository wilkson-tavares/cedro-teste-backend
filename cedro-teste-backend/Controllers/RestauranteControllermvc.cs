using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cedro_teste_backend.Controllers
{
    [Route("api/[controller]")]
    public class RestauranteControllermvc : Controller
    {
        private ContextDB context;

        public RestauranteControllermvc(ContextDB _context)
        {
            this.context = _context;
        }

        [HttpGet]
        public IEnumerable<Restaurante> GetAll()
        {
            return context.Set<Restaurante>().ToList();
        }
    }
}
