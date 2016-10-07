using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class NguoiLX_Hoso_QuocteMap : EntityTypeConfiguration<NguoiLX_Hoso_Quocte>
    {
        public NguoiLX_Hoso_QuocteMap()
        {
            // Primary Key
            this.HasKey(t => t.MaDK);

            // Properties
            this.Property(t => t.MaDK)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.NOI_SINH)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ANH_CHU_KY)
                .HasMaxLength(255);

            this.Property(t => t.SO_SERI)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("NguoiLX_Hoso_Quocte");
            this.Property(t => t.MaDK).HasColumnName("MaDK");
            this.Property(t => t.NOI_SINH).HasColumnName("NOI_SINH");
            this.Property(t => t.ANH_CHU_KY).HasColumnName("ANH_CHU_KY");
            this.Property(t => t.LASTUPDATED).HasColumnName("LASTUPDATED");
            this.Property(t => t.SO_SERI).HasColumnName("SO_SERI");

            // Relationships
            this.HasRequired(t => t.NguoiLX_HoSo)
                .WithOptional(t => t.NguoiLX_Hoso_Quocte);

        }
    }
}
