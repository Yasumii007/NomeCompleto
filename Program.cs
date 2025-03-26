string nome, sobrenome;

Console.WriteLine("Por favor digite seu nome primeiro nome");
nome = Console.ReadLine()!;

Console.WriteLine("Por favor digite seu sobrenome");

sobrenome = Console.ReadLine()!;

Console.WriteLine($"Seu nome completo é: {nome} {sobrenome}");

Console.WriteLine($"Seu nome de catalogo é: {sobrenome.ToUpper()}, {nome}");