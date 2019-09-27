using EquipmentInventory.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentInventory.Business
{
    public interface IEquipmentLogic
    {
        List<EquipmentDTO> GetAllEquipments();
    }
}
