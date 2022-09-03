using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_PlasticaribeWebAPI.Models
{
    public class Estado
    {


        [Key]
        public int Estado_Id { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string Estado_Nombre { get; set; }


        [Column(TypeName = "varchar(MAX)")]
        public string? Estado_Descripcion { get; set; }

        public int TpEstado_Id { get; set; }
        public Tipos_Estados? Tipo_Estado { get; set; }
    }
}
