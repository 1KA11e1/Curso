/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("primeiro programa");

int idade = 33;
Console.WriteLine(idade);

string nomePessoa = "Alerrandro";
Console.WriteLine(nomePessoa);

decimal valor = 200.99m;
Console.WriteLine(valor);
double valorDouble = 200.99;
Console.WriteLine(valorDouble);
float valorFloat = 200.99f;
Console.WriteLine(valorFloat);

var idadeNova = 21;
Console.WriteLine(idadeNova);

char flag = 'Y';
Console.WriteLine(flag);

bool ativo = true;
ativo = false;
Console.WriteLine(ativo);

//isso é uma constante
const string descricao = "Curso CSHARP";
//descricao = "curso";

Console.WriteLine(descricao);
*/
using System.Collections;

int numero1 = 1;
var numero2 = 2;
/*
int soma = numero1 + numero2;
Console.WriteLine(soma);

int subtracao = numero2 - numero1;
Console.WriteLine(subtracao);

int multiplicacao = (numero2 * numero1)*10;
Console.WriteLine(multiplicacao);

int divisao = numero2 / numero1;
Console.WriteLine(divisao);

bool igual = numero1 == numero2;
Console.WriteLine(igual);

bool maior = numero2 > numero1;
Console.WriteLine(maior);

bool menor = numero2 < numero1;
Console.WriteLine(menor);

bool menorOuIgual = numero2 <= numero1;
Console.WriteLine(menorOuIgual);

bool maiorOuIgual = numero2 >= numero1;
Console.WriteLine(maiorOuIgual);

bool diferente = numero2 != numero1;
Console.WriteLine(diferente);


bool valido = numero2 > numero1 && 6 > 7;
Console.WriteLine(valido);

bool valido2 = numero2 > 10 || 6 > 7;
Console.WriteLine(valido2);

bool valido3 = !(numero2 > 3);
Console.WriteLine(valido3);


bool ativo = false;
string status = ativo ? "Cadastro Ativo" : "Cadastro inativo";
Console.WriteLine(status);

var nome = Nomecompleto();
Console.WriteLine(nome);
var soma = SomarValores();
Console.WriteLine(soma);

void EscreverNome(){
    var nome = Nomecompleto();
    Console.WriteLine(nome);
    
    var soma = SomarValores();
    Console.WriteLine(soma);
}
string Nomecompleto(){
    string primeiroNome = "Alerrandro";
    string segundoNome = "Barata";
    return primeiroNome +" "+ segundoNome;
}

int SomarValores(){
    return 8+2;
}

var soma = SomaValores(3,5);
Console.WriteLine(soma);

int SomaValores( int a, int b){
    return a + b;
}

var nome = NomeEIdade("Alerrandro", 21);
Console.WriteLine(nome);

string NomeEIdade(string nome,int idade){
    return "Meu nome é " + nome + " e tenho " + idade + " anos";
}


var arrayList = new ArrayList();
arrayList.Add(1);//0
arrayList.Add("Alerrandro");//1
arrayList.Add(true);//2
//Console.WriteLine(arrayList[1]);//acesso por indice

arrayList.RemoveAt(1);
//arrayList= new ArrayList();
arrayList.Clear();

foreach (var item in arrayList ){
    Console.WriteLine(item);
}
*/

var arrayTipadoNumero = new int[3];
arrayTipadoNumero[0] =5;
arrayTipadoNumero[1]= 5;
arrayTipadoNumero[2]= 10;
//Array.Resize(ref arrayTipadoNumero, 100);
//arrayTipadoNumero[10]= 100;

foreach (var item in arrayTipadoNumero ){
    Console.WriteLine(item);
}

var arrayTipadoString = new string[2];
arrayTipadoString[0] = "Alerrandro";
arrayTipadoString[1] = "Barata";

foreach (var item in arrayTipadoString ){
    Console.WriteLine(item);
}
