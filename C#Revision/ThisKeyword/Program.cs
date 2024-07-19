using ThisKeyword;




// Usage:
Person person1 = new Person(); // Uses default values ("Unknown", 0)
Person person2 = new Person("Alice"); // Sets name to "Alice" and age to 0
Person person3 = new Person("Bob", 30); // Sets name to "Bob" and age to 30
Console.WriteLine(person1);
Console.WriteLine(person2);
Console.WriteLine(person3);

Books book = new Books();
book.title[0] = "Book1";
book.title[1] = "Book1";
book.title[3] = "Book1";


Factory f1 = Factory.GetInstance();
f1.GetDetails();

Factory f2 = Factory.GetInstance();
f2.GetDetails();

f2.setFactoryName("Bhupendra");
f1.GetDetails();
