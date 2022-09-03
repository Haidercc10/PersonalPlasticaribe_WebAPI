using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_PlasticaribeWebAPI.Models
{
    public class Tipos_Estados
    {
        [Key]
        public int TpEstado_Id { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string TpEstado_Nombre { get; set; }


        [Column(TypeName = "varchar(MAX)")]
        public string? TpEstado_Descripcion { get; set; }
    }
}
