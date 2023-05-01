using System;

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

                for (int i = 0; i < this.handlers.Count(); i++)
                {
                    if (this.handlers[i].get_command_name() == command)
                    {
                        this.handlers[i].handle(args);
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
