using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce
{

    public class Valores
    {
        public string version { get; set; }
        public string autor { get; set; }
        public DateTime fecha { get; set; }
        public Uf uf { get; set; }
        public Ivp ivp { get; set; }
        public Dolar dolar { get; set; }
        public Dolar_Intercambio dolar_intercambio { get; set; }
        public Euro euro { get; set; }
        public Ipc ipc { get; set; }
        public Utm utm { get; set; }
        public Imacec imacec { get; set; }
        public Tpm tpm { get; set; }
        public Libra_Cobre libra_cobre { get; set; }
        public Tasa_Desempleo tasa_desempleo { get; set; }
        public Bitcoin bitcoin { get; set; }
    }

    public class Uf
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public DateTime fecha { get; set; }
        public float valor { get; set; }
    }

    public class Ivp
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public DateTime fecha { get; set; }
        public float valor { get; set; }
    }

    public class Dolar
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public DateTime fecha { get; set; }
        public float valor { get; set; }
    }

    public class Dolar_Intercambio
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public DateTime fecha { get; set; }
        public float valor { get; set; }
    }

    public class Euro
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public DateTime fecha { get; set; }
        public float valor { get; set; }
    }

    public class Ipc
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public DateTime fecha { get; set; }
        public float valor { get; set; }
    }

    public class Utm
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public DateTime fecha { get; set; }
        public int valor { get; set; }
    }

    public class Imacec
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public DateTime fecha { get; set; }
        public string valor { get; set; }
    }

    public class Tpm
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public DateTime fecha { get; set; }
        public float valor { get; set; }
    }

    public class Libra_Cobre
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public DateTime fecha { get; set; }
        public float valor { get; set; }
    }

    public class Tasa_Desempleo
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public DateTime fecha { get; set; }
        public float valor { get; set; }
    }

    public class Bitcoin
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public DateTime fecha { get; set; }
        public float valor { get; set; }
    }

}
