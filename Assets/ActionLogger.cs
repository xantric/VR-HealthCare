using System.Collections.Generic;
using UnityEngine;

public class ActionLogger : MonoBehaviour
{
    public static ActionLogger Instance;
    private List<string> actionLog = new List<string>();

    void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void LogAction(string action)
    {
        string logEntry = $"{System.DateTime.Now:HH:mm:ss} - {action}";
        actionLog.Add(logEntry);
        Debug.Log(logEntry);
    }

    public string GetLogText()
    {
        return string.Join("\n", actionLog);
    }
}
