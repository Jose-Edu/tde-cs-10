Retangulo rec = new Retangulo();
Retangulo rec1 = new Retangulo(5);
Retangulo rec2 = new Retangulo(4, 6);

Console.WriteLine($"Retângulo 1: Área = {rec.CalcularArea()}, Perímetro = {rec.CalcularPerimetro()}");
Console.WriteLine($"Retângulo 2: Área = {rec1.CalcularArea()}, Perímetro = {rec1.CalcularPerimetro()}");
Console.WriteLine($"Retângulo 3: Área = {rec2.CalcularArea()}, Perímetro = {rec2.CalcularPerimetro()}");

rec2.Redimensionar(2);
Console.WriteLine($"Retângulo 3 Redimensionado: Área = {rec2.CalcularArea()}, Perímetro = {rec2.CalcularPerimetro()}");

rec1.Redimensionar(10, 15);
Console.WriteLine($"Retângulo 2 Redimensionado: Área = {rec1.CalcularArea()}, Perímetro = {rec1.CalcularPerimetro()}");