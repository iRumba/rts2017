using System;

namespace Com.CodeGame.CodeWars2017.DevKit.CSharpCgdk.Model
{
    public class Move
    {
        private ActionType? action;
        private int group;
        private double left;
        private double top;
        private double right;
        private double bottom;
        private double x;
        private double y;
        private double angle;
        private double maxSpeed;
        private double maxAngularSpeed;
        private VehicleType? vehicleType;
        private long facilityId = -1L;

        /// <summary>
        /// Текущее действие игрока
        /// </summary>
        public ActionType? Action
        {
            get { return action; }
            set { action = value; }
        }

        /// <summary>
        /// Текущая группа юнитов
        /// </summary>
        public int Group
        {
            get { return group; }
            set { group = value; }
        }

        /// <summary>
        /// Левая граница рамки выделения
        /// </summary>
        public double Left
        {
            get { return left; }
            set { left = value; }
        }

        /// <summary>
        /// Верхняя граница рамки выделения
        /// </summary>
        public double Top
        {
            get { return top; }
            set { top = value; }
        }

        /// <summary>
        /// правая граница рамки выделения
        /// </summary>
        public double Right
        {
            get { return right; }
            set { right = value; }
        }

        /// <summary>
        /// Нижняя граница прямоугольной рамки выделения
        /// </summary>
        public double Bottom
        {
            get { return bottom; }
            set { bottom = value; }
        }

        /// <summary>
        /// Текущая абсцисса точки или вектора
        /// </summary>
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        /// <summary>
        /// Текущая ордината точки или вектора
        /// </summary>
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        /// <summary>
        /// Угол поворота
        /// </summary>
        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        /// <summary>
        /// Текущее ограничение линейной скорости
        /// </summary>
        public double MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        /// <summary>
        /// Текущее абсолютное ограничение скорости поворота
        /// </summary>
        public double MaxAngularSpeed
        {
            get { return maxAngularSpeed; }
            set { maxAngularSpeed = value; }
        }

        /// <summary>
        /// Текущий тип техники
        /// </summary>
        public VehicleType? VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        /// <summary>
        /// Текущий идентификатор сооружения
        /// </summary>
        public long FacilityId
        {
            get { return facilityId; }
            set { facilityId = value; }
        }
    }
}