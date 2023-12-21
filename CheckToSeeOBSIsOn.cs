using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CheckToSeeOBSIsOn : MonoBehaviour
{
    private string obsProcessName = "obs64.exe";
    private string obsProcessNameMac = "obs.app";
    private bool obsYes;

    private void Start()
    {
        if (IsProcessRunning(obsProcessName) || IsProcessRunning(obsProcessNameMac))
        {
            obsYes = true;
        }
        else
        {
            obsYes = false;
        }
        UnityEngine.Debug.Log(obsYes);
    }

    private bool IsProcessRunning(string processName)
    {
        Process[] processes = Process.GetProcessesByName(processName);
        return processes.Length > 0;
    }
}
