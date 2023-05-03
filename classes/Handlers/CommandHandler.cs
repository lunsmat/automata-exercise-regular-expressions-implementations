using System;
using System.IO;

namespace Classes.Handlers
{
    class CommandHandler: IHandler
    {
        private List<IHandler> handlers;

        public CommandHandler()
        {
            this.handlers = new List<IHandler>();
        }

        public string get_command_name() 
        {
            return "ajuda";
        }

        public void handle(string[] args)
        {
            string command = "ajuda";

            if (args.Length > 0)
            {
                command = args[0];

                string[]? new_args = args.Clone() as string[];

                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "--file-args")
                    {
                        // read file from i + 1 and set args
                        if (args.Length <= i + 1)
                        {
                            Console.WriteLine("Sem argumentos o suficiente");
                            Console.WriteLine("Uso: dotnet run --file-args <caminho_do_arquivo>");
                            return;
                        }

                        string file_path = args[i + 1];

                        if (!File.Exists(file_path))
                        {
                            Console.WriteLine($"Arquivo {file_path} não encontrado");
                            return;
                        }

                        string[] file_args = File.ReadAllLines(file_path);

                        new_args = new_args?.Where((source, index) => index != i && index != i + 1).ToArray();

                        for (int j = 0; j < file_args.Length; j++)
                        {
                            new_args = new_args?.Append(file_args[j]).ToArray();
                        }
                        break;
                    }
                }

                for (int i = 0; i < this.handlers.Count(); i++)
                {
                    if (this.handlers[i].get_command_name() == command)
                    {
                        this.handlers[i].handle(new_args ?? args);
                        return;
                    }
                }

                command = command == "ajuda" ? "ajuda" : "not_found";
            }

            if (command == "ajuda")
            {
                this.usage_example();
                return;
            }

            // not_found
            Console.WriteLine($"Comando {args[0]} não disponível, veja dotnet run ajuda para ver os comandos disponíveis");
        }

        public void usage_example()
        {
            Console.WriteLine("----------- Uso dos comandos -----------");
            Console.WriteLine("Uso: dotnet run <nome_da_questão> <alternativa> <argumentos>");
            Console.WriteLine("Questões disponíveis:");

            for (int i = 0; i < this.handlers.Count(); i++)
            {
                this.handlers[i].usage_example();
            }
        }

        public void register_handler(IHandler handler) {
            this.handlers.Add(handler);
        }
    }
}
