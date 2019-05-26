Ejecutar el comando "generarbackup" desde la consola para generar backups de la base de datos del programa segundo los parametros definidos en el archivo app.configo

Pasos:
-----------------------------------------------
1- Abrir consola del sistema en modo "administrador"
2- Pararce en la raiz de la aplicacion y ejecutar los siguiente "CalculadoraRecetas.exe generarbackup"
3- Como resultado de la ejecucion se generar un archivo zip con el backup de los archivos correspondientes a la base de datos de la aplicacion

IMPORTANTE: se debe de definir en el archivo app.config de la aplicacion el lugar donde se encuentran los archivos de la base de datos, el lugar donde se desea generar los backups y por ultimo el nombre que tendra el backups