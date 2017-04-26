using System;

namespace Laboratorio.ModeloDeAnalisis.Negocio.GeneracionDeEmisionDeCertificados
{
    public class CertificadoDigital
    {
        public DateTime FechaDeEmision { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public string DireccionDeRevocacion { get; set; }
        public string Sujeto { get; set; }
    }
}
