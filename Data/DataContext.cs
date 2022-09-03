using Microsoft.EntityFrameworkCore;
using Personal_PlasticaribeWebAPI.Models;

namespace Personal_PlasticaribeWebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        /** Modelos */
        public DbSet<Models.Area> Areas { get; set; }
        
        public DbSet<Models.Estado> Estados { get; set; }

        public DbSet<Models.Registro_Operario> Registros_Operarios { get; set; }

        public DbSet<Models.Tipo_Identificacion> Tipos_Identificaciones { get; set; }

        public DbSet<Models.Tipo_Registro> Tipos_Registros { get; set; }

        public DbSet<Models.Tipo_Usuario> Tipos_Usuarios { get; set; }
        
        public DbSet<Models.Turno> Turnos { get; set; }

        public DbSet<Models.Usuarios> Usuarios { get; set; }

        public DbSet<Models.Tipos_Estados> Tipos_Estados { get; set; }

        /** Relaciones FLUENT API */

        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /** Relaciones Registros_Operarios */
            //modelBuilder.Entity<Registro_Operario>().HasOne(reg => reg.TipoReg).WithMany().HasForeignKey(reg => reg.TpReg_Id).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Registro_Operario>().HasOne(reg => reg.Usuario).WithMany().HasForeignKey(reg => reg.Usu_Id).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Registro_Operario>().HasOne(reg => reg.Turnos).WithMany().HasForeignKey(reg => reg.Turno_Id).OnDelete(DeleteBehavior.Restrict);

            /** Relaciones Tipos_Registros */
            modelBuilder.Entity<Tipo_Registro>().HasOne(reg => reg.Turnos).WithMany().HasForeignKey(reg => reg.Turno_Id).OnDelete(DeleteBehavior.Restrict);

            /** Relaciones Usuarios */
            modelBuilder.Entity<Usuarios>().HasOne(reg => reg.TipoIdent).WithMany().HasForeignKey(reg => reg.TipoIdent_Id).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Usuarios>().HasOne(reg => reg.TipoUsu).WithMany().HasForeignKey(reg => reg.TipoUsu_Id).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Usuarios>().HasOne(reg => reg.Estado).WithMany().HasForeignKey(reg => reg.Estado_Id).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Usuarios>().HasOne(reg => reg.Area).WithMany().HasForeignKey(reg => reg.Area_Id).OnDelete(DeleteBehavior.Restrict);

            /** Relaciones Estados */
            modelBuilder.Entity<Estado>().HasOne(reg => reg.Tipo_Estado).WithMany().HasForeignKey(reg => reg.TpEstado_Id).OnDelete(DeleteBehavior.Restrict);


        }








    }
}
