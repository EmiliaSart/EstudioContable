using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Empleado
    {
        private int _id;
        private int _idEmpresa;
        private int _idCategoria;
        private long _cuit;
        private DateTime _fechaNacimiento;
        private DateTime _fechaAlta;
        private bool _activo;

        public int id { get => _id; set => _id = value; }
        public int idEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public int idCategoria { get => _idCategoria; set => _idCategoria = value; }
        public long cuit { get => _cuit; set => _cuit = value; }
        public DateTime fechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public DateTime fechaAlta { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public bool activo { get => _activo; set => _activo = value; }


    }
}
