using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.Model
{
    public class ObjectEvalution
    {
        public int Id { get; set; }
        public string View { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public int IndexAddress { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string NumberHouse { get; set; }
        public int NumberRoom { get; set; }
        public string CadasterNumber { get; set; }
        public int CadasterPrice { get; set; }
        public int CarryingAmount { get; set; }
        public int YearConstraction { get; set; }
        public string ExternalMaterial { get; set; }
        public int PhysicalDeterioration { get; set; }
        public int Floors { get; set; }
        public string MaterialOverlaps { get; set; }
        public string DescriptionOverlaps { get; set; }
        public string TypeBuilding { get; set; }
        public string Electrosupply { get; set; }
        public string ColdWaterSupply { get; set; }
        public string HotWaterSupply { get; set; }
        public string Heating { get; set; }
        public string GasSupply { get; set; }
        public string Sewerage { get; set; }
        public string WallsMaterial { get; set; }
        public string DescriptionWalls { get; set; }
        public string FloorMaterial { get; set; }
        public string DescriptionFloor { get; set; }
        public string CeilingMaterial { get; set; }
        public string DescriptionCeiling { get; set; }
        public string DoorMaterial { get; set; }
        public string DescriptionDoor { get; set; }
        public string WindowMaterial { get; set; }
        public string DescriptionWindow { get; set; }
        public int AreaFull { get; set; }
        public int AreaSummer { get; set; }
        public int AreaLiving { get; set; }
        public int AreaKitchen { get; set; }
        public int CeilingHeight { get; set; }
        public int FloorPlacement { get; set; }
        public string PropertyRight { get; set; }
        public string DescriptionPropertyRight { get; set; }
        public int ShareRoom { get; set; }
        public string Encumbrance { get; set; }
        public string DescriptionEncumbrance { get; set; }
        public string CurrentUse { get; set; }
        public string InteriorDecoration { get; set; }
        public string CommunicationSystem { get; set; }
        public string CommunicationСonnecting { get; set; }
        public bool SpontaneousParking { get; set; }
        public bool OrganizedParking { get; set; }
        public bool UndergroundParking { get; set; }
        public bool FencedTerritory { get; set; }
        public bool AsphaltCovering { get; set; }
        public bool CheckPoint { get; set; }
        public bool FencedSecurityTerritory { get; set; }
        public bool Playground { get; set; }
        public bool RailwayEnd { get; set; }
        public bool Elevator { get; set; }
        public bool GarbageChute { get; set; }
        public bool PrivateEntrance { get; set; }
        public bool Cargo { get; set; }
        public bool Fridge { get; set; }
        public enum TypeRoom { StudioRoom,  OneRoom, TwoRoom, ThreeRoom, FourRoom, FiveRoom, MultiRoom }
        public bool Renovation { get; set; }
        public bool Conclusion { get; set; }
        public bool Usage { get; set; }
    }
}
