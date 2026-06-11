using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Vehicles {
        public int amountWheels;
        public virtual String GetInfo()
        {
            var str = String.Format("\nКол-во колёс: {0}", this.amountWheels);

            return str;

        }

    }
    public enum AirplaneEngineType {reciprocating, gasTurbin, reactive}
    public class Airplane : Vehicles
    {
        public AirplaneEngineType type = AirplaneEngineType.reciprocating;
        public int maxFlightAltitude = 1000;

        public override String GetInfo()
        {
            var textType = "";
            var str = "Я самолёт";
            str += String.Format("\nМаксимальная высота полёта: {0}", this.maxFlightAltitude);
            switch (type)
            {
                case AirplaneEngineType.reciprocating:
                    textType = "Поршневой";
                    break;
                case AirplaneEngineType.gasTurbin:
                    textType = "Газотурбинный";
                    break;
                case AirplaneEngineType.reactive:
                    textType = "Реактивный";
                    break;
            }
            str += String.Format("\nТип двигателя: {0}", textType);
            str += base.GetInfo();
            return str;
        }
    }

    public enum CarType {bus, truck, SUV, passenger}
    public class Car : Vehicles
    {
        public CarType type = CarType.bus;
        public double engineDisplacement = 2.5;
        public int countDoors = 4;
        public override String GetInfo()
        {
            var str = "Я машина";
            str += String.Format("\nКоличество дверей: {0}", this.countDoors);
            str += String.Format("\nОбъём двигателя: {0}", this.engineDisplacement);
            var textType = "";
            switch (type)
            {
                case CarType.bus:
                    textType = "Автобус";
                    break;
                case CarType.truck:
                    textType = "Грузовой";
                    break;
                case CarType.SUV:
                    textType = "Внедорожник";
                    break;
                case CarType.passenger:
                    textType = "Легковая";
                    break;
            }
            str += String.Format("\nТип машины: {0}", textType);
            str += base.GetInfo();
            return str;
        }
    }

    public enum BikeType {mountain, city, childish}
    public class Bike : Vehicles
    {
        public BikeType type = BikeType.mountain;
        public int wheelRadius = 20;

        public override String GetInfo()
        {
            var str = "Я велосипед";
            var textType = "";
            str += String.Format("\nРадиус колёс: {0}", this.wheelRadius);
            switch (type)
            {
                case BikeType.mountain:
                    textType = "Горный";
                    break;
                case BikeType.city:
                    textType = "Городской";
                    break;
                case BikeType.childish:
                    textType = "Детский";
                    break;
            }
            str += String.Format("\nТип велосипеда: {0}", textType);
            str += base.GetInfo();
            return str;
        }
    }

}