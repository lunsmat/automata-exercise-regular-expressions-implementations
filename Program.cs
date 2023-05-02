using Classes.Handlers;

namespace AutomataExercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CommandHandler commandHandler = new CommandHandler();

            QuestionOneHandler questionOneHandler = new QuestionOneHandler();
            QuestionTwoHandler questionTwoHandler = new QuestionTwoHandler();

            commandHandler.register_handler(questionOneHandler);
            commandHandler.register_handler(questionTwoHandler);

            commandHandler.handle(args);
        }
    }
}
