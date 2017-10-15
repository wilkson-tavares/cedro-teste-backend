using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class RestauranteRepositorio : IRestauranteRepositorio
{
    private ContextDB _context;

    public RestauranteRepositorio(ContextDB context)
    {
        this._context = context;
    }

    public void Add(Restaurante item)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Restaurante Find(Restaurante item)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Restaurante> GetAll()
    {
        return _context.Set<Restaurante>().ToList();

        //List<Restaurante> teste = new List<Restaurante>();
        //teste.Add(new Restaurante() { ID = 1, Nome = "Barollo" });
        //return teste;
    }

    public void Update(Restaurante item)
    {
        throw new NotImplementedException();
    }
}
