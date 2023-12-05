using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Layer.Entity
{
    public class VTM_RESTO_MESAS_Entity
    {
        [MaxLength(3)]
        public string Emp_cCodigo { get; set; }
        [MaxLength(5)]
        public string Pvt_cCodigo { get; set; }
        [MaxLength(5)]
        public string Mes_cCodigo { get; set; }
        [MaxLength(100)]
        public string Mes_cDescripcion { get; set; }
        [MaxLength(1)]
        public string Mes_cEstado { get; set; }
        [MaxLength(20)]
        public string Mes_cUserCrea { get; set; }
        public DateTime Mes_dFechaCrea { get; set; }
        [MaxLength(20)]
        public string Mes_cUserModifica { get; set; }
        public DateTime Mes_dFechaModifica { get; set; }
        [MaxLength(20)]
        public string Mes_cEquipoUser { get; set; }

    }

}

