using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VT.VPDK.DBMapping.Models.Mapping
{
    public class QTHT_NguoiDungMap : EntityTypeConfiguration<QTHT_NguoiDung>
    {
        public QTHT_NguoiDungMap()
        {
            // Primary Key
            this.HasKey(t => t.UserName);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(172);

            this.Property(t => t.HoTen)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SoCMND)
                .HasMaxLength(14);

            this.Property(t => t.TrangThai)
                .HasMaxLength(1);

            this.Property(t => t.GhiChu)
                .HasMaxLength(150);

            this.Property(t => t.Prefix)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("QTHT_NguoiDung");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.HoTen).HasColumnName("HoTen");
            this.Property(t => t.SoCMND).HasColumnName("SoCMND");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.Prefix).HasColumnName("Prefix");
        }
    }
}
