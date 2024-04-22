//Faça um algoritmo que leia 2 números inteiros e faça sua adição. Se o resultado for 
//maior ou igual a 10, some 5 a este número. Caso contrário some 7 a ele. Imprima o resultado final.


Double num1,num2,ad; //declarando as variáveis pros números e pra adição
Console.Write("Primeiro número: ");
num1=Double.Parse(Console.ReadLine());//obtendo primeiro número
Console.Write("Segundo número: ");
num2=Double.Parse(Console.ReadLine());//obtendo segundo número
ad=num1+num2; //realizando a operação de soma
if(ad>=10){ //se o resultado da soma for maior que 10, então adicionamos 5 a soma
    ad=ad+5;
}
else //caso não for, será adicionado 7 a soma
    ad=ad+7;
    Console.Write("Resultado: {0}",ad); //mostrando o resultado

