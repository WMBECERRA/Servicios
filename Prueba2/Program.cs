using AccesoADatos;
using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClientesLogica datos = new ClientesLogica();
            List<Cliente> lista = datos.ListarClientes();
            foreach (var item in lista)
            {
                Console.WriteLine(item.nombre + " " + item.cedula);
            }
            Console.ReadKey();
        }
    }
}
