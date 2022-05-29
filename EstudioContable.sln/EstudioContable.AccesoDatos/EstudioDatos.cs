using EstudioContable.AccesoDatos.Utilidades;
using EstudioContable.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.AccesoDatos
{
    public class EstudioDatos
    {
        public List<Empleado> TraerTodos()
        {
            string json2 = WebHelper.Get("empleado");
            List<Empleado> resultado = MapList(json2);
            return resultado;
        }



        private List<Empleado> MapList(string json)
        {
            List<Empleado> lst = JsonConvert.DeserializeObject<List<Empleado>>(json); // deserializacion
            return lst;
        }

        public Empleado TraerPorId(int id)
        {
            string json2 = WebHelper.Get("estudio/" + id + "/id");
            Empleado resultado = MapObj(json2);
            return resultado;
        }

        private Empleado MapObj(string json)
        {
            throw new NotImplementedException(); Empleado lst = JsonConvert.DeserializeObject<Empleado>(json); // deserializacion
            return lst;
        }

        public TransactionResult Insertar(Empleado empleado)
        {
            NameValueCollection obj = ReverseMap(cliente); //serializacion -> json

            string json = WebHelper.Post("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);

            string json = WebHelper.Put("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cliente.id.ToString());
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Telefono", cliente.Telefono);
            n.Add("Email", cliente.Email);
            n.Add("DNI", cliente.DNI.ToString());
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("FechaNacimiento", cliente.FechaNacimiento.ToString("yyyy-MM-dd"));
            n.Add("Usuario", ACA_VA_TU_REGISTRO);
            return n;
        }

    }
}
