using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Dtos;
using AutoMapper;
using Core.entities;


namespace Api.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles(){
            CreateMap<Cargo,CargoDto>().ReverseMap();
            CreateMap<Cliente,ClienteDto>().ReverseMap();
            CreateMap<Colores,ColorDto>().ReverseMap();
            CreateMap<DatalleOrden,DetalleOrdenDto>().ReverseMap();
            CreateMap<DetalleVenta,DetalleVentaDto>().ReverseMap();
            CreateMap<Empleado,EmpleadoDto>().ReverseMap();
            CreateMap<Empresa,EmpresaDto>().ReverseMap();
            CreateMap<Estado,EstadoDto>().ReverseMap();
            CreateMap<FormaPago,FormaPagoDto>().ReverseMap();
            CreateMap<Genero,GeneroDto>().ReverseMap();
            CreateMap<Insumo,InsumoDto>().ReverseMap();
            CreateMap<InsumoPrenda,InsumoPrendaDto>().ReverseMap();
            CreateMap<InsumoProveedor,InsumoProveedorDto>().ReverseMap();
            CreateMap<Inventario,InventarioDto>().ReverseMap();
            CreateMap<InventarioTalla,InventarioTallaDto>().ReverseMap();
            CreateMap<Municipio,MunicipioDto>().ReverseMap();
            CreateMap<Orden,OrdenDto>().ReverseMap();
            CreateMap<Prenda,PrendaDto>().ReverseMap();
            CreateMap<Talla,TallaDto>().ReverseMap();
            CreateMap<Pais,PaisDto>().ReverseMap();
            CreateMap<Proveedor,ProveedorDto>().ReverseMap();
            CreateMap<TipoEstado,TipoEstado>().ReverseMap();
            CreateMap<TipoPersona,TipoPersonaDto>().ReverseMap();
            CreateMap<TipoProteccion,TipoProteccionDto>().ReverseMap();
            CreateMap<Venta,VentasDto>().ReverseMap();
            CreateMap<Departamento,DepartamentoDto>().ReverseMap();
            CreateMap<Cargo,CargoDto>().ReverseMap();

        }
        
    }
}