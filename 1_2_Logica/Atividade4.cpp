/*
Fazer um programa para ler o
código de uma peça 1, o número de peças
1, o valor unitário de cada peça 1, o código
de uma peça 2, o número de peças 2 e o
valor unitário de cada peça 2. Calcule e
mostre o valor a ser pago.
*/

#include<iostream>
#include<iomanip>
using namespace std;
int main(){
    int codigo1, codigo2, numPeca1, numPeca2;
    double ValorPeca1, ValorPeca2;
    cin>> codigo1 >>numPeca1 >> ValorPeca1;
    cin >> codigo2 >> numPeca2 >> ValorPeca2;
    cout << "Valor a pagar: " << (numPeca1* ValorPeca1) + (numPeca2*ValorPeca2) ;
}