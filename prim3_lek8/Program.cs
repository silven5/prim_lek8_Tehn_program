// See https://aka.ms/new-console-template for more information
using prim3_lek8;

Console.WriteLine("Введіть потужність");
var power = Convert.ToDouble(Console.ReadLine());

var car = new Car("Reno");
var moto = new Moto("Reno", "Гоночний");
IEngine engine;
engine = new Engine_gas();
IEngine engine1;
engine1 = new Engine_benzin();
engine.Power = power;
engine1.Power = power;
IEngine engine2 = new Engine_elektro();
engine2.Power = power;
var inj = new EngineFactory();
inj.inject(car, engine2);
inj.inject(moto, engine1);
Console.WriteLine(car.Model + " Двигун потужністтю " +
    car.Engine.Power.ToString()
    + " Двигун тип пального " + car.Engine.Name_pal) ;
Console.WriteLine(moto.Model + " "+moto.Type +" Двигун потужністтю " +
    moto.Engine.Power.ToString()
    + " Двигун тип пального " + moto.Engine.Name_pal);
