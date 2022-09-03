using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_PlasticaribeWebAPI.Models
{
    public class Usuarios
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Usu_Codigo { get; set; } 

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Usu_Id { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string Usu_Nombre { get; set; }


        /** Tipo ID */
        [Column(TypeName = "varchar(10)")]
        public string TipoIdent_Id { get; set; }
        public Tipo_Identificacion? TipoIdent { get; set; }


        /** Area */
        public int Area_Id { get; set; }
        public Area? Area { get; set; }


        /** Tipo Usuario */
        public int TipoUsu_Id { get; set; }
        public Tipo_Usuario? TipoUsu { get; set; }


        /** Estado */
        public int Estado_Id { get; set; }
        public Estado? Estado { get; set; }


    }
}
