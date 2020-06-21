using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextFix : MonoBehaviour
{
    TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
        text.outlineColor = Color.black;
        text.outlineWidth = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
