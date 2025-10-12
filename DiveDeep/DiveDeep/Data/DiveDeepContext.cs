using DiveDeep.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DiveDeep.Data
{
    public class DiveDeepContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<InventoryUnit> InventoryUnits { get; set; }

        public DiveDeepContext(DbContextOptions<DiveDeepContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var m = modelBuilder.Entity<Product>();

            modelBuilder.Entity<Order>()
                .HasMany(o => o.Items)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);

            m.Property(p => p.ProductType).HasConversion<string>();

            m.OwnsOne(p => p.DivingSuit, o =>
            {
                o.ToTable("DivingSuitSpecs");
                o.WithOwner().HasForeignKey("ProductId");
                o.HasKey("ProductId");
                o.Property(x => x.SuitType).HasConversion<string>();
                o.Property(x => x.Sizes)
                    .HasConversion(
                        v => string.Join(',', v),
                        v => (IReadOnlyList<Size>)v
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => Enum.Parse<Size>(s))
                        .ToArray()
                    );
                o.Property(x => x.Genders)
                    .HasConversion(
                        v => string.Join(',', v),
                        v => (IReadOnlyList<Gender>)v
                            .Split(',', StringSplitOptions.RemoveEmptyEntries)
                            .Select(s => Enum.Parse<Gender>(s))
                            .ToArray()
    );
            });

            m.OwnsOne(p => p.BCD, o =>
            {
                o.ToTable("BCDSpecs");
                o.WithOwner().HasForeignKey("ProductId");
                o.HasKey("ProductId");
                o.Property(x => x.Sizes)
                    .HasConversion(
                        v => string.Join(',', v),
                        v => (IReadOnlyList<Size>)v
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => Enum.Parse<Size>(s))
                        .ToArray()
                    );
            });

            m.OwnsOne(p => p.Fins, o =>
            {
                o.ToTable("FinsSpecs");
                o.WithOwner().HasForeignKey("ProductId");
                o.HasKey("ProductId");
                o.Property(x => x.Sizes)
                    .HasConversion(
                        v => string.Join(',', v),
                        v => (IReadOnlyList<Size>)v
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => Enum.Parse<Size>(s))
                        .ToArray()
                    );
            });

            m.OwnsOne(p => p.OxygenTank, o =>
            {
                o.ToTable("OxygenTankSpecs");
                o.WithOwner().HasForeignKey("ProductId");
                o.HasKey("ProductId");
            });

            m.OwnsOne(p => p.Regulator, o =>
            {
                o.ToTable("RegulatorSpecs");
                o.WithOwner().HasForeignKey("ProductId");
                o.HasKey("ProductId");
            });

            m.OwnsOne(p => p.MaskSnorkel, o =>
            {
                o.ToTable("MaskSnorkelSpecs");
                o.WithOwner().HasForeignKey("ProductId");
                o.HasKey("ProductId");
            });

            modelBuilder.Entity<Product>().HasData(
                new { Id = 1, ProductType = ProductType.BCD, Brand = "Scubapro", DailyPrice = 125, FilePath = "https://scubadirect.dk/cdn/shop/files/SP_21770X00_Navigator_Lite_BLK_Left34-View.webp?v=1747051445" },
                new { Id = 2, ProductType = ProductType.BCD, Brand = "Scubapro", DailyPrice = 140, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/scubapro-bcd-glide-1.w1200.jpg" },
                new { Id = 3, ProductType = ProductType.BCD, Brand = "Scubapro", DailyPrice = 200, FilePath = "https://dykker-butikken.dk/cdn/shop/files/scubapro-hydros-pro-m_nd-3.jpg?v=1730217105" },
                new { Id = 4, ProductType = ProductType.BCD, Brand = "Seac", DailyPrice = 145, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/seac-bcd-modular-one-size-1.w610.h610.fill.jpg" },

                new { Id = 30, ProductType = ProductType.DivingSuit, Brand = "Scubapro", DailyPrice = 100, FilePath = "https://scubadirect.dk/cdn/shop/products/DEFINITION-STMR-3MM-B-ZIP-MAN-63.930.X.jpg?v=1656951438" },
                new { Id = 31, ProductType = ProductType.DivingSuit, Brand = "Scubapro", DailyPrice = 100, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/definition-stmr-5mm-b-zip-man-63.932.x.png" },
                new { Id = 32, ProductType = ProductType.DivingSuit, Brand = "Scubapro", DailyPrice = 100, FilePath = "https://aquaholics.co.uk/cdn/shop/products/scubapro-definition-7mm-woman.jpg?v=1541519476" },
                new { Id = 33, ProductType = ProductType.DivingSuit, Brand = "Waterproof", DailyPrice = 100, FilePath = "https://www.mikesdivestore.com/cdn/shop/products/W7_male_new_9cbb2496-b304-4daa-ad92-fc0dc822eb51.jpg?v=1672042321&width=1214" },
                new { Id = 5, ProductType = ProductType.DivingSuit, Brand = "Fourth Element", DailyPrice = 120, FilePath = "https://jettydive.com.au/wp-content/uploads/2022/02/PROTEUS-II-e1492122864772.jpg" },
                new { Id = 6, ProductType = ProductType.DivingSuit, Brand = "Scubapro", DailyPrice = 300, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/EXODRY_4_MN_60.853.000.w1200.jpg" },
                new { Id = 7, ProductType = ProductType.DivingSuit, Brand = "Waterproof", DailyPrice = 320, FilePath = "https://www.sublub.nl/resize/waterproofd7-evo_10013765071715.png/0/1100/True/waterproof-d7-evo-drysuit-men-size-l-plus.png" },
                new { Id = 8, ProductType = ProductType.DivingSuit, Brand = "Santi", DailyPrice = 350, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/elite-plus_01-kolor.jpg" },

                new { Id = 9, ProductType = ProductType.Regulator, Brand = "Scubapro", DailyPrice = 125, FilePath = "https://johnsonoutdoors.widen.net/content/rpvygpvdbi/jpeg/SP_12971965_MKEVODIN_S600_R105.jpg" },
                new { Id = 10, ProductType = ProductType.Regulator, Brand = "Scubapro", DailyPrice = 100, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/MK17Evo_C370_R095_DIN.webp" },
                new { Id = 11, ProductType = ProductType.Regulator, Brand = "Scubapro", DailyPrice = 150, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/mk25-bt-a700carbon-s270.w1200.jpg" },

                new { Id = 12, ProductType = ProductType.OxygenTank, Brand = "Scubapro", DailyPrice = 150, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/n_p1eee6v6q25m2120k16duojq6774-2.w1200.jpg" },
                new { Id = 13, ProductType = ProductType.OxygenTank, Brand = "Scubapro", DailyPrice = 160, FilePath = "https://scubadirect.dk/cdn/shop/products/Flaske1udtag-p.jpg?v=1617200377" },
                new { Id = 14, ProductType = ProductType.OxygenTank, Brand = "Scubapro", DailyPrice = 170, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/18-012-121.w1200.jpg" },
                new { Id = 15, ProductType = ProductType.OxygenTank, Brand = "Scubapro", DailyPrice = 180, FilePath = "https://www.edyk.dk/cdn/shop/products/Dykkerflaske15Liter.jpg?v=1666609081" },

                new { Id = 16, ProductType = ProductType.Fins, Brand = "Scubapro", DailyPrice = 50, FilePath = "https://aquashoppen.dk/files/products/S-25365400.jpg" },
                new { Id = 17, ProductType = ProductType.Fins, Brand = "Scubapro", DailyPrice = 50, FilePath = "https://www.kingfish.dk/media/catalog/product/cache/c1c0e1fb1ecf4dd56138fa5b5577c9ad/s/c/scubapro-go-travel-finner-dykning-2-2.jpg" },
                new { Id = 18, ProductType = ProductType.Fins, Brand = "Scubapro", DailyPrice = 60, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/SP_25505X00_Seawing_Supernova_2.jpg" },
                new { Id = 19, ProductType = ProductType.Fins, Brand = "Seac", DailyPrice = 50, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/seac-finne-propulsion-s-hvid-1.jpg" },
                new { Id = 20, ProductType = ProductType.Fins, Brand = "Seac", DailyPrice = 50, FilePath = "https://www.kids-world.dk/images/YP436.jpg" },
                new { Id = 21, ProductType = ProductType.Fins, Brand = "Fourth Element", DailyPrice = 75, FilePath = "https://www.onlinedivegear.com.au/cdn/shop/products/Fourth-Element-Tech-Fins-Grey_500x.jpg?v=1655305970" },
                new { Id = 22, ProductType = ProductType.Fins, Brand = "Fourth Element", DailyPrice = 80, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/fnrec02.jpg" },

                new { Id = 23, ProductType = ProductType.Snorkel, Brand = "Scubapro", DailyPrice = 50, FilePath = "https://m.media-amazon.com/images/I/519C84G2uYL._UF1000,1000_QL80_.jpg" },
                new { Id = 24, ProductType = ProductType.Snorkel, Brand = "Scubapro", DailyPrice = 60, FilePath = "https://scubadirect.dk/cdn/shop/products/24.250.200-p.jpg?v=1616663057&width=360" },
                new { Id = 25, ProductType = ProductType.Snorkel, Brand = "Scubapro", DailyPrice = 50, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/scubapro-spectra-mini-sort-soelv.jpg" },
                new { Id = 26, ProductType = ProductType.Snorkel, Brand = "Scubapro", DailyPrice = 75, FilePath = "https://www.edyk.dk/cdn/shop/products/Scubapro-Crystal-VU-dykkermaske-sort-s_C3_B8lv-p.jpg?v=1684326130&width=1080" },
                new { Id = 27, ProductType = ProductType.Snorkel, Brand = "Scubapro", DailyPrice = 75, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/dykkermaske-fourth-element-scout-sort-enhance-1-1.w1200.jpg" },
                new { Id = 28, ProductType = ProductType.Snorkel, Brand = "Scubapro", DailyPrice = 75, FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/dykkermaske-fourth-element-scout-sort-kontrast-1-1.w610.h610.fill.jpg" },
                new { Id = 29, ProductType = ProductType.Snorkel, Brand = "Scubapro", DailyPrice = 75, FilePath = "https://scubaevolution.co.za/cdn/shop/files/SP_24108100_Steel_Comp_Mask_1.webp?v=1747029931" }
            );

            // === BCDSpecs (owned) ===
            modelBuilder.Entity<Product>().OwnsOne(p => p.BCD).HasData(
                new { ProductId = 1, Model = "Navigator Lite BCD", Sizes = new[] { Size.S, Size.M, Size.L } },
                new { ProductId = 2, Model = "BCD Glide", Sizes = new[] { Size.S, Size.M, Size.L } },
                new { ProductId = 3, Model = "BCD Hydros Pro", Sizes = new[] { Size.S, Size.M, Size.L } },
                new { ProductId = 4, Model = "BCD Modular", Sizes = new[] { Size.S, Size.M, Size.L } }
            );

            // === DivingSuitSpecs (owned) ===
            modelBuilder.Entity<Product>().OwnsOne(p => p.DivingSuit).HasData(
                new { ProductId = 30, Model = "Definition", SuitType = SuitType.Våddragt, ThicknessInMm = 3.0, Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL }, Genders = new[] { Gender.Herre, Gender.Dame } },
                new { ProductId = 31, Model = "Definition", SuitType = SuitType.Våddragt, ThicknessInMm = 5.0, Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL }, Genders = new[] { Gender.Herre, Gender.Dame } },
                new { ProductId = 32, Model = "Definition", SuitType = SuitType.Våddragt, ThicknessInMm = 7.0, Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL }, Genders = new[] { Gender.Herre, Gender.Dame } },
                new { ProductId = 33, Model = "W5", SuitType = SuitType.Våddragt, ThicknessInMm = 3.5, Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL }, Genders = new[] { Gender.Herre, Gender.Dame } },
                new { ProductId = 5, Model = "Proteus", SuitType = SuitType.Våddragt, ThicknessInMm = 5.0, Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL }, Genders = new[] { Gender.Herre, Gender.Dame } },
                new { ProductId = 6, Model = "Exodry 4.0", SuitType = SuitType.Tørdragt, ThicknessInMm = (double?)null, Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL }, Genders = new[] { Gender.Herre, Gender.Dame } },
                new { ProductId = 7, Model = "D7 Evo", SuitType = SuitType.Tørdragt, ThicknessInMm = (double?)null, Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL }, Genders = new[] { Gender.Herre, Gender.Dame } },
                new { ProductId = 8, Model = "E.Lite Plus", SuitType = SuitType.Tørdragt, ThicknessInMm = (double?)null, Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL }, Genders = new[] { Gender.Herre, Gender.Dame } }
            );

            // === RegulatorSpecs (owned) ===
            modelBuilder.Entity<Product>().OwnsOne(p => p.Regulator).HasData(
                new { ProductId = 9, StageOne = "MK25EVO", StageTwo = "S600", Octopus = "R105" },
                new { ProductId = 10, StageOne = "MK17EVO", StageTwo = "C370", Octopus = "R095" },
                new { ProductId = 11, StageOne = "MK25EVO BT", StageTwo = "A700 Carbon BT", Octopus = "S270" }
            );

            // === OxygenTankSpecs (owned) — VolumeInL som heltal/double efter din model ===
            modelBuilder.Entity<Product>().OwnsOne(p => p.OxygenTank).HasData(
                new { ProductId = 12, VolumeInL = 5 },
                new { ProductId = 13, VolumeInL = 10 },
                new { ProductId = 14, VolumeInL = 12 },
                new { ProductId = 15, VolumeInL = 15 }
            );

            // === FinsSpecs (owned) ===
            modelBuilder.Entity<Product>().OwnsOne(p => p.Fins).HasData(
                new { ProductId = 16, Model = "Jet Fin", Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL } },
                new { ProductId = 17, Model = "GO Travel", Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL } },
                new { ProductId = 18, Model = "Seawing Supernova", Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL } },
                new { ProductId = 19, Model = "Propulsion", Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL } },
                new { ProductId = 20, Model = "ALA", Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL } },
                new { ProductId = 21, Model = "Tech", Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL } },
                new { ProductId = 22, Model = "Rec Fin", Sizes = new[] { Size.XS, Size.S, Size.M, Size.L, Size.XL } }
            );

            // === MaskSnorkelSpecs (owned) ===
            modelBuilder.Entity<Product>().OwnsOne(p => p.MaskSnorkel).HasData(
                new { ProductId = 23, Model = "Ghost" },
                new { ProductId = 24, Model = "D-Mask" },
                new { ProductId = 25, Model = "Spectra Mini" },
                new { ProductId = 26, Model = "Crystal VU" },
                new { ProductId = 27, Model = "Scout Kontrast" },
                new { ProductId = 28, Model = "Scout Enhance" },
                new { ProductId = 29, Model = "Element" }
            );

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<InventoryUnit>()
                 .HasIndex(x => new { x.ProductId, x.Size, x.Gender })
                 .IsUnique();

            // DB-defaults (bruges kun hvis kolonnen udelades i INSERT)
            modelBuilder.Entity<InventoryUnit>()
                 .Property(x => x.Size)
                 .HasDefaultValue(Size.NA);

            modelBuilder.Entity<InventoryUnit>()
                 .Property(x => x.Gender)
                 .HasDefaultValue(Gender.NA);
        }
    }
}
