using Football.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Football 
{
    public class Team
    {
        private Coach coach;
        private FootballPlayer[] players;
        private int averageAge;

        public Team(Coach coach, FootballPlayer[] players) {
            if (players.Length < 11 || players.Length > 22)
                throw new ArgumentOutOfRangeException("The team must have minimal 11 players up to 22");
                this.coach = coach;
                this.players = players;
                CalculateAverageAge();
        }

        private void CalculateAverageAge()
        {
            averageAge = 0;
            for (int i = 0; i < players.Length; i++)
            {
                averageAge += players[i].Age;
            }
            averageAge = averageAge / players.Length;
        }

        public Coach Coach {
            get { return coach; }
            set { coach = value; }
        }

        public FootballPlayer[] Players {
            get { return players; }
            set {
                if (value.Length < 11 || value.Length > 22) throw new ArgumentOutOfRangeException();
                else
                {
                    players = value;
                    CalculateAverageAge();
                }
            }
        }

        public int AverageAge { get { return this.averageAge; } }

    }
}
