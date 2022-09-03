using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_PlasticaribeWebAPI.Models
{
    public class Area
    {

        [Key]
        public int Area_Id { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string Area_Nombre { get; set; }


        [Column(TypeName = "varchar(MAX)")]
        public string? Area_Descripcion { get; set; }
    }
}
