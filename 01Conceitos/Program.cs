
using System;  // -- using -- IMPORTAR FUNCIONALIDADE -- System -- Biblioteca padrão

namespace _01Conceitos  // namespace á pastinha (local) do projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar (criar) um objeto
            Pessoa obj = new Pessoa();
            obj.name = "Gabriel";
            obj.age = 200;
            obj.message();
        }
    }
}