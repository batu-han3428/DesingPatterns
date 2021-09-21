using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPattern
{
    public class Cs1_5
    {
        public int _playerId { get; set; }
        public string _GameName { get; set; }
        public string _GameType { get; set; }
        public bool _isActive { get; set; }

        public Cs1_5(int playerId, string GameName, string GameType, bool isActive)
        {
            _playerId = playerId;
            _GameName = GameName;
            _GameType = GameType;
            _isActive = isActive;
        }

    }
}
