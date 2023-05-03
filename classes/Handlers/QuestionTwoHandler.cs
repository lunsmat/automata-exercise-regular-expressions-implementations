using System;
using Classes.Validators;
using Classes.Validators.QuestionTwo;
using Classes.Helpers;

namespace Classes.Handlers
{
    class QuestionTwoHandler: IHandler
    {
        Logger logger = new Logger();

        public string get_command_name()
        {
            return "questao_dois";
        }

        public void handle(string[] args)
        {
            string altenative = "none";
            IValidator validator;
            int skipArgs = 2;

            // just == it's necessary, but to avoid non expected errors <= it's used
            if (args.Length <= 2)
            {
                Console.WriteLine("Sem argumentos o suficiente");
                Console.WriteLine("Uso: dotnet run questao_dois <alternativa> <argumentos>");
            }   

            if (args.Length > 2)
            {
                altenative = args[1];
            }
               
            switch (altenative) {
                case "a":
                    validator = new AAlternativeValidator();
                    break;
                case "b":
                    validator = new BAlternativeValidator();
                    break;
                case "c":
                    validator = new CAlternativeValidator();
                    break;
                case "d":
                    validator = new DAlternativeValidator();
                    break;
                case "e":
                    validator = new EAlternativeValidator();
                    break;
                case "f":
                    validator = new FAlternativeValidator();
                    break;
                case "g":
                    if (args.Length <= 4)
                    {
                        Console.WriteLine("Sem argumentos o suficiente");
                        Console.WriteLine("Uso: dotnet run questao_dois d <x> <y> <argumento_a_ser_validado>");
                        return;
                    }
                    
                    if (int.TryParse(args[2], out int x) == false || int.TryParse(args[3], out int y) == false)
                    {
                        Console.WriteLine("Argumentos x e y devem ser inteiros");
                        Console.WriteLine("Uso: dotnet run questao_dois d <x> <y> <argumento_a_ser_validado>");
                        return;
                    }

                    if (x <= 0 || y <= 0 || !(x <= y))
                    {
                        Console.WriteLine("Argumentos x e y devem ser inteiros positivos e x <= y");
                        Console.WriteLine("Uso: dotnet run questao_dois d <x> <y> <argumento_a_ser_validado>");
                        return;
                    }

                    validator = new GAlternativeValidator(x, y);
                    skipArgs = 4;
                    break;
                default:
                    Console.WriteLine("Alternativa não disponível, use 'dotnet run ajuda' para ver as alternativas disponíveis");
                    return;
            }

            this.logger.info("Expressão regular utilizada para essa solução: " + validator.get_regex_pattern());
            for (int i = skipArgs; i < args.Length; i++)
            {
                string arg = args[i];
            
                if (validator.validate(arg))
                    this.logger.success($"\"{arg}\" é valido");
                else
                    this.logger.error($"\"{arg}\" é invalido");
            }
        }

        public void usage_example()
        {
            Console.WriteLine("----------- Uso comando questão 2 -----------");
            Console.WriteLine($"dotnet run questao_dois <alternativas> <argumentos>");
            Console.WriteLine("Alternativas disponíveis:");

            Console.WriteLine("    a. Casais heterossexuais mais velhos que os filhos com pelo menos duas filhas mulheres, ou pelo menos um filho homem, ou ainda pelo menos dois filhos homens e uma filha mulher:");
            Console.WriteLine("        Uso: dotnet run questao_dois a <argumento_a_ser_validado>");

            Console.WriteLine("    b. Casais heterossexuais mais velhos que os filhos e com uma quantidade ímpar de filhas mulheres:");
            Console.WriteLine("        Uso: dotnet run questao_dois b <argumento_a_ser_validado>");

            Console.WriteLine("    c. Casais heterossexuais mais velhos que os filhos, com a filha mais velha mulher e o filho mais novo homem:");
            Console.WriteLine("        Uso: dotnet run questao_dois c <argumento_a_ser_validado>");

            Console.WriteLine("    d. Casais homossexuais mais velhos que os filhos, com pelo menos seis filhos, em que os dois primeiros filhos formam um casal e os últimos também:");
            Console.WriteLine("        Uso: dotnet run questao_dois d <argumento_a_ser_validado>");

            Console.WriteLine("    e. Casais homossexuais mais velhos que os filhos, em que o sexo dos filhos é alternado conforme a ordem de nascimento:");
            Console.WriteLine("        Uso: dotnet run questao_dois e <argumento_a_ser_validado>");

            Console.WriteLine("    f. Casais homossexuais mais velhos que os filhos, com qualquer quantidade de filhos homens e mulheres, mas que não tiveram dois filhos homens consecutivos:");
            Console.WriteLine("        Uso: dotnet run questao_dois f <argumento_a_ser_validado>");

            Console.WriteLine("    g. Arranjo de no mínimo x∈ℕ e no máximo y∈ℕ , com x>0 , y>0 , e x≤y , de adultos (Hs ou Ms) mais velhos que os filhos, com qualquer quantidade de filhos homens e mulheres, mas que os três filhos mais novos não foram homens:");
            Console.WriteLine("        Uso: dotnet run questao_dois g <x> <y> <argumento_a_ser_validado>");
        }
    }
}
