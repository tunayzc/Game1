using Game1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Remove(Game game);
        void Update(Game game); 

    }
}
