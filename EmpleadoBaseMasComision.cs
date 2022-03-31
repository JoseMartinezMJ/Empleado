using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class EmpleadoBaseMasComision: EmpleadoPorComision
    {
        private decimal salarioBase;
        public EmpleadoBaseMasComision(string nombre, string apellido,string nss, decimal ventas, decimal tarifa, decimal salario): base(nombre, apellido, nss, ventas, tarifa)
        {
            SalarioBase = salario; 
        } // fin del constructor de EmpleadoBaseMasComision con seis parámetros
        public decimal SalarioBase
        {
            get
            {
                return salarioBase;
            } // fin de get
            set
            {
                salarioBase = (value >= 0) ? value : 0; // validación
            } // fin de set
        } // fin de la propiedad SalarioBase
        public override decimal Ingresos()
        {
            return SalarioBase + base.Ingresos();
        } // fin del método Ingresos
        public override string ToString()
        {
            return string.Format("{0} {1}; {2}: {3:C}","salario base +", base.ToString(), "salario base", SalarioBase);
        }
    }
}
