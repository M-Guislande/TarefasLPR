/*
Defina uma struct Livro com os seguintes
campos: Titulo, Autor, AnoPublicacao,
NumeroPaginas e Preco. Crie um
programa que permita ao usuário inserir
dados de 3 livros e, em seguida, calcule e
exiba o preço total dos livros cadastrados
e a média de páginas dos livros.
*/
#include<iostream>
#include<vector>
using namespace std;
struct Livro
{
    string Titulo;
    string Autor;
    uint16_t AnoPublicacao;
    uint16_t NumPaginas;
    float Preco;
};

int main(){
    vector<Livro> Biblioteca(3);
    for (int i = 0; i < Biblioteca.size(); i++)
    {
        cout << "Livro " << i + 1 << endl;

        cout << "Título: ";
        cin >> Biblioteca[i].Titulo;
        cout << "Autor: ";
        cin >> Biblioteca[i].Autor;

        cout << "Ano de Publicação: ";
        cin >> Biblioteca[i].AnoPublicacao;

        cout << "Número de Páginas: ";
        cin >> Biblioteca[i].NumPaginas;

        cout << "Preço: ";
        cin >> Biblioteca[i].Preco;
    }
    float ValorFinal = 0;
    float Media = 0;
    for (int i = 0; i < Biblioteca.size(); i++)
    {
        ValorFinal+= Biblioteca[i].Preco;
        Media += Biblioteca[i].NumPaginas; 
    }
    cout << "Valor total dos Livros:\n" << ValorFinal << "R$\n";
    cout << "Media de paginas dos livros:\n" << Media/Biblioteca.size() << endl; 
}