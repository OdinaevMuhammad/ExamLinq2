using Task2;

List<Person> people = new List<Person> {
 new Person { Name = "Alice", Age = 25, IsStudent = true },
 new Person { Name = "Bob", Age = 30, IsStudent = false },
 new Person { Name = "Charlie", Age = 20, IsStudent = true },
 new Person { Name = "Dave", Age = 35, IsStudent = false },
 new Person { Name = "Eve", Age = 28, IsStudent = true }
};

var linq = people.Where(x=> x.IsStudent == true).Average(x=>x.Age);

System.Console.WriteLine(string.Join(",", linq));