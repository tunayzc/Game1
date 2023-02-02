using Game1.Abstract;
using Game1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Add(Player player, Game game, Campaign campaign)
        {
            double bill = (game.Price * campaign.Discount) / 100;
            bill = game.Price - bill;
            Console.WriteLine("---İndirim uygulandı---");
            Console.WriteLine("Kullanıcı Adı:" + " " + player.UserName);
            Console.WriteLine("İsim-Soyisim:" + " " + player.FirstName + " " + player.LastName);
            Console.WriteLine("Toplam Ödeme:" + " " + bill);
        }
    }
}
