using System.Reflection;
using Tasks;

namespace LeetCodeSolutionDebugger
{
    internal static class TaskReflectionUtils
    {
        public static Type[] GetAllTasks()
        {
            return typeof(ITask).Assembly.GetTypes().Where(t => t.IsClass && typeof(ITask).IsAssignableFrom(t)).ToArray();
        }

        public static object? InvokeSolution(Type? type)
        {
            if (type == null) return null;
            const string METHOD_NAME = "Solve";
            var methodInfo = type.GetMethod(METHOD_NAME) ?? throw new NullReferenceException($"Couldn't find method {METHOD_NAME} in type {type.FullName}");
            var classInstance = Activator.CreateInstance(type) ?? throw new NullReferenceException($"Couldn't create instanse of type {type.FullName}");
            var parameterInfos = methodInfo.GetParameters();

            return parameterInfos.Length == 0 ? methodInfo.Invoke(classInstance, null) : methodInfo.Invoke(classInstance, IOUtils.AskForParameters());
        }
    }
}
