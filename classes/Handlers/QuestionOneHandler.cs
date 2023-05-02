using System;
using Classes.Validators;
using Classes.Validators.QuestionOne;

namespace Classes.Handlers
{
    class QuestionOneHandler: IHandler
    {
        public string get_command_name()
        {
            return "questao_um";
        }

        public void handle(string[] args)
        {
            string altenative = "none";
            IValidator validator;
            string arg = "";

            // just == it's necessary, but to avoid non expected errors <= it's used
            if (args.Length <= 2)
            {
                Console.WriteLine("Sem argumentos o suficiente");
                Console.WriteLine("Uso: dotnet run questao_um <alternativa> <argumentos>");
            }   

            if (args.Length > 2)
            {
                altenative = args[1];
            }
               
            // concat in arg the args from 2 to final
            IEnumerable<string> args_arr = args.Skip(2);
            arg += args_arr.ElementAt(0);
            for (int i = 1; i < args_arr.Count(); i++)
            {
                arg += " ";
                arg += args_arr.ElementAt(i);
            }

            switch (altenative) {
                case "nome":
                    validator = new NameValidator();
                    break;
                case "email":
                    validator = new MailValidator();
                    break;
                case "senha":
                    validator = new PasswordValidator();
                    break;
                case "cpf":
                    validator = new CPFValidator();
                    break;
                case "telefone":
                    validator = new PhoneValidator();
                    break;
                case "data_hora":
                    validator = new DateTimeValidator();
                    break;
                case "numero_real":
                    validator = new RealNumberValidator();
                    break;
                default:
                    Console.WriteLine("Alternativa não disponível, use 'dotnet run ajuda' para ver as alternativas disponíveis");
                    return;
            }

            if (validator.validate(arg))
            {
                Console.WriteLine($"O argumento \"{arg}\" é valido");
            }
            else
            {
                Console.WriteLine($"O argumento \"{arg}\" é invalido");
            }
        }

        public void usage_example()
        {
            Console.WriteLine("----------- Uso comando questão 1 -----------");
            Console.WriteLine($"dotnet run questao_um <alternativas> <argumentos>");
            Console.WriteLine("Alternativas disponíveis:");

            Console.WriteLine("    1. Validador de nome:");
            Console.WriteLine("        Uso: dotnet run questao_um nome <nome_para_ser_validado>");

            Console.WriteLine("    2. Validador de Email:");
            Console.WriteLine("        Uso: dotnet run questao_um email <email_para_ser_validado>");

            Console.WriteLine("    3. Validador de senha:");
            Console.WriteLine("        Uso: dotnet run questao_um senha <senha_para_ser_validado>");

            Console.WriteLine("    4. Validador de cpf:");
            Console.WriteLine("        Uso: dotnet run questao_um cpf <cpf_para_ser_validado>");

            Console.WriteLine("    5. Validador de telefone:");
            Console.WriteLine("        Uso: dotnet run questao_um telefone <telefone_para_ser_validado>");

            Console.WriteLine("    6. Validador de data e horário:");
            Console.WriteLine("        Uso: dotnet run questao_um data_hora <data_hora_para_ser_validado>");

            Console.WriteLine("    7. Validador de número real:");
            Console.WriteLine("        Uso: dotnet run questao_um numero_real <numero_real_para_ser_validado>");
        }
    }
}
