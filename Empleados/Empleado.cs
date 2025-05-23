using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Herencia.Empleados
{
    public abstract class Empleado
    {
        protected double Salario {  get; set; }
        protected string PrimerNombre { get; set; }
        protected string ApellidoPaterno { get; set; }
        protected string NumeroSeguroSocial { get; set; }
        public Empleado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial)
        {
            PrimerNombre = primerNombre;
            ApellidoPaterno = apellidoPaterno;
            NumeroSeguroSocial = numeroSeguroSocial;
            Salario = 0;
        }

        public virtual void mostrarInfo(){}

        public virtual double CalcularPago(){
            return Salario;
        }
    }
}
