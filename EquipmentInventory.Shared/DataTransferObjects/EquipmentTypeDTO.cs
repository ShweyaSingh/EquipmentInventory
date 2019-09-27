namespace EquipmentInventory.Shared
{
    public class EquipmentTypeDTO
    {
        public int Id { get; set; }
        public bool? IsMobile { get; set; }

        public int? Wheels { get; set; }

        public float? Weight { get; set; }

        public int? EquipmentId { get; set; }
    }
}
