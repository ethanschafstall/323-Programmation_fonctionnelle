using System;
using System.Collections.Immutable;

// 4 players
List<Player> players = new List<Player>()
{
    new Player("Joe", 32),
    new Player("Jack", 30),
    new Player("William", 37),
    new Player("Averell", 25)
};


// Initialize search
//Player elder = players.First();
//int biggestAge = elder.Age;


var playerDic = ImmutableDictionary<string, int>.Empty
    .Add(players[0].Name, players[0].Age)
    .Add(players[1].Name, players[1].Age)
    .Add(players[2].Name, players[2].Age);

var test = playerDic.ToList<KeyValuePair<string, int>>();

//// search
//foreach (Player p in players)
//{
//    if (p.Age > biggestAge) // memorize new elder
//    {
//        elder = p;
//        biggestAge = p.Age; // for future loops
//    }

//}

Console.WriteLine($"Le plus agé est {test} qui a {playerDic.Values.Max()} ans");


Console.ReadKey();

public class Player
{
    private readonly string _name;
    private readonly int _age;

    public Player(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public string Name => _name;

    public int Age => _age;
}