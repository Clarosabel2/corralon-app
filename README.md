# README - Corralón App

## Descripción del Proyecto

**corralon-app** es un sistema integral de gestión empresarial desarrollado en Windows Forms para operaciones de ferreterías y corralones. El sistema maneja funciones centrales del negocio incluyendo autenticación de usuarios, procesamiento de ventas, gestión de inventario, seguimiento de pedidos y relaciones con clientes a través de una arquitectura de capas bien definida. <cite/>

## Arquitectura del Sistema

El proyecto sigue un patrón de arquitectura de cinco capas con clara separación de responsabilidades:

- **UI (Interfaz de Usuario)**: Capa de presentación con Windows Forms
- **BLL (Lógica de Negocio)**: Procesamiento y validación de reglas de negocio <cite/>
- **DAL (Capa de Acceso a Datos)**: Persistencia de datos y operaciones SQL  
- **SVC (Servicios)**: Servicios transversales como seguridad y comunicación <cite/>
- **BE (Entidades de Negocio)**: Estructuras de datos y entidades del dominio <cite/>

## Tecnologías Utilizadas

- **.NET Framework 4.8** [4]
- **SQL Server** (Base de datos `corralondb`) <cite/>
- **Windows Forms** para la interfaz gráfica
- **Guna.UI2** y **ReaLTaiizor** para componentes UI avanzados <cite/>
- **DotNetEnv** para configuración de variables de entorno 

## Funcionalidades Principales

### Gestión de Usuarios y Permisos
- Sistema de autenticación con roles jerárquicos (Administrador, Vendedor, Logística) <cite/>
- Control de acceso basado en permisos por funcionalidad <cite/>

### Gestión de Ventas
- Creación y procesamiento de ventas <cite/>
- Generación de facturas <cite/>
- Gestión de clientes <cite/>

### Control de Inventario
- Administración de productos 
- Gestión de proveedores
- Seguimiento de stock <cite/>

### Características Adicionales
- Soporte multiidioma con patrón Observer <cite/>
- Mantenimiento de base de datos (backup/restore) <cite/>
- Cifrado AES para seguridad <cite/>

## Estructura de Proyectos

```
corralon-app/
├── UI/           # Interfaz de usuario (Windows Forms)
├── BLL/          # Lógica de negocio
├── DAL/          # Acceso a datos
├── SVC/          # Servicios transversales
└── BE/           # Entidades de negocio
```

## Instalación y Configuración

1. **Requisitos previos**:
   - .NET Framework 4.8 [8]
   - SQL Server para la base de datos `corralondb`

2. **Configuración**:
   - Configurar la cadena de conexión a la base de datos
   - Ejecutar los scripts de inicialización de la base de datos

3. **Compilación**:
   - Abrir `corralon-app.sln` en Visual Studio
   - Restaurar paquetes NuGet
   - Compilar la solución

## Uso del Sistema

El sistema inicia con un formulario de login que autentica usuarios y establece permisos según el rol asignado. <cite/> La interfaz principal adapta sus controles disponibles basándose en el tipo de usuario autenticado. <cite/>

## Contribución

Este proyecto utiliza una arquitectura modular que facilita el mantenimiento y la extensión de funcionalidades. <cite/> Cada capa tiene responsabilidades bien definidas y dependencias claras entre los proyectos. 

## Notes

El proyecto incluye formularios especializados para diferentes funciones del negocio como `FormCreateSale`, `FormProducts`, `FormOrders`, entre otros, todos integrados en la arquitectura de capas. La base de datos utiliza un DataSet tipado (`corralondbDataSet`) para el manejo de datos estructurados.


