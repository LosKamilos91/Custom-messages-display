namespace MessagesLibrary
{
    public class Messages
    {
        private const string emptyMessage = $"[{info}]: No message was entered or used only white spaces.";
        private const string info = "Information";
        private const string success = "Success";
        private const string error = "Error";
        private const string warning = "Warning";
        public enum TypeMessages
        {
            errorMessage,
            warningMessage,
            infoMessage,
            successMessage,
        }
        /// <summary>
        /// Possibility to display message with font colour.
        /// </summary>
        public static void TextMessage(string message, ConsoleColor fontColor)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine(emptyMessage);
            }
            else
            {
                    Console.ForegroundColor = fontColor;
                    Console.WriteLine($"{message.Trim()}");
                    Console.ResetColor();
            }
        }
        /// <summary>
        /// Posibility to display message with font color and type message.
        /// </summary>
        /// <param name="type">Display type in [ ], before message.</param>
        public static void TextMessage(string type, string message, ConsoleColor fontColor)
        {
            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine($"[{info}]: No message or type was entered or used only white space.");
            }
            else
            {
                Console.ForegroundColor = fontColor;
                Console.Write($"[{type.Trim()}]: ");
                Console.ResetColor();
                Console.WriteLine($"{message.Trim()}");
            }
        }
        /// <summary>
        /// Display of message with specific type and font colour.
        /// </summary>
        /// <param name="type">message type designation</param>
        public static void TextMessage(string message, TypeMessages type)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine(emptyMessage);
            }
            else
            {
                if (type == TypeMessages.successMessage)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"[{success}]: ");
                    Console.ResetColor();
                    Console.WriteLine($"{message.Trim()}");
                }
                else if (type == TypeMessages.errorMessage)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"[{error}]: ");
                    Console.ResetColor();
                    Console.WriteLine($"{message.Trim()}");
                }
                else if (type == TypeMessages.warningMessage)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"[{warning}]: ");
                    Console.ResetColor();
                    Console.WriteLine($"{message.Trim()}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"[{info}]: ");
                    Console.ResetColor();
                    Console.WriteLine($"{message.Trim()}");
                }
            }
        }
    }
}