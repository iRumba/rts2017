using System;

namespace Com.CodeGame.CodeWars2017.DevKit.CSharpCgdk.Model
{
    public class Game
    {
        private readonly long randomSeed;
        private readonly int tickCount;
        private readonly double worldWidth;
        private readonly double worldHeight;
        private readonly bool isFogOfWarEnabled;
        private readonly int victoryScore;
        private readonly int facilityCaptureScore;
        private readonly int vehicleEliminationScore;
        private readonly int actionDetectionInterval;
        private readonly int baseActionCount;
        private readonly int additionalActionCountPerControlCenter;
        private readonly int maxUnitGroup;
        private readonly int terrainWeatherMapColumnCount;
        private readonly int terrainWeatherMapRowCount;
        private readonly double plainTerrainVisionFactor;
        private readonly double plainTerrainStealthFactor;
        private readonly double plainTerrainSpeedFactor;
        private readonly double swampTerrainVisionFactor;
        private readonly double swampTerrainStealthFactor;
        private readonly double swampTerrainSpeedFactor;
        private readonly double forestTerrainVisionFactor;
        private readonly double forestTerrainStealthFactor;
        private readonly double forestTerrainSpeedFactor;
        private readonly double clearWeatherVisionFactor;
        private readonly double clearWeatherStealthFactor;
        private readonly double clearWeatherSpeedFactor;
        private readonly double cloudWeatherVisionFactor;
        private readonly double cloudWeatherStealthFactor;
        private readonly double cloudWeatherSpeedFactor;
        private readonly double rainWeatherVisionFactor;
        private readonly double rainWeatherStealthFactor;
        private readonly double rainWeatherSpeedFactor;
        private readonly double vehicleRadius;
        private readonly int tankDurability;
        private readonly double tankSpeed;
        private readonly double tankVisionRange;
        private readonly double tankGroundAttackRange;
        private readonly double tankAerialAttackRange;
        private readonly int tankGroundDamage;
        private readonly int tankAerialDamage;
        private readonly int tankGroundDefence;
        private readonly int tankAerialDefence;
        private readonly int tankAttackCooldownTicks;
        private readonly int tankProductionCost;
        private readonly int ifvDurability;
        private readonly double ifvSpeed;
        private readonly double ifvVisionRange;
        private readonly double ifvGroundAttackRange;
        private readonly double ifvAerialAttackRange;
        private readonly int ifvGroundDamage;
        private readonly int ifvAerialDamage;
        private readonly int ifvGroundDefence;
        private readonly int ifvAerialDefence;
        private readonly int ifvAttackCooldownTicks;
        private readonly int ifvProductionCost;
        private readonly int arrvDurability;
        private readonly double arrvSpeed;
        private readonly double arrvVisionRange;
        private readonly int arrvGroundDefence;
        private readonly int arrvAerialDefence;
        private readonly int arrvProductionCost;
        private readonly double arrvRepairRange;
        private readonly double arrvRepairSpeed;
        private readonly int helicopterDurability;
        private readonly double helicopterSpeed;
        private readonly double helicopterVisionRange;
        private readonly double helicopterGroundAttackRange;
        private readonly double helicopterAerialAttackRange;
        private readonly int helicopterGroundDamage;
        private readonly int helicopterAerialDamage;
        private readonly int helicopterGroundDefence;
        private readonly int helicopterAerialDefence;
        private readonly int helicopterAttackCooldownTicks;
        private readonly int helicopterProductionCost;
        private readonly int fighterDurability;
        private readonly double fighterSpeed;
        private readonly double fighterVisionRange;
        private readonly double fighterGroundAttackRange;
        private readonly double fighterAerialAttackRange;
        private readonly int fighterGroundDamage;
        private readonly int fighterAerialDamage;
        private readonly int fighterGroundDefence;
        private readonly int fighterAerialDefence;
        private readonly int fighterAttackCooldownTicks;
        private readonly int fighterProductionCost;
        private readonly double maxFacilityCapturePoints;
        private readonly double facilityCapturePointsPerVehiclePerTick;
        private readonly double facilityWidth;
        private readonly double facilityHeight;

        public Game(long randomSeed, int tickCount, double worldWidth, double worldHeight, bool isFogOfWarEnabled,
                int victoryScore, int facilityCaptureScore, int vehicleEliminationScore, int actionDetectionInterval,
                int baseActionCount, int additionalActionCountPerControlCenter, int maxUnitGroup,
                int terrainWeatherMapColumnCount, int terrainWeatherMapRowCount, double plainTerrainVisionFactor,
                double plainTerrainStealthFactor, double plainTerrainSpeedFactor, double swampTerrainVisionFactor,
                double swampTerrainStealthFactor, double swampTerrainSpeedFactor, double forestTerrainVisionFactor,
                double forestTerrainStealthFactor, double forestTerrainSpeedFactor, double clearWeatherVisionFactor,
                double clearWeatherStealthFactor, double clearWeatherSpeedFactor, double cloudWeatherVisionFactor,
                double cloudWeatherStealthFactor, double cloudWeatherSpeedFactor, double rainWeatherVisionFactor,
                double rainWeatherStealthFactor, double rainWeatherSpeedFactor, double vehicleRadius,
                int tankDurability, double tankSpeed, double tankVisionRange, double tankGroundAttackRange,
                double tankAerialAttackRange, int tankGroundDamage, int tankAerialDamage, int tankGroundDefence,
                int tankAerialDefence, int tankAttackCooldownTicks, int tankProductionCost, int ifvDurability,
                double ifvSpeed, double ifvVisionRange, double ifvGroundAttackRange, double ifvAerialAttackRange,
                int ifvGroundDamage, int ifvAerialDamage, int ifvGroundDefence, int ifvAerialDefence,
                int ifvAttackCooldownTicks, int ifvProductionCost, int arrvDurability, double arrvSpeed,
                double arrvVisionRange, int arrvGroundDefence, int arrvAerialDefence, int arrvProductionCost,
                double arrvRepairRange, double arrvRepairSpeed, int helicopterDurability, double helicopterSpeed,
                double helicopterVisionRange, double helicopterGroundAttackRange, double helicopterAerialAttackRange,
                int helicopterGroundDamage, int helicopterAerialDamage, int helicopterGroundDefence,
                int helicopterAerialDefence, int helicopterAttackCooldownTicks, int helicopterProductionCost,
                int fighterDurability, double fighterSpeed, double fighterVisionRange, double fighterGroundAttackRange,
                double fighterAerialAttackRange, int fighterGroundDamage, int fighterAerialDamage,
                int fighterGroundDefence, int fighterAerialDefence, int fighterAttackCooldownTicks,
                int fighterProductionCost, double maxFacilityCapturePoints,
                double facilityCapturePointsPerVehiclePerTick, double facilityWidth, double facilityHeight)
        {
            this.randomSeed = randomSeed;
            this.tickCount = tickCount;
            this.worldWidth = worldWidth;
            this.worldHeight = worldHeight;
            this.isFogOfWarEnabled = isFogOfWarEnabled;
            this.victoryScore = victoryScore;
            this.facilityCaptureScore = facilityCaptureScore;
            this.vehicleEliminationScore = vehicleEliminationScore;
            this.actionDetectionInterval = actionDetectionInterval;
            this.baseActionCount = baseActionCount;
            this.additionalActionCountPerControlCenter = additionalActionCountPerControlCenter;
            this.maxUnitGroup = maxUnitGroup;
            this.terrainWeatherMapColumnCount = terrainWeatherMapColumnCount;
            this.terrainWeatherMapRowCount = terrainWeatherMapRowCount;
            this.plainTerrainVisionFactor = plainTerrainVisionFactor;
            this.plainTerrainStealthFactor = plainTerrainStealthFactor;
            this.plainTerrainSpeedFactor = plainTerrainSpeedFactor;
            this.swampTerrainVisionFactor = swampTerrainVisionFactor;
            this.swampTerrainStealthFactor = swampTerrainStealthFactor;
            this.swampTerrainSpeedFactor = swampTerrainSpeedFactor;
            this.forestTerrainVisionFactor = forestTerrainVisionFactor;
            this.forestTerrainStealthFactor = forestTerrainStealthFactor;
            this.forestTerrainSpeedFactor = forestTerrainSpeedFactor;
            this.clearWeatherVisionFactor = clearWeatherVisionFactor;
            this.clearWeatherStealthFactor = clearWeatherStealthFactor;
            this.clearWeatherSpeedFactor = clearWeatherSpeedFactor;
            this.cloudWeatherVisionFactor = cloudWeatherVisionFactor;
            this.cloudWeatherStealthFactor = cloudWeatherStealthFactor;
            this.cloudWeatherSpeedFactor = cloudWeatherSpeedFactor;
            this.rainWeatherVisionFactor = rainWeatherVisionFactor;
            this.rainWeatherStealthFactor = rainWeatherStealthFactor;
            this.rainWeatherSpeedFactor = rainWeatherSpeedFactor;
            this.vehicleRadius = vehicleRadius;
            this.tankDurability = tankDurability;
            this.tankSpeed = tankSpeed;
            this.tankVisionRange = tankVisionRange;
            this.tankGroundAttackRange = tankGroundAttackRange;
            this.tankAerialAttackRange = tankAerialAttackRange;
            this.tankGroundDamage = tankGroundDamage;
            this.tankAerialDamage = tankAerialDamage;
            this.tankGroundDefence = tankGroundDefence;
            this.tankAerialDefence = tankAerialDefence;
            this.tankAttackCooldownTicks = tankAttackCooldownTicks;
            this.tankProductionCost = tankProductionCost;
            this.ifvDurability = ifvDurability;
            this.ifvSpeed = ifvSpeed;
            this.ifvVisionRange = ifvVisionRange;
            this.ifvGroundAttackRange = ifvGroundAttackRange;
            this.ifvAerialAttackRange = ifvAerialAttackRange;
            this.ifvGroundDamage = ifvGroundDamage;
            this.ifvAerialDamage = ifvAerialDamage;
            this.ifvGroundDefence = ifvGroundDefence;
            this.ifvAerialDefence = ifvAerialDefence;
            this.ifvAttackCooldownTicks = ifvAttackCooldownTicks;
            this.ifvProductionCost = ifvProductionCost;
            this.arrvDurability = arrvDurability;
            this.arrvSpeed = arrvSpeed;
            this.arrvVisionRange = arrvVisionRange;
            this.arrvGroundDefence = arrvGroundDefence;
            this.arrvAerialDefence = arrvAerialDefence;
            this.arrvProductionCost = arrvProductionCost;
            this.arrvRepairRange = arrvRepairRange;
            this.arrvRepairSpeed = arrvRepairSpeed;
            this.helicopterDurability = helicopterDurability;
            this.helicopterSpeed = helicopterSpeed;
            this.helicopterVisionRange = helicopterVisionRange;
            this.helicopterGroundAttackRange = helicopterGroundAttackRange;
            this.helicopterAerialAttackRange = helicopterAerialAttackRange;
            this.helicopterGroundDamage = helicopterGroundDamage;
            this.helicopterAerialDamage = helicopterAerialDamage;
            this.helicopterGroundDefence = helicopterGroundDefence;
            this.helicopterAerialDefence = helicopterAerialDefence;
            this.helicopterAttackCooldownTicks = helicopterAttackCooldownTicks;
            this.helicopterProductionCost = helicopterProductionCost;
            this.fighterDurability = fighterDurability;
            this.fighterSpeed = fighterSpeed;
            this.fighterVisionRange = fighterVisionRange;
            this.fighterGroundAttackRange = fighterGroundAttackRange;
            this.fighterAerialAttackRange = fighterAerialAttackRange;
            this.fighterGroundDamage = fighterGroundDamage;
            this.fighterAerialDamage = fighterAerialDamage;
            this.fighterGroundDefence = fighterGroundDefence;
            this.fighterAerialDefence = fighterAerialDefence;
            this.fighterAttackCooldownTicks = fighterAttackCooldownTicks;
            this.fighterProductionCost = fighterProductionCost;
            this.maxFacilityCapturePoints = maxFacilityCapturePoints;
            this.facilityCapturePointsPerVehiclePerTick = facilityCapturePointsPerVehiclePerTick;
            this.facilityWidth = facilityWidth;
            this.facilityHeight = facilityHeight;
        }

        public long RandomSeed => randomSeed;

        /// <summary>
        /// ���������� ����� �� ����
        /// </summary>
        public int TickCount => tickCount;

        /// <summary>
        /// ������ ����
        /// </summary>
        public double WorldWidth => worldWidth;

        /// <summary>
        /// ������ ����
        /// </summary>
        public double WorldHeight => worldHeight;

        /// <summary>
        /// ������� ������ �����
        /// </summary>
        public bool IsFogOfWarEnabled => isFogOfWarEnabled;

        /// <summary>
        /// ���������� ������ �� ������
        /// </summary>
        public int VictoryScore => victoryScore;

        /// <summary>
        /// ���������� ������ �� ������ ����������
        /// </summary>
        public int FacilityCaptureScore => facilityCaptureScore;

        /// <summary>
        /// ���������� ������ �� ����������� �����
        /// </summary>
        public int VehicleEliminationScore => vehicleEliminationScore;

        /// <summary>
        /// ��������, ����������� � ����������� ���������� ��������
        /// </summary>
        public int ActionDetectionInterval => actionDetectionInterval;

        /// <summary>
        /// ���������� �������� �� ActionDetectionInterval
        /// </summary>
        public int BaseActionCount => baseActionCount;

        /// <summary>
        /// �������������� ���������� ��������
        /// </summary>
        public int AdditionalActionCountPerControlCenter => additionalActionCountPerControlCenter;

        /// <summary>
        /// ����������� ��������� ������ ����� ������
        /// </summary>
        public int MaxUnitGroup => maxUnitGroup;

        /// <summary>
        /// ���������� �������� � ������ ��������� � ������
        /// </summary>
        public int TerrainWeatherMapColumnCount => terrainWeatherMapColumnCount;

        /// <summary>
        /// ���������� ����� � ������ ��������� � ������
        /// </summary>
        public int TerrainWeatherMapRowCount => terrainWeatherMapRowCount;

        /// <summary>
        /// ����������� ��������� �� �������
        /// </summary>
        public double PlainTerrainVisionFactor => plainTerrainVisionFactor;

        /// <summary>
        /// ����������� ���������� �� �������
        /// </summary>
        public double PlainTerrainStealthFactor => plainTerrainStealthFactor;

        /// <summary>
        /// ����������� �������� �� �������
        /// </summary>
        public double PlainTerrainSpeedFactor => plainTerrainSpeedFactor;

        /// <summary>
        /// ����������� ��������� �� ������
        /// </summary>
        public double SwampTerrainVisionFactor => swampTerrainVisionFactor;

        /// <summary>
        /// ����������� ���������� �� ������
        /// </summary>
        public double SwampTerrainStealthFactor => swampTerrainStealthFactor;

        /// <summary>
        /// ����������� �������� �� ������
        /// </summary>
        public double SwampTerrainSpeedFactor => swampTerrainSpeedFactor;

        /// <summary>
        /// ����������� ��������� � ����
        /// </summary>
        public double ForestTerrainVisionFactor => forestTerrainVisionFactor;

        /// <summary>
        /// ����������� ���������� � ����
        /// </summary>
        public double ForestTerrainStealthFactor => forestTerrainStealthFactor;

        /// <summary>
        /// ����������� �������� � ����
        /// </summary>
        public double ForestTerrainSpeedFactor => forestTerrainSpeedFactor;

        /// <summary>
        /// ����������� ��������� ������ ��� ����� ������
        /// </summary>
        public double ClearWeatherVisionFactor => clearWeatherVisionFactor;

        /// <summary>
        /// ����������� ������������ ��� ����� ������
        /// </summary>
        public double ClearWeatherStealthFactor => clearWeatherStealthFactor;

        /// <summary>
        /// ����������� �������� ��� ����� ������
        /// </summary>
        public double ClearWeatherSpeedFactor => clearWeatherSpeedFactor;

        /// <summary>
        /// ����������� ��������� ������ ��� �������� ������
        /// </summary>
        public double CloudWeatherVisionFactor => cloudWeatherVisionFactor;

        /// <summary>
        /// ����������� ������������ ��� �������� ������
        /// </summary>
        public double CloudWeatherStealthFactor => cloudWeatherStealthFactor;

        /// <summary>
        /// ����������� �������� ��� �������� ������
        /// </summary>
        public double CloudWeatherSpeedFactor => cloudWeatherSpeedFactor;

        /// <summary>
        /// ����������� ��������� ��� ��������� ������
        /// </summary>
        public double RainWeatherVisionFactor => rainWeatherVisionFactor;

        /// <summary>
        /// ����������� ������������ ��� ��������� ������
        /// </summary>
        public double RainWeatherStealthFactor => rainWeatherStealthFactor;

        /// <summary>
        /// ����������� �������� ��� ��������� ������
        /// </summary>
        public double RainWeatherSpeedFactor => rainWeatherSpeedFactor;

        /// <summary>
        /// ������ �������
        /// </summary>
        public double VehicleRadius => vehicleRadius;

        /// <summary>
        /// ��������� �����
        /// </summary>
        public int TankDurability => tankDurability;

        /// <summary>
        /// �������� �����
        /// </summary>
        public double TankSpeed => tankSpeed;

        /// <summary>
        /// ��������� ������ �����
        /// </summary>
        public double TankVisionRange => tankVisionRange;

        /// <summary>
        /// ��������� ����� ����� �� �������� ������
        /// </summary>
        public double TankGroundAttackRange => tankGroundAttackRange;

        /// <summary>
        /// ��������� ����� ����� �� ��������� ������
        /// </summary>
        public double TankAerialAttackRange => tankAerialAttackRange;

        /// <summary>
        /// ���� ����� �� �������� ������
        /// </summary>
        public int TankGroundDamage => tankGroundDamage;

        /// <summary>
        /// ���� ����� �� ��������� ������
        /// </summary>
        public int TankAerialDamage => tankAerialDamage;

        /// <summary>
        /// ������ ����� �� �������� ����
        /// </summary>
        public int TankGroundDefence => tankGroundDefence;

        /// <summary>
        /// ������ ����� �� ��������� ����
        /// </summary>
        public int TankAerialDefence => tankAerialDefence;

        /// <summary>
        /// �������� ����� ������� �����
        /// </summary>
        public int TankAttackCooldownTicks => tankAttackCooldownTicks;

        /// <summary>
        /// ����� ������������ �����
        /// </summary>
        public int TankProductionCost => tankProductionCost;

        /// <summary>
        /// ��������� ���
        /// </summary>
        public int IfvDurability => ifvDurability;

        /// <summary>
        /// �������� ���
        /// </summary>
        public double IfvSpeed => ifvSpeed;

        /// <summary>
        /// ��������� ������ ���
        /// </summary>
        public double IfvVisionRange => ifvVisionRange;

        /// <summary>
        /// ��������� ����� ��� �� �������� �����
        /// </summary>
        public double IfvGroundAttackRange => ifvGroundAttackRange;

        /// <summary>
        /// ��������� ����� ��� �� ��������� �����
        /// </summary>
        public double IfvAerialAttackRange => ifvAerialAttackRange;

        /// <summary>
        /// ���� ��� �� �������� �����
        /// </summary>
        public int IfvGroundDamage => ifvGroundDamage;

        /// <summary>
        /// ���� ��� �� ��������� �����
        /// </summary>
        public int IfvAerialDamage => ifvAerialDamage;

        /// <summary>
        /// ������ ��� �� �������� ����
        /// </summary>
        public int IfvGroundDefence => ifvGroundDefence;

        /// <summary>
        /// ������ ��� �� ��������� ����
        /// </summary>
        public int IfvAerialDefence => ifvAerialDefence;

        /// <summary>
        /// �������� ����� ������� ���
        /// </summary>
        public int IfvAttackCooldownTicks => ifvAttackCooldownTicks;

        /// <summary>
        /// ����� ������������ ���
        /// </summary>
        public int IfvProductionCost => ifvProductionCost;

        /// <summary>
        /// ��������� ����
        /// </summary>
        public int ArrvDurability => arrvDurability;

        /// <summary>
        /// �������� �������� ����
        /// </summary>
        public double ArrvSpeed => arrvSpeed;

        /// <summary>
        /// ��������� ��������� ����
        /// </summary>
        public double ArrvVisionRange => arrvVisionRange;

        /// <summary>
        /// ������ ���� �� �������� �������
        /// </summary>
        public int ArrvGroundDefence => arrvGroundDefence;
        /// <summary>
        /// ������ ���� �� ��������� �������
        /// </summary>
        public int ArrvAerialDefence => arrvAerialDefence;

        /// <summary>
        /// ���������� ����� ��� ������������ ����
        /// </summary>
        public int ArrvProductionCost => arrvProductionCost;

        /// <summary>
        /// ������������ ���������� ������� ����
        /// </summary>
        public double ArrvRepairRange => arrvRepairRange;

        /// <summary>
        /// ����������� ����������������� ���� ��������� �� ���
        /// </summary>
        public double ArrvRepairSpeed => arrvRepairSpeed;

        /// <summary>
        /// ��������� ���������
        /// </summary>
        public int HelicopterDurability => helicopterDurability;

        /// <summary>
        /// �������� ���������
        /// </summary>
        public double HelicopterSpeed => helicopterSpeed;

        /// <summary>
        /// ��������� ������ ���������
        /// </summary>
        public double HelicopterVisionRange => helicopterVisionRange;

        /// <summary>
        /// ��������� ����� ��������� �� �������� �����
        /// </summary>
        public double HelicopterGroundAttackRange => helicopterGroundAttackRange;

        /// <summary>
        /// ��������� ����� ��������� �� ��������� �����
        /// </summary>
        public double HelicopterAerialAttackRange => helicopterAerialAttackRange;

        /// <summary>
        /// ���� ��������� �� �������� �����
        /// </summary>
        public int HelicopterGroundDamage => helicopterGroundDamage;

        /// <summary>
        /// ���� ��������� �� ��������� �����
        /// </summary>
        public int HelicopterAerialDamage => helicopterAerialDamage;

        /// <summary>
        /// ������ ��������� �� �������� ����
        /// </summary>
        public int HelicopterGroundDefence => helicopterGroundDefence;

        /// <summary>
        /// ������ ��������� �� ��������� ����
        /// </summary>
        public int HelicopterAerialDefence => helicopterAerialDefence;

        /// <summary>
        /// �������� ����� ������� ���������
        /// </summary>
        public int HelicopterAttackCooldownTicks => helicopterAttackCooldownTicks;

        /// <summary>
        /// ����� ������������ ���������
        /// </summary>
        public int HelicopterProductionCost => helicopterProductionCost;

        /// <summary>
        /// ��������� �����������
        /// </summary>
        public int FighterDurability => fighterDurability;

        /// <summary>
        /// �������� �����������
        /// </summary>
        public double FighterSpeed => fighterSpeed;

        /// <summary>
        /// ��������� ������ �����������
        /// </summary>
        public double FighterVisionRange => fighterVisionRange;

        /// <summary>
        /// ��������� ����� ����������� �� �������� �����
        /// </summary>
        public double FighterGroundAttackRange => fighterGroundAttackRange;

        /// <summary>
        /// ��������� ����� ����������� �� ��������� �����
        /// </summary>
        public double FighterAerialAttackRange => fighterAerialAttackRange;

        /// <summary>
        /// ���� ����������� �� �������� �����
        /// </summary>
        public int FighterGroundDamage => fighterGroundDamage;

        /// <summary>
        /// ���� ����������� �� ��������� �����
        /// </summary>
        public int FighterAerialDamage => fighterAerialDamage;

        /// <summary>
        /// ������ ����������� �� �������� ����
        /// </summary>
        public int FighterGroundDefence => fighterGroundDefence;

        /// <summary>
        /// ������ ����������� �� ��������� ����
        /// </summary>
        public int FighterAerialDefence => fighterAerialDefence;

        /// <summary>
        /// �������� ����� ���� �����������
        /// </summary>
        public int FighterAttackCooldownTicks => fighterAttackCooldownTicks;

        /// <summary>
        /// ����� ������������ �����������
        /// </summary>
        public int FighterProductionCost => fighterProductionCost;

        /// <summary>
        /// ���������� ����� ��� ������� ����������
        /// </summary>
        public double MaxFacilityCapturePoints => maxFacilityCapturePoints;

        /// <summary>
        /// �������� ������� �� ��� ��� ������ ������� ������� ������ ������
        /// </summary>
        public double FacilityCapturePointsPerVehiclePerTick => facilityCapturePointsPerVehiclePerTick;

        /// <summary>
        /// ������ ����������
        /// </summary>
        public double FacilityWidth => facilityWidth;

        /// <summary>
        /// ������ ����������
        /// </summary>
        public double FacilityHeight => facilityHeight;
    }
}