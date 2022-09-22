namespace ClassLibrary02
{
    public class Vehicle
    {
        private double _x;
        private double _y;

        private string _name;

        protected string Name { get => _name; set => _name = value; }

        private double _price = 0;
        private double _speed = 0;
        private uint _year = 0;

        public double Price { get => _price; set => _price = value; }
        public double Speed { get => _speed; set => _speed = value; }
        public uint Year { get => _year; set => _year = value; }

        public Vehicle(double x, double y)
        {
            _x = x;
            _y = y;
            _name = "Vehicle";
        }

        virtual public void Info()
        {
            Console.WriteLine($"---------- #{_name}-----------");
            Console.WriteLine($"Price: {_price}");
            Console.WriteLine($"Speed: {_speed}");
            Console.WriteLine($"Year: {_year}");
        }


    }

    public class Car: Vehicle {

        public Car(double x, double y): base(x, y)
        {
            Name = "Car";
        }
    }

    public class Plane: Vehicle
    {
        double _height = 0;
        uint _passengers = 0;

        public double Height { get => _height; set => _height = value; }
        public uint Passengers { get => _passengers; set => _passengers = value; }

        public Plane(double x, double y): base(x, y)
        {
            Name = "Plane";
        }

        override public void Info()
        {
            base.Info();
            Console.WriteLine($"Height: {_height}");
            Console.WriteLine($"Passengers: {_passengers}");
        }
    }

    public class Ship: Vehicle
    {
        uint _port = 0;
        uint _passengers = 0;

        public uint Port { get => _port; set => _port = value; }
        public uint Passengers { get => _passengers; set => _passengers = value; }

        public Ship(double x, double y) : base(x, y)
        {
            Name = "Ship";
        }

        override public void Info()
        {
            base.Info();
            Console.WriteLine($"Port: {_port}");
            Console.WriteLine($"Passengers: {_passengers}");
        }
    }

}
