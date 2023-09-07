

using PruebaHerencia;

EmpleadoPorComision empleadoPorComision = new("Susana", "Perez", "222-22-22222", .06M, 10000.00M);

Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}\n", "LLama a tostring se empleadoporcomision con referencia de clase base",
    "a objeto de clase base", empleadoPorComision.ToString(), "Ingresos", empleadoPorComision.Ingresos());


EmpleadoBaseMasComision2 empleadoBaseMasComision = new("Roberto", "Lopez", "333-333-333", .04M, 5000.00M, 300.00M);

Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}\n", "LLama a tostring se EmpleadoBaseMasComisionn con referencia de clase",
    " derivada a objeto de clase derivada"
    , empleadoBaseMasComision.ToString(), "Ingresos", empleadoBaseMasComision.Ingresos());


EmpleadoPorComision empleadoPorComision2 = empleadoBaseMasComision;

Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}\n", "LLama a tostring se EmpleadoBaseMasComisionn con referencia de clase",
    " derivada a objeto de clase derivada"
    , empleadoPorComision2.ToString(), "Ingresos", empleadoPorComision2.Ingresos());
