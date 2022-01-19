3- Vistas

En este archivo hemos cambiado el nombre a una vista y cuando hemos ejecutado nos ha dado problemas porque no la
encuetra pero existe una forma de que busque nuestra vista por su nombre despue de cambiarla y es:

public IActionResult Index()
        {
            return View("Index2");
        }

En el return View le hemos puesto entre comillas dobles el nombre de la vista.