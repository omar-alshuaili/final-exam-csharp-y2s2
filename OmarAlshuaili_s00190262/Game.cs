using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmarAlshuaili_s00190262
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MetacriticScore { get; set; }
        public string Game_Image { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }

        public Game()
        {

        }

        public Game(string name,string platform, int CriticScore, decimal price ,string description, string GameImage)
        {
            Name = name;
            Platform = platform;
            MetacriticScore = CriticScore;
            Price = price;
            Description  = description ;
            Game_Image = GameImage;

        }

        public void DecreasePrice(decimal decreasedPrice)
        {
            Price -= decreasedPrice;
        }



    }

    public class GameData : DbContext
    {
        public GameData() : base("GameData") { }

        public DbSet<Game> games { get; set; }
    }
}
