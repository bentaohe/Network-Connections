using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start");
        if (Application.isEditor){
        } else
        {
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
            Debug.Log("after disabled");
        }
        Debug.Log("End");
        }
    public void PrintMe()
    {
        Debug.Log("PrintMe() called.");
    }
}


