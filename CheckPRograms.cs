using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.Win32;
using System;
using System.IO;
using System.Xml.Linq;
using System.Linq;

public class CheckPRograms : MonoBehaviour
{



    private void Start()
    {
     FindObsStudio();
      //Get computer name
     string computerName = Environment.MachineName;
     Debug.Log("Computer Name: " + computerName);
    }
   
    static void FindObsStudio()
    {
        string applicationsDirectory = "/Applications";
        string obsAppName = "OBS.app";

        // Combine the directory path and application name to get the full path
        string obsAppPath = Path.Combine(applicationsDirectory, obsAppName);

        // Check if OBS Studio is installed
        if (Directory.Exists(obsAppPath))
        {
            Debug.Log("OBS Studio is installed at: " + obsAppPath);
        }
        else
        {
            Debug.Log("OBS Studio is not installed on this system.");
        }
    }

}