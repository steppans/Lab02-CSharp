using ClassLibrary02;

Car car = new Car(10, 15);
car.Price = 680000;
car.Speed = 150;
car.Year = 2009;

Ship ship = new Ship(-17, 0.5);
ship.Price = 2750000;
ship.Speed = 60;
ship.Year = 2012;
ship.Port = 10;
ship.Passengers = 215;

Plane plane = new Plane(25.7, -3.5);
plane.Price = 10000000;
plane.Speed = 780;
plane.Year = 2005;
plane.Height = 9000;
plane.Passengers = 1050;

car.Info();
ship.Info();
plane.Info();

