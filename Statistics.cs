using Com.CodeGame.CodeWars2017.DevKit.CSharpCgdk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.CodeGame.CodeWars2017.DevKit.CSharpCgdk
{
    public class Statistics : IStatistics
    {
        World _world;

        public Statistics()
        {
            DamagedVehicles = new List<Vehicle>();
            AllVehicles = new Dictionary<long, Vehicle>();
        }

        public void Recount(World worldState)
        {
            _world = worldState;

            //throw new NotImplementedException();
        }

        public List<Vehicle> DamagedVehicles { get; set; }

        public Dictionary<long, Vehicle> AllVehicles { get; set; }

        public List<Vehicle> InvolvedVehicles { get; set; }

        void RecountInvolvedVehicles()
        {
            InvolvedVehicles = new List<Vehicle>();
            if (AllVehicles.Count == 0)
                return;
            foreach(var vehU in _world.VehicleUpdates)
            {
                
                if (AllVehicles.ContainsKey(vehU.Id))
                {
                    AllVehicles[vehU.Id] = new Vehicle(AllVehicles[vehU.Id], vehU);
                    InvolvedVehicles.Add(AllVehicles[vehU.Id]);
                }
            }
        }

        void RecountAllVehicles()
        {
            foreach (var vehI in InvolvedVehicles)
                if (vehI.Durability <= 0)
                    AllVehicles.Remove(vehI.Id);
            foreach (var vehN in _world.NewVehicles)
                AllVehicles[vehN.Id] = vehN;
        }

        void RecountDamagedVehicles()
        {
            //DamagedVehicles.RemoveAll(v => v.Durability == v.MaxDurability);
            foreach (var veh in _world.VehicleUpdates)
            {
                //new Vehicle()
            }
        }
    }
}
