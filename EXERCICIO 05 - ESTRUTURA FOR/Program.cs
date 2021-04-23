using System;
namespace EXERCICIO_05___ESTRUTURA_FOR{
    class Program{
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Conditional();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("Exercício 04 - estrutura repetitiva FOR - Lista de exercícios.");
        }
        //------------------------------------------------------------------------------------------//
        static void Conditional(){
            int n = int.Parse(Console.ReadLine()); //----> Números de casos
            int fat = 1;
            for ( int i = 1; i <= n; i++) {
                fat = fat * i;
            }
            Console.WriteLine(+fat);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
