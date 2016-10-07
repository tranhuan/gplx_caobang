using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class TRANS_LoaiDuLieuMap : EntityTypeConfiguration<TRANS_LoaiDuLieu>
    {
        public TRANS_LoaiDuLieuMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Ten)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.MoTa)
                .HasMaxLength(2550);

            this.Property(t => t.DangSuDung)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("TRANS_LoaiDuLieu");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Ten).HasColumnName("Ten");
            this.Property(t => t.MoTa).HasColumnName("MoTa");
            this.Property(t => t.DangSuDung).HasColumnName("DangSuDung");
        }
    }
}
