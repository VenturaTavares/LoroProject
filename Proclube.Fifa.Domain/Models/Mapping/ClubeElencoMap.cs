using System.Data.Entity.ModelConfiguration;


namespace Proclube.Fifa.Domain.Models.Mapping
{
    public class ClubeElencoMap : EntityTypeConfiguration<ClubeElenco>
    {

        public ClubeElencoMap()
        {
            this.HasKey(t => t.ClubeElencoID);

            // Properties

            // Table & Column Mappings
            this.ToTable("ClubeElenco");
            this.Property(t => t.ClubeElencoID).HasColumnName("ClubeElencoID").HasColumnType("int");
            this.Property(t => t.CluebeID).HasColumnName("CluebeID").HasColumnType("int");
            this.Property(t => t.JogadorID).HasColumnName("JogadorID").HasColumnType("int");

        }
    }
}
