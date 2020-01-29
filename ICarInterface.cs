using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    public interface ICarInterface
    {
        void setName(string name);
        string getName();
        int setSpeed(int speed);
        int getSpeed();
        void setMPG(int mpg);
        void drive(int minutes);
        void fill(int gals);
        double gasLeft();
        void setTankCapacity(int gals);
        int getMilesDriven();
    }
}
