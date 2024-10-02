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
//using System.Collections;

//int numero1 = 1;
//var numero2 = 2;
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

var lista = new List<string>(10)
{"Alerrandro",
 "Barata"};
lista.Add("Alerrandro");
lista.Add("Barata");
lista.Add("curso");

var nome = lista[0];
Console.WriteLine(nome);
lista.RemoveAt(1);

foreach (var item in lista ){
    Console.WriteLine(item);
}

var dicionario = new Dictionary<int, string>()
{
    {100, "Alerrandro"},
    {2, "Barata"  },
    {50, "Curso"},
};

dicionario[5] = "csharp";
//dicionario.Add(100,"Alerrandro");
//dicionario.Add(2, "Barata");
//dicionario.Add(50, "Curso");


var nome = dicionario[5];
//Console.WriteLine(nome);
foreach (var item in dicionario ){
    Console.WriteLine(item.Value);
}

using System.Collections;

var queue = new Queue<string>();
queue.Enqueue("Alerrandro");
queue.Enqueue("Barata");

//var nome = queue.Peek();
//var nome1 = queue.Peek();

var nome = queue.Dequeue();
var nome1 = queue.Dequeue();

Console.WriteLine(nome);
Console.WriteLine(nome1);


//foreach (var item in queue){
  //Console.WriteLine(item);
//}

var stack = new Stack<string>();
stack.Push("Alerrandro");
stack.Push("Barata");

var nome = stack.Pop();
var nome1 = stack.Pop();
Console.WriteLine(nome);
Console.WriteLine(nome1);
    //foreach (var item in stack){
      //  Console.WriteLine(item);
    //}
    */
//modulo 7 - aula 1

/*
var diaDaSemana = 8;
//var diaDeTrabalho = false;

//if (diaDaSemana == 0 && diaDeTrabalho == true){
 //   Console.WriteLine("Hoje é segunda");
//}
//else if(diaDaSemana == 0 && diaDeTrabalho == false){
   // Console.WriteLine("hoje é segunda mas não é dia de trabalho");
//}
//else{
   // Console.WriteLine("hoje não é segunda");
//}
//if (diaDaSemana == 0 ){
// Console.WriteLine("Hoje é segunda");
//}else if( diaDaSemana == 1){
//    Console.WriteLine("Hoje é terça");
//}else if(diaDaSemana == 2){
//    Console.WriteLine("Hoje é quarta");
//}else if(diaDaSemana == 3){
//    Console.WriteLine("Hoje é quinta");
//}else if(diaDaSemana == 4){
//    Console.WriteLine("Hoje é sexta");
//}else if(diaDaSemana == 5){
//    Console.WriteLine("Hoje é sabado");
//}else if(diaDaSemana == 6){
//    Console.WriteLine("Hoje é Domingo");
//}else{
//    Console.WriteLine("hoje é feriado");
//}
*/
/*var diaDaSemana = 7;
switch (diaDaSemana)
{
 case 0: 
 Console.WriteLine("hoje é domingo");
 break;
  case 1: 
 Console.WriteLine("hoje é segunda");
 break;
  case 2: 
 Console.WriteLine("hoje é terça");
 break;
  case 3: 
 Console.WriteLine("hoje é quarta");
 break;
  case 4: 
 Console.WriteLine("hoje é quinta");
 break;
  case 5: 
 Console.WriteLine("hoje é sexta");
 break;
  case 6: 
 Console.WriteLine("hoje é sabado");
 break; 
 default: Console.WriteLine("Hoje é feriado!");
 break;
}
switch (diaDaSemana < 1)
{
    case true: 
    Console.WriteLine("hoje é domingo");
    break;
    case false:
    Console.WriteLine("hoje não é domingo");                                             //exemplo de cenario aonde o switch nao é recomendado
    break;
    default: Console.WriteLine("hoje nao tem trabalho, mas não é domingo");
    break;
}

if (diaDaSemana < 1){
    Console.WriteLine("hoje é domingo");
}else if(diaDaSemana >= 1  && diaDaSemana <= 6){
   Console.WriteLine("hoje não é domingo");                                               //forma mais recomendada
}else{
    Console.WriteLine("hoje nao tem trabalho, mas não é domingo");
}

var lista = new List<string>(){"Alerrandro", "Curso", "CSHARP"};
var count = lista.Count;

for (int i = 0; i < count; i++){
    var nome = lista[i];
    Console.WriteLine(nome);
}


var lista = new List<string>(){"Alerrandro", "Curso", "CSHARP"};
/*
foreach (var item in lista)
{
    Console.WriteLine(item);    
}

foreach (var letra in "Alerrandro")
{
    Console.WriteLine(letra);
}

using System.Diagnostics.Contracts;
using Microsoft.VisualBasic;

var i = 0;

while (i < 5)
{
    if (i == 0)
    {
         Console.WriteLine("iniciando...");
         i++;
        continue;    
    }
    Console.WriteLine("var i = "+i);
    i ++;
    //i = i + 1;
    //i +=  1;
    if (i ==2)
    {
         Console.WriteLine("valor de i é igual a 2(dois)");
        break;    
    }
    
}
//var j = 0;
//do
//{
  //   Console.WriteLine( "var j = "+ j);
    //j ++;
//} while ( j < 10);
*/

//modulo 8 - POO(Programação orientada a objetos).

