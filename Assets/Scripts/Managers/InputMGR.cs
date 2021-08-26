using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMGR :MonoSingleton<InputMGR>
{
    public static Action<int, int> OnAddHUDPanelClick;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad7)) { OnAddHUDPanelClick(0, 0); }
        if (Input.GetKeyDown(KeyCode.Keypad8)) { OnAddHUDPanelClick(0, 1); }
        if (Input.GetKeyDown(KeyCode.Keypad9)) { OnAddHUDPanelClick(0, 2); }
        if (Input.GetKeyDown(KeyCode.Keypad4)) { OnAddHUDPanelClick(1, 0); }
        if (Input.GetKeyDown(KeyCode.Keypad5)) { OnAddHUDPanelClick(1, 1); }
        if (Input.GetKeyDown(KeyCode.Keypad6)) { OnAddHUDPanelClick(1, 2); }
        if (Input.GetKeyDown(KeyCode.Keypad1)) { OnAddHUDPanelClick(2, 0); }
        if (Input.GetKeyDown(KeyCode.Keypad2)) { OnAddHUDPanelClick(2, 1); }
        if (Input.GetKeyDown(KeyCode.Keypad3)) { OnAddHUDPanelClick(2, 2); }
    }
}
