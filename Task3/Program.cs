using Task3;

List<Customer> customers = new List<Customer> {
 new Customer {
 Name = "Alice",
 Email = "alice@example.com",
 Age = 25,
 PurchaseHistory = new List<Purchase> {
 new Purchase { Date = new DateTime(2022, 1, 1), Amount = 100.00M },
 new Purchase { Date = new DateTime(2022, 2, 1), Amount = 50.00M },
 new Purchase { Date = new DateTime(2022, 3, 1), Amount = 75.00M }
 }
 },
 new Customer {
 Name = "Bob",
 Email = "bob@example.com",
 Age = 35,
 PurchaseHistory = new List<Purchase> {
 new Purchase { Date = new DateTime(2022, 1, 1), Amount =
150.00M },
 new Purchase { Date = new DateTime(2022, 2, 1), Amount = 75.00M },
 new Purchase { Date = new DateTime(2022, 3, 1), Amount = 125.00M }
 }
 },
 new Customer {
 Name = "Charlie",
 Email = "charlie@example.com",
 Age = 30,
 PurchaseHistory = new List<Purchase> {
 new Purchase { Date = new DateTime(2022, 1, 1), Amount = 75.00M },
 new Purchase { Date = new DateTime(2022, 2, 1), Amount = 125.00M },
 new Purchase { Date = new DateTime(2022, 3, 1), Amount = 150.00M }
 }
 }
};

var list = (from c in customers
            orderby c.PurchaseHistory.Select(x=>x.Amount).Sum() descending
            select new 
            {
                Name = c.Name,
                Age = c.Age,
                Email = c.Email,
                TotalAmount = c.PurchaseHistory.Select(x=>x.Amount).Sum()
            }).ToList();
System.Console.WriteLine(string.Join(",", list));
