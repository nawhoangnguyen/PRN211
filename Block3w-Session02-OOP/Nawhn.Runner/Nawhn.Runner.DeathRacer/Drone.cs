using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.Runner.DeathRacer
{
    internal class Drone : Racer
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double Run()
        {
            return Random.Shared.NextDouble() * 100;
        }
        public double RunToDeath() => Random.Shared.NextDouble() * 300;
        public string ShowRecord()
        {
            return Name + " speed " + RunToDeath();
        }
        //vì tham gia câu lạc bộ đua thì phải cam kết có hàm đua đến chết
    }
}
