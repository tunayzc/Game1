// See https://aka.ms/new-console-template for more information
using Game1.Abstract;
using Game1.Adapters;
using Game1.Concrete;
using Game1.Entity;

namespace Game1
{
    class program
    {
        static void Main(string[] args)
        {
            Player player1= new Player ();
            player1.Id = 1;
            player1.FirstName = "Ahmet Tunahan";
            player1.LastName = "Yazıcı";
            player1.UserName = "Asmodeus";
            player1.CreditCard = "53454343553";
            player1.YearOfBirth = 1999;
            player1.NationalityId = "28082377872";      
            PlayerManager playerManager= new PlayerManager(new MernisServiceAdapter());
            playerManager.Add(player1);

            GameManager gameManager1 = new GameManager();
            Game game1= new Game ();
            game1.Id = 1;
            game1.Name = "Call of Duty";
            game1.Price = 1100;
            game1.Type = "FPS";
            gameManager1.Add(game1);

            Game game2 = new Game();
            game2.Id = 2;
            game2.Name = "CYBERPUNK 2077";
            game2.Price = 500;
            game2.Type = "RPG";
            gameManager1.Add(game2);

            Game game3 = new Game();
            game3.Id = 2;
            game3.Name = "NBA 2K23";
            game3.Price = 800;
            game3.Type = "SPORT";
            gameManager1.Add(game3);

            CampaingManager campaingManager1 = new CampaingManager();
            Campaign campaign1 = new Campaign ();
            campaign1.CampaignName = "Winter Sale";
            campaign1.Discount = 30;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignName = "Winter Sale";
            campaign2.Discount = 20;
     
            campaingManager1.Add(campaign1);
            campaingManager1.Add(campaign2);

            SalesManager salesManager = new SalesManager ();
            salesManager.Add(player1, game1, campaign1);
            salesManager.Add(player1 ,game2, campaign1);
            salesManager.Add(player1, game3, campaign2);







        }

    }

}
