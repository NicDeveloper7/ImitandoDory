//

//Declaração da variável
string txt;

//Aqui você pede informação para um usuário 
Console.WriteLine("Digite o seu texto em português para traduzi-lo para o baleiês:");
//Aqui armazena o valor na variável
txt = Console.ReadLine()!; 
Console.WriteLine();
//Aqui exibe o valor armazenado na variável 
Console.WriteLine($"Em português: " + txt);
Console.WriteLine();

//Aqui usamos o replace para repetir a vogal 
txt = txt.Replace("a", string.Concat(Enumerable.Repeat("aaa", 1)));
txt = txt.Replace("e", string.Concat(Enumerable.Repeat("eee", 1)));
txt = txt.Replace("i", string.Concat(Enumerable.Repeat("iii", 1)));
txt = txt.Replace("o", string.Concat(Enumerable.Repeat("ooo", 1)));
txt = txt.Replace("u", string.Concat(Enumerable.Repeat("uuu", 1)));

//E aqui exibimos o valor armazenado novamente
Console.WriteLine($"Em baleiês: " + txt);





