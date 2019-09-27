namespace EquipmentInventory.Shared
{
    public class EquipmentDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float? Distance { get; set; }

        public float? MaintainanceCost { get; set; }
    }
}
