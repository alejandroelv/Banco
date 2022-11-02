using System;

namespace Banco
{
	public class Cuenta
	{
		private string numCuenta;
		private string nombre;
		private double saldo;
		private double tipoInteres;

		public Cuenta()
		{
		}

		public Cuenta(string numCuenta, string nombre, double saldo, double tipoInteres)
		{
			NumCuenta = numCuenta;
			Nombre = nombre;
			Saldo = saldo;
			TipoInteres = tipoInteres;
		}

		public string NumCuenta { get => numCuenta; set => numCuenta = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public double Saldo { get => saldo; set => saldo = value; }
		public double TipoInteres { get => tipoInteres; set => tipoInteres = value; }

		public virtual void estado()
		{
			Console.WriteLine("Numero de cuenta: " + this.NumCuenta);
			Console.WriteLine("Nombre del propietario: " + this.Nombre);
			Console.WriteLine("Saldo de la cuenta: " + this.Saldo + " euros");
			Console.WriteLine("Tipo de interes: " + this.TipoInteres + "%");
		}

		public override string ToString()
		{
			return this.numCuenta;
		}
	}
}