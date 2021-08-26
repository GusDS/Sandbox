using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dados : MonoBehaviour
{
    public List<GameObject> dados;
    public float dadoSpeed;
    private Rigidbody dadoRB;
    private Vector3 dadoRotation;

    void Start()
    {
        for (int i = 0; i < dados.Count; i++)
        {
            dados[i].GetComponent<Renderer>().material.color = new Color32((byte)Random.Range(0, 256), (byte)Random.Range(0, 256), (byte)Random.Range(0, 256), 255);
        }
        StartCoroutine(DadoRotate());
    }

    void Update()
    {
    }

    IEnumerator DadoRotate()
    {
        while (true)
        {
            dadoRB = dados[Random.Range(0, dados.Count)].GetComponent<Rigidbody>();
            dadoRotation = new Vector3(Random.value, Random.value, Random.value);
            dadoRB.AddTorque(dadoRotation * dadoSpeed, ForceMode.Impulse);
            Util.DebugMe("Dado Rotation", dadoRotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
