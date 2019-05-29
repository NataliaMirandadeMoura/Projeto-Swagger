using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Repository
{
    public interface IClienteRepository : IDisposable
    {
        void Create(Cliente cliente);
        void Update(Cliente cliente);
        void Remove(Cliente cliente);

        List<Cliente> SelectAll();
        Cliente SelectById(int id);

    }
}
