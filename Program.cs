using GestionInstitucion;

// ══════════════════════════════════════════════════════
//   PROGRAMA PRINCIPAL — Gestión Institución Educativa
// ══════════════════════════════════════════════════════

var institucion = new Institucion("Universidad Nacional de Ejemplo");

// ── 1. Registro de personas ──────────────────────────
Console.WriteLine("=== REGISTRO DE PERSONAS ===\n");

institucion.Agregar(new Estudiante(
    "EST-001", "Laura", "Martínez", EstadoCivil.Soltero, "Ingeniería de Sistemas - 5° Semestre"));

institucion.Agregar(new Estudiante(
    "EST-002", "Carlos", "Pérez", EstadoCivil.Casado, "Medicina - 3° Semestre"));

institucion.Agregar(new Profesor(
    "PRO-001", "Ana", "Rodríguez", EstadoCivil.Casada, 2015, "Facultad de Ciencias Exactas"));

institucion.Agregar(new Profesor(
    "PRO-002", "Javier", "López", EstadoCivil.Divorciado, 2010, "Facultad de Humanidades"));

institucion.Agregar(new Administrativo(
    "ADM-001", "María", "González", EstadoCivil.Soltero, 2018, "Departamento de Finanzas"));

institucion.Agregar(new Administrativo(
    "ADM-002", "Roberto", "Silva", EstadoCivil.Casado, 2012, "Secretaría General"));

institucion.Agregar(new ServiciosVarios(
    "SRV-001", "Pedro", "Ramírez", EstadoCivil.UnionLibre, 2020, "Mantenimiento y Limpieza"));

institucion.Agregar(new ServiciosVarios(
    "SRV-002", "Elena", "Torres", EstadoCivil.Viudo, 2019, "Seguridad y Vigilancia"));

// ── 2. Listado completo (polimorfismo) ───────────────
Console.WriteLine("\n=== LISTADO COMPLETO ===");
institucion.ListarTodos();

// ── 3. Demostración de métodos por ID ────────────────
Console.WriteLine("=== MODIFICACIONES POR ID ===\n");

// Cambio de estado civil
Console.WriteLine("── Cambio de estado civil ──");
institucion.CambiarEstadoCivil("EST-001", EstadoCivil.Casada);
institucion.CambiarEstadoCivil("PRO-002", EstadoCivil.Casado);
institucion.CambiarEstadoCivil("XXX-999", EstadoCivil.Soltero); // ID inexistente

Console.WriteLine();

// Matrícula de estudiante
Console.WriteLine("── Matrícula de estudiante ──");
institucion.MatricularEstudiante("EST-001", "Ingeniería de Sistemas - 6° Semestre");
institucion.MatricularEstudiante("PRO-001", "Curso X"); // ID no es estudiante

Console.WriteLine();

// Cambio de facultad de profesor
Console.WriteLine("── Cambio de facultad ──");
institucion.CambiarFacultadProfesor("PRO-001", "Facultad de Ingeniería");
institucion.CambiarFacultadProfesor("ADM-001", "Facultad Z"); // ID no es profesor

Console.WriteLine();

// Modificación de labor de servicios varios
Console.WriteLine("── Modificación de labor ──");
institucion.ModificarLaborServicio("SRV-001", "Jardinería y Ornato");
institucion.ModificarLaborServicio("EST-002", "Pintura"); // ID no es servicios

Console.WriteLine();

// Modificación de dependencia administrativa
Console.WriteLine("── Modificación de dependencia ──");
institucion.ModificarDependenciaAdministrativo("ADM-001", "Rectoría");
institucion.ModificarDependenciaAdministrativo("SRV-002", "TI"); // ID no es administrativo

// ── 4. Listado final actualizado ─────────────────────
Console.WriteLine("\n=== LISTADO FINAL ACTUALIZADO ===");
institucion.ListarTodos();

// ── 5. Listado por rol (polimorfismo con ObtenerRol) ─
Console.WriteLine("=== LISTADO POR ROL ===");
institucion.ListarPorRol("Estudiante");
institucion.ListarPorRol("Profesor");
institucion.ListarPorRol("Administrativo");
institucion.ListarPorRol("Servicios Varios");

Console.WriteLine("\n✔ Programa finalizado correctamente.");
