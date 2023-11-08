// See https://aka.ms/new-console-template for more information
using prim1_lek8;
using prim2_lek8;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Масив автівок для прикладу 3
var n = 3;
Car[] cars = new Car[n];
void show_cars()
{
    foreach (var item in cars)
    {
        Console.WriteLine(item.Model + " Двигун потужністтю " +
        item.Engine.CurrentPower.ToString());
    }
}
//Оголошуємо новий інжектор
var injector = new EngineInjector();
//Інтерфейс. Приклад4
var models  = new string[] { "Tesla", "Ford", "Nissan" };
var powers = new double[] { 3, 5, 10 };
for (int i = 0; i < n; i++)
{
    var car = new Car(models[i]);
    var eng = new Engine();
    eng.CurrentPower= powers[i];
    cars[i] = car;
    //Робимо ін'єкцію залежностей
    injector.inject(cars[i], eng);
}
show_cars();
//Зміна потужностей всіх двигунів
var eng1 = new Engine();
    eng1.CurrentPower = 90;
  injector.updateEngine(eng1);
Console.WriteLine("Зміна потужності");
show_cars();
