using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleCanvas : MonoBehaviour
{
    public string titleString;
    public GameObject titlePrefab;

    void Start()
    {
    }

    void Update()
    {
    }

    public void ShowTitle() {
        if (string.IsNullOrEmpty(titleString)) titleString = Application.productName;

        var panelTemp = Instantiate(titlePrefab, gameObject.transform.position, gameObject.transform.rotation); // Vector3.zero, Quaternion.identity); // 
        panelTemp.transform.SetParent(gameObject.transform);
        panelTemp.GetComponentInChildren<Text>().text = titleString;
    }
}
