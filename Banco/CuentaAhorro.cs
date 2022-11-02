using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class CuentaAhorro : Cuenta
    {
        private double cuotaMantenimiento;
        public CuentaAhorro()
        {

        }

        public CuentaAhorro(string numCuenta, string nombre, double saldo, double tipoInteres, double cuotaMantenimiento) : base(numCuenta, nombre, saldo, tipoInteres)
        {
            CuotaMantenimiento = cuotaMantenimiento;
        }
        public double CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value;}

        public override void estado()
        {
            base.estado();
            Console.WriteLine("Cuota de mantenimiento: " + this.CuotaMantenimiento);
        }
    }
}
