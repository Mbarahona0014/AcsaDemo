using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcsaDemo.Model
{
    public class Intermediario
    {
        public string nombre { get; set; }
        public string correo { get; set; }

        [RegularExpression(@"[0-9]{4}[-][0-9]{6}[-][0-9]{3}[-][0-9]{1}",
         ErrorMessage = "El valor no coincide con el formato de nit [####-#######-###-#]")]
        public string nit { get; set; }
        public string fecha_nac { get; set; }
        public string conyuge { get; set; }
        public string fecha_nac_conyuge { get; set; }
        public int n_hijos { get; set; }
        public double suma_titular { get; set; }
        public double suma_conyuge { get; set; }
        public double valor_pcuota { get; set; }
        public double valor_csucesiva { get; set; }
    }
}
