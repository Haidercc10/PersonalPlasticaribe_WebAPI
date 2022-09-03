using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_PlasticaribeWebAPI.Models
{
    public class Registro_Operario
    {

        [Key]
        public long RegOpe_Id { get; set; }

        /** Usuario */
        public long Usu_Id { get; set; }
        public Usuarios? Usuario { get; set; }

        /** Tipo Registro */
        public int TpReg_Id { get; set;  }
        public Tipo_Registro? TipoReg { get; set; }


        [Column(TypeName = "date")]
        public DateTime RegOpe_Fecha { get; set; }

        public string RegOpe_Hora { get; set; } 
        

    }
}
