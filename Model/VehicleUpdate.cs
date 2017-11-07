using System;

namespace Com.CodeGame.CodeWars2017.DevKit.CSharpCgdk.Model
{
    public class VehicleUpdate
    {
        private readonly long id;
        private readonly double x;
        private readonly double y;
        private readonly int durability;
        private readonly int remainingAttackCooldownTicks;
        private readonly bool isSelected;
        private readonly int[] groups;

        public VehicleUpdate(long id, double x, double y, int durability, int remainingAttackCooldownTicks,
                bool isSelected, int[] groups)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.durability = durability;
            this.remainingAttackCooldownTicks = remainingAttackCooldownTicks;
            this.isSelected = isSelected;

            this.groups = new int[groups.Length];
            Array.Copy(groups, this.groups, groups.Length);
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id => id;

        public double X => x;
        public double Y => y;
        public int Durability => durability;

        /// <summary>
        /// Время до следующей атаки
        /// </summary>
        public int RemainingAttackCooldownTicks => remainingAttackCooldownTicks;
        public bool IsSelected => isSelected;

        /// <summary>
        /// Группы, в которые входит эта техника
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