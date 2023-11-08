// See https://aka.ms/new-console-template for more information
using prim1_lek8;
Console.WriteLine("Введіть потужність");
var power = Convert.ToDouble(Console.ReadLine());
//Приклад 1
Console.WriteLine("Композиція");
var car = new Car("Tesla", power);
Console.WriteLine(car.model+" Двигун потужністтю "+
    car.engine.CurrentPower.ToString());
//!!!Приклад 2
//закоментувати CTRL+K,C
//разкоментувати CTRL+K,U
Console.WriteLine("DI через конструктор");
var engine = new Engine();
engine.CurrentPower = power;
var car_constr_di = new Car_DI_constructor("Tesla", engine);
Console.WriteLine(car_constr_di.model + " Двигун потужністтю " +
    car_constr_di.engine.CurrentPower.ToString());
//!!!Приклад 3
Console.WriteLine("DI через set");
var engine1 = new Engine();
engine1.CurrentPower = power;
var car_set = new Car_set("Tesla");
car_set.Engine = engine1;
Console.WriteLine(car_set.model + " Двигун потужністтю " +
    car_set.Engine.CurrentPower.ToString());
