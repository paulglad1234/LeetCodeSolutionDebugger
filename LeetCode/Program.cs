// See https://aka.ms/new-console-template for more information
using LeetCodeSolutionDebugger;

var tasks = TaskReflectionUtils.GetAllTasks();
IOUtils.ListTasks(tasks);

var selectedIndex = IOUtils.AskToSelectATask(tasks.Length);
if (selectedIndex < 0) return;

IOUtils.ShowResult(TaskReflectionUtils.InvokeSolution(tasks[selectedIndex]));