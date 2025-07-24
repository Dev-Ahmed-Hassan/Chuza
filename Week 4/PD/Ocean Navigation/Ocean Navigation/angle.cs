using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation
{
    internal class angle
    {
        public int degrees;
        public float minutes;
        public char direction;

        public angle(int degrees, float minutes, char direction)
        {
            this.direction = direction;
            this.degrees = degrees;
            this.minutes = minutes;
        }

        public void AlterAngle(int degrees, float minutes, char direction)
        {
            this.direction = direction;
            this.degrees = degrees;
            this.minutes = minutes;
        }

        public string ShowAngle()
        {
            return $"{degrees}\u00b0{minutes}'{direction}";
        }
    }
}
