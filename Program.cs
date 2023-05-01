using Classes.Handlers;

namespace AutomataExercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CommandHandler commandHandler = new CommandHandler();

            QuestionOneHandler questionOneHandler = new QuestionOneHandler();

            commandHandler.register_handler(questionOneHandler);

            commandHandler.handle(args);
        }
    }
}
