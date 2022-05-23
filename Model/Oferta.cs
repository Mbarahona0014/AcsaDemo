using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcsaDemo.Model
{
    public class Oferta
    {
        public string conyuge { get; set; }
        public DateTime fecha_nac_conyuge { get; set; }
        public int n_hijos { get; set; }
        public double suma_titular { get; set; }
        public double suma_conyuge { get; set; }
        public double valor_pcuota { get; set; }
        public double valor_csucesiva { get; set; }
    }
}
