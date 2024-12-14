# UnoSquareTest

## MIGRACION BD
1. Cambiar la cadena de conexión en el archivo appsettings.json
2. Ejecutar Comando en la consola de paquetes para accionar la migración
```bash
   Update-Database -StartupProject UnoSquareTest -Project UnoSquareTest.Data
```
## EJECUCIÓN
1. La ejecución del proyecto se realiza mediante el perfil HTTPS, por defecto en localhost:7049 y asimismo es el puerto que se consume en la aplicación FRONT

## ENDPOINTS 
1. Obtener lista de tareas [GET] {{BASE}}/api/tasks
2. Guardar tarea [POST] {{BASE}}/api/tasks
3. Obtener task [PUT] {{BASE}}/api/tasks/{{id}}
4. Obtener task [DELETE] {{BASE}}/api/tasks/{{id}}

## ARQUITECTURA
El proyecto está basado en la arquitectura CORE-DRIVEN https://www.netmentor.es/entrada/core-driven-architecture
1. Prioriza la inyección de dependencia
2. Está divido en 4 partes principales
   - API: Punto de partida de la API y controladores
   - DATA: Contiente los datos relacionados a la persistencia de la información, Entities, Migrations, DbContext además del uso del patrón repositorio para el manejo y centralización de las acciones ejecutadas en BD
   - DTOS: Contiene los Dtos de la aplicación (Request & Response)
   - USE_CASES: Contiene los casos de uso en este caso de la entidad TASK, lo cual facilita los test unitarios y contiene mappers manuales por medio de métodos de extensión para ganar velocidad y evitar el uso de librerías.


