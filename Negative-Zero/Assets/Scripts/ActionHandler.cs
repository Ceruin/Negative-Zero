using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActionHandler : MonoBehaviour
{
    [SerializeField] TMP_Text output;
    [SerializeField] TMP_Text currentList;
    [SerializeField] TMP_InputField inputField;

    System.Random random = new System.Random();
    string input = string.Empty;

    public void StoreText()
    {
        currentList.text = input = inputField.text.Trim();
    }

    public void GetRandom()
    {
        var test = input.Split('\n');

        int index = random.Next(0, test.Length);

        output.text = test[index];
    }
}
