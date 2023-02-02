using Game1.Abstract;
using Game1.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient((KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12));
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.YearOfBirth);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
