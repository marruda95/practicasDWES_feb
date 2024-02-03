# practicasDWES_feb
Practicas Presencials Feb 2024 

Aplicación que consiste en poder encontrar Artistas de distintas disciplinas y poder hacer "sponsor" de ellos. 

La aplicación tiene dos áreas distintas: 
    - Area de usuario
    - Area pública

Dentro de la área pública el usuario (no loggeado) podrá buscar por nombre de Artista o el Catálago completo. 

En caso de querer añadir un artista en una lista de favoritos desde el catálago de Artistas se hace introduciendo Y (sí) o N (no). En caso de introducir Y (sí), y el usuario no está loggeado, le mostrará el menú secundario de poder loggear o crear una cuenta nueva. Cuando se haya realizado el log in correctamente, o se ha creado un nuevo usuario, podrá continuar con añadir a favoritos. 

El catalago de artistas mostrará toda la información (como ranking general, proyectos y su información correspondiente, o si el artista esta "sponsored" o no por un usuario). 


Funcionalidades obligatorias
● (1.5p) La aplicación estará compuesta de:
    ○ Menú principal y secundario para navegar entre las funcionalidades interactuando a través de la aplicación.
    ○ Gestión de alta y selección de usuarios y/o productos y/o servicios. Dependerá del propósito de la aplicación el que existan unos u otros.
    ○ Zona pública de información. Dependerá del propósito de la aplicación y será pública para todos los usuarios.

● (1.5p) El modelo de datos estará compuesto de, al menos, 2 clases y
tendrán que existir relaciones entre ellas. Cada clase tendrá, al menos,
5 atributos (String, int, decimal, boolean, DateTime).

● (1p) Desarrolla una funcionalidad de búsqueda en el que, al menos,
se pueda buscar por un campo.

● (1p) Conteneriza la aplicación y aloja el contenedor en un registro de
contenedores, descarga ese contenedor en tu ordenador y usa la
aplicación a través del contenedor.

Funcionalidades extra
● (1.5p) Utiliza Git y la metodología Gitflow durante todo el desarrollo de
la aplicación.

● (1.5p) Implementa una interfaz de usuario más visual usando
librerías como &quot;Terminal.GUI&quot; o &quot;Spectre.Console&quot;