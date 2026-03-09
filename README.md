<h1 align="center">🛠️ Corralón App</h1>

<p align="center">
  <strong>Sistema Integral de Gestión Empresarial para Ferreterías y Corralones</strong>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/.NET_Framework-4.8-512BD4?style=flat&logo=.net" alt=".NET Framework 4.8" />
  <img src="https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/SQL_Server-CC2927?style=flat&logo=microsoft-sql-server&logoColor=white" alt="SQL Server" />
  <img src="https://img.shields.io/badge/Windows_Forms-0078D7?style=flat&logo=windows&logoColor=white" alt="Windows Forms" />
</p>

---

## 📝 Descripción del Proyecto

**Corralón App** es un completo sistema de gestión empresarial (ERP) desarrollado en Windows Forms con C#. Está diseñado específicamente para optimizar las operaciones diarias de ferreterías y corralones de materiales de construcción.

El sistema maneja las funciones centrales del negocio, incluyendo:

- Autenticación y autorización de usuarios basada en roles.
- Procesamiento de ventas y facturación.
- Gestión avanzada de inventario y stock.
- Seguimiento de pedidos y logística.
- Administración de clientes y proveedores.

Todo el desarrollo se asienta sobre una arquitectura de capas bien definida (N-Tier) y cuenta con inyección de dependencias para garantizar escalabilidad y fácil mantenimiento.

## 🏗️ Arquitectura del Sistema

El proyecto sigue un patrón de **arquitectura de múltiples capas** con una clara separación de responsabilidades:

- **UI (Capa de Presentación)**: Interfaz de usuario enriquecida desarrollada en Windows Forms.
- **BLL (Lógica de Negocio)**: Capa donde se procesan todas las reglas y validaciones de negocio.
- **DAL (Capa de Acceso a Datos)**: Responsable de la persistencia de datos y operaciones SQL contra la base de datos.
- **SVC (Servicios)**: Servicios transversales y utilidades compartidas, como manejo de seguridad, criptografía y utilidades del sistema.
- **BE (Entidades de Negocio)**: Definición de las estructuras de datos, interfaces y entidades de dominio puras.
- **BDE (Entidades de Base de Datos)**: Modelos específicos para mapeo de base de datos.

## 💻 Tecnologías Utilizadas

- **Plataforma:** .NET Framework 4.8
- **Lenguaje:** C#
- **Base de Datos:** Microsoft SQL Server (Base de datos propia `corralondb`)
- **Interfaz Gráfica:** Windows Forms (WinForms)
- **Componentes UI Avanzados:** Guna.UI2 y ReaLTaiizor para un diseño moderno visualmente atractivo.
- **Patrones de Diseño Aplicados:** Inyección de Dependencias (DI), Observer (para el sistema multiidioma), Mapper, Singleton, entre otros.
- **Librerías Adicionales:** DotNetEnv para la gestión de variables de entorno de forma segura.

## ✨ Funcionalidades Principales

### 👥 Gestión de Usuarios y Seguridad

- Sistema de autenticación robusto.
- Soporte para roles jerárquicos y perfiles (Administrador, Vendedor, Logística, etc.).
- Control de acceso granular basado en permisos por funcionalidad en la interfaz.
- Cifrado seguro de contraseñas (AES).

### 🛒 Ventas y Facturación

- Módulo de Punto de Venta (POS) para creación y procesamiento ágil de ventas.
- Generación y consulta de facturas y comprobantes.
- Administración detallada del perfil de clientes y su cuenta corriente.

### 📦 Control de Inventario

- Catálogo maestro de productos y familias de productos.
- Gestión completa de proveedores.
- Control estricto de movimientos de stock, ingresos y egresos.

### ⚙️ Características Adicionales

- **Sistema Multiidioma**: Capacidad de cambiar el idioma de la aplicación dinámicamente utilizando el patrón de diseño Observer.
- **Mantenimiento Integrado**: Funcionalidad para realizar copias de seguridad (Backup) y restauraciones (Restore) de la base de datos directamente desde el sistema.
- **Diseño Moderno**: Interfaz adaptativa, moderna y amigable usando paletas de colores corporativas.

## 📂 Estructura del Repositorio

```text
corralon-app/
├── UI/           # Interfaz de usuario (Windows Forms y Formularios)
├── BLL/          # Componentes de Lógica de Negocio
├── DAL/          # Componentes de Acceso a Datos y mapeadores
├── SVC/          # Componentes de Servicios (ej. Encriptación, Sesión)
├── BE/           # Entidades del Dominio e Interfaces Abiertas
├── BDE/          # Modelos de Datos para SQL
└── corralon-app.sln # Solución de Visual Studio
```

## 🚀 Instalación y Configuración

### 1. Requisitos Previos

- Windows 10 o superior.
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (o 2019) con la carga de trabajo "Desarrollo de escritorio de .NET".
- [.NET Framework 4.8 Developer Pack](https://dotnet.microsoft.com/download/dotnet-framework/net48).
- Microsoft SQL Server (LocalDB, Express o superior).

### 2. Configuración de Base de Datos

1. Crear una base de datos local o en servidor llamada `corralondb` en SQL Server.
2. Ejecutar los scripts de inicialización SQL (si están provistos) o utilizar el esquema de Entity Framework/DataSet.
3. Ubicar el archivo de configuración `.env` en la raíz del proyecto para definir la cadena de conexión (o directamente en App.config según la configuración final del proyecto):
    ```env
    DB_CONNECTION_STRING=Server=TU_SERVIDOR;Database=corralondb;Integrated Security=True;
    ```

### 3. Compilación y Ejecución

1. Clonar el repositorio:
    ```bash
    git clone https://github.com/tu-usuario/corralon-app.git
    ```
2. Abrir el archivo de solución `corralon-app.sln` en Visual Studio.
3. Restaurar los paquetes NuGet de la solución (Click derecho sobre la solución -> _Restaurar paquetes NuGet_).
4. Establecer el proyecto `UI` como el proyecto de inicio.
5. Presionar `F5` o el botón "Iniciar" para compilar y ejecutar el sistema.

## 🤝 Contribución

El proyecto está diseñado de forma modular, con alta cohesión y bajo acoplamiento gracias a la Inyección de Dependencias. Esto facilita enormemente el mantenimiento del código, la adición de nuevas funcionalidades y escalabilidad futura.

Siéntete libre de abrir _Issues_ para reportar errores técnicos o hacer _Pull Requests_ para proponer mejoras en la aplicación.

---

_Desarrollado para optimizar el rubro ferretero y de la construcción._ 🏢🏗️
