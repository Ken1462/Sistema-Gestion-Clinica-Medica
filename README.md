# Sistema de Gestión de Clínica Médica

Aplicación de escritorio desarrollada para facilitar la gestión de información de una clínica médica. El sistema permite administrar pacientes, médicos, citas y registros de signos vitales mediante una interfaz gráfica conectada a una base de datos SQL Server.

## Funcionalidades

### Gestión de Pacientes

El módulo de pacientes permite:

- Registrar nuevos pacientes.
- Almacenar información personal como nombre, apellido, edad, sexo, teléfono y correo electrónico.
- Registrar ciudad, plan médico y fecha de nacimiento.
- Buscar pacientes utilizando diferentes criterios.
- Visualizar los pacientes registrados en el sistema.

### Gestión de Médicos

El módulo de médicos permite:

- Registrar nuevos médicos.
- Almacenar nombre y apellido.
- Registrar la especialidad médica.
- Registrar teléfono y correo electrónico.
- Establecer el horario del médico.
- Buscar médicos por nombre, apellido o especialidad.
- Visualizar la lista de médicos registrados.

### Gestión de Citas

El módulo de citas permite:

- Crear nuevas citas médicas.
- Buscar y seleccionar pacientes registrados.
- Seleccionar el médico correspondiente.
- Establecer fecha y hora de la cita.
- Registrar el motivo de la consulta.
- Buscar citas utilizando un rango de fechas.
- Visualizar las citas registradas.

### Registro de Signos Vitales

El módulo de signos vitales permite:

- Buscar y seleccionar pacientes.
- Registrar la fecha de la evaluación.
- Registrar presión arterial.
- Registrar temperatura.
- Registrar peso.
- Registrar altura.
- Registrar frecuencia cardíaca.
- Buscar registros por paciente y rango de fechas.
- Visualizar el historial de signos vitales.

## Tecnologías Utilizadas

El proyecto fue desarrollado utilizando:

- Visual Basic .NET
- Windows Forms
- SQL Server
- SQL Server Management Studio
- Visual Studio
- SQL LocalDB

## Base de Datos

La base de datos utilizada por el sistema se llama:

`ClinicaMedicaDB`

Está compuesta por las siguientes tablas principales:

- `Pacientes`
- `Medicos`
- `Citas`
- `SignosVitales`

Las tablas están relacionadas mediante claves primarias y claves foráneas para mantener la integridad de los datos.

El repositorio incluye el archivo:

`ClinicaMedicaDB.sql`

Este script contiene la estructura necesaria para crear las tablas y sus relaciones.

## Capturas del Sistema

### Módulo de Pacientes

![Módulo de Pacientes](screenshots/Módulo%20de%20Paciente.png)

### Módulo de Médicos

![Módulo de Médicos](screenshots/Módulo%20de%20Médicos.png)

### Módulo de Citas

![Módulo de Citas](screenshots/Módulo%20de%20Citas.png)

### Módulo de Signos Vitales

![Módulo de Signos Vitales](screenshots/Módulo%20de%20Signos%20Vitales.png)

## Estructura del Proyecto

El proyecto contiene los formularios principales:

- `frmPacientes`
- `frmMedicos`
- `frmCitas`
- `frmSignosVitales`

Cada formulario contiene la lógica correspondiente para interactuar con la base de datos y realizar las operaciones necesarias.

## Ejecución del Proyecto

Para ejecutar el proyecto:

1. Clonar o descargar el repositorio.
2. Abrir el archivo de solución en Visual Studio.
3. Verificar que SQL Server LocalDB esté instalado.
4. Crear la base de datos `ClinicaMedicaDB`.
5. Ejecutar el archivo `ClinicaMedicaDB.sql` para crear las tablas y relaciones.
6. Verificar la cadena de conexión utilizada por la aplicación.
7. Compilar y ejecutar el proyecto desde Visual Studio.

## Objetivo del Proyecto

El objetivo de este proyecto es demostrar la integración entre una aplicación de escritorio desarrollada en Visual Basic .NET y una base de datos SQL Server.

El sistema implementa conceptos como:

- Diseño de interfaces gráficas.
- Programación orientada a eventos.
- Conexión entre VB.NET y SQL Server.
- Operaciones de almacenamiento y consulta de datos.
- Búsquedas y filtros.
- Uso de claves primarias y foráneas.
- Relaciones entre tablas.
- Validación de información ingresada por el usuario.

## Autor

Kenneth W. Carmona Vázquez

Bachelor's Degree in Network Technology and Applications Development

Northbridge University
