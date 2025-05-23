using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Herencia.Empleados
{
    public class EmpleadoAsalariado : Empleado
    {
        protected double SalarioSemanal { get; set; }
        public EmpleadoAsalariado(string PrimerNombre, string ApellidoPaterno, string numeroSeguroSocial, double salarioSemanal) : base(PrimerNombre, ApellidoPaterno, numeroSeguroSocial)
        {
            SalarioSemanal = salarioSemanal;
        }
        public override double CalcularPago()
        {
            return SalarioSemanal;
        }
        public override void mostrarInfo() {
            Console.WriteLine("Empleado Asalariado:");
            Console.WriteLine($"Nombre: {PrimerNombre} {ApellidoPaterno}");
            Console.WriteLine($"Número de Seguro Social: {NumeroSeguroSocial}");
            Console.WriteLine($"Salario Semanal: {SalarioSemanal}");
        }
    }
}
