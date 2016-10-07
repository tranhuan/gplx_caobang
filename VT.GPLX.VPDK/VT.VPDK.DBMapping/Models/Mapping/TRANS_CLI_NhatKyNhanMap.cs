using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class TRANS_CLI_NhatKyNhanMap : EntityTypeConfiguration<TRANS_CLI_NhatKyNhan>
    {
        public TRANS_CLI_NhatKyNhanMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.IdInputFile });

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.IdInputFile)
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
            this.ToTable("TRANS_CLI_NhatKyNhan");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdInputFile).HasColumnName("IdInputFile");
            this.Property(t => t.NguoiThaoTac).HasColumnName("NguoiThaoTac");
            this.Property(t => t.NgayThaoTac).HasColumnName("NgayThaoTac");
            this.Property(t => t.ThongBao).HasColumnName("ThongBao");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");

            // Relationships
            this.HasRequired(t => t.TRANS_CLI_HangDoiNhan)
                .WithMany(t => t.TRANS_CLI_NhatKyNhan)
                .HasForeignKey(d => d.IdInputFile);

        }
    }
}
