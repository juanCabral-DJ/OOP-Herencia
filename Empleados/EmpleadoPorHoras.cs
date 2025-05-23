using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Herencia.Empleados
{
    public class EmpleadoPorHoras : Empleado
    {
        protected double pago { get; set;}
        protected int SueldoPorHoras { get; set; }
        protected double HorasTrabajadas { get; set; }
        public EmpleadoPorHoras(string PrimerNombre, string ApellidoPaterno, string numeroSeguroSocial, int sueldoPorHoras, double horasTrabajadas) : base(PrimerNombre, ApellidoPaterno, numeroSeguroSocial)
        {
            SueldoPorHoras = sueldoPorHoras;
            HorasTrabajadas = horasTrabajadas;
            pago = 0;
        }

        public override double CalcularPago()
        {
            if (HorasTrabajadas <= 40 && HorasTrabajadas > 0)
            {
                pago = HorasTrabajadas * SueldoPorHoras;
              
            }
            else if (HorasTrabajadas > 40)
            {
                pago = (SueldoPorHoras * 40) + (SueldoPorHoras * 1.5 * (HorasTrabajadas - 40));
              
            }
            else
            {
                pago = 0;
                Console.WriteLine("No hubieron horas trabajadas");
            }
            return pago;
        }
        public override void mostrarInfo()
        {
            Console.WriteLine("Empleado Por Horas:");
            Console.WriteLine($"Nombre: {PrimerNombre} {ApellidoPaterno}");
            Console.WriteLine($"Número de Seguro Social: {NumeroSeguroSocial}");
            Console.WriteLine($"Salario Semanal: {pago:F2}");
        }
    }
}
