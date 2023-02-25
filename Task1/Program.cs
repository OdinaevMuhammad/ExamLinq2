using System.Collections.Generic;
List<string> words = new List<string> { "apple", "banana", "orange", 
"grape", "mango" };


var list = words.OrderByDescending(x=> x.Length).Take(1);

System.Console.WriteLine(string.Join(",", list));
