using WatchApp.Models;

namespace WatchApp.Services
{
    public class ProductService
    {
        public List<Product> GetProducts() => new List<Product>
        {
            new Product{ Id=1, Name="Dress Watch", Description="Women's Quartz Watch for Ladies Female Bling Rhinestone Variety Colors Silicon Jelly Colorful Casual Dress Waterproof Analog lady Wrist Watches", Price=10, ImageUrl="https://m.media-amazon.com/images/I/61I4KLN8S6L._AC_SY695_.jpg"}
            ,new Product{Id=2,Name="Apple Smart Watch", Description="Smart Watches for Women, 1.91\" HD Fitness Tracker Watch with Blood Pressure/Heart Rate Monitor, Bluetooth 5.3 Make Calls Smart Watch for Android/iOS Phones, IP68 Waterproof Fitness Watch for Women", Price=49, ImageUrl="https://m.media-amazon.com/images/I/81v5g3tFvbL._AC_SX679_.jpg"}
            ,new Product{Id=3,Name="AK Watch", Description="AKNIGHT Watches for Men Analog Quartz Mens Watches Chronograph 30M Waterproof Stainless Steel Watch Casual Fashion Designer Dress Wrist Watches Elegant Gift for Men", Price=30, ImageUrl="https://m.media-amazon.com/images/I/711qxrw0hYL._AC_SY675_.jpg"}
            ,new Product{Id=4,Name="Digital watch", Description="Men's Digital Watch, Sports Waterproof Military Watches for Men LED Casual Stopwatch Alarm Tactical Army Watch", Price=15, ImageUrl="https://m.media-amazon.com/images/I/61AepCrYDOL._AC_SY675_.jpg"}
            ,new Product{Id=5,Name="IOWODO watch", Description="Watch for Men Women - 1.85''HD Screen with Make and Answer Calls, with AI Voice Assistant, SpO2/Heart Rate/Sleep Monitor, 100+ Sports Modes, Smartwatch for Android and iOS (2 Straps)", Price=35, ImageUrl="https://m.media-amazon.com/images/I/71oaX1N6STL._AC_SX679_.jpg"}
            ,new Product{Id=6,Name="Tang Buckle", Description="Watches - Remington Watch for Men and Women - Japanese Movements with Date - Retro Watch - Water Resistant Watch - Stainless Steel Case", Price=75, ImageUrl="https://m.media-amazon.com/images/I/61KYtOAP0XL._AC_SY675_.jpg"}
        };
    }
}
