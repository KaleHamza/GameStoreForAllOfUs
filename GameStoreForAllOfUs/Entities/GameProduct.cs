using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreForAllOfUs.Entities
{
    public class GameProduct:FirstPerson
    { 
        string GameId{ get; set; }
        string GameName { get; set; }
        string GameCost { get; set; }
    }
}
