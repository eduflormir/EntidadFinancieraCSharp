using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera.Datos
{
    public abstract class Producto
    {
        public Cliente Cliente { get; set; }
        public decimal Saldo { get; set; }


        #region Metodos Abstractos

        protected virtual void Detalle()
        {
            Console.WriteLine("Datos del cliente, DNI: {0} el Nombre: {1} y su Telefono es: {2} \n", Cliente.Dni, Cliente.Nombre, Cliente.Telefono);
            Console.WriteLine("Saldo: {0:C} \n", Saldo); // :C hace formato tipo moneda
        }

        public abstract void Ingresar(decimal cantidad);
        public abstract void RetirarEfectivo(decimal cantidad);

        #endregion




    }
}
