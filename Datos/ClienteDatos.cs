using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;

namespace Datos
{
    public class ClienteDatos : IDatos<Cliente>
    {
        ClientesEntities contextobd = new ClientesEntities();
        public bool Actualizar(Cliente item)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Cliente item)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Cliente item)
        {
            try
            {
                contextobd.Cliente.Add(item);
                contextobd.SaveChanges();
                return true;
            } catch (Exception)
            {
                return false;
            }

        }

        public List<Cliente> Listar()
        {
            return contextobd.Cliente.ToList();
        }
    }
}