using Football.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Goal
    {

        private int minute;
        private FootballPlayer player;

        public Goal(int minute, FootballPlayer player)
        {
            this.minute = minute;
            this.player = player;
        }

        public int Minute { get { return minute; } set { minute = value; } }
        public FootballPlayer Player { get { return player; } set { player = value; } } 
    }
}
