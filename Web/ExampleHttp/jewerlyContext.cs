using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ExampleHttp
{
    public partial class jewerlyContext : DbContext
    {
        public jewerlyContext()
        {
        }

        public jewerlyContext(DbContextOptions<jewerlyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Dostavka> Dostavkas { get; set; }
        public virtual DbSet<Izdelie> Izdelies { get; set; }
        public virtual DbSet<IzdelieSpr> IzdelieSprs { get; set; }
        public virtual DbSet<Izgotovlenie> Izgotovlenies { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Otdelka> Otdelkas { get; set; }
        public virtual DbSet<Prize> Prizes { get; set; }
        public virtual DbSet<Rabotum> Rabota { get; set; }
        public virtual DbSet<Sotrudnik> Sotrudniks { get; set; }
        public virtual DbSet<TipIzd> TipIzds { get; set; }
        public virtual DbSet<Zakaz> Zakazs { get; set; }
        public virtual DbSet<Zakupka> Zakupkas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=jewerly;Username=postgres;Password=saak2108");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.HasKey(e => e.IdAns)
                    .HasName("answers_pkey");

                entity.ToTable("answers");

                entity.Property(e => e.IdAns)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_ans")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateAns)
                    .HasColumnType("date")
                    .HasColumnName("date_ans");

                entity.Property(e => e.IdComment).HasColumnName("id_comment");

                entity.Property(e => e.IdZak).HasColumnName("id_zak");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.HasOne(d => d.IdAnsNavigation)
                    .WithOne(p => p.Answer)
                    .HasForeignKey<Answer>(d => d.IdAns)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("answers_fkey");

                entity.HasOne(d => d.IdZakNavigation)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.IdZak)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("answers2_fkey");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEnd).HasColumnType("timestamp with time zone");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasKey(e => e.IdBank)
                    .HasName("bank_pkey");

                entity.ToTable("bank");

                entity.Property(e => e.IdBank)
                    .HasColumnName("id_bank")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.NameBank)
                    .IsRequired()
                    .HasColumnName("name_bank");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("client_pkey");

                entity.ToTable("client");

                entity.Property(e => e.IdClient)
                    .HasColumnName("id_client")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.AddressLive)
                    .IsRequired()
                    .HasColumnName("address_live");

                entity.Property(e => e.ContactFace).HasColumnName("contact_face");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasColumnName("fio");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login");

                entity.Property(e => e.Passport)
                    .IsRequired()
                    .HasColumnName("passport");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.Rekvizits)
                    .IsRequired()
                    .HasColumnName("rekvizits");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => e.IdComment)
                    .HasName("comments_pkey");

                entity.ToTable("comments");

                entity.Property(e => e.IdComment)
                    .HasColumnName("id_comment")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateComment)
                    .HasColumnType("date")
                    .HasColumnName("date_comment");

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdZak).HasColumnName("id_zak");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("comments2_fkey");

                entity.HasOne(d => d.IdZakNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.IdZak)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("comments_fkey");
            });

            modelBuilder.Entity<Dostavka>(entity =>
            {
                entity.HasKey(e => e.IdDost)
                    .HasName("dostavka_pkey");

                entity.ToTable("dostavka");

                entity.Property(e => e.IdDost)
                    .HasColumnName("id_dost")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.AddressDost).HasColumnName("address_dost");

                entity.Property(e => e.DateDost)
                    .HasColumnType("date")
                    .HasColumnName("date_dost");

                entity.Property(e => e.PochtaIndex).HasColumnName("pochta_index");

                entity.Property(e => e.StatusDost).HasColumnName("status_dost");
            });

            modelBuilder.Entity<Izdelie>(entity =>
            {
                entity.HasKey(e => e.IdIzd)
                    .HasName("izdelie_pkey");

                entity.ToTable("izdelie");

                entity.Property(e => e.IdIzd)
                    .HasColumnName("id_izd")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateShtampa)
                    .HasColumnType("date")
                    .HasColumnName("date_shtampa");

                entity.Property(e => e.IdIzdspr).HasColumnName("id_izdspr");

                entity.Property(e => e.IdProb).HasColumnName("id_prob");

                entity.Property(e => e.PriceIzd).HasColumnName("price_izd");

                entity.Property(e => e.Razmer).HasColumnName("razmer");

                entity.HasOne(d => d.IdIzdsprNavigation)
                    .WithMany(p => p.Izdelies)
                    .HasForeignKey(d => d.IdIzdspr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("izdelie_id_izdspr_fkey");
            });

            modelBuilder.Entity<IzdelieSpr>(entity =>
            {
                entity.HasKey(e => e.IdIzdspr)
                    .HasName("izdelie_spr_pkey");

                entity.ToTable("izdelie_spr");

                entity.Property(e => e.IdIzdspr)
                    .HasColumnName("id_izdspr")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.IdMaterial).HasColumnName("id_material");

                entity.Property(e => e.IdOtdelk).HasColumnName("id_otdelk");

                entity.Property(e => e.IdRabota).HasColumnName("id_rabota");

                entity.Property(e => e.IdTipIzd).HasColumnName("id_tip_izd");

                entity.Property(e => e.NameItm).HasColumnName("name_itm");

                entity.Property(e => e.NameIzd).HasColumnName("name_izd");

                entity.Property(e => e.UrlPic).HasColumnName("url_pic");

                entity.HasOne(d => d.IdMaterialNavigation)
                    .WithMany(p => p.IzdelieSprs)
                    .HasForeignKey(d => d.IdMaterial)
                    .HasConstraintName("izdelie_spr_id_material_fkey");

                entity.HasOne(d => d.IdOtdelkNavigation)
                    .WithMany(p => p.IzdelieSprs)
                    .HasForeignKey(d => d.IdOtdelk)
                    .HasConstraintName("izdelie_spr_id_otdelk_fkey");

                entity.HasOne(d => d.IdRabotaNavigation)
                    .WithMany(p => p.IzdelieSprs)
                    .HasForeignKey(d => d.IdRabota)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("izdelie_spr_id_rabota_fkey");

                entity.HasOne(d => d.IdTipIzdNavigation)
                    .WithMany(p => p.IzdelieSprs)
                    .HasForeignKey(d => d.IdTipIzd)
                    .HasConstraintName("izdelie_spr_id_tip_izd_fkey");
            });

            modelBuilder.Entity<Izgotovlenie>(entity =>
            {
                entity.HasKey(e => e.IdIzgot)
                    .HasName("izgotovlenie_pkey");

                entity.ToTable("izgotovlenie");

                entity.Property(e => e.IdIzgot)
                    .HasColumnName("id_izgot")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DataEnd)
                    .HasColumnType("date")
                    .HasColumnName("data_end");

                entity.Property(e => e.DataStart)
                    .HasColumnType("date")
                    .HasColumnName("data_start");

                entity.Property(e => e.IdIzd).HasColumnName("id_izd");

                entity.Property(e => e.IdSotr).HasColumnName("id_sotr");

                entity.Property(e => e.ListDoneJob).HasColumnName("list_done_job");

                entity.Property(e => e.PoluStatus).HasColumnName("polu_status");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.IdIzdNavigation)
                    .WithMany(p => p.Izgotovlenies)
                    .HasForeignKey(d => d.IdIzd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("izgotovlenie_id_izd_fkey");

                entity.HasOne(d => d.IdSotrNavigation)
                    .WithMany(p => p.Izgotovlenies)
                    .HasForeignKey(d => d.IdSotr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("izgotovlenie_id_sotr_fkey");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.IdMater)
                    .HasName("materials_pkey");

                entity.ToTable("materials");

                entity.Property(e => e.IdMater)
                    .HasColumnName("id_mater")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.IdBank).HasColumnName("id_bank");

                entity.Property(e => e.NameMater)
                    .IsRequired()
                    .HasColumnName("name_mater");

                entity.Property(e => e.PriceMater).HasColumnName("price_mater");

                entity.Property(e => e.UrlMater).HasColumnName("url_mater");
            });

            modelBuilder.Entity<Otdelka>(entity =>
            {
                entity.HasKey(e => e.IdOtdelk)
                    .HasName("otdelka_pkey");

                entity.ToTable("otdelka");

                entity.Property(e => e.IdOtdelk)
                    .HasColumnName("id_otdelk")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Koeff).HasColumnName("koeff");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Prize>(entity =>
            {
                entity.HasKey(e => e.IdPriz)
                    .HasName("prizes_pkey");

                entity.ToTable("prizes");

                entity.Property(e => e.IdPriz)
                    .HasColumnName("id_priz")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.IdIzgotMass).HasColumnName("id_izgot_mass");

                entity.Property(e => e.IdSotr).HasColumnName("id_sotr");

                entity.Property(e => e.SummPriz)
                    .HasColumnType("money")
                    .HasColumnName("summ_priz");

                entity.HasOne(d => d.IdSotrNavigation)
                    .WithMany(p => p.Prizes)
                    .HasForeignKey(d => d.IdSotr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prizes_id_sotr_fkey");
            });

            modelBuilder.Entity<Rabotum>(entity =>
            {
                entity.HasKey(e => e.IdRabota)
                    .HasName("rabota_pkey");

                entity.ToTable("rabota");

                entity.Property(e => e.IdRabota)
                    .HasColumnName("id_rabota")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.SpisokRabot).HasColumnName("spisok_rabot");
            });

            modelBuilder.Entity<Sotrudnik>(entity =>
            {
                entity.HasKey(e => e.IdSotr)
                    .HasName("sotrudnik_pkey");

                entity.ToTable("sotrudnik");

                entity.Property(e => e.IdSotr)
                    .HasColumnName("id_sotr")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasColumnName("fio");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login");

                entity.Property(e => e.Passport)
                    .IsRequired()
                    .HasColumnName("passport");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.Stag).HasColumnName("stag");
            });

            modelBuilder.Entity<TipIzd>(entity =>
            {
                entity.HasKey(e => e.IdTipIzd)
                    .HasName("tip_izd_pkey");

                entity.ToTable("tip_izd");

                entity.Property(e => e.IdTipIzd)
                    .HasColumnName("id_tip_izd")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.NameTipIzd)
                    .IsRequired()
                    .HasColumnName("name_tip_izd");

                entity.Property(e => e.PriceTipIzd)
                    .HasColumnType("money")
                    .HasColumnName("price_tip_izd");
            });

            modelBuilder.Entity<Zakaz>(entity =>
            {
                entity.HasKey(e => e.IdZak)
                    .HasName("zakaz_pkey");

                entity.ToTable("zakaz");

                entity.Property(e => e.IdZak)
                    .HasColumnName("id_zak")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateZak)
                    .HasColumnType("date")
                    .HasColumnName("date_zak");

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdDost).HasColumnName("id_dost");

                entity.Property(e => e.IdIzd).HasColumnName("id_izd");

                entity.Property(e => e.StatusZak).HasColumnName("status_zak");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Zakazs)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zakaz_id_client_fkey");

                entity.HasOne(d => d.IdDostNavigation)
                    .WithMany(p => p.Zakazs)
                    .HasForeignKey(d => d.IdDost)
                    .HasConstraintName("zakaz_id_dost_fkey");

                entity.HasOne(d => d.IdIzdNavigation)
                    .WithMany(p => p.Zakazs)
                    .HasForeignKey(d => d.IdIzd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zakaz_id_izd_fkey");
            });

            modelBuilder.Entity<Zakupka>(entity =>
            {
                entity.HasKey(e => e.IdZakup)
                    .HasName("zakupka_pkey");

                entity.ToTable("zakupka");

                entity.Property(e => e.IdZakup)
                    .HasColumnName("id_zakup")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.IdMater).HasColumnName("id_mater");

                entity.HasOne(d => d.IdMaterNavigation)
                    .WithMany(p => p.Zakupkas)
                    .HasForeignKey(d => d.IdMater)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zakupka_id_mater_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
