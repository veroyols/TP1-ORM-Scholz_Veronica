# Menu Restaurant - Parte 1 - ORM | Gestión de Comandas con Entity Framework Core

Este proyecto corresponde a la primera parte del trabajo práctico de la materia Proyecto de Software. Se implementa una aplicación de consola en C# para la gestión de comandas (pedidos de clientes) utilizando Entity Framework Core como ORM y una base de datos relacional.

## Criterios de Aceptación

La aplicación debe cumplir con los siguientes criterios:

*   **Registro de Comandas:** Permitir el registro de nuevas comandas, capturando la información del pedido del cliente.
*   **Listado de Comandas:** Mostrar un listado de las comandas registradas, incluyendo el detalle de los platos solicitados en cada una.

## Consigna

Desarrollar una aplicación de consola en C# que cumpla con los criterios de aceptación mencionados. Se deben seguir las siguientes directrices:

*   **Uso de ORM:** Implementar el acceso a la base de datos utilizando un ORM (Entity Framework Core).
*   **Modelo de Datos:** El modelo de datos debe seguir la estructura definida en la figura 1 (incluir la figura en el README si es posible o una breve descripción).
*   **Code-First:** Utilizar el enfoque Code-First para la creación y gestión del esquema de la base de datos.
*   **Carga Inicial de Datos:** La mercadería, los tipos de mercadería y las formas de entrega deben ser cargados automáticamente al crear la base de datos. Esto asegura una configuración inicial consistente.
*   **Detalle del Listado:** El listado de comandas debe mostrar la siguiente información:
    *   Código de la comanda.
    *   Listado de la mercadería solicitada, incluyendo el nombre y el tipo de cada artículo.
    *   Precio total de la comanda.
    *   Forma de entrega.

## Tecnologías Utilizadas

*   **C#**
*   **.NET**
*   **SQL Server**
*   **Entity Framework Core**

## Diagrama de la Base de Datos

![Figura 1 - Diagrama del esquema de la base de datos](https://github.com/veroyols/TP1-ORM-Scholz_Veronica/blob/master/bd.png)

## Referencias

*   **Tutorial EF Core C#:** [https://www.entityframeworktutorial.net/efcore/entity-framework-core-console-application.aspx](https://www.entityframeworktutorial.net/efcore/entity-framework-core-console-application.aspx)
