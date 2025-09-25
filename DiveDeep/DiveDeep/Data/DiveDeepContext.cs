using Microsoft.EntityFrameworkCore;
using DiveDeep.Models;

namespace DiveDeep.Data
{
    public class DiveDeepContext : DbContext
    {
        public DiveDeepContext (DbContextOptions<DiveDeepContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().OwnsOne(p => p.BCD);
            modelBuilder.Entity<Product>().OwnsOne(p => p.DivingSuit);
            modelBuilder.Entity<Product>().OwnsOne(p => p.Fins);
            modelBuilder.Entity<Product>().OwnsOne(p => p.OxygenTank);
            modelBuilder.Entity<Product>().OwnsOne(p => p.Regulator);
            modelBuilder.Entity<Product>().OwnsOne(p => p.MaskSnorkel);
        }

    }
    public static class DbInitializer
    {
        public static void Seed(DiveDeepContext context)
        {
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }

            var products = new List<Product>
            {
                            new Product {ProductType = ProductType.BCD, Brand = "Scubapro", DailyPrice = 125, BCD = new BCDSpecs { Model = "Navigator Lite BCD" },
                     FilePath="https://scubadirect.dk/cdn/shop/files/SP_21770X00_Navigator_Lite_BLK_Left34-View.webp?v=1747051445"},

            new Product {ProductType = ProductType.BCD, Brand = "Scubapro", DailyPrice = 140, BCD = new BCDSpecs { Model = "BCD Glide" },
                     FilePath="https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/scubapro-bcd-glide-1.w1200.jpg"},

            new Product {ProductType = ProductType.BCD, Brand = "Scubapro", DailyPrice = 200, BCD = new BCDSpecs { Model = "BCD Hydros Pro" },
                     FilePath="https://dykker-butikken.dk/cdn/shop/files/scubapro-hydros-pro-m_nd-3.jpg?v=1730217105"},

            new Product {ProductType = ProductType.BCD, Brand = "Seac", DailyPrice = 145, BCD = new BCDSpecs { Model = "BCD Modular" },
                     FilePath="https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/seac-bcd-modular-one-size-1.w610.h610.fill.jpg"},

            new Product {ProductType = ProductType.DivingSuit, Brand = "Scubapro", DailyPrice = 100, DivingSuit = new DivingSuitSpecs { Model = "Definition", SuitType = SuitType.Våddragt, ThicknessInMm = 3 },
                            FilePath="https://scubadirect.dk/cdn/shop/products/DEFINITION-STMR-3MM-B-ZIP-MAN-63.930.X.jpg?v=1656951438"},

            new Product {ProductType = ProductType.DivingSuit, Brand = "Scubapro", DailyPrice = 100, DivingSuit = new DivingSuitSpecs { Model = "Definition", SuitType = SuitType.Våddragt, ThicknessInMm = 5 },
                            FilePath="https://shop11921.sfstatic.io/upload_dir/shop/definition-stmr-5mm-b-zip-man-63.932.x.png"},

            new Product {ProductType = ProductType.DivingSuit, Brand = "Scubapro", DailyPrice = 100, DivingSuit = new DivingSuitSpecs { Model = "Definition", SuitType = SuitType.Våddragt, ThicknessInMm = 7 },
                            FilePath = "https://aquaholics.co.uk/cdn/shop/products/scubapro-definition-7mm-woman.jpg?v=1541519476"},

            new Product {ProductType = ProductType.DivingSuit, Brand = "Waterproof", DailyPrice = 100, DivingSuit = new DivingSuitSpecs { Model = "W5", SuitType = SuitType.Våddragt, ThicknessInMm = 3.5 },
                            FilePath="https://www.mikesdivestore.com/cdn/shop/products/W7_male_new_9cbb2496-b304-4daa-ad92-fc0dc822eb51.jpg?v=1672042321&width=1214"},

            new Product {ProductType = ProductType.DivingSuit, Brand = "Fourth Element", DailyPrice = 120, DivingSuit = new DivingSuitSpecs { Model = "Proteus", SuitType = SuitType.Våddragt, ThicknessInMm = 5 },
                            FilePath="https://jettydive.com.au/wp-content/uploads/2022/02/PROTEUS-II-e1492122864772.jpg"},

            new Product {ProductType = ProductType.DivingSuit, Brand = "Scubapro", DailyPrice = 300, DivingSuit = new DivingSuitSpecs { Model = "Exodry 4.0", SuitType = SuitType.Tørdragt },
                            FilePath="https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/EXODRY_4_MN_60.853.000.w1200.jpg"},

            new Product {ProductType = ProductType.DivingSuit, Brand = "Waterproof", DailyPrice = 320, DivingSuit = new DivingSuitSpecs { Model = "D7 Evo", SuitType = SuitType.Tørdragt },
                            FilePath="https://www.sublub.nl/resize/waterproofd7-evo_10013765071715.png/0/1100/True/waterproof-d7-evo-drysuit-men-size-l-plus.png"},

            new Product {ProductType = ProductType.DivingSuit, Brand = "Santi", DailyPrice = 350, DivingSuit = new DivingSuitSpecs { Model = "E.Lite Plus", SuitType = SuitType.Tørdragt },
                            FilePath="https://shop11921.sfstatic.io/upload_dir/shop/elite-plus_01-kolor.jpg"},

            new Product {ProductType = ProductType.Regulator, Brand = "Scubapro", DailyPrice = 125, Regulator = new RegulatorSpecs { StageOne = "MK25EVO", StageTwo = "S600", Octopus = "R105" },
                           FilePath="https://johnsonoutdoors.widen.net/content/rpvygpvdbi/jpeg/SP_12971965_MKEVODIN_S600_R105.jpg"},

            new Product {ProductType = ProductType.Regulator, Brand = "Scubapro", DailyPrice = 100, Regulator = new RegulatorSpecs { StageOne = "MK17EVO", StageTwo = "C370", Octopus = "R095" },
                           FilePath="https://shop11921.sfstatic.io/upload_dir/shop/MK17Evo_C370_R095_DIN.webp"},

            new Product {ProductType = ProductType.Regulator, Brand = "Scubapro", DailyPrice = 150,  Regulator = new RegulatorSpecs { StageOne = "MK25EVO BT", StageTwo = "A700 Carbon BT", Octopus = "S270" } ,
                           FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/mk25-bt-a700carbon-s270.w1200.jpg"},

            new Product {ProductType = ProductType.OxygenTank, DailyPrice = 150, Brand = "Scubapro", OxygenTank = new OxygenTankSpecs { VolumeInL = 5 },
                            FilePath="https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/n_p1eee6v6q25m2120k16duojq6774-2.w1200.jpg"},

            new Product {ProductType = ProductType.OxygenTank, DailyPrice = 160, Brand = "Scubapro", OxygenTank = new OxygenTankSpecs { VolumeInL = 10 },
                            FilePath = "https://scubadirect.dk/cdn/shop/products/Flaske1udtag-p.jpg?v=1617200377"},

            new Product {ProductType = ProductType.OxygenTank, DailyPrice = 170, Brand = "Scubapro", OxygenTank = new OxygenTankSpecs { VolumeInL = 12 },
                            FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/18-012-121.w1200.jpg"},

            new Product {ProductType = ProductType.OxygenTank, DailyPrice = 180, Brand = "Scubapro", OxygenTank = new OxygenTankSpecs { VolumeInL = 15 },
                            FilePath = "https://www.edyk.dk/cdn/shop/products/Dykkerflaske15Liter.jpg?v=1666609081"},

            new Product {ProductType = ProductType.Fins, DailyPrice = 50, Brand = "Scubapro", Fins = new FinsSpecs { Model = "Jet Fin" },
                     FilePath = "https://aquashoppen.dk/files/products/S-25365400.jpg"},

            new Product {ProductType = ProductType.Fins, DailyPrice = 50, Brand = "Scubapro", Fins = new FinsSpecs { Model = "GO Travel" },
                     FilePath = "https://www.kingfish.dk/media/catalog/product/cache/c1c0e1fb1ecf4dd56138fa5b5577c9ad/s/c/scubapro-go-travel-finner-dykning-2-2.jpg"},

            new Product {ProductType = ProductType.Fins, DailyPrice = 60, Brand = "Scubapro", Fins = new FinsSpecs { Model = "Seawing Supernova" },
                     FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/SP_25505X00_Seawing_Supernova_2.jpg"},

            new Product {ProductType = ProductType.Fins, DailyPrice = 50, Brand = "Seac", Fins = new FinsSpecs { Model = "Propulsion" },
                     FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/seac-finne-propulsion-s-hvid-1.jpg"},

            new Product {ProductType = ProductType.Fins, DailyPrice = 50, Brand = "Seac", Fins = new FinsSpecs { Model = "ALA" },
                     FilePath = "https://www.kids-world.dk/images/YP436.jpg"},

            new Product {ProductType = ProductType.Fins, DailyPrice = 75, Brand = "Fourth Element", Fins = new FinsSpecs { Model = "Tech" },
                     FilePath = "https://www.onlinedivegear.com.au/cdn/shop/products/Fourth-Element-Tech-Fins-Grey_500x.jpg?v=1655305970"},

            new Product {ProductType = ProductType.Fins, DailyPrice = 80, Brand = "Fourth Element", Fins = new FinsSpecs { Model = "Rec Fin" },
                     FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/fnrec02.jpg"},

            new Product {ProductType = ProductType.Snorkel, DailyPrice = 50, Brand = "Scubapro", MaskSnorkel = new MaskSnorkelSpecs { Model = "Ghost" },
                         FilePath = "https://m.media-amazon.com/images/I/519C84G2uYL._UF1000,1000_QL80_.jpg"},

            new Product {ProductType = ProductType.Snorkel, DailyPrice = 60, Brand = "Scubapro", MaskSnorkel = new MaskSnorkelSpecs { Model = "D-Mask" },
                         FilePath = "https://scubadirect.dk/cdn/shop/products/24.250.200-p.jpg?v=1616663057&width=360"},

            new Product {ProductType = ProductType.Snorkel, DailyPrice = 50, Brand = "Scubapro", MaskSnorkel = new MaskSnorkelSpecs { Model = "Spectra Mini" },
                         FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/scubapro-spectra-mini-sort-soelv.jpg"},

            new Product {ProductType = ProductType.Snorkel, DailyPrice = 75, Brand = "Scubapro", MaskSnorkel = new MaskSnorkelSpecs { Model = "Crystal VU" },
                         FilePath = "https://www.edyk.dk/cdn/shop/products/Scubapro-Crystal-VU-dykkermaske-sort-s_C3_B8lv-p.jpg?v=1684326130&width=1080"},

            new Product {ProductType = ProductType.Snorkel, DailyPrice = 75, Brand = "Scubapro", MaskSnorkel = new MaskSnorkelSpecs { Model = "Scout Kontrast" },
                         FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/dykkermaske-fourth-element-scout-sort-enhance-1-1.w1200.jpg"},

            new Product {ProductType = ProductType.Snorkel, DailyPrice = 75, Brand = "Scubapro", MaskSnorkel = new MaskSnorkelSpecs { Model = "Scout Enhance" },
                         FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/dykkermaske-fourth-element-scout-sort-kontrast-1-1.w610.h610.fill.jpg"},

            new Product {ProductType = ProductType.Snorkel, DailyPrice = 75, Brand = "Scubapro", MaskSnorkel = new MaskSnorkelSpecs { Model = "Element" },
                         FilePath = "https://scubaevolution.co.za/cdn/shop/files/SP_24108100_Steel_Comp_Mask_1.webp?v=1747029931"}
            };     
            context.Product.AddRange(products);
            context.SaveChanges();
        }
    }
}

