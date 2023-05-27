using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        private Team team1;
        private Team team2;
        private Referee referee;
        private Referee assistantReferee1;
        private Referee assistantReferee2;
        private List<Goal> goals = new List<Goal>();
        private string result;
        private Team winner;

        public Game(Team team1, Team team2, Referee referee,
            Referee assistantReferee1, Referee assistantReferee2, List<Goal> goals, Team winner)
        {
            result = "Game between Team 1 and Team 2 with winner the team of the Coach with name ";
            this.winner = winner;
            if (this.winner.Equals(team1)) result += team1.Coach.Name;
            else
                result += team2.Coach.Name;
            this.team1 = team1;
            this.team2 = team2;
            this.referee = referee;
            this.assistantReferee1 = assistantReferee1;
            this.assistantReferee2 = assistantReferee2;
            this.goals = goals;
        }

        public Team Team1 {
            get { return team1; }
            set { team1 = value; }
        }
        public Team Team2 {
            get { return team2; }
            set { team2 = value; }
        }
        public Referee Referee {
            get { return referee; }
            set { referee = value; }
        }
        public Referee AssistantReferee1 {
            get { return assistantReferee1; }
            set { assistantReferee1 = value; }
        }
        public Referee AssistantReferee2
        {
            get { return assistantReferee2; }
            set { assistantReferee2 = value; }
        }
        public List<Goal> Goals {
            get { return goals; }
            set { goals = value; }
        }
        public string Result {
            get { return result; }
            set { result = value; }
        }
        public Team Winner {
            get { return winner; }
            set {
                winner = value;
                result = "Game between Team 1 and Team 2 with winner the team of the Coach with name ";
                if (winner.Equals(team1)) result += team1.Coach.Name;
                else
                    result += team2.Coach.Name;
            }
        }

        public void ScoreGoal(Goal goal) { 
        goals.Add(goal);
        }

        public void PrintResult() {
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine("Team1:");
            for (int i = 0; i < team1.Players.Length; i++)
            {
                Console.WriteLine("Player with number " + team1.Players[i].Number.ToString()
                    + " and name " + team1.Players[i].Name + " aged "
                    + team1.Players[i].Age.ToString() + " with height" + team1.Players[i].Height.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Team2:");
            for (int i = 0; i < team2.Players.Length; i++)
            {
                Console.WriteLine("Player with number " + team2.Players[i].Number.ToString()
                   + " and name " + team2.Players[i].Name + " aged "
                   + team2.Players[i].Age.ToString() + " with height" + team2.Players[i].Height.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Goals this game:");
            foreach (Goal goal in goals)
            {
                Console.WriteLine("Scored by " + goal.Player.Name
                    + " with number " + goal.Player.Number.ToString()
                    +" in minute " + goal.Minute.ToString());
            }
        }
    }
}
