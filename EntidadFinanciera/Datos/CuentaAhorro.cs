using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera.Datos
{
    internal class CuentaAhorro : Producto
    {
        public double Bonificacion { get; set; }

        public double Penalizacion { get; set; }


        public override void Ingresar(decimal cantidad)
        {
           Saldo += cantidad + (cantidad * (decimal)Bonificacion);
           Console.WriteLine("A ingresado: {0:C} y su saldo actual es de {1:C} \n", cantidad, Saldo);
        }

        public override void RetirarEfectivo(decimal cantidad)
        {

            var penalizacion = cantidad * (decimal)Penalizacion;
            if (Saldo >= cantidad + penalizacion)
            {
                Saldo -= cantidad + penalizacion;
                Console.WriteLine("Retirada realizada con exito! \n");
                Detalle();
            }
            else
            {
                Console.WriteLine("Saldo insuficiente \n");
                Detalle();
            }
            
        }
    }
}
