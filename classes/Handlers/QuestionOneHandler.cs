using System;
using Classes.Validators;
using Classes.Validators.QuestionOne;
using Classes.Helpers;

namespace Classes.Handlers
{
    class QuestionOneHandler: IHandler
    {
        Logger logger = new Logger();

        public string get_command_name()
        {
            return "questao_um";
        }

        public void handle(string[] args)
        {
            string altenative = "none";
            IValidator validator;

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

            for (int i = 2; i < args.Length; i++)
            {
                string arg = args[i];
                
                if (validator.validate(arg))
                {
                    this.logger.success($"O argumento \"{arg}\" é valido para expressão regular: {validator.get_regex_pattern()}");
                }
                else
                {
                    this.logger.error($"O argumento \"{arg}\" é invalido para expressão regular: {validator.get_regex_pattern()}");
                }
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
