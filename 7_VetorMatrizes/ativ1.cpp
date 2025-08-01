/*
Construa um algoritmo
que leia 10 números inteiros e armazene-os
em um vetor (use o for para fazer a leitura).
Depois, crie automaticamente dois
vetores, um contendo apenas os números
pares e outro os números ímpares
digitados.
*/
#include<iostream>
#include<vector>
using namespace std;
int main()
{
    int quant_par =0, quant_impar=0, entrada;
    //introduz os vetores sem tamanho fixo
    vector<int> vetor;
    vector<int> par;
    vector<int> impar;

    for(int i =0; i<10; i++)
    {
        cout<<"Entre com o "<< i+1 << " numero inteiro"<<endl;
        cin >> entrada;

// Novidade do chat: .push_back(); ele ve um numero e salva ele no vetor e adiciona mais um espaço para esse vetor  
        vetor.push_back(entrada); 
        
        if (entrada %2==0) par.push_back(entrada);

        else impar.push_back(entrada);       
    }
    
// Novidade do chat: .empty(); verifica se o vetor esta vazio
    cout<< "Numeros pares: ";
    if (!par.empty())
    for(int num: par) cout << num << " ";
    else cout<<"Nenhum numero par foi encontrado";

    cout<< "\nNumeros impares: ";
    if (!impar.empty()) 
    for(int num: impar) cout << num << " ";
    else cout<<"Nenhum numero impar foi encontrado";
}