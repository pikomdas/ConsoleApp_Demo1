using System;

public class HashSetExmpl
{
	public HashSetExmpl()
	{
        HashSet<string> names = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit"
            };
        names.Add("Rajeev");
        //duplicates are not added into collection.   
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        Console.ReadKey();
    }
}
