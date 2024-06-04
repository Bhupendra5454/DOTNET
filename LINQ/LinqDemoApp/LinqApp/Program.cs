using LinqApp.Entities;

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var even = from number in numbers
           where number%2 == 0
           select number;
foreach(var num in even)
{
    Console.WriteLine(num);
}

List<Customer> customers = new List<Customer>();
customers.Add(new Customer { Id = 54, Name = "Bhupendra Walhekar", Email = "bhupendraw2512@gmail.com", Phone = "9175116616" });
customers.Add(new Customer { Id = 11, Name = "Vaibhav Lakudzode", Email = "vaibhavl@gmail.com", Phone = "9175116617" });
customers.Add(new Customer { Id = 45, Name = "Shreedhar Patil", Email = "shreedharp@gmail.com", Phone = "9175116618" });
customers.Add(new Customer { Id = 97, Name = "Ajinkya Tambade", Email = "ajinkyat@gmail.com", Phone = "9175116619" });

var cust = from cus in customers
           where cus.Id == 11
           select cus;
foreach(var cus in cust)
{
    Console.WriteLine(cus.Name);
}

List<string> names = new List<string>() { "Bhupendra", "Akshay", "Aniket", "Anurag", "Sourabh" };
IEnumerable<string> filterednames = names.Where(name => name.StartsWith('A'));
foreach(var name in filterednames)
{
    Console.WriteLine(name);
}


IQueryable<Candidate> topMaleCandidates = candidats.Where(candidate => candidate.Gendre == "Male")
                       .OrderByDesending(candidate => candidate.score)
                       .Take(100);



