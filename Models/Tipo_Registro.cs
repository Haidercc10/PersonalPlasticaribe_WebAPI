using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_PlasticaribeWebAPI.Models
{
    public class Tipo_Registro
    {

        [Key]
        public int TpReg_Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string TpReg_Nombre { get; set; }


        [Column(TypeName = "varchar(MAX)")]
        public string? TpReg_Descripcion { get; set; }


        public string TpReg_Hora { get; set; }

        /** Turnos */
        public int Turno_Id { get; set; }
        public Turno? Turnos { get; set;  } 

    }
}
