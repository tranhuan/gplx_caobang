using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class TRANS_CLI_NhatKyGuiMap : EntityTypeConfiguration<TRANS_CLI_NhatKyGui>
    {
        public TRANS_CLI_NhatKyGuiMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.IdOutputFile)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.NguoiThaoTac)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ThongBao)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.TrangThai)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("TRANS_CLI_NhatKyGui");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdOutputFile).HasColumnName("IdOutputFile");
            this.Property(t => t.NguoiThaoTac).HasColumnName("NguoiThaoTac");
            this.Property(t => t.NgayThaoTac).HasColumnName("NgayThaoTac");
            this.Property(t => t.ThongBao).HasColumnName("ThongBao");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");

            // Relationships
            this.HasRequired(t => t.TRANS_CLI_HangDoiGui)
                .WithMany(t => t.TRANS_CLI_NhatKyGui)
                .HasForeignKey(d => d.IdOutputFile);

        }
    }
}
