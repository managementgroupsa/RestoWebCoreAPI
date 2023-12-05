using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Layer.Entity
{
    public class VTD_RESTO_APERTURA_PEDIDO_Entity
    {
        [MaxLength(3)]
        public string Emp_cCodigo { get; set; }
        [MaxLength(4)]
        public string Pan_cAnio { get; set; }
        [MaxLength(10)]
        public string Res_cNummov { get; set; }
        [MaxLength(5)]
        public string Mes_cCodigo { get; set; }
        public int Ped_nItem { get; set; }
        [MaxLength(6)]
        public string Cab_cCatalogo { get; set; }
        public int Ped_nCantidad { get; set; }
        [MaxLength(1000)]
        public string Ped_cComentario { get; set; }
        [MaxLength(1)]
        public string Ped_cEstado { get; set; }
        [MaxLength(20)]
        public string Ped_cUserCrea { get; set; }
        public DateTime Ped_dFechaCrea { get; set; }
        [MaxLength(20)]
        public string Ped_cUserModifica { get; set; }
        public DateTime Ped_dFechaModifica { get; set; }
        [MaxLength(20)]
        public string Ped_cEquipoUser { get; set; }

    }


}

