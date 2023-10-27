namespace LeetCodeSolutionDebugger
{
    internal static class IOUtils
    {
        public static void ListTasks(Type[] tasks)
        {
            if (tasks.Length == 0)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            Console.WriteLine("Available tasks:");
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine($"{i}. {tasks[i].Name}");
            }
        }

        public static int AskToSelectATask(int tasksTotal)
        {
            int selected;
            do
            {
                Console.WriteLine("Select a task or type a negative number to exit");
            } while (!int.TryParse(Console.ReadLine(), out selected) || selected >= tasksTotal || selected >= 0);
            return selected;
        }

        public static object[]? AskForParameters()
        {
            string? args;
            do
            {
                Console.WriteLine("Please enter parameters");
                args = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(args));

            return ParseParameters(args.Split(';'));
        }

        static object[]? ParseParameters(string[] args)
        {
            if (args == null || args.Length == 0) return null;

            var parameters = new object[args.Length];
            for (int i = 0; i < args.Length; i++)
                parameters[i] = ParseSingleParameter(args[i]);

            return parameters;
        }

        static object ParseSingleParameter(string parameterString)
        {
            throw new NotImplementedException();
        }

        public static void ShowResult(object? result)
        {
            throw new NotImplementedException();
        }
    }
}
