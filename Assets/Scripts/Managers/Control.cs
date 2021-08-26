using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Settings
    // Game
    public GameObject player;
    public static Vector3 playerPosition;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        UIMGR.ShowBetaApp();
        UIMGR.ShowTitle();
    }

    void Update()
    {
        //playerPosition = player.transform.position;
    }
}
