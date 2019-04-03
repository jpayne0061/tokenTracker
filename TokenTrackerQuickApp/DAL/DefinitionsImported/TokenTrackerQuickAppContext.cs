using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.DefinitionsImported
{
    public partial class TokenTrackerQuickAppContext : DbContext
    {
        public TokenTrackerQuickAppContext()
        {
        }

//        public TokenTrackerQuickAppContext(DbContextOptions<TokenTrackerQuickAppContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Group> Group { get; set; }
//        public virtual DbSet<GroupDetail> GroupDetail { get; set; }
//        public virtual DbSet<PointTransaction> PointTransaction { get; set; }
//        public virtual DbSet<Product> Product { get; set; }
//        public virtual DbSet<ProductGroup> ProductGroup { get; set; }
//        public virtual DbSet<Role> Role { get; set; }
//        public virtual DbSet<User> User { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=TokenTrackerQuickApp;Trusted_Connection=True");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

//            modelBuilder.Entity<Group>(entity =>
//            {
//                entity.HasIndex(e => e.Name)
//                    .IsUnique();

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(255)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<GroupDetail>(entity =>
//            {
//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.Group)
//                    .WithMany(p => p.GroupDetail)
//                    .HasForeignKey(d => d.GroupId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_GroupDetail_Group");
//            });

//            modelBuilder.Entity<PointTransaction>(entity =>
//            {
//                entity.HasIndex(e => e.ProductId);

//                entity.HasIndex(e => e.TransactionDate);

//                entity.Property(e => e.AwardMessage)
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.TransactionDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.HasOne(d => d.Product)
//                    .WithMany(p => p.PointTransaction)
//                    .HasForeignKey(d => d.ProductId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_PointTransaction_Product");
//            });

//            modelBuilder.Entity<Product>(entity =>
//            {
//                entity.HasIndex(e => e.Name)
//                    .IsUnique();

//                entity.HasIndex(e => e.ProductGroupId);

//                entity.Property(e => e.Description)
//                    .IsRequired()
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.IsActive)
//                    .IsRequired()
//                    .HasDefaultValueSql("((1))");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.ProductGroup)
//                    .WithMany(p => p.Product)
//                    .HasForeignKey(d => d.ProductGroupId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Product_ProductGroup");
//            });

//            modelBuilder.Entity<ProductGroup>(entity =>
//            {
//                entity.HasIndex(e => e.Name)
//                    .IsUnique();

//                entity.Property(e => e.AffectOnTransaction).HasDefaultValueSql("((1))");

//                entity.Property(e => e.IsActive)
//                    .IsRequired()
//                    .HasDefaultValueSql("((1))");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Role>(entity =>
//            {
//                entity.HasIndex(e => e.Name)
//                    .HasName("IX_Role")
//                    .IsUnique();

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(255)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<User>(entity =>
//            {
//                entity.HasIndex(e => e.Email)
//                    .IsUnique();

//                entity.HasIndex(e => e.GroupId);

//                entity.HasIndex(e => e.RoleId);

//                entity.Property(e => e.Email)
//                    .IsRequired()
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.Group)
//                    .WithMany(p => p.User)
//                    .HasForeignKey(d => d.GroupId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_User_Group");

//                entity.HasOne(d => d.Role)
//                    .WithMany(p => p.User)
//                    .HasForeignKey(d => d.RoleId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_User_Role");
//            });
//        }
    }
}
