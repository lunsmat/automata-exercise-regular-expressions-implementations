namespace Classes.Helpers {
    class Logger {
        public void log(string message) {
            System.Console.WriteLine(message);
        }

        public void red(string message) {
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            System.Console.WriteLine(message);
            System.Console.ResetColor();
        }

        public void green(string message) {
            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine(message);
            System.Console.ResetColor();
        }

        public void yellow(string message) {
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine(message);
            System.Console.ResetColor();
        }
        
        public void blue(string message) {
            System.Console.ForegroundColor = System.ConsoleColor.Blue;
            System.Console.WriteLine(message);
            System.Console.ResetColor();
        }

        public void magenta(string message) {
            System.Console.ForegroundColor = System.ConsoleColor.Magenta;
            System.Console.WriteLine(message);
            System.Console.ResetColor();
        }


        public void cyan(string message) {
            System.Console.ForegroundColor = System.ConsoleColor.Cyan;
            System.Console.WriteLine(message);
            System.Console.ResetColor();
        }

        public void white(string message) {
            System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.WriteLine(message);
            System.Console.ResetColor();
        }

        public void error(string message) {
            this.red(message);
        }

        public void success(string message) {
            this.green(message);
        }

        public void info(string message) {
            this.blue(message);
        }

        public void warning(string message) {
            this.yellow(message);
        }

        public void debug(string message) {
            this.magenta(message);
        }

        public void trace(string message) {
            this.cyan(message);
        }
    }
}