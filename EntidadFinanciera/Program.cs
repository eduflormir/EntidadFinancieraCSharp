using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadFinanciera.Datos;

namespace EntidadFinanciera
{
    class Program
    {
        static void Main(string[] args)
        {
            var cl = new Cliente()
            {
                Dni = "1234",
                Nombre = "Eduardo Flores",
                Telefono = "12345678"
            };
            var cc = new CuentaCorriente()
            {
                Cliente = cl,
                Saldo = 1200,
                Credito = 500,
                Interes = (decimal)0.12
            };
            var ca = new CuentaAhorro()
            {
                Cliente = cl,
                Saldo = 12000,
                Bonificacion = 0.01,
                Penalizacion = 0.04
            };

            cc.RetirarEfectivo(3000);
            ca.RetirarEfectivo(10000);


            Console.ReadLine();
        }
    }
}
