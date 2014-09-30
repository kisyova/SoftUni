using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.ThePlanet = planet;
        }

        public double Latitude {
            get { return this.latitude; }
            set { this.latitude = value; }
        }

        public double Longitude {
            get { return this.longitude; }
            set { this.longitude = value;}
        }

        public Planet ThePlanet {
            get { return this.planet; }
            set { this.planet = value; } 
        }

        public override string ToString()
        {
            string result = string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.ThePlanet);
            return result.ToString();
        }
    }
}
