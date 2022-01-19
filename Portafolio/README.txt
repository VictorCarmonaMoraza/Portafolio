7 - CSS, Cache y Tag Helpers

Hemos agregado un borde nuevo a nuestra fotografia y en el archivo _layout hemos puesto
asp-append-version="true" que recargara los archivos css si han tenido cambios.

<link rel="stylesheet" href="~/css/site.css" asp-append-version="true" />
<link rel="stylesheet" href="~/css/personalizado.css" asp-append-version="true" />
