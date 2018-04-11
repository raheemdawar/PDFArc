using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PDFArt.DBModels
{
    public partial class PDFARTContext : DbContext
    {
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Catagory> Catagory { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ImageBook> ImageBook { get; set; }
        public virtual DbSet<ImageCatagory> ImageCatagory { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-4VHAAHN;Database=PDFART;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("Book_ID");

                entity.Property(e => e.BookAuthorName)
                    .HasColumnName("Book_Author_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.BookDateCreated)
                    .HasColumnName("Book_Date_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.BookDateUpdated)
                    .HasColumnName("Book_Date_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.BookEdition)
                    .HasColumnName("Book_Edition")
                    .HasMaxLength(30);

                entity.Property(e => e.BookIsActive).HasColumnName("Book_IsActive");

                entity.Property(e => e.BookName)
                    .HasColumnName("Book_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.BookUrl)
                    .HasColumnName("bookUrl")
                    .HasMaxLength(50);

                entity.Property(e => e.FkCatagoryId).HasColumnName("FK_Catagory_ID");

                entity.Property(e => e.FkUserId).HasColumnName("Fk_User_ID");

                entity.HasOne(d => d.FkCatagory)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.FkCatagoryId)
                    .HasConstraintName("FK_CatagoryID_Book");

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.FkUserId)
                    .HasConstraintName("FK_UserID_Book");
            });

            modelBuilder.Entity<Catagory>(entity =>
            {
                entity.Property(e => e.CatagoryId).HasColumnName("Catagory_ID");

                entity.Property(e => e.CatagoryDateCreated)
                    .HasColumnName("Catagory_Date_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.CatagoryDateUpdated)
                    .HasColumnName("Catagory_Date_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.CatagoryIsActive).HasColumnName("Catagory_IsActive");

                entity.Property(e => e.CatagoryName)
                    .HasColumnName("Catagory_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.ContactId).HasColumnName("Contact_ID");

                entity.Property(e => e.ContactCreateDate)
                    .HasColumnName("Contact_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContactEmail)
                    .HasColumnName("Contact_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactIsActive).HasColumnName("Contact_isActive");

                entity.Property(e => e.ContactMessage).HasColumnName("Contact_Message");

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactUpdateDate)
                    .HasColumnName("Contact_UpdateDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ImageBook>(entity =>
            {
                entity.ToTable("Image_Book");

                entity.Property(e => e.ImageBookId).HasColumnName("Image_Book_ID");

                entity.Property(e => e.FkBookId).HasColumnName("FK_Book_ID");

                entity.Property(e => e.ImageBookDateCreated)
                    .HasColumnName("Image_Book_Date_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImageBookDateUpdated)
                    .HasColumnName("Image_Book_Date_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImageBookIsActive).HasColumnName("Image_Book_IsActive");

                entity.Property(e => e.ImageBookUrl)
                    .HasColumnName("Image_Book_URL")
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkBook)
                    .WithMany(p => p.ImageBook)
                    .HasForeignKey(d => d.FkBookId)
                    .HasConstraintName("FK_BookID_Image_Book");
            });

            modelBuilder.Entity<ImageCatagory>(entity =>
            {
                entity.ToTable("Image_Catagory");

                entity.Property(e => e.ImageCatagoryId).HasColumnName("Image_Catagory_ID");

                entity.Property(e => e.FkCatagoryId).HasColumnName("FK_Catagory_ID");

                entity.Property(e => e.ImageCatagoryDateCreated)
                    .HasColumnName("Image_Catagory_Date_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImageCatagoryDateUpdated)
                    .HasColumnName("Image_Catagory_Date_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImageCatagoryIsActive).HasColumnName("Image_Catagory_IsActive");

                entity.Property(e => e.ImageCatagoryUrl)
                    .HasColumnName("Image_Catagory_URL")
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkCatagory)
                    .WithMany(p => p.ImageCatagory)
                    .HasForeignKey(d => d.FkCatagoryId)
                    .HasConstraintName("FK_CatagoryID_Image_Catagory");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.UserDateCreated)
                    .HasColumnName("User_Date_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserDateUpdated)
                    .HasColumnName("User_Date_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserEmail)
                    .HasColumnName("User_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.UserIsActive).HasColumnName("User_IsActive");

                entity.Property(e => e.UserName)
                    .HasColumnName("User_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UserPassword)
                    .HasColumnName("User_Password")
                    .HasMaxLength(50);
            });
        }
    }
}
