using CalculadoraRecetas.Clases.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using CalculadoraRecetas.Clases.StaticHelper;

namespace CalculadoraRecetas.Clases.DAL
{
    public class ClientesDAL : BaseDAL, IObjectDAL<Cliente>
    {
        public bool Delete(int id)
        {
            try
            {
                var clie = _dbContext.Clientes.Where(a => a.Id == id).FirstOrDefault();

                if (clie != null)
                {
                    string error = ValidDelete(clie);

                    if (error != string.Empty)
                        throw new Exception("Ocurrio un error en el Delete: " + error);

                    _dbContext.Clientes.Remove(clie);
                    _dbContext.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }
        }

        public bool Delete(Cliente clie)
        {
            return Delete(clie.Id);
        }

        public IList<Cliente> GetAllObj()
        {
            return _dbContext.Clientes.ToList();
        }

        public Cliente GetObjtById(int id)
        {
            return _dbContext.Clientes.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool Save(Cliente clie)
        {
            try
            {
                string error = ValidSave(clie);

                if (error != string.Empty)
                    throw new Exception("Ocurrio un error durante el Save: " + error);

                if (clie.Id == 0)
                    _dbContext.Clientes.Add(clie);

                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }
        }

        public string ValidDelete(Cliente clie)
        {
            if (_dbContext.Pedidos.Where(a => a.Id_Cliente == clie.Id).Any())
                return "No se puede borrar el cliente. Existen Pedidos a su nombre";

            return string.Empty;
        }

        public string ValidSave(Cliente clie)
        {
            if (clie.Nombre == "" || clie.Nombre == string.Empty)
                return "El Nombre del clietne no puede ser vacio. Es un campo obligatorio";

            if (clie.Nombre.Length > 50)
                return "El Nombre no puede superar los 50 caracteres";

            if (clie.Mail.Length > 75)
                return "El Mail no puede superar los 75 caracteres";

            if (clie.Direccion.Length > 150)
                return "La Direccion no puede superar los 150 caracteres";

            if (clie.Telefono.Length > 25)
                return "El Telefono no puede superar los 25 caracteres";

            if (clie.Celular.Length > 25)
                return "El Celular no puede superar los 25 caracteres";

            if (clie.Notas.Length > 2000)
                return "Las Notas no pueden superar los 2000 caracteres";

            return string.Empty;
        }
    }
}
