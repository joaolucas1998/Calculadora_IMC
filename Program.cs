string continuar;

do
{
    Console.WriteLine("Digite o seu nome: ");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite sua altura: ");
    double altura = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite seu peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    //calculo do imc

    double imc = peso / (altura * altura);

    //definindo a classificação do IMC

    string resultado;

    if (imc < 16.9)
    {
        resultado = "Você está muito abaixo do peso.";
    }
    else if(imc < 18.4)
    {
        resultado = "Você está abaixo do peso.";
    }
    else if(imc < 24.9)
    {
        resultado = "Você está com um peso normal.";
    }
    else if(imc < 29.9)
    {
        resultado = "Você está acima do peso.";
    }
    else if(imc < 34.9)
    {
        resultado = "Você está com obesidade grau 1";
    }
    else if(imc < 40)
    {
        resultado = "Você está com obesidade grau 2";
    }
    else
    {
        resultado = "você está com obesidade grau 3";
    }

    // definindo a faixa etaria

    string faixa;
    
    if(idade < 12)
    {
        faixa = "Criança";
    }
    else if(idade < 18)
    {
        faixa = "Adolescente";
    }
    else if(idade < 65)
    {
        faixa = "Adulto";
    }
    else
    {
        faixa = "Idoso";
    }

    //gerando um relatorio

    Console.WriteLine("\n---------------------------------- Relatôrio de IMC -------------------------------------");
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Idade:" + idade);
    Console.WriteLine("Faixa etária:" + faixa);
    Console.WriteLine("IMC:" + imc);
    Console.WriteLine($"{nome}, {resultado}");

    Console.WriteLine("\nDeseja gerar um novo relatório? Digite sim para continuar ou nao para encerrar o programa.");
    continuar = Console.ReadLine().ToLower();

}while(continuar == "sim");

Console.WriteLine("Obrigado por usar nossa calculadora de IMC!!!");
