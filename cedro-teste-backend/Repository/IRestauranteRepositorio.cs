using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IRestauranteRepositorio
{
    void Add(Restaurante item);

    void Update(Restaurante item);

    IEnumerable<Restaurante> GetAll();

    Restaurante Find(Restaurante item);

    void Delete(int id);
}
