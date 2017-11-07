using System;

namespace Com.CodeGame.CodeWars2017.DevKit.CSharpCgdk.Model
{
    public abstract class Unit
    {
        private readonly long id;
        private readonly double x;
        private readonly double y;

        protected Unit(long id, double x, double y)
        {
            this.id = id;
            this.x = x;
            this.y = y;
        }

        public long Id => id;
        public double X => x;
        public double Y => y;

        /// <summary>
        /// ���������� �� �����
        /// </summary>
        public double GetDistanceTo(double x, double y)
        {
            double xRange = x - this.x;
            double yRange = y - this.y;
            return Math.Sqrt(xRange * xRange + yRange * yRange);
        }

        /// <summary>
        /// ���������� �� ������� �����
        /// </summary>
        public double GetDistanceTo(Unit unit) {
            return GetDistanceTo(unit.x, unit.y);
        }
    }
}