using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class EmpleadoPorComision:AsbtractEmpleado
    {
        private decimal ventasBrutas; // ventas semanales totales
        private decimal tarifaComision; // porcentaje de comisión
        // constructor con cinco parámetros
        public EmpleadoPorComision(string nombre, string apellido, string nss,decimal ventas, decimal tarifa) : base(nombre, apellido, nss)
        {
            VentasBrutas = ventas;
            TarifaComision = tarifa;
        }
        public decimal TarifaComision
        {
            get
            {
                return tarifaComision;
            } // fin de get
            set
            {
                tarifaComision = (value > 0 && value < 1) ?value : 0; }
        }
        public decimal VentasBrutas
        {
            get
            {
                return ventasBrutas;
            } // fin de get
            set
            {
                ventasBrutas = (value >= 0 ) ? value : 0; // validación
            } // fin de set
        } // fin de la propiedad VentasBrutas
        public override decimal Ingresos()
        {
            return TarifaComision * VentasBrutas;
        } // fin del método Ingresos
        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}","empleado por comisión", base.ToString(),"ventas brutas", VentasBrutas, "tarifa de comisión", TarifaComision);
        }

    }
}
