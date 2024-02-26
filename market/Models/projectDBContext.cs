using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace market.Models
{
    public partial class projectDBContext :  IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public projectDBContext()
        {
        }

        public projectDBContext(DbContextOptions<projectDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<EntryItems> EntryItems { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductEntry> ProductEntry { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=DESKTOP-JLMI2BA;database= projectDB;Trusted_Connection=True; Encrypt=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsVip)
                    .IsRequired()
                    .HasColumnName("isVIP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");
            });

            modelBuilder.Entity<EntryItems>(entity =>
            {
                entity.ToTable("Entry_Items");

                entity.HasIndex(e => e.ProdId);

                entity.HasIndex(e => e.ProductEntryId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProdId).HasColumnName("prod_ID");

                entity.Property(e => e.ProductEntryId).HasColumnName("product_Entry_ID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.EntryItems)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Entry_Items_Product");

                entity.HasOne(d => d.ProductEntry)
                    .WithMany(p => p.EntryItems)
                    .HasForeignKey(d => d.ProductEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Entry_Items_Product_Entry");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.CustomerId);

                entity.Property(e => e.Id).HasColumnName("ID");


                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.DeliveryAddress)
                    .IsRequired()
                    .HasColumnName("deliveryAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryPrice).HasColumnName("deliveryPrice").HasColumnType("money");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("orderDate")
                    .HasColumnType("datetime");

                

                entity.Property(e => e.Tax).HasColumnName("tax").HasColumnType("money");

                entity.Property(e => e.TotalPrice).HasColumnName("totalPrice").HasColumnType("money");


                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Customer");
            });

            modelBuilder.Entity<OrderItems>(entity =>
            {
                entity.ToTable("Order_ITems");

                entity.HasIndex(e => e.OrderId);

                entity.HasIndex(e => e.ProdId);

                entity.Property(e => e.Id).HasColumnName("ID");


                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.Price).HasColumnName("price").HasColumnType("money");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");


                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Has_Products_Order");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Has_Products_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlertQuantity).HasColumnName("alertQuantity");


                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price").HasColumnType("money");

                entity.Property(e => e.Quantity).HasColumnName("quantity");


            });

            modelBuilder.Entity<ProductEntry>(entity =>
            {
                entity.ToTable("Product_Entry");

                entity.HasIndex(e => e.SupplierId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.SupplierId).HasColumnName("supplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ProductEntry)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Entry_Supplier");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasIndex(e => e.Name).IsUnique();
            });

            //   OnModelCreatingPartial(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
