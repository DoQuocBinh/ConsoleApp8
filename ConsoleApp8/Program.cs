
using ConsoleApp8;
using System.Globalization;

//Console.WriteLine("Enter your name:");
//String name = Console.ReadLine();
//Console.WriteLine($"Your name is: {name}");
Console.OutputEncoding = System.Text.Encoding.UTF8;

var n = DateTime.Now;

CultureInfo vn = new CultureInfo("vi-VN");
Thread.CurrentThread.CurrentCulture = vn;
//Console.WriteLine(n.ToLongDateString());
//Console.WriteLine(vn.DateTimeFormat.GetMonthName(n.Month));
Console.WriteLine(n.Month + " " + n.Year);
double amount = 334432.4456;
Console.WriteLine(String.Format(vn,"{0:c}",amount));
Console.WriteLine(String.Format(vn, "{0:f}", amount));


List<GRWStudent> list = new List<GRWStudent>();
list.Add(new GRWStudent{ Name="Trang"});
list.Add(new GRWStudent { Name = "Phuong" });
Console.WriteLine($"So phan tu la: {list.Count}");

