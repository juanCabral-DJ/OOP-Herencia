using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Herencia.Empleados
{
    public class EmpleadoPorComision : Empleado
    {
        protected double pago { get; set; }
        protected int ventasBrutas { get; set; }
        protected int tarifaComision { get; set; }
        public EmpleadoPorComision(string PrimerNombre, string ApellidoPaterno, string numeroSeguroSocial, int ventasBruta, int tarifaDeComision) : base(PrimerNombre, ApellidoPaterno, numeroSeguroSocial)
        {
            ventasBrutas = ventasBruta;
            tarifaComision = tarifaDeComision;
            pago = 0;
        }
        public override double CalcularPago()
        {  
            if (ventasBrutas != 0 && tarifaComision != 0)
            {
                pago = ventasBrutas * tarifaComision;
                
            }
            else
            {
                pago = 0;
                Console.WriteLine("No se pudo calcular el pago");
            }
            return pago;
        }
             public override void mostrarInfo() {
            Console.WriteLine("Empleado Por Comision:");
            Console.WriteLine($"Nombre: {PrimerNombre} {ApellidoPaterno}");
            Console.WriteLine($"Número de Seguro Social: {NumeroSeguroSocial}");
            Console.WriteLine($"Salario Semanal: {pago:F2}");
        }
    }
}
