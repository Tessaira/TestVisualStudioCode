using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestMyIde : MonoBehaviour
{
    string Tag = "TestMyIde";
    int a = 1;
    int b = 2;
    float d = 5;

    TextMeshProUGUI TextPro;

    // Start is called before the first frame update
    void Start()
    {
        int c = a + b;
        Debug.Log("a + b = " + 3);
        Debug.Log(Tag + "- Done ;)");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
