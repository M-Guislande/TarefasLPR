/*
WHILE: Construa um algoritmo que calcule a
média aritmética de um conjunto de números
pares fornecidos pelo usuário. O usuário deve
fornecer primeiro a quantidade de números que
serão digitados, e em seguida, os números
considerados na média. O usuário pode digitar
números ímpares, que devem ser ignorados.
Por exemplo, no caso da tabela abaixo, o 5
informa que serão digitados 5 números (2 7 8 6
10), e para a média devem ser considerados
apenas os números pares (2, 8, 6 e 10)
ignorando o número 7 digitado.
*/
#include <iostream>
#include<locale>
using namespace std;

int main() {
    system("color 0A");
    setlocale(LC_ALL, "Portuguese.UTF-8");
    int quant = 0, divisor = 0;
    int num;
    double acumulador = 0;

    cout << "O programa calcula a média, ignorando os números ímpares." << endl;
    cout << "\n----------------" << endl;
    cout << "Calcule a média!" << endl;
    cout << "----------------" << endl;
    cout << "Digite a quantidade de números que deseja usar para calcular a média:" << endl;
    cin >> quant;
    while (quant > 0) {
        cout << "Digite um número:" << endl;
        cin >> num;

        if (num % 2 == 0)
        {
            acumulador += num;
            divisor++;
        }

        quant--;
    }

    if (divisor == 0) 
    {
        cout << "Nenhum número par foi inserido. Tente novamente." << endl;
    }
    else 
    {
        cout << "A média é: " << acumulador / divisor << endl;
    }
}