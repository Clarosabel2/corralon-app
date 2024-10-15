# Corralon App - Sistema de Gestión de Ventas

El sistema **Corralon App** es una aplicación de escritorio desarrollada en C# utilizando Windows Forms (WinForms) para .NET. Está diseñada para gestionar las operaciones de ventas de un corralón, incluyendo el manejo de productos, clientes, ventas y reportes. La aplicación implementa patrones de diseño y arquitectura para asegurar la escalabilidad, mantenibilidad y eficiencia del software.

## Arquitectura y Patrones Utilizados

### Arquitectura en Capas
El sistema sigue una arquitectura en capas que separa las responsabilidades de la aplicación en diferentes niveles, facilitando así su mantenimiento y escalabilidad. Las capas principales incluyen:

- **Presentación (UI):** Interfaz de usuario donde se interactúa con el sistema. Implementada utilizando Windows Forms, proporciona formularios para la gestión de ventas, productos, clientes y reportes.
- **Negocio (BLL):** Contiene la lógica de negocio, encargándose de las operaciones y reglas que definen el funcionamiento del sistema.
- **Acceso a Datos (DAL):** Capa encargada de la comunicación con la base de datos, ejecutando consultas y operaciones de almacenamiento.
- - **Servicios (SVC):** Capa que gestiona la comunicación entre la lógica de negocio y las interfaces de usuario, ofreciendo métodos centralizados para las operaciones del negocio. Incluye clases para encriptación y la implementación de los patrones Observer y Singleton.

### Patrón Observador
El sistema utiliza el **patrón Observador** para implementar la actualización de idioma en respuesta a cambios en el estado del sistema o los datos. Esto permite que los formularios se actualicen automáticamente cuando se modifican los datos relevantes.

### Patrón Singleton
Para el manejo de sesiones y la conexión a la base de datos, se utiliza el **patrón Singleton**, asegurando que exista una única instancia de la sesión del usuario y la conexión a la base de datos a lo largo de la ejecución del programa. Esto ayuda a gestionar los recursos de manera eficiente y a mantener el control sobre el acceso a los datos.

### Patrón Repositorio
El **patrón Repositorio** se emplea para abstraer la lógica de acceso a datos de la capa de negocio, permitiendo una manera más organizada y mantenible de acceder y modificar los datos. Facilita la implementación de operaciones CRUD (Crear, Leer, Actualizar, Eliminar) para las entidades del sistema.
