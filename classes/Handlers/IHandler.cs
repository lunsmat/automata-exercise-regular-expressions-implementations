namespace Classes.Handlers
{
    interface IHandler
    {
        public string get_command_name();
        public void handle(string[] args);
        void usage_example();
    }
}
