using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("hello, world!");

string message = "krediler";
int term = 12;
double amount = 100000.6;

bool isAuthenticated = false;
Console.WriteLine(message);

if (isAuthenticated)
{
    Console.WriteLine("Buton => Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Buton => Sisteme Giriş Yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6", };

//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "JAVA";
course2.Description = "JAVA 17...";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.12...";
course3.Price = 20;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

CourseManager courseManager = new(new CourseDal());
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NatıonalIdentity = "12345678922";
customer1.FİrstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123457";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NatıonalIdentity = "12372389874";
customer2.FİrstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123896";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12672398230";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "654566";
customer4.TaxNumber = "126723988340";

BaseCustomer[] customers = {  customer1, customer2, customer3, customer4 };

//POLYMORPHISM
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}