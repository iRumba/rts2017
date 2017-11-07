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
        /// ������� �������� ������
        /// </summary>
        public ActionType? Action
        {
            get { return action; }
            set { action = value; }
        }

        /// <summary>
        /// ������� ������ ������
        /// </summary>
        public int Group
        {
            get { return group; }
            set { group = value; }
        }

        /// <summary>
        /// ����� ������� ����� ���������
        /// </summary>
        public double Left
        {
            get { return left; }
            set { left = value; }
        }

        /// <summary>
        /// ������� ������� ����� ���������
        /// </summary>
        public double Top
        {
            get { return top; }
            set { top = value; }
        }

        /// <summary>
        /// ������ ������� ����� ���������
        /// </summary>
        public double Right
        {
            get { return right; }
            set { right = value; }
        }

        /// <summary>
        /// ������ ������� ������������� ����� ���������
        /// </summary>
        public double Bottom
        {
            get { return bottom; }
            set { bottom = value; }
        }

        /// <summary>
        /// ������� �������� ����� ��� �������
        /// </summary>
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        /// <summary>
        /// ������� �������� ����� ��� �������
        /// </summary>
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        /// <summary>
        /// ���� ��������
        /// </summary>
        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        /// <summary>
        /// ������� ����������� �������� ��������
        /// </summary>
        public double MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        /// <summary>
        /// ������� ���������� ����������� �������� ��������
        /// </summary>
        public double MaxAngularSpeed
        {
            get { return maxAngularSpeed; }
            set { maxAngularSpeed = value; }
        }

        /// <summary>
        /// ������� ��� �������
        /// </summary>
        public VehicleType? VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        /// <summary>
        /// ������� ������������� ����������
        /// </summary>
        public long FacilityId
        {
            get { return facilityId; }
            set { facilityId = value; }
        }
    }
}