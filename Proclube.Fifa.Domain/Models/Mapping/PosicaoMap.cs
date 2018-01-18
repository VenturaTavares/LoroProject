
using System.Data.Entity.ModelConfiguration;


namespace Proclube.Fifa.Domain.Models.Mapping
{
    public class PosicaoMap : EntityTypeConfiguration<Posicao>
    {

        public PosicaoMap()
        {
            // Primary Key
            this.HasKey(t => t.PosicaoID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Posicao");
            this.Property(t => t.PosicaoID).HasColumnName("PosicaoID").HasColumnType("int");
            this.Property(t => t.Descricao).HasColumnName("Descricao").HasColumnType("nvarchar(200)");

        }
    }
}
