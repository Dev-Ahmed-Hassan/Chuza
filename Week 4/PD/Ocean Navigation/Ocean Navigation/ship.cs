using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation
{
    internal class ship
    {
        public string ShipNumber;
        public angle Latitude;
        public angle Longitude;

        public ship(string ShipNumber, angle Latitude, angle Longitude)
        {
            this .ShipNumber = ShipNumber;
            this .Latitude = Latitude;
            this .Longitude = Longitude;
        }

        public string PrintPosition()
        {
            return $"Ship is at {Latitude.degrees}°{Latitude.minutes}'{Latitude.direction} and {Longitude.degrees}°{Longitude.minutes}'{Longitude.direction}";
        }

        public string ShowSerial()
        {
            return $"Ship's serial number is: {ShipNumber}";
        }
    }
}
