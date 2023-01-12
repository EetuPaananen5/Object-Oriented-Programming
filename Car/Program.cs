using CarExercise;
using System.Runtime.CompilerServices;

Car car = new Car();
Car mycar1 = new Car();
Car mycar2 = new Car();

mycar1.AskData();
mycar1.Accelerate(10);
mycar1.ShowCarInfo();
mycar1.Brake(0.9);
mycar1.ShowCarInfo();

mycar2.AskData();
mycar2.Accelerate(20);
mycar2.ShowCarInfo();
mycar2.Brake(0.9);
mycar2.ShowCarInfo();


//car.AskData();
//car.Accelerate(30);
//car.ShowCarInfo();