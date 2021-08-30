using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject scorePrefab;
    private GameObject scorePanel;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void DisplayScore() {
        scorePanel = UIMGR.Print(scorePrefab, 0, 1);
        Util.DebugMe("Panel Scale", scorePanel.transform.localScale.x);
    }

}
