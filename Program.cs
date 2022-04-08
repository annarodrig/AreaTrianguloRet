//Cria váriaveis em ponto flutuante
double areaTriangulo, Base, altura;

Console.Write("Base:");
Base = Convert.ToDouble(Console.ReadLine());

Console.Write("Altura:");
altura = Convert.ToDouble(Console.ReadLine());

//Calcula Área do triangulo
areaTriangulo = altura * Base / 2;

Console.Write($"Área:{areaTriangulo}");
