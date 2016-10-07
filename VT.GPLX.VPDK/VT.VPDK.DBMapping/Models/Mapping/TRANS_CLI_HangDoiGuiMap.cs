using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class TRANS_CLI_HangDoiGuiMap : EntityTypeConfiguration<TRANS_CLI_HangDoiGui>
    {
        public TRANS_CLI_HangDoiGuiMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.NoiGui)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.NoiNhan)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.DuongDan)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.TrangThai)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.NguoiTao)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KieuDuLieu)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("TRANS_CLI_HangDoiGui");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.NoiGui).HasColumnName("NoiGui");
            this.Property(t => t.NoiNhan).HasColumnName("NoiNhan");
            this.Property(t => t.DuongDan).HasColumnName("DuongDan");
            this.Property(t => t.KickThuocFile).HasColumnName("KickThuocFile");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.NguoiTao).HasColumnName("NguoiTao");
            this.Property(t => t.NgayTao).HasColumnName("NgayTao");
            this.Property(t => t.KieuDuLieu).HasColumnName("KieuDuLieu");

            // Relationships
            this.HasRequired(t => t.TRANS_LoaiDuLieu)
                .WithMany(t => t.TRANS_CLI_HangDoiGui)
                .HasForeignKey(d => d.KieuDuLieu);

        }
    }
}
