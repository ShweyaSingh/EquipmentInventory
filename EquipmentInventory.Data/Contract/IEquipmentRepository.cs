using EquipmentInventory.Shared;
using System.Collections.Generic;

namespace EquipmentInventory.Data
{
    public interface IEquipmentRepository
    {
        List<EquipmentDTO> GetAllEquipments();
        //EquipmentDTO GetEquipment(int equipmentid);
        //int InsertEquipment(EquipmentDTO equipmentDTO);
        //int UpdateEquipment(EquipmentDTO equipmentDTO);
        //bool DeleteEquipment(int equipmentid);
    }
}
