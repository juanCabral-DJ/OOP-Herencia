using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Herencia.Empleados
{
    public class EmpleadoAsalariadoPorComision : Empleado
    {
        protected double pagoSemanal { get; set; }
        protected int ventasBrutas { get; set; }
        protected int tarifaComision { get; set; }
        protected int salarioBase { get; set; }
        public EmpleadoAsalariadoPorComision(string PrimerNombre, string ApellidoPaterno, string numeroSeguroSocial, int ventasBruta, int tarifaDeComision, int salarioBases) : base(PrimerNombre, ApellidoPaterno, numeroSeguroSocial)
        {
            ventasBrutas = ventasBruta;
            tarifaComision = tarifaDeComision;
            salarioBase = salarioBases;
            pagoSemanal = 0;
        }
        public override double CalcularPago()
        {
            if (salarioBase != 0)
            {
                pagoSemanal = ventasBrutas * tarifaComision + salarioBase + salarioBase * 0.10;

            }
            else
            {
                pagoSemanal = 0;
                Console.WriteLine("No se pudo procesar el pago");
            }
            return pagoSemanal;
        }
        public override void mostrarInfo()
        {
            Console.WriteLine("Empleado Asalariado Por Comision:");
            Console.WriteLine($"Nombre: {PrimerNombre} {ApellidoPaterno}");
            Console.WriteLine($"Número de Seguro Social: {NumeroSeguroSocial}");
            Console.WriteLine($"Salario Semanal: {pagoSemanal:F2}");
        }
    }
}
