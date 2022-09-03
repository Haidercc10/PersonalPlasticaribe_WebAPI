using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_PlasticaribeWebAPI.Models
{
    public class Tipo_Usuario
    {

        [Key]
        public int TipoUsu_Id { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string TipoUsu_Nombre { get; set; }


        [Column(TypeName = "varchar(MAX)")]
        public string? TipoUsu_Descripcion { get; set; }
    }
}
