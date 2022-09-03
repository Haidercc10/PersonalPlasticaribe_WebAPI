using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_PlasticaribeWebAPI.Models
{
    public class Turno
    {

        [Key]
        public int Turno_Id { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string Turno_Nombre { get; set; }


        [Column(TypeName = "varchar(MAX)")]
        public string? Turno_Descripcion { get; set; }

    }
}
