/*
ESCOLHA A MELHOR ESTRUTURA DE
REPETIÇÃO: Crie um programa que simula
o treinamento de um Jedi. O usuário deve
inserir o número de horas de treinamento
por dia. O programa deve calcular o total
de horas de treinamento em uma semana,
desconsiderando sábados e domingos, e
informar quantos dias, semanas e meses
seriam necessários para alcançar o total de
1000 horas de treinamento. Considere 1
mês = 4,5 semanas.
*/
#include <iostream>
using namespace std;
int main() 
{
    system("color 0A");
    float calculo;
    float h_treinadas;
    int dias = 0;
    cout<< "---------------------" << endl;
    cout<< " Treine como um jedi " << endl;
    cout<< "---------------------" << endl;
    cout<< "Quantas horas voce treinou por dia?" << endl;
    cin>> h_treinadas;
    while(h_treinadas>24){
        cout<< "para de mentir" << endl;
        cin>> h_treinadas;
    }
    while (h_treinadas<1000)
    {
     calculo = h_treinadas * dias;
     if(calculo<1000){
        calculo= calculo/dias;
        dias++;
     }else{
        h_treinadas=calculo;
     }
    }
    cout<< "Voce precisara de "<<dias<<" dias" << endl;
    cout<< "Voce precisara de "<<dias/5<<" semanas" << endl;
    int mes = (dias/5)/4.5;
    cout<< "Voce precisara de "<< mes <<" meses" << endl;
    

     
}