using Game1.Abstract;
using Game1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " " + "başaryıla eklendi");
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.Name + " " + "kaldırıldı");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " " + "adlı oyunun fiyatı güncellendi");
        }
    }
}
