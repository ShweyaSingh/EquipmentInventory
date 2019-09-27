using EquipmentInventory.Data;
using EquipmentInventory.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentInventory.Business
{
    public class EquipmentLogic: IEquipmentLogic
    {
        private IEquipmentRepository _equipmentRepository;
        public EquipmentLogic(EquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }
        public List<EquipmentDTO> GetAllEquipments()
        {
           return _equipmentRepository.GetAllEquipments();
        }
    }
}
