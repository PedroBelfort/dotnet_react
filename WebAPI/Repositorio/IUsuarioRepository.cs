using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositorio
{
    // aqui eu defino os métodos que eu quero expor na web api
    public interface IUsuarioRepository
    {

        void Add(Usuario user);

        IEnumerable<Usuario> GetAll();

        Usuario Find(long id);

        void Remove(long id);

        void Update(Usuario User);

    }
}
