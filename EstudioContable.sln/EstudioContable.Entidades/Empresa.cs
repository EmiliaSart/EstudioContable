using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    internal class Empresa
    {
        private int _id;
        private string _razonSocial;
        private long _cuit;
        private string _domicilio;
        private DateTime _fechaAlta;


        public int Id { get => _id; set => _id = value; }
        public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        public long Cuit { get => _cuit; set => _cuit = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
    }
}
