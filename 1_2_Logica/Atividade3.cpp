/*
Fazer um programa que leia o
número de um funcionário, seu número de
horas trabalhadas, o valor que recebe por
hora e calcule o salário desse funcionário.
A seguir, mostre o número e o salário do
funcionário, com duas casas decimais.
*/
#include<iostream>
#include<iomanip>
using namespace std;
int main(){
    int numFuncionario;
    float hTrabalhadas, SalarioH;
    cout<<"Digite seu numero, Horas trabalhadas e quanto recebe por hora:"<< endl;
    cin >> numFuncionario>> hTrabalhadas >> SalarioH;
    cout<< "Numero: "<< numFuncionario<< endl << "Salario: " << fixed << setprecision(2) << hTrabalhadas* SalarioH << "R$";
}