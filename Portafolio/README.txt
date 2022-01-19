5 - Introduccion al Ruteo

El ruteo define que ruta se relaciona con cada accion.

El ruteo se configura en la clase Program.cs en net Core 6 en net Core 5 se configura en la 
clase Startup.cs, exactamente en:

endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

Hay varios tipos de ruteo que seria:

    -Ruteo por atributo 
    -Ruteo Convencional

    El que hemos puesto antes es ruteo convencional.
    Por defecto en el ruteo de antes carga el controlador Home y la accion Index.
    El {id?}indica que es opcional.