using System;

namespace Laboratorio.ModeloDeAnalisis.Negocio.GeneracionDeEmisionDeCertificados
{
    public class EmisionDeCertificados
    {
        public DateTime FechaDeEmision { get; set; }
        public CertificadoDigital CertificadoDigitalDeFirma { get; set; }
        public CertificadoDigital CertificadoDigitalDeAutenticacion { get; set; }
    }
}
