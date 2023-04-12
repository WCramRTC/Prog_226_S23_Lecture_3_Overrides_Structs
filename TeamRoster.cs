using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_226_S23_Lecture_3_Overrides_Structs
{
    internal class TeamRoster
    {
        string _name;
        string _city;
        List<Player> _roster;

        public TeamRoster(string name, string city)
        {
            _name = name;
            _city = city;
            _roster = new List<Player>();
        }

        // To create an index in a class
        // Access Modifier - Return Type - this keyword - brackets [ int i ]
        // get = list[i]
        // set = list[i] = value
        public Player this[int i]
        {
            get => _roster[i];
            set => _roster[i] = value;
        }

        public int Count
        {
            get => _roster.Count;
        }

        // sanFran + london. Add the london players, to sanFrancisco

        // 
        //public static TeamRoster operator +(List<Player> team1, List<Player> team2)
        //{
        //    List<Player> _fullList = new List<Player>();

        //    foreach (Player player in team1)
        //    {
        //        _fullList.Add(player);
        //    }

        //    foreach (Player player in team2)
        //    {
        //        _fullList.Add(player);
        //    }

        //    return _fullList;
        //}

        public void AddPlayer(Player player)
        {
            _roster.Add(player);
        }

    } // class

} // namespace
