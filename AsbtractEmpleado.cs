using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public abstract class AsbtractEmpleado
    {
        private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;

        // Constructor con tres parámetros
        public AsbtractEmpleado(string nombre, string apellido, string nss)
        {
            primerNombre = nombre;
            apellidoPaterno = apellido;
            numeroSeguroSocial = nss;
        } 
        // Fin de constructor de Empleado con tres parámetro

        // Propiedad de solo lectura que obtiene el primer nombre del empleado
        public string PrimerNombre
        {
            get 
            { 
                return primerNombre; 
            }//Fin de get
        }// fin de la propiedad Primer Nombre

        public string ApellidoPaterno 
        { 
            get 
            { 
                return apellidoPaterno; 
            } 
        }//fin
        public string NumeroSeguroSocial
        {
            get 
            { 
                return numeroSeguroSocial;
            }
        }//fin
        public override string ToString()
        {
            return string.Format("{0} {1}\nnúmero de seguro social: {2}", PrimerNombre, ApellidoPaterno, NumeroSeguroSocial);
        }
        public abstract decimal Ingresos();
    }
}
