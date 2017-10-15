using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
[EnableCors("SiteCorsPolicy")]
[Produces("application/json")]
[Route("api/Restaurante")]
public class RestauranteController : Controller
{
    ContextDB _context;

    public RestauranteController(ContextDB context)
    {
        _context = context;
    }

    // GET: api/Restaurante/get
    [HttpGet]
    [Route("Get")]
    public IEnumerable<Restaurante> Get()
    {   
        return _context.restaurante;
    }

    // GET api/Restaurante/get/5
    [HttpGet("{id}")]
    [Route("Get/{id}")]
    public IEnumerable<Restaurante> Get(int id)
    {
        return _context.restaurante.Where(x => x.ID == id);
    }

    // POST api/values
    [HttpPost]
    public void Post(int id)
    {
        //if (param.ID == 0)
        //    _context.restaurante.Add(param);
        //else
        //    _context.restaurante.Update(param);

        _context.SaveChanges();
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(Restaurante param)
    {
        _context.restaurante.Remove(param);
        _context.SaveChanges();
    }
}
