using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMGR : MonoSingleton<UIMGR>
{
    // baseCanvas

    // speechCanvas

    // hudCanvas
    private static HUDCanvas hudCanvas;
    private static Score score;

    // titleCanvas

    // menuCanvas

    // popupCanvas

    // tooltipsCanvas

    // debugCanvas

    // titleCanvas
    private static TitleCanvas titleCanvas;

    // debugCanvas
    private static string appStatus = "Pre-alpha"; // set to null for release
    public static GameObject versionPanel;
    public static Text versionText;

    private void Awake()
    {
        hudCanvas = GameObject.Find("HUD Canvas").GetComponent<HUDCanvas>();
        // score = GameObject.Find("UIMGR").GetComponent<Score>();
        score = gameObject.GetComponentInChildren<Score>();
        Control.OnGameStart += DrawUI;
        //
        titleCanvas = GameObject.Find("Title Canvas").GetComponent<TitleCanvas>();
        versionPanel = GameObject.Find("VersionPanel").gameObject;
        versionText = GameObject.Find("VersionText").GetComponent<Text>();
    }

    void Start()
    {
    }

    public static void ShowBetaApp()
    {
        if (appStatus != null) {
            versionText.text = "  " + Application.productName + "  " + appStatus + "  Version: " + Application.version;
        } else {
            versionPanel.SetActive(false);
        }
    }

    public static void ShowTitle() {
        titleCanvas.ShowTitle();
    }

    public static void DrawUI() {
        score.DisplayScore(); // TODO where/how
        // DisplayScore(); // TODO where/how
    }

    // public static void DisplayScore() {
    //     hudCanvas.AddHUDPanel(0, 1);
    // }

    public static GameObject Print(GameObject childPanel, int row, int col) { /*TODO nombre,funcionalidad*/
        return hudCanvas.AddHUDPanel(childPanel, row, col);
    }

}