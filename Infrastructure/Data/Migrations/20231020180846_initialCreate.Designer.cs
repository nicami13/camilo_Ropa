﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(RopaContext))]
    [Migration("20231020180846_initialCreate")]
    partial class initialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.entities.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<double>("SueldoBase")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("Core.entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecharegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCLiente")
                        .HasColumnType("int");

                    b.Property<int>("IdMunicipio")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersona")
                        .HasColumnType("int");

                    b.Property<int>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<int>("TipoPersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.HasIndex("TipoPersonaId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Core.entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Colores");
                });

            modelBuilder.Entity("Core.entities.DatalleOrden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CantidadProducida")
                        .HasColumnType("int");

                    b.Property<int>("CantidadProducir")
                        .HasColumnType("int");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<int?>("EstadoId")
                        .HasColumnType("int");

                    b.Property<int>("IdColor")
                        .HasColumnType("int");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.Property<int>("IdOrden")
                        .HasColumnType("int");

                    b.Property<int>("IdPrenda")
                        .HasColumnType("int");

                    b.Property<int?>("OrdenId")
                        .HasColumnType("int");

                    b.Property<int?>("PrendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("OrdenId");

                    b.HasIndex("PrendaId");

                    b.ToTable("DatalleOrdenes");
                });

            modelBuilder.Entity("Core.entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPais")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<int?>("PaisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("Core.entities.DetalleVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("IdTalla")
                        .HasColumnType("int");

                    b.Property<int>("IdVenta")
                        .HasColumnType("int");

                    b.Property<int?>("InventarioId")
                        .HasColumnType("int");

                    b.Property<int>("TallaId")
                        .HasColumnType("int");

                    b.Property<double>("ValorUnitario")
                        .HasColumnType("double");

                    b.Property<int?>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InventarioId");

                    b.HasIndex("TallaId");

                    b.HasIndex("VentaId");

                    b.ToTable("DetalleVentas");
                });

            modelBuilder.Entity("Core.entities.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CargoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCargo")
                        .HasColumnType("int");

                    b.Property<int>("IdEmp")
                        .HasColumnType("int");

                    b.Property<int>("IdMunicipio")
                        .HasColumnType("int");

                    b.Property<int?>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Core.entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdMunicipio")
                        .HasColumnType("int");

                    b.Property<int?>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<int?>("Nit")
                        .HasColumnType("int");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("longtext");

                    b.Property<string>("RepresentanteLegal")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Core.entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<int>("IdTipoEstado")
                        .HasColumnType("int");

                    b.Property<int>("TipoEstadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoEstadoId");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Core.entities.FormaPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("FormaPagos");
                });

            modelBuilder.Entity("Core.entities.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Core.entities.Insumo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<int>("StockMax")
                        .HasColumnType("int");

                    b.Property<int>("StockMin")
                        .HasColumnType("int");

                    b.Property<double>("ValorUnitario")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Insumos");
                });

            modelBuilder.Entity("Core.entities.InsumoPrenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdInsumo")
                        .HasColumnType("int");

                    b.Property<int>("IdPrenda")
                        .HasColumnType("int");

                    b.Property<int?>("InsumoId")
                        .HasColumnType("int");

                    b.Property<int?>("PrendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InsumoId");

                    b.HasIndex("PrendaId");

                    b.ToTable("InsumoPrendas");
                });

            modelBuilder.Entity("Core.entities.InsumoProveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdInsumo")
                        .HasColumnType("int");

                    b.Property<int>("IdProovedor")
                        .HasColumnType("int");

                    b.Property<int?>("InsumoId")
                        .HasColumnType("int");

                    b.Property<int?>("ProveedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InsumoId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("InsumoProveedores");
                });

            modelBuilder.Entity("Core.entities.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CodInv")
                        .HasColumnType("longtext");

                    b.Property<int>("IdPrenda")
                        .HasColumnType("int");

                    b.Property<int>("PrendaId")
                        .HasColumnType("int");

                    b.Property<double>("ValorVtaCop")
                        .HasColumnType("double");

                    b.Property<double>("ValorVtaUsd")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("PrendaId");

                    b.ToTable("Inventarios");
                });

            modelBuilder.Entity("Core.entities.InventarioTalla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdInventario")
                        .HasColumnType("int");

                    b.Property<int>("IdTalla")
                        .HasColumnType("int");

                    b.Property<int>("InventarioId")
                        .HasColumnType("int");

                    b.Property<int>("TallaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InventarioId");

                    b.HasIndex("TallaId");

                    b.ToTable("InventarioTallas");
                });

            modelBuilder.Entity("Core.entities.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamento")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("Core.entities.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<int?>("EstadoId")
                        .HasColumnType("int");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("Core.entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("Core.entities.Prenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("EstadoId")
                        .HasColumnType("int");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.Property<int>("IdGenero")
                        .HasColumnType("int");

                    b.Property<string>("IdPrenda")
                        .HasColumnType("longtext");

                    b.Property<int>("IdTipoProteccion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<int?>("TipoProteccionId")
                        .HasColumnType("int");

                    b.Property<double>("ValorUnitCop")
                        .HasColumnType("double");

                    b.Property<double>("ValorUnitUsd")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.HasIndex("GeneroId");

                    b.HasIndex("TipoProteccionId");

                    b.ToTable("Prendas");
                });

            modelBuilder.Entity("Core.entities.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdMunicipio")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersona")
                        .HasColumnType("int");

                    b.Property<int>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("NItProveedor")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<int?>("TipoPersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.HasIndex("TipoPersonaId");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Core.entities.Talla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tallas");
                });

            modelBuilder.Entity("Core.entities.TipoEstado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoEstados");
                });

            modelBuilder.Entity("Core.entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoPersonas");
                });

            modelBuilder.Entity("Core.entities.TipoProteccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoProtecciones");
                });

            modelBuilder.Entity("Core.entities.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FormaPagoId")
                        .HasColumnType("int");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IdFormaPago")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("FormaPagoId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Core.entities.Cliente", b =>
                {
                    b.HasOne("Core.entities.Municipio", "Municipio")
                        .WithMany("Clientes")
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.entities.TipoPersona", "TipoPersona")
                        .WithMany("Clientes")
                        .HasForeignKey("TipoPersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Core.entities.DatalleOrden", b =>
                {
                    b.HasOne("Core.entities.Color", "Color")
                        .WithMany("DatalleOrdenes")
                        .HasForeignKey("ColorId");

                    b.HasOne("Core.entities.Estado", "Estado")
                        .WithMany("DetalleOrdenes")
                        .HasForeignKey("EstadoId");

                    b.HasOne("Core.entities.Orden", "Orden")
                        .WithMany("DatalleOrdenes")
                        .HasForeignKey("OrdenId");

                    b.HasOne("Core.entities.Prenda", "Prenda")
                        .WithMany("DatalleOrdenes")
                        .HasForeignKey("PrendaId");

                    b.Navigation("Color");

                    b.Navigation("Estado");

                    b.Navigation("Orden");

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Core.entities.Departamento", b =>
                {
                    b.HasOne("Core.entities.Pais", "Pais")
                        .WithMany("Departamentos")
                        .HasForeignKey("PaisId");

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Core.entities.DetalleVenta", b =>
                {
                    b.HasOne("Core.entities.Inventario", "Inventario")
                        .WithMany("DetalleVentas")
                        .HasForeignKey("InventarioId");

                    b.HasOne("Core.entities.Talla", "Talla")
                        .WithMany("DetalleVentas")
                        .HasForeignKey("TallaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.entities.Venta", "Venta")
                        .WithMany("DetalleVentas")
                        .HasForeignKey("VentaId");

                    b.Navigation("Inventario");

                    b.Navigation("Talla");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("Core.entities.Empleado", b =>
                {
                    b.HasOne("Core.entities.Cargo", "Cargo")
                        .WithMany("Empleados")
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.entities.Municipio", "Municipio")
                        .WithMany("Empleados")
                        .HasForeignKey("MunicipioId");

                    b.Navigation("Cargo");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("Core.entities.Empresa", b =>
                {
                    b.HasOne("Core.entities.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioId");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("Core.entities.Estado", b =>
                {
                    b.HasOne("Core.entities.TipoEstado", "TipoEstado")
                        .WithMany("Estados")
                        .HasForeignKey("TipoEstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoEstado");
                });

            modelBuilder.Entity("Core.entities.InsumoPrenda", b =>
                {
                    b.HasOne("Core.entities.Insumo", "Insumo")
                        .WithMany("InsumoPrendas")
                        .HasForeignKey("InsumoId");

                    b.HasOne("Core.entities.Prenda", "Prenda")
                        .WithMany("InsumoPrendas")
                        .HasForeignKey("PrendaId");

                    b.Navigation("Insumo");

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Core.entities.InsumoProveedor", b =>
                {
                    b.HasOne("Core.entities.Insumo", "Insumo")
                        .WithMany("InsumoProveedores")
                        .HasForeignKey("InsumoId");

                    b.HasOne("Core.entities.Proveedor", "Proveedor")
                        .WithMany("InsumoProveedores")
                        .HasForeignKey("ProveedorId");

                    b.Navigation("Insumo");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Core.entities.Inventario", b =>
                {
                    b.HasOne("Core.entities.Prenda", "Prenda")
                        .WithMany("Inventarios")
                        .HasForeignKey("PrendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Core.entities.InventarioTalla", b =>
                {
                    b.HasOne("Core.entities.Inventario", "Inventario")
                        .WithMany("InventarioTallas")
                        .HasForeignKey("InventarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.entities.Talla", "Talla")
                        .WithMany("InventarioTallas")
                        .HasForeignKey("TallaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventario");

                    b.Navigation("Talla");
                });

            modelBuilder.Entity("Core.entities.Municipio", b =>
                {
                    b.HasOne("Core.entities.Departamento", "Departamento")
                        .WithMany("Municipios")
                        .HasForeignKey("DepartamentoId");

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Core.entities.Orden", b =>
                {
                    b.HasOne("Core.entities.Cliente", "Cliente")
                        .WithMany("Ordenes")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Core.entities.Empleado", "Empleado")
                        .WithMany("Ordenes")
                        .HasForeignKey("EmpleadoId");

                    b.HasOne("Core.entities.Estado", "Estado")
                        .WithMany("Ordenes")
                        .HasForeignKey("EstadoId");

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Core.entities.Prenda", b =>
                {
                    b.HasOne("Core.entities.Estado", "Estado")
                        .WithMany("Prendas")
                        .HasForeignKey("EstadoId");

                    b.HasOne("Core.entities.Genero", "Genero")
                        .WithMany("Prendas")
                        .HasForeignKey("GeneroId");

                    b.HasOne("Core.entities.TipoProteccion", "TipoProteccion")
                        .WithMany("Prendas")
                        .HasForeignKey("TipoProteccionId");

                    b.Navigation("Estado");

                    b.Navigation("Genero");

                    b.Navigation("TipoProteccion");
                });

            modelBuilder.Entity("Core.entities.Proveedor", b =>
                {
                    b.HasOne("Core.entities.Municipio", "Municipio")
                        .WithMany("Proveedores")
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.entities.TipoPersona", "TipoPersona")
                        .WithMany("proveedores")
                        .HasForeignKey("TipoPersonaId");

                    b.Navigation("Municipio");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Core.entities.Venta", b =>
                {
                    b.HasOne("Core.entities.Cliente", "Cliente")
                        .WithMany("Ventas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.entities.Empleado", "Empleado")
                        .WithMany("Ventas")
                        .HasForeignKey("EmpleadoId");

                    b.HasOne("Core.entities.FormaPago", "FormaPago")
                        .WithMany("Ventas")
                        .HasForeignKey("FormaPagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("FormaPago");
                });

            modelBuilder.Entity("Core.entities.Cargo", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Core.entities.Cliente", b =>
                {
                    b.Navigation("Ordenes");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Core.entities.Color", b =>
                {
                    b.Navigation("DatalleOrdenes");
                });

            modelBuilder.Entity("Core.entities.Departamento", b =>
                {
                    b.Navigation("Municipios");
                });

            modelBuilder.Entity("Core.entities.Empleado", b =>
                {
                    b.Navigation("Ordenes");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Core.entities.Estado", b =>
                {
                    b.Navigation("DetalleOrdenes");

                    b.Navigation("Ordenes");

                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Core.entities.FormaPago", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Core.entities.Genero", b =>
                {
                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Core.entities.Insumo", b =>
                {
                    b.Navigation("InsumoPrendas");

                    b.Navigation("InsumoProveedores");
                });

            modelBuilder.Entity("Core.entities.Inventario", b =>
                {
                    b.Navigation("DetalleVentas");

                    b.Navigation("InventarioTallas");
                });

            modelBuilder.Entity("Core.entities.Municipio", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Empleados");

                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("Core.entities.Orden", b =>
                {
                    b.Navigation("DatalleOrdenes");
                });

            modelBuilder.Entity("Core.entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Core.entities.Prenda", b =>
                {
                    b.Navigation("DatalleOrdenes");

                    b.Navigation("InsumoPrendas");

                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Core.entities.Proveedor", b =>
                {
                    b.Navigation("InsumoProveedores");
                });

            modelBuilder.Entity("Core.entities.Talla", b =>
                {
                    b.Navigation("DetalleVentas");

                    b.Navigation("InventarioTallas");
                });

            modelBuilder.Entity("Core.entities.TipoEstado", b =>
                {
                    b.Navigation("Estados");
                });

            modelBuilder.Entity("Core.entities.TipoPersona", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("proveedores");
                });

            modelBuilder.Entity("Core.entities.TipoProteccion", b =>
                {
                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Core.entities.Venta", b =>
                {
                    b.Navigation("DetalleVentas");
                });
#pragma warning restore 612, 618
        }
    }
}
