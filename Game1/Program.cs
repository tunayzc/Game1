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

            Game game1= new Game ();
            game1.Id = 1;
            game1.Name = "Call of Duty";
            game1.Price = 1100;
            game1.Type = "FPS";
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Campaign campaign1 = new Campaign ();
            campaign1.CampaignName = "Winter Sale";
            campaign1.Discount = 30;
            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(campaign1);

            SalesManager salesManager1 = new SalesManager ();
            salesManager1.Add(player1, game1, campaign1);
            
            

            
            


        }

    }

}
