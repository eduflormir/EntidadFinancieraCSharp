using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadFinanciera.Interfaces;

namespace EntidadFinanciera.Datos
{
    class CuentaCorriente:Producto,ICalculoSeguro
    {
        public decimal Credito{get;set;}
        public decimal Interes {get;set;}



        public override void Ingresar(decimal cantidad)
        {
            Saldo += cantidad;
            Console.WriteLine("Ingreso realizado con exito! \n");
            Detalle();
        }

        public override void RetirarEfectivo(decimal cantidad)
        {
            if (Saldo >= cantidad)
            {
                Saldo -= cantidad;
            Console.WriteLine("Retirada realizada con exito ");
            Console.WriteLine("Su Saldo actual es de: {0:C} \n",Saldo);
        } else if (Saldo+Credito>=cantidad)
        {
            var cs = cantidad - Saldo;
            var interes = cs*Interes;
            Console.WriteLine("Retirada realizada con exito! \n");
            Detalle();
        }
            
        }

        public decimal Prima(decimal cantidad, int edad)
        {
            if (edad < 40)
            {
                return cantidad * (decimal)0.01;
            }
            else
            {
                return cantidad * (decimal)0.03;
            }
        }

        public decimal Cancelacion(decimal cantidad)
        {
            return cantidad * (decimal)0.01;
        }
    }
}
