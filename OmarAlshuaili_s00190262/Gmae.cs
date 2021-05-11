using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmarAlshuaili_s00190262
{
    public class Game
    {
        public string Name { get; set; }
        public int MetacriticScore { get; set; }
        public string Game_Image { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }

      

        public Game(string Name,string Platform, int CriticScore, decimal Price ,string Description, string GameImage = "")
        {
            Name = this.Name;
            Description = this.Description;
            CriticScore = this.MetacriticScore;
            Platform = this.Platform;
            Price = this.Price;
            GameImage = this.Game_Image;





        }



    }
}
