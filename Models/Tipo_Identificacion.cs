using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_PlasticaribeWebAPI.Models
{
    public class Tipo_Identificacion
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "varchar(10)")]
        public string TipoIdent_Id { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string TipoIdent_Nombre { get; set; }


        [Column(TypeName = "varchar(MAX)")]
        public string? TipoIdent_Descripcion { get; set; }
    }
}
