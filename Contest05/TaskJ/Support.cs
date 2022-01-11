using System;
using System.Collections.Generic;

public class Support
{
    private readonly List<Task> tasks = new List<Task>();

    public IEnumerable<Task> Tasks => tasks;

    public int OpenTask(string text)
    {
        tasks.Add(new Task(tasks.Count + 1, text));
        return tasks.Count;
    }

    public void CloseTask(int id, string answer)
    {
        tasks[id - 1].IsResolved = true;
        tasks[id - 1].Answer = answer;
    }

    public List<Task> GetAllUnresolvedTasks()
    {
        List<Task> tasksUnResolved = new List<Task>();

        for (int i = 0; i < tasks.Count; i++)
        {
            if (tasks[i].IsResolved == false)
            {
                tasksUnResolved.Add(tasks[i]);
            }
        }

        return tasksUnResolved;
    }

    public void CloseAllUnresolvedTasksWithDefaultAnswer(string answer)
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            if (tasks[i].IsResolved == false)
            {
                tasks[i].IsResolved = true;
                tasks[i].Answer = answer;
            }
        }

    }

    public string GetTaskInfo(int id)
    {
        return tasks[id - 1].ToString();
    }
}