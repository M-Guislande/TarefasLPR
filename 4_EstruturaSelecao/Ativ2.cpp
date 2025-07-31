/*
Leia 2 valores inteiros (A e B). Após, o
programa deve mostrar uma mensagem
"Sao Multiplos" ou "Nao sao Multiplos",
indicando se os valores lidos são múltiplos
entre si. Atenção: os números podem ser
digitados em ordem crescente ou
decrescente.
*/
#include<iostream>

using namespace std;

int main(){
    int A, B;
    cout << "\033[32m" << "Digite dois numeros inteiros: ";
    // Ler dois numeros inteiros
    cin >> A >> B;
    if (A < B) {
        swap(A, B);// Troca os valores de duas variaveis
    }
    if (A % B == 0) {
        cout << "Sao Multiplos" << endl;
    } else {
        cout << "Nao sao Multiplos" << endl;
    }
        cout << "\033[0m"; // resetar cor
}