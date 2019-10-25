using System;
namespace code_challenges
{
    public class SpaceAge
    {
        int seconds = 0;
        public SpaceAge(int seconds)
        {
            this.seconds = seconds;
        }

        public double OnEarth()
        {
            double onEarth = 31557600;
            return seconds / onEarth;
        }

        public double OnMercury()
        {
            double onMercury = 0.2408467;
            return OnEarth() / onMercury;
        }

        public double OnVenus()
        {
            double onVenus = 0.61519726;
            return OnEarth() / onVenus;
        }

        public double OnMars()
        {
            double onMars = 1.8808158;
            return OnEarth() / onMars;
        }

        public double OnJupiter()
        {
            double onJupiter = 11.862615;
            return OnEarth() / onJupiter;
        }

        public double OnSaturn()
        {
            double onSaturn = 29.447498;
            return OnEarth() / onSaturn;
        }

        public double OnUranus()
        {
            double onUranus = 84.016846;
            return OnEarth() / onUranus;
        }

        public double OnNeptune()
        {
            double onNeptune = 164.79132;
            return OnEarth() / onNeptune;
        }
    }
}
