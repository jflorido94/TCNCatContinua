# Historial Grupos terapéuticos y Artículos

> Programa de escritorio realizado para Tecinet que muestra los cambios realizados en Grupos terapéuticos y en artículos de la base de datos, con opciones de filtrado.

## Instrucciones de uso


### Botones 


| Nombre |  Uso |
|:--:|:--|
| Familias| Muestra los filtros y datos de los cambios en los artículos. [^1]|
|GT - Familias| Muestra los filtros y datos de los cambios en los grupos terapéuticos. [^1]|
| Limpiar| Reestablece todos los filtros a sus valores iniciales.|
| Actualizar| Actualiza los datos mostrados. |

[^1]: Se mantienen los filtros establecidos.

### Familias 

> Artículos que han sido cambiados de una familia a otra.

| Filtros |  Uso | Ejemplo |
|:--:|:--|:--|
| Desde| Busca cambios realizados ==después== de la fecha introducida. | 31/12/2020 |
|Hasta| Busca cambios realizados ==antes== de la fecha introducida. | 31/12/2021 |
| Familia anterior|  Familia del artículo ==antes== del cambio. |Solares |
| Familia actual|  Familia del artículo ==después== del cambio. |Proteccion solar|
| C.N.|  Busca artículos por el codigo.|2|
| Artículo| Busca artículos según descripción. |Gafas|

### GT - Familias 

> Grupos terapéuticos en los que se a realizado alguna acción.

| Filtros | Uso | Ejemplo |
|:--:|:--|:--|
| Desde| Busca cambios realizados ==después== de la fecha introducida. | 31/12/2020 |
|Hasta| Busca cambios realizados ==antes== de la fecha introducida. | 31/12/2021 |
| Acción| Filtra según la acción realizada. | Modificar |
| Familia|  Familia del grupo terapéutico. |Sistema cardiovascular|
| Código Grupo| Busca grupos terapéuticos por el código.| Grupo C|
| Descrip. Grupo | Busca grupos terapéuticos según descripción. | Vasoprotectores|


## Código fuente 

> Todos los archivos están comentados en cada función y cada línea de código realizada y pre-configurada para funcionar con la base de datos de Tecinet. [^2] 

[^2]: Después de cualquier modificación en el código de la aplicación hay que realizar una compilación para obtener el programa completo.

### Modificar acceso a base de datos

* Modificaremos el archivo **_BDConnection.cs_**  cambiando las variables locales :
	
| variable | valor |
|--|--|
| server | Dirección web o IP donde se encuentra el servidor de la base de datos |
|user| Usuario de acceso a la base de datos|
|pass| Contraseña de acceso a la base de datos|
|db| Nombre de la base de datos|

### Modificaciones en el programa

+ Para modificar comportamientos en el filtrado o muestra de los datos del programa tendremos que modificar el archivo **_Form1.cs_** y buscar la función que realiza dicho comportamiento. 
+ Para modificar la apariencia del programa tendremos que modificar el archivo **_Form1.Designer.cs_** o el diseño de **_Form1.cs_** usando un IDE de interfaz gráfica.

> No recomiendo modificar nada en el código sin tener una idea de programación y de C#.


Realizado por:
:  Javier Florido Pavón (jflorido94@hotmail.com)
