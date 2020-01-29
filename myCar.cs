using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    public class myCar : ICarInterface
    {
        int m_speed;
        int m_gas;
        int m_distance;

        string carName = "";

        public void drive(int minutes)
        {
            minutes = 1;

            if (m_gas > 0)
            {
                m_distance = m_speed * minutes;
                if (m_speed > 60)
                {
                    if (m_speed > 100)
                    {
                        m_gas = m_gas - (((((((m_speed / 2) + (minutes / 2)) / 2)) / 4) / 3));
                    }
                    else
                    {
                        m_gas = m_gas - (((((((m_speed / 2) + (minutes / 2)) / 2)) / 4)));
                    }
                }
                else
                {
                    m_gas = m_gas - (((((((m_speed / 2) + (minutes / 2)) / 2)) / 2)));
                }
            }
            else
            {
                m_speed = 0;
            }
        }

        public void fill(int gals)
        {
            m_gas = m_gas + gals;
        }

        public double gasLeft()
        {
            return m_gas;
        }

        public int getMilesDriven()
        {
            return m_distance;
        }

        public string getName()
        {
            return carName;
        }

        public int getSpeed()
        {
            return m_speed;
        }

        public void setMPG(int mpg)
        {
            for (int i = 0; i < m_gas; i++)
            {
                mpg++;
            }
        }

        public void setName(string name)
        {
            carName = name;
        }

        public int setSpeed(int speed)
        {
            m_speed = speed;
            return speed;
        }

        public void setTankCapacity(int gals)
        {
            m_gas = gals;
        }
    }
}
