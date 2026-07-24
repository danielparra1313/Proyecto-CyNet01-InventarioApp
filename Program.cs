using System;
using System.Reflection;

namespace TechStore.Inventario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables:

            // Constante: porcentaje de IVA aplicado en TechStore SAS
            const double IVA = 0.19;

            // Variable con inferencia de tipo (var)
            var nombreDesarrollador = "Juan Pérez";

            // Variable con tipo explícito
            string funcionPrincipal = "Administración de usuarios mediante API.";

            // Versión registrada, leída desde el manifiesto del ensamblado (System.Reflection)
            var versionEnsamblado = Assembly.GetExecutingAssembly().GetName().Version;

            string[] modulos =
            {
                "Autenticación",
                "Gestión de Usuarios",
                "Gestión de Productos",
                "Reportes",
                "Configuración"
            };

            int endpointsAproximados = 35;

            // Procesamiento:

            Console.WriteLine("==========================================");
            Console.WriteLine("      INFORMACIÓN DEL PROGRAMA");
            Console.WriteLine("==========================================");

            // 1. Versión del Sistema Operativo
            Console.WriteLine("1. Sistema Operativo : " + Environment.OSVersion);

            // 2. Nombre del desarrollador
            Console.WriteLine("2. Desarrollador     : " + nombreDesarrollador);

            // 3. Versión registrada del programa (leída con System.Reflection)
            Console.WriteLine("3. Versión Programa  : " + versionEnsamblado);

            // 4. Función principal
            Console.WriteLine("4. Función Principal : " + funcionPrincipal);

            // 5. Módulos del programa
            Console.WriteLine("5. Módulos:");
            foreach (var modulo in modulos)
            {
                Console.WriteLine("   - " + modulo);
            }

            // 6. Total aproximado de Endpoints
            Console.WriteLine("6. Endpoints aproximados: " + endpointsAproximados);

            // IVA aplicable a los productos gestionados por el módulo de inventario
            Console.WriteLine("7. IVA aplicado      : " + (IVA * 100) + "%");

            Console.WriteLine("\n==========================================");
            Console.WriteLine("      Registro Del Usuario");
            Console.WriteLine("==========================================");

            // Captura de los datos

            Console.Write("Ingrese su nombre completo: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su género (M/F): ");
            char genero = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.Write("¿Está casado? (true/false): ");
            bool estadoCivil = Convert.ToBoolean(Console.ReadLine());

            // Confirmar que si es false se considera Soltero
            string descripcionEstadoCivil = estadoCivil ? "Casado" : "Soltero";

            // Mostrar información capturada
            Console.WriteLine("\n==========================================");
            Console.WriteLine("      Datos Registrados");
            Console.WriteLine("==========================================");
            Console.WriteLine("Nombre Completo : " + nombre);
            Console.WriteLine("Edad            : " + edad);
            Console.WriteLine("Género          : " + genero);
            Console.WriteLine("Estado Civil    : " + descripcionEstadoCivil);

            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}

/*

Preguntas de reflexión de la actividad:

1. ¿Cuál es la diferencia entre lo que hizo "dotnet build" y lo
   que hizo "dotnet run"?

   El comando "dotnet build" solo se encarga de compilar el proyecto: revisa el código,
   genera los ensamblados (.dll) en la carpeta bin/ y los
   archivos intermedios en obj/, pero no ejecuta el programa.
   
   Al momento de ejecutarse el comando "dotnet run" primero se compila el proyecto (si hay cambios) y,
   además, ejecuta inmediatamente el ejecutable resultante,
   mostrando en consola la salida del programa.

2. ¿Por qué es seguro eliminar las carpetas bin/ y obj/, y qué
   archivo deberías configurar antes de compartir el proyecto
   con un compañero de equipo?

   Es seguro eliminarlas porque son artefactos generados
   automáticamente por el compilador a partir del código fuente;
   pues no contienen código escrito a mano ni configuración propia del
   proyecto, así que estos pueden regenerarse en cualquier momento con
   "dotnet build" o "dotnet run". Antes de compartir el proyecto
   con un compañero conviene configurar un archivo .gitignore que
   excluya las carpetas bin/ y obj/, para no subir binarios ni
   archivos temporales al repositorio.

*/