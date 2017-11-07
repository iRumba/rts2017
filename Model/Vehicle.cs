using System;

namespace Com.CodeGame.CodeWars2017.DevKit.CSharpCgdk.Model
{
    public class Vehicle : CircularUnit
    {
        private readonly long playerId;
        private readonly int durability;
        private readonly int maxDurability;
        private readonly double maxSpeed;
        private readonly double visionRange;
        private readonly double squaredVisionRange;
        private readonly double groundAttackRange;
        private readonly double squaredGroundAttackRange;
        private readonly double aerialAttackRange;
        private readonly double squaredAerialAttackRange;
        private readonly int groundDamage;
        private readonly int aerialDamage;
        private readonly int groundDefence;
        private readonly int aerialDefence;
        private readonly int attackCooldownTicks;
        private readonly int remainingAttackCooldownTicks;
        private readonly VehicleType type;
        private readonly bool isAerial;
        private readonly bool isSelected;
        private readonly int[] groups;

        public Vehicle(long id, double x, double y, double radius, long playerId, int durability, int maxDurability,
                double maxSpeed, double visionRange, double squaredVisionRange, double groundAttackRange,
                double squaredGroundAttackRange, double aerialAttackRange, double squaredAerialAttackRange,
                int groundDamage, int aerialDamage, int groundDefence, int aerialDefence, int attackCooldownTicks,
                int remainingAttackCooldownTicks, VehicleType type, bool isAerial, bool isSelected, int[] groups)
                : base(id, x, y, radius)
        {
            this.playerId = playerId;
            this.durability = durability;
            this.maxDurability = maxDurability;
            this.maxSpeed = maxSpeed;
            this.visionRange = visionRange;
            this.squaredVisionRange = squaredVisionRange;
            this.groundAttackRange = groundAttackRange;
            this.squaredGroundAttackRange = squaredGroundAttackRange;
            this.aerialAttackRange = aerialAttackRange;
            this.squaredAerialAttackRange = squaredAerialAttackRange;
            this.groundDamage = groundDamage;
            this.aerialDamage = aerialDamage;
            this.groundDefence = groundDefence;
            this.aerialDefence = aerialDefence;
            this.attackCooldownTicks = attackCooldownTicks;
            this.remainingAttackCooldownTicks = remainingAttackCooldownTicks;
            this.type = type;
            this.isAerial = isAerial;
            this.isSelected = isSelected;

            this.groups = new int[groups.Length];
            Array.Copy(groups, this.groups, groups.Length);
        }

        public Vehicle(Vehicle vehicle, VehicleUpdate vehicleUpdate)
                : base(vehicle.Id, vehicleUpdate.X, vehicleUpdate.Y, vehicle.Radius)
        {
            this.playerId = vehicle.playerId;
            this.durability = vehicleUpdate.Durability;
            this.maxDurability = vehicle.maxDurability;
            this.maxSpeed = vehicle.maxSpeed;
            this.visionRange = vehicle.visionRange;
            this.squaredVisionRange = vehicle.squaredVisionRange;
            this.groundAttackRange = vehicle.groundAttackRange;
            this.squaredGroundAttackRange = vehicle.squaredGroundAttackRange;
            this.aerialAttackRange = vehicle.aerialAttackRange;
            this.squaredAerialAttackRange = vehicle.squaredAerialAttackRange;
            this.groundDamage = vehicle.groundDamage;
            this.aerialDamage = vehicle.aerialDamage;
            this.groundDefence = vehicle.groundDefence;
            this.aerialDefence = vehicle.aerialDefence;
            this.attackCooldownTicks = vehicle.attackCooldownTicks;
            this.remainingAttackCooldownTicks = vehicleUpdate.RemainingAttackCooldownTicks;
            this.type = vehicle.type;
            this.isAerial = vehicle.isAerial;
            this.isSelected = vehicleUpdate.IsSelected;

            int[] updateGroups = vehicleUpdate.Groups;
            this.groups = new int[updateGroups.Length];
            Array.Copy(updateGroups, this.groups, updateGroups.Length);
        }

        /// <summary>
        /// Идентификатор игрока
        /// </summary>
        public long PlayerId => playerId;

        /// <summary>
        /// Текущая прочность
        /// </summary>
        public int Durability => durability;

        /// <summary>
        /// Максимальная прочность
        /// </summary>
        public int MaxDurability => maxDurability;

        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public double MaxSpeed => maxSpeed;

        /// <summary>
        /// Дальность обзора
        /// </summary>
        public double VisionRange => visionRange;

        /// <summary>
        /// Квадрат максимального расстояния, на котором данная техника обнаруживает другие объекты
        /// </summary>
        public double SquaredVisionRange => squaredVisionRange;

        /// <summary>
        /// Дальность атаки по наземным целям
        /// </summary>
        public double GroundAttackRange => groundAttackRange;

        /// <summary>
        /// Квадрат максимального расстояния, на котором данная техника может атаковать наземные цели
        /// </summary>
        public double SquaredGroundAttackRange => squaredGroundAttackRange;

        /// <summary>
        /// Дальность атаки по воздушным целям
        /// </summary>
        public double AerialAttackRange => aerialAttackRange;

        /// <summary>
        /// Квадрат максимального расстояния, на котором данная техника может атаковать воздушные цели
        /// </summary>
        public double SquaredAerialAttackRange => squaredAerialAttackRange;

        /// <summary>
        /// Урон по наземным целям
        /// </summary>
        public int GroundDamage => groundDamage;

        /// <summary>
        /// Урон по воздушным целям
        /// </summary>
        public int AerialDamage => aerialDamage;

        /// <summary>
        /// Защита от наземных атак
        /// </summary>
        public int GroundDefence => groundDefence;

        /// <summary>
        /// Защита от воздушных атак
        /// </summary>
        public int AerialDefence => aerialDefence;

        /// <summary>
        /// Интервал между атаками
        /// </summary>
        public int AttackCooldownTicks => attackCooldownTicks;

        /// <summary>
        /// Количество тиков до следующей атаки
        /// </summary>
        public int RemainingAttackCooldownTicks => remainingAttackCooldownTicks;

        /// <summary>
        /// Тип техники
        /// </summary>
        public VehicleType Type => type;

        /// <summary>
        /// Данная техника воздушная
        /// </summary>
        public bool IsAerial => isAerial;

        /// <summary>
        /// Данная техника выделена
        /// </summary>
        public bool IsSelected => isSelected;


        /// <summary>
        /// Группы, в которые входит данная техника
        /// </summary>
        public int[] Groups {
            get {
                if (this.groups == null) {
                    return null;
                }

                int[] groups = new int[this.groups.Length];
                Array.Copy(this.groups, groups, this.groups.Length);
                return groups;
            }
        }
    }
}