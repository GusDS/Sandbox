using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDCanvas : MonoBehaviour
{
    public int hudCols;
    public int hudRows;
    public List<GameObject> hudZones;
    public GameObject panelPrefab;
    private GameObject panelTemp;

    void Start()
    {
        InputMGR.OnAddHUDPanelClick += AddHUDPanel;
    }

    void Update()
    {
    }

    public void AddHUDPanel(int row, int col)
    {
        // rows (0..2), cols (0..2): row * numCols + col
        panelTemp = Instantiate(panelPrefab, Vector3.zero, Quaternion.identity);
        panelTemp.transform.SetParent(hudZones[row * hudCols + col].transform);
    }

    public GameObject AddHUDPanel(GameObject childPanel, int row, int col)
    {
        panelTemp = Instantiate(childPanel, Vector3.zero, Quaternion.identity);
        panelTemp.transform.SetParent(hudZones[row * hudCols + col].transform);
        return panelTemp;
    }
}
