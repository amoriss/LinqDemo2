using LinqLibrary;
using System.Threading.Channels;




List<Person> people = ListManager.LoadSimpleData();

//sort by last name

//people.OrderBy(x => x.FirstName)
//    .ToList()
//    .ForEach(x => Console.WriteLine($"Full Name: {x.FullName}    YOE: {x.YearsOfExperience}"));

//filter where first names have a length of greater than 3
//people.Where(x => x.FirstName.Length > 3).ToList().ForEach(x => Console.WriteLine(x.FullName));

//filter where employees have years of experience greater than 6

int number = 6;

people.Where(x => x.YearsOfExperience > number).OrderByDescending(x => x.YearsOfExperience).ToList().ForEach(x => Console.WriteLine($"Name: {x.FullName} YOE: {x.YearsOfExperience}"));

//people.Remove(people[3]);

//foreach (Person person in people)
//{
//    Console.WriteLine(person.FullName);
//}

//Find all people whose first name starts with M

//people.Where(x => x.FirstName.StartsWith("M")).ToList().ForEach(x => Console.WriteLine(x.FullName));