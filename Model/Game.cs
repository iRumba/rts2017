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
        /// Количество тиков на игру
        /// </summary>
        public int TickCount => tickCount;

        /// <summary>
        /// Ширина мира
        /// </summary>
        public double WorldWidth => worldWidth;

        /// <summary>
        /// Высота мира
        /// </summary>
        public double WorldHeight => worldHeight;

        /// <summary>
        /// Наличие тумана войны
        /// </summary>
        public bool IsFogOfWarEnabled => isFogOfWarEnabled;

        /// <summary>
        /// Количество баллов за победу
        /// </summary>
        public int VictoryScore => victoryScore;

        /// <summary>
        /// количество баллов за захват сооружения
        /// </summary>
        public int FacilityCaptureScore => facilityCaptureScore;

        /// <summary>
        /// Количество баллов за уничтожение юнита
        /// </summary>
        public int VehicleEliminationScore => vehicleEliminationScore;

        /// <summary>
        /// Интервал, учитываемый в ограничении количества действий
        /// </summary>
        public int ActionDetectionInterval => actionDetectionInterval;

        /// <summary>
        /// Количество действия за ActionDetectionInterval
        /// </summary>
        public int BaseActionCount => baseActionCount;

        /// <summary>
        /// Дополнительное количество действий
        /// </summary>
        public int AdditionalActionCountPerControlCenter => additionalActionCountPerControlCenter;

        /// <summary>
        /// Максимально возможный индекс групы юнитов
        /// </summary>
        public int MaxUnitGroup => maxUnitGroup;

        /// <summary>
        /// Количество столбцов в картах местности и погоды
        /// </summary>
        public int TerrainWeatherMapColumnCount => terrainWeatherMapColumnCount;

        /// <summary>
        /// Количество строк в картах местности и погоды
        /// </summary>
        public int TerrainWeatherMapRowCount => terrainWeatherMapRowCount;

        /// <summary>
        /// Коэффициент видимости на равнине
        /// </summary>
        public double PlainTerrainVisionFactor => plainTerrainVisionFactor;

        /// <summary>
        /// Коэффициент скрытности на равнине
        /// </summary>
        public double PlainTerrainStealthFactor => plainTerrainStealthFactor;

        /// <summary>
        /// Коэффициент скорости на равнине
        /// </summary>
        public double PlainTerrainSpeedFactor => plainTerrainSpeedFactor;

        /// <summary>
        /// Коэффициент видимости на болоте
        /// </summary>
        public double SwampTerrainVisionFactor => swampTerrainVisionFactor;

        /// <summary>
        /// Коэффициент скрытности на болоте
        /// </summary>
        public double SwampTerrainStealthFactor => swampTerrainStealthFactor;

        /// <summary>
        /// Коэффициент скорости на болоте
        /// </summary>
        public double SwampTerrainSpeedFactor => swampTerrainSpeedFactor;

        /// <summary>
        /// Коэффициент видимости в лесу
        /// </summary>
        public double ForestTerrainVisionFactor => forestTerrainVisionFactor;

        /// <summary>
        /// Коэффициент скрытности в лесу
        /// </summary>
        public double ForestTerrainStealthFactor => forestTerrainStealthFactor;

        /// <summary>
        /// Коэффициент скоросте в лесу
        /// </summary>
        public double ForestTerrainSpeedFactor => forestTerrainSpeedFactor;

        /// <summary>
        /// Коэффициент дальности обзора при ясной погоде
        /// </summary>
        public double ClearWeatherVisionFactor => clearWeatherVisionFactor;

        /// <summary>
        /// Коэффициент незаметности при ясной погоде
        /// </summary>
        public double ClearWeatherStealthFactor => clearWeatherStealthFactor;

        /// <summary>
        /// Коэффициент скорости при ясной погоде
        /// </summary>
        public double ClearWeatherSpeedFactor => clearWeatherSpeedFactor;

        /// <summary>
        /// Коэффициент дальности обзора при облачной погоде
        /// </summary>
        public double CloudWeatherVisionFactor => cloudWeatherVisionFactor;

        /// <summary>
        /// Коэффициент незаметности при облачной погоде
        /// </summary>
        public double CloudWeatherStealthFactor => cloudWeatherStealthFactor;

        /// <summary>
        /// Коэффициент скорости при облачной погоде
        /// </summary>
        public double CloudWeatherSpeedFactor => cloudWeatherSpeedFactor;

        /// <summary>
        /// Коэффициент видимости при дождливой погоде
        /// </summary>
        public double RainWeatherVisionFactor => rainWeatherVisionFactor;

        /// <summary>
        /// Коэффициент незаметности при дождливой погоде
        /// </summary>
        public double RainWeatherStealthFactor => rainWeatherStealthFactor;

        /// <summary>
        /// Коэффициент скорости при дождливой погоде
        /// </summary>
        public double RainWeatherSpeedFactor => rainWeatherSpeedFactor;

        /// <summary>
        /// Радиус техники
        /// </summary>
        public double VehicleRadius => vehicleRadius;

        /// <summary>
        /// Прочность танка
        /// </summary>
        public int TankDurability => tankDurability;

        /// <summary>
        /// Скорость танка
        /// </summary>
        public double TankSpeed => tankSpeed;

        /// <summary>
        /// Дальность обзора танка
        /// </summary>
        public double TankVisionRange => tankVisionRange;

        /// <summary>
        /// Дальность атаки танка по наземным юнитам
        /// </summary>
        public double TankGroundAttackRange => tankGroundAttackRange;

        /// <summary>
        /// Дальность атаки танка по воздушным юнитам
        /// </summary>
        public double TankAerialAttackRange => tankAerialAttackRange;

        /// <summary>
        /// Урон танка по наземным юнитам
        /// </summary>
        public int TankGroundDamage => tankGroundDamage;

        /// <summary>
        /// урон танка по воздушным юнитам
        /// </summary>
        public int TankAerialDamage => tankAerialDamage;

        /// <summary>
        /// Защита танка от наземных атак
        /// </summary>
        public int TankGroundDefence => tankGroundDefence;

        /// <summary>
        /// Защита танка от воздушных атак
        /// </summary>
        public int TankAerialDefence => tankAerialDefence;

        /// <summary>
        /// Интервал между атаками танка
        /// </summary>
        public int TankAttackCooldownTicks => tankAttackCooldownTicks;

        /// <summary>
        /// Время производства танка
        /// </summary>
        public int TankProductionCost => tankProductionCost;

        /// <summary>
        /// Прочность БМП
        /// </summary>
        public int IfvDurability => ifvDurability;

        /// <summary>
        /// Скорость БМП
        /// </summary>
        public double IfvSpeed => ifvSpeed;

        /// <summary>
        /// Дальность обзора БМП
        /// </summary>
        public double IfvVisionRange => ifvVisionRange;

        /// <summary>
        /// Дальность атаки БМП по наземным целям
        /// </summary>
        public double IfvGroundAttackRange => ifvGroundAttackRange;

        /// <summary>
        /// Дальность атаки БМП по воздушным целям
        /// </summary>
        public double IfvAerialAttackRange => ifvAerialAttackRange;

        /// <summary>
        /// Урон БМП по наземным целям
        /// </summary>
        public int IfvGroundDamage => ifvGroundDamage;

        /// <summary>
        /// Урон БМП по воздушным целям
        /// </summary>
        public int IfvAerialDamage => ifvAerialDamage;

        /// <summary>
        /// Защита БМП от наземных атак
        /// </summary>
        public int IfvGroundDefence => ifvGroundDefence;

        /// <summary>
        /// Защита БМП от воздушных атак
        /// </summary>
        public int IfvAerialDefence => ifvAerialDefence;

        /// <summary>
        /// Интервал между атаками БМП
        /// </summary>
        public int IfvAttackCooldownTicks => ifvAttackCooldownTicks;

        /// <summary>
        /// Время производства БМП
        /// </summary>
        public int IfvProductionCost => ifvProductionCost;

        /// <summary>
        /// Прочность БРЭМ
        /// </summary>
        public int ArrvDurability => arrvDurability;

        /// <summary>
        /// Скорость движения БРЭМ
        /// </summary>
        public double ArrvSpeed => arrvSpeed;

        /// <summary>
        /// Дальность видимости БРЭМ
        /// </summary>
        public double ArrvVisionRange => arrvVisionRange;

        /// <summary>
        /// Защита БРЭМ от наземной техники
        /// </summary>
        public int ArrvGroundDefence => arrvGroundDefence;
        /// <summary>
        /// Защита БРЭМ от воздушной техники
        /// </summary>
        public int ArrvAerialDefence => arrvAerialDefence;

        /// <summary>
        /// Количество тиков для производства БРЭМ
        /// </summary>
        public int ArrvProductionCost => arrvProductionCost;

        /// <summary>
        /// Максимальное расстояние ремонта БРЭМ
        /// </summary>
        public double ArrvRepairRange => arrvRepairRange;

        /// <summary>
        /// Колличество восстанавливаемой БРЭМ прочности на тик
        /// </summary>
        public double ArrvRepairSpeed => arrvRepairSpeed;

        /// <summary>
        /// Прочность вертолета
        /// </summary>
        public int HelicopterDurability => helicopterDurability;

        /// <summary>
        /// Скорость вертолета
        /// </summary>
        public double HelicopterSpeed => helicopterSpeed;

        /// <summary>
        /// Дальность обзора вертолета
        /// </summary>
        public double HelicopterVisionRange => helicopterVisionRange;

        /// <summary>
        /// Дальность атаки вертолета по наземным целям
        /// </summary>
        public double HelicopterGroundAttackRange => helicopterGroundAttackRange;

        /// <summary>
        /// Дальность атаки вертолета по воздушным целям
        /// </summary>
        public double HelicopterAerialAttackRange => helicopterAerialAttackRange;

        /// <summary>
        /// Урон вертолета по наземным целям
        /// </summary>
        public int HelicopterGroundDamage => helicopterGroundDamage;

        /// <summary>
        /// Урон вертолета по воздушным целям
        /// </summary>
        public int HelicopterAerialDamage => helicopterAerialDamage;

        /// <summary>
        /// Защита вертолета от наземных атак
        /// </summary>
        public int HelicopterGroundDefence => helicopterGroundDefence;

        /// <summary>
        /// Защита вертолета от воздушных атак
        /// </summary>
        public int HelicopterAerialDefence => helicopterAerialDefence;

        /// <summary>
        /// Интревал между атаками вертолета
        /// </summary>
        public int HelicopterAttackCooldownTicks => helicopterAttackCooldownTicks;

        /// <summary>
        /// Время производства вертолета
        /// </summary>
        public int HelicopterProductionCost => helicopterProductionCost;

        /// <summary>
        /// Прочность истребителя
        /// </summary>
        public int FighterDurability => fighterDurability;

        /// <summary>
        /// Скорость истребителя
        /// </summary>
        public double FighterSpeed => fighterSpeed;

        /// <summary>
        /// Дальность обзора истребителя
        /// </summary>
        public double FighterVisionRange => fighterVisionRange;

        /// <summary>
        /// Дальность атаки истребителя по наземным целям
        /// </summary>
        public double FighterGroundAttackRange => fighterGroundAttackRange;

        /// <summary>
        /// Дальность атаки истребителя по воздушным целям
        /// </summary>
        public double FighterAerialAttackRange => fighterAerialAttackRange;

        /// <summary>
        /// Урон истребителя по наземным целям
        /// </summary>
        public int FighterGroundDamage => fighterGroundDamage;

        /// <summary>
        /// Урон истребителя по воздушным целям
        /// </summary>
        public int FighterAerialDamage => fighterAerialDamage;

        /// <summary>
        /// Защита истребителя от наземных атак
        /// </summary>
        public int FighterGroundDefence => fighterGroundDefence;

        /// <summary>
        /// Защита истребителя от воздушных атак
        /// </summary>
        public int FighterAerialDefence => fighterAerialDefence;

        /// <summary>
        /// Интервал между атак истребителя
        /// </summary>
        public int FighterAttackCooldownTicks => fighterAttackCooldownTicks;

        /// <summary>
        /// Время производства истребителя
        /// </summary>
        public int FighterProductionCost => fighterProductionCost;

        /// <summary>
        /// Количество очков для захвата сооружения
        /// </summary>
        public double MaxFacilityCapturePoints => maxFacilityCapturePoints;

        /// <summary>
        /// Скорость захвата за тик для каждой единицы техники внутри здания
        /// </summary>
        public double FacilityCapturePointsPerVehiclePerTick => facilityCapturePointsPerVehiclePerTick;

        /// <summary>
        /// Ширина сооружения
        /// </summary>
        public double FacilityWidth => facilityWidth;

        /// <summary>
        /// Высота сооружения
        /// </summary>
        public double FacilityHeight => facilityHeight;
    }
}