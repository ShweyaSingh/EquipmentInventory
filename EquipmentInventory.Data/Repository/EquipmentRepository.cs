using AutoMapper;
using EquipmentInventory.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentInventory.Data
{
    public class EquipmentRepository : IEquipmentRepository
    {
        public List<EquipmentDTO> GetAllEquipments()
        {
            List<EquipmentDTO> equipmentDTOs = new List<EquipmentDTO>();
            try
            {
                using (var dbContext = new EquipmentInventoryDBEntities())
                {
                    var equipments = dbContext.Equipments.ToList();
                    equipmentDTOs = Mapper.Map<List<Equipment>, List<EquipmentDTO>>(equipments);
                }
            }
            catch (Exception e)
            {
                equipmentDTOs = null;
                Console.WriteLine(e.Message);
            }
            return equipmentDTOs;
        }

        //public EquipmentDTO GetEquipment(int equipmentid)
        //{
        //    EquipmentDTO equipmentDTO = null;
        //    using (var dbcontext = new EquipmentInventoryEntities())
        //    {
        //        var equipment = dbcontext.equipments.Where(e => e.EID == equipmentid).FirstOrDefault();
        //        if (equipment != null)
        //        {
        //            equipmentDTO = AutoMapper.Mapper.Map<equipment, EquipmentDTO>(equipment);
        //        }
        //    }
        //    return equipmentDTO;
        //}

        //public int InsertEquipment(EquipmentDTO equipmentDTO)
        //{
        //    using (var dbcontext = new EquipmentInventoryEntities())
        //    {
        //        var equipment = AutoMapper.Mapper.Map<EquipmentDTO, equipment>(equipmentDTO);
        //        dbcontext.equipments.Add(equipment);
        //        dbcontext.SaveChanges();
        //    }
        //    return equipmentDTO.EID;
        //}

        //public int UpdateEquipment(EquipmentDTO equipmentDTO)
        //{
        //    using (var dbcontext = new EquipmentInventoryEntities())
        //    {
        //        var equipment = AutoMapper.Mapper.Map<EquipmentDTO, equipment>(equipmentDTO);
        //        dbcontext.equipments.Add(equipment);
        //        dbcontext.SaveChanges();
        //    }
        //    return equipmentDTO.EID;
        //}

        //public bool DeleteEquipment(int equipmentid)
        //{
        //    bool equipmentDeleted = false;
        //    using (var dbcontext = new EquipmentInventoryEntities())
        //    {
        //        var equipment = dbcontext.equipments.Where(e => e.EID == equipmentid).FirstOrDefault();
        //        if (equipment != null)
        //        {
        //            equipmentDeleted = true;
        //            dbcontext.equipments.Remove(equipment);
        //            dbcontext.SaveChanges();
        //        }
        //    }
        //    return equipmentDeleted;
        //}
    }
}
