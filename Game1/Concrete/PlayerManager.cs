using Game1.Abstract;
using Game1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
  
                   
        public void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                Console.WriteLine(player.UserName + " " + "kullanıcı adlı oyuncu kaydı tamamlandı.");
            }
            else
            {
                throw new Exception("Not a real person");
            }
        }
        public void Delete(Player player)
        {
            Console.WriteLine(player.UserName + " " + "kullanıcı adlı oyuncu silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.UserName + " " + "kullanıcı adlı oyuncu güncellendi");
        }
    }
}
