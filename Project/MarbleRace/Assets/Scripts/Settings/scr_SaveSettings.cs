﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_SaveSettings : MonoBehaviour {

    public void SaveSettings()
    {
        scr_InputManager.CreateFolders();
        scr_InputManager.CreateFiles();
        scr_InputManager.SaveSettings();
    }
}
