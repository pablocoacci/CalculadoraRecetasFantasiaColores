using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRecetas.Clases.Dominio
{
    public class Cliente
    {
        public Cliente()
        {
            Nombre = "";
            Mail = "";
            Telefono = "";
            Celular = "";
            Direccion = "";
            Nombre = "";
            Notas = "";
            ClienteDificil = false;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Notas { get; set; }
        public bool ClienteDificil { get; set; }
    }
}
