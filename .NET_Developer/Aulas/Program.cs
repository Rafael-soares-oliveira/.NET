#!meta

{"kernelInfo":{"defaultKernelName":"csharp","items":[{"aliases":[],"name":"csharp"}]}}

#!markdown

## Comentário

#!csharp

// Console.WriteLine("Olá mundo!");

/* 
Comentário de 
várias linhas
*/

#!markdown

## Console.WriteLine("texto")
Imprime o texto na tela

#!csharp

Console.WriteLine("Hello, World!"); 

#!markdown

## Variáveis

#!csharp

string amigo = "Rafael";
Console.WriteLine(amigo);
Console.WriteLine("Olá " + amigo );
Console.WriteLine($"Ola {amigo}");

#!markdown

### .Length
Contar a quantidade de caracteres

#!csharp

string amigo = "Rafael";
Console.WriteLine($"O nome {amigo} possui {amigo.Length} letras.");

#!markdown

### .Trim() / .TrimStart() / .TrimEnd()
Remove os espaçoes em branco

#!csharp

string texto = "      Texto com espaços       ";
Console.WriteLine($"[{texto}]");

string sem_espaço_comeco = texto.TrimStart();
Console.WriteLine($"[{sem_espaço_comeco}]");

string sem_espaco_final  = texto.TrimEnd();
Console.WriteLine($"[{sem_espaco_final}]");

string sem_espaco = texto.Trim();
Console.WriteLine($"[{sem_espaco}]");

#!markdown

### .Replace()
Substitui uma string específica por outra

#!csharp

string texto_grande = "Isso é um texto enorme";
Console.WriteLine(texto_grande);
texto_grande = texto_grande.Replace("um texto", "uma frase");
Console.WriteLine(texto_grande);

#!markdown

### ToUpper() / ToLower()
Define a string como maiúscula ou minúscula

#!csharp

string texto_grande = "Isso é um texto enorme";
Console.WriteLine(texto_grande.ToUpper());

#!markdown

### .Contains()
Método para procurar se há determinada string na váriavel

#!csharp

string musica_x = "Sei lá o que, mais alguma coisa";
Console.WriteLine(musica_x.Contains("coisa"));

#!markdown

### Built-in tipos de variáveis

#!markdown

- Tipos de variáveis:
    - string: uma série de caracteres
    - char: caractere unicode (UTF-32 / UTF-16 / UTF-8)
    - objeto: variável do tipo objeto
    - bool: verdadeiro ou falso
    - byte: 8-bit (0 a 255)
    - decimal: 96-bits inteiros e 32-bits decimais (números com até 29 casas decimais)
    - double: 64-bit (5x10^-324 até 1,7x10^308)
    - int: 32-bit número inteiro (+/- 2.147.483.648)
    - float: 32-bit (+/- 3,4X10^38)
    - long: 64-bit inteiro (+/- 9.223.372.036.854.775.808)
    - uint: 32-bit inteiro positivo (0 até 4.294.967.295)
    - short: 16-bit inteiro (+/- 32.768)
    - ulong: 64-bit inteiro positivo (0 até 18.446.744.073.709.551.615)

#!csharp

int i = 10; // Variável do tipo inteiro
double j = 5.5d; // Variável do tipo double: 
char c = 'C'; // Variável do tipo char

Console.WriteLine(i);
Console.WriteLine(j);
Console.WriteLine(c);

#!markdown

### Var variável
Força o compilador a determinar o tipo da variável

#!csharp

var frase = "54";
var numero = 54;
var letra = "C";

Console.WriteLine(frase);
Console.WriteLine(numero);
Console.WriteLine(letra)

#!markdown

### Literais reais
- Determina o tipo númerico de ponto flutuante a partir do sufixo:
    - Sem sufixo ou com sufixo d ou D: são do tipo double
    - Sufixo f ou F: são do tipo float
    - Sufixo m ou M: são do tipo decimal

#!csharp

tipo_double = 100.4564d;
tipo_double.GetType()

#!csharp

tipo_float = 1000.4564f;
tipo_float.GetType()

#!csharp

tipo_decimal = 1000.4564m;
tipo_decimal.GetType()