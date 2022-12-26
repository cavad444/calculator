using calculator;

Console.WriteLine("Bir eded daxil edin");
double x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bu emellerden birini daxil edin: *,/,+,-");
string mathOperator = Console.ReadLine();
Console.WriteLine("Diger ededi daxil edin");
double y = Convert.ToInt32(Console.ReadLine());
Calculator calculate = new();
calculate.X = x;
calculate.Y = y;
calculate.Operator = mathOperator;
calculate.Calculate();
