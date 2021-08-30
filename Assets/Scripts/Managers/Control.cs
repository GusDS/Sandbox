using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Settings
    public delegate void ActionGameStart();
    public static event ActionGameStart OnGameStart;
    // private int scrWidth;
    // private int scrHeight;
    // public float panelScale = 0;
    // Game
    public GameObject player;
    public static Vector3 playerPosition;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        UIMGR.ShowBetaApp();
        ScrRes(1920, 1080);
        // UIMGR.ShowTitle();
        if (OnGameStart != null) OnGameStart();

    }

    void Update()
    {
        //playerPosition = player.transform.position;
        if (Input.GetKeyDown(KeyCode.Alpha1)) { ScrRes(1920, 1080); OnGameStart(); }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { ScrRes(1440, 900); OnGameStart(); }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { ScrRes(960, 1080); OnGameStart(); }
        Util.DebugMe("Screen Width", Screen.width);
        Util.DebugMe("Screen Height", Screen.height);
    }

    void ScrRes(int width, int height) {
        Screen.SetResolution(width, height, false);
        // scrWidth = Screen.width;
        // scrHeight = Screen.height;
    }
}
