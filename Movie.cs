using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB;
 class Movie
{
    public string Title { get; set; }
    public int RunningTime { get; set; }
    public List<Actor> Actors { get; set; }

    public Movie(string title, int runningtime, List<Actor> actors)
    {
        Title = title;
        RunningTime = runningtime;
        Actors = actors;
    }

    public virtual void ShowMovieInfo()
    {
        Console.Write("The movie " +  Title + " is " + RunningTime + " minutes long. The characters are played by: ");
        foreach(Actor actor in Actors)
        {
            Console.Write(actor.Name + "(born in " + actor.BirthYear + "), ");
        }

    }
}

class Actor
{
    public string Name { get; set; }
    public int BirthYear { get; set; }

    public Actor(string name, int birtyear)
    {
        Name = name;
        BirthYear = birtyear;
    }

}




class Comedy : Movie
{
    public int NumberOfFunnyScenes { get; set; }

    public Comedy(string title, int runningtime, List<Actor> actors, int numberoffunnyscenes) : base(title, runningtime, actors)
    {
        NumberOfFunnyScenes = numberoffunnyscenes;
    }

    public override void ShowMovieInfo()
    {
        base.ShowMovieInfo();
        Console.Write(" The movie has " + NumberOfFunnyScenes + " Funny scenes.");
        Console.WriteLine();
    }
}

class Action : Movie
{
    public int NumberOfShotsFired { get; set; }

    public Action(string title, int runningtime, List<Actor> actors, int numberofshotsfired) : base(title, runningtime, actors)
    {
        NumberOfShotsFired = numberofshotsfired;
    }

    public override void ShowMovieInfo()
    {
        base.ShowMovieInfo();
        Console.Write(" The movie has " + NumberOfShotsFired + " shots fired.");
        Console.WriteLine();
    }
}

class SciFi : Movie
{
    public int NumberOfSpaceShips { get; set; }

    public SciFi(string title, int runningtime, List<Actor> actors, int numberofspaceships) : base(title, runningtime, actors)
    {
        NumberOfSpaceShips = numberofspaceships;
    }

    public override void ShowMovieInfo()
    {
        base.ShowMovieInfo();
        Console.Write(" The movie has " + NumberOfSpaceShips + " space ships.");
        Console.WriteLine();
    }
}
