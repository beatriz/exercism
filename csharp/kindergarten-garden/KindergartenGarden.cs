using System;
using System.Collections.Generic;
using System.Linq;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{    
    private static Dictionary<char, Plant> InitialToPlant = new Dictionary<char, Plant>
    {
        { 'V', Plant.Violets },
        { 'R', Plant.Radishes },
        { 'C', Plant.Clover },
        { 'G', Plant.Grass }
    };

    private string[] plants;
    private string[] students;

    public KindergartenGarden(string diagram) : this(diagram, new[] { "Alice", "Bob", "Charlie", "David", "Eve", "Fred", "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry" })
    {
    }

    public KindergartenGarden(string diagram, IEnumerable<string> students)
    {
        this.plants = diagram.Split("\n");
        this.students = students.OrderBy(x => x).ToArray();
    }

    public IEnumerable<Plant> Plants(string student)
    {
        var studentIndex = Array.IndexOf(this.students, student);
        
        return new [] 
        { 
            InitialToPlant[this.plants[0][studentIndex * 2]], InitialToPlant[this.plants[0][studentIndex * 2 + 1]], 
            InitialToPlant[this.plants[1][studentIndex * 2]], InitialToPlant[this.plants[1][studentIndex * 2 + 1]] 
        };
    }
}