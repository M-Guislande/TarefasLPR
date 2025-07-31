/*
Construa um algoritmo
que leia 10 números inteiros. Depois
solicite para o usuário um número que ele
gostaria de pesquisar no vetor. Caso o
número exista no vetor, mostre em qual
posição (ou quais) ele aparece e quantas
ocorrências foram detectadas.
*/
#include<iostream>
#include<vector>
using namespace std;
int main()
{
    vector<int> vetor(10);
    int procura = 0, quant = 0;

    //entra com 10 numeros
    for(int i =0; i < vetor.size();i++)
    {
        cout<<"Entre com o "<< i + 1 << " numero inteiro: ";
        cin >> vetor[i];
    }

    //Entre com o numero que ela quer achar no vetor
    cout<< "digite um numero e vou procurar no vetor: ";
    cin >> procura; 
    cout<< "A(s) posicoe(s):";

    //Ja mostra as posicoes ou não(Não ha uma verificação)
    for(int num =0; num < vetor.size(); num++)
    {
        if(vetor[num] == procura)
        {
            quant++;
            cout<<num<<" ";
        }
    }
    
    // verificação 
    if(quant > 0) cout<<"\nQuantas vezes ele aparece: "<< quant;
    else cout<<"\nEle nao apareceu nenhuma vez";
}