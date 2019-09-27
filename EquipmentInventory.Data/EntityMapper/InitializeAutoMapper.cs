using AutoMapper;
using EquipmentInventory.Shared;

namespace EquipmentInventory.Data
{
    public class InitializeAutoMapper
    {
        public void InitializeMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Equipment, EquipmentDTO>()
                .ForMember(dto => dto.Id, map => map.MapFrom(model => model.Id))
                .ForMember(dto => dto.Name, map => map.MapFrom(model => model.Name))
                .ForMember(dto => dto.Distance, map => map.MapFrom(model => model.Distance))
                .ForMember(dto => dto.MaintainanceCost, map => map.MapFrom(model => model.MaintenanceCost))
                .ForMember(dto => dto.Description, map => map.MapFrom(model => model.Description));

                cfg.CreateMap<EquipmentType, EquipmentTypeDTO>()
                .ForMember(dto => dto.Id, map => map.MapFrom(model => model.Id))
                .ForMember(model => model.IsMobile, map => map.MapFrom(dto => dto.IsMobile))
                .ForMember(model => model.Wheels, map => map.MapFrom(dto => dto.Wheels))
                .ForMember(model => model.Weight, map => map.MapFrom(dto => dto.Weight))
                .ForMember(model => model.EquipmentId, map => map.MapFrom(dto => dto.EquipmentId));
            });
        }
    }
}
