using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace Aula_Fundamentos.Models // organização das classes que estao no mesmo dominio. de bom tom criar um padrão de importancia nao reflete o caminho fisico
{
    public class Pessoa// classe 
    {

        private string _nome;// campo que armazeno o nome ele e um encapsulamento. o unico que consegue 
        // fazer a modificação no _nome e proprioa Classe 
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper(); // ele vai retornar uma variavel mais sussinta. 

            //{return _nome.ToUpper();}


            set
            {
                if (value == "") // value e o argumento que recebeu o nome
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        } // metodo // string.Empty; foi presico para nao dar erro '
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0) //se o valor for menor que zero vai dar a inseção
                {
                    throw new ArgumentException("A idade não pode ser menor que zero")
                }
                _idade = value;
            }
        } // oberter o valor e get set e setando
        // get e pega o valor e o set passa o valor para o atributo
        public void Apresentar() // esse parenteses indica um metodo. mas pode ser colocar um valor tambem 
        {                           // parametro ou argumento e oque esta a baixo
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
            //aqui tem o get
        }    // console = classe. Writeline = metodo
    }
} 

