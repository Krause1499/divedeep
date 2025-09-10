using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public static class ProductRepository
    {
        public static List<Category> Products = new List<Category>
        {
            new BCD {Id = 1, ProductType = ProductType.BCD, Brand = "Scubapro", Model = "Navigator Lite BCD", Price = 125,
                     FilePath="https://scubadirect.dk/cdn/shop/files/SP_21770X00_Navigator_Lite_BLK_Left34-View.webp?v=1747051445"},
            new BCD {Id = 2, ProductType = ProductType.BCD, Brand = "Scubapro", Model = "BCD Glide", Price = 140,
                     FilePath="https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/scubapro-bcd-glide-1.w1200.jpg"},
            new BCD {Id = 3, ProductType = ProductType.BCD, Brand = "Scubapro", Model = "BCD Hydros Pro", Price = 200,
                     FilePath="https://dykker-butikken.dk/cdn/shop/files/scubapro-hydros-pro-m_nd-3.jpg?v=1730217105"},
            new BCD {Id = 4, ProductType = ProductType.BCD, Brand = "Seac", Model = "BCD Modular", Size = Size.M, Price = 145,
                     FilePath="https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/seac-bcd-modular-one-size-1.w610.h610.fill.jpg"},
            new DivingSuit {Id = 30, ProductType = ProductType.DivingSuit, Brand = "Scubapro", Model = "Definition", Type = SuitType.Våddragt, Thickness = 3, Price = 100,
                            FilePath="https://scubadirect.dk/cdn/shop/products/DEFINITION-STMR-3MM-B-ZIP-MAN-63.930.X.jpg?v=1656951438"},
            new DivingSuit {Id = 31, ProductType = ProductType.DivingSuit, Brand = "Scubapro", Model = "Definition", Type = SuitType.Våddragt, Thickness = 5, Price = 100,
                            FilePath="https://shop11921.sfstatic.io/upload_dir/shop/definition-stmr-5mm-b-zip-man-63.932.x.png"},
            new DivingSuit {Id = 32, ProductType = ProductType.DivingSuit, Brand = "Scubapro", Model = "Definition", Type = SuitType.Våddragt, Thickness = 7, Price = 100,
                            FilePath = "https://aquaholics.co.uk/cdn/shop/products/scubapro-definition-7mm-woman.jpg?v=1541519476"},
            new DivingSuit {Id = 33, ProductType = ProductType.DivingSuit, Brand = "Waterproof", Model = "W5", Type = SuitType.Våddragt, Thickness = 3.5, Price = 100,
                            FilePath="https://www.mikesdivestore.com/cdn/shop/products/W7_male_new_9cbb2496-b304-4daa-ad92-fc0dc822eb51.jpg?v=1672042321&width=1214"},
            new DivingSuit {Id = 5, ProductType = ProductType.DivingSuit, Brand = "Fourth Element", Model = "Proteus", Type = SuitType.Våddragt, Thickness = 5, Price = 120,
                            FilePath="https://jettydive.com.au/wp-content/uploads/2022/02/PROTEUS-II-e1492122864772.jpg"},
            new DivingSuit {Id = 6, ProductType = ProductType.DivingSuit, Brand = "Scubapro", Model = "Exodry 4.0", Type = SuitType.Tørdragt, Price = 300,
                            FilePath="https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/EXODRY_4_MN_60.853.000.w1200.jpg"},
            new DivingSuit {Id = 7, ProductType = ProductType.DivingSuit, Brand = "Waterproof", Model = "D7 Evo", Type = SuitType.Tørdragt, Price = 320,
                            FilePath="https://www.sublub.nl/resize/waterproofd7-evo_10013765071715.png/0/1100/True/waterproof-d7-evo-drysuit-men-size-l-plus.png"},
            new DivingSuit {Id = 8, ProductType = ProductType.DivingSuit, Brand = "Santi", Model = "E.Lite Plus", Type = SuitType.Tørdragt, Price = 350,
                            FilePath="https://shop11921.sfstatic.io/upload_dir/shop/elite-plus_01-kolor.jpg"},
            new Regulator {Id = 9, ProductType = ProductType.Regulator, Brand = "Scubapro", StageOne = "MK25EVO", StageTwo = "S600", Octopus = "R105" , Price = 125,
                           FilePath="https://johnsonoutdoors.widen.net/content/rpvygpvdbi/jpeg/SP_12971965_MKEVODIN_S600_R105.jpg"},
            new Regulator {Id = 10, ProductType = ProductType.Regulator, Brand = "Scubapro", StageOne = "MK17EVO", StageTwo = "C370", Octopus = "R095" , Price = 100,
                           FilePath="https://shop11921.sfstatic.io/upload_dir/shop/MK17Evo_C370_R095_DIN.webp"},
            new Regulator {Id = 11, ProductType = ProductType.Regulator, Brand = "Scubapro", StageOne = "MK25EVO BT", StageTwo = "A700 Carbon BT", Octopus = "S270" , Price = 150,
                           FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/mk25-bt-a700carbon-s270.w1200.jpg"},
            new OxygenTank {Id = 12, ProductType = ProductType.OxygenTank, Brand = "Scubapro", Volume = 5, Price = 150,
                            FilePath="https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/n_p1eee6v6q25m2120k16duojq6774-2.w1200.jpg"},
            new OxygenTank {Id = 13, ProductType = ProductType.OxygenTank, Brand = "Scubapro", Volume = 10, Price = 160,
                            FilePath = "https://scubadirect.dk/cdn/shop/products/Flaske1udtag-p.jpg?v=1617200377"},
            new OxygenTank {Id = 14, ProductType = ProductType.OxygenTank, Brand = "Scubapro", Volume = 12, Price = 170,
                            FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/18-012-121.w1200.jpg"},
            new OxygenTank {Id = 15, ProductType = ProductType.OxygenTank, Brand = "Scubapro", Volume = 15, Price = 180,
                            FilePath = "https://www.edyk.dk/cdn/shop/products/Dykkerflaske15Liter.jpg?v=1666609081"},
            new Fin {Id = 16, ProductType = ProductType.Fin, Brand = "Scubapro", Model = "Jet Fin", Size = Size.M, Price = 50,
                     FilePath = "https://aquashoppen.dk/files/products/S-25365400.jpg"},
            new Fin {Id = 17, ProductType = ProductType.Fin, Brand = "Scubapro", Model = "GO Travel", Size = Size.M, Price = 50,
                     FilePath = "https://www.kingfish.dk/media/catalog/product/cache/c1c0e1fb1ecf4dd56138fa5b5577c9ad/s/c/scubapro-go-travel-finner-dykning-2-2.jpg"},
            new Fin {Id = 18, ProductType = ProductType.Fin, Brand = "Scubapro", Model = "Seawing Supernova", Size = Size.M, Price = 60,
                     FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/SP_25505X00_Seawing_Supernova_2.jpg"},
            new Fin {Id = 19, ProductType = ProductType.Fin, Brand = "Seac", Model = "Propulsion", Size = Size.M, Price = 50,
                     FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/seac-finne-propulsion-s-hvid-1.jpg"},
            new Fin {Id = 20, ProductType = ProductType.Fin, Brand = "Seac", Model = "ALA", Size = Size.M, Price = 50,
                     FilePath = "https://www.kids-world.dk/images/YP436.jpg"},
            new Fin {Id = 21, ProductType = ProductType.Fin, Brand = "Fourth Element", Model = "Tech", Size = Size.M, Price = 75,
                     FilePath = "https://www.onlinedivegear.com.au/cdn/shop/products/Fourth-Element-Tech-Fins-Grey_500x.jpg?v=1655305970"},
            new Fin {Id = 22, ProductType = ProductType.Fin, Brand = "Fourth Element", Model = "Rec Fin", Size = Size.M, Price = 80,
                     FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/fnrec02.jpg"},
            new Snorkel {Id = 23, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "Ghost", Price = 50,
                         FilePath = "https://m.media-amazon.com/images/I/519C84G2uYL._UF1000,1000_QL80_.jpg"},
            new Snorkel {Id = 24, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "D-Mask", Price = 60,
                         FilePath = "https://scubadirect.dk/cdn/shop/products/24.250.200-p.jpg?v=1616663057&width=360"},
            new Snorkel {Id = 25, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "Spectra Mini", Price = 50,
                         FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/scubapro-spectra-mini-sort-soelv.jpg"},
            new Snorkel {Id = 26, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "Crystal VU", Price = 75,
                         FilePath = "https://www.edyk.dk/cdn/shop/products/Scubapro-Crystal-VU-dykkermaske-sort-s_C3_B8lv-p.jpg?v=1684326130&width=1080"},
            new Snorkel {Id = 27, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "Scout Kontrast", Price = 75,
                         FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/dykkermaske-fourth-element-scout-sort-enhance-1-1.w1200.jpg"},
            new Snorkel {Id = 28, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "Scout Enhance", Price = 75,
                         FilePath = "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/dykkermaske-fourth-element-scout-sort-kontrast-1-1.w610.h610.fill.jpg"},
            new Snorkel {Id = 29, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "Element", Price = 75,
                         FilePath = "https://scubaevolution.co.za/cdn/shop/files/SP_24108100_Steel_Comp_Mask_1.webp?v=1747029931"}
        };

        public static List<object> GetAllProductsByType(ProductType product)
        {
            List<object> products = Products
                .Where(p => p.ProductType == product)
                .OrderBy(p => p.Brand) // eller hvad du vil sortere på
                .Cast<object>()
                .ToList();

            return products;
        }

        public static object? GetByID(int id)
        {
            return Products.FirstOrDefault(x => x.Id == id);
        }
    }
}