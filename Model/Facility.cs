using System;

namespace Com.CodeGame.CodeWars2017.DevKit.CSharpCgdk.Model {
    public class Facility {
        private readonly long id;
        private readonly FacilityType type;
        private readonly long ownerPlayerId;
        private readonly double left;
        private readonly double top;
        private readonly double capturePoints;
        private readonly VehicleType? vehicleType;
        private readonly int productionProgress;

        public Facility(long id, FacilityType type, long ownerPlayerId, double left, double top, double capturePoints,
                VehicleType? vehicleType, int productionProgress) {
            this.id = id;
            this.type = type;
            this.ownerPlayerId = ownerPlayerId;
            this.left = left;
            this.top = top;
            this.capturePoints = capturePoints;
            this.vehicleType = vehicleType;
            this.productionProgress = productionProgress;
        }

        public long Id => id;
        public FacilityType Type => type;

        /// <summary>
        /// Идентификатор владельца (-1 если ничьё)
        /// </summary>
        public long OwnerPlayerId => ownerPlayerId;

        /// <summary>
        /// Координата левой границы
        /// </summary>
        public double Left => left;

        /// <summary>
        /// координата верхней границы
        /// </summary>
        public double Top => top;
        /// <summary>
        /// Индикатор захвата
        /// </summary>
        public double CapturePoints => capturePoints;

        /// <summary>
        /// Тип производящейся техники
        /// </summary>
        public VehicleType? VehicleType => vehicleType;

        /// <summary>
        /// Прогресс производства
        /// </summary>
        public int ProductionProgress => productionProgress;
    }
}