using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScrip : MonoBehaviour
{
    string text;
    int num;
    public GameObject inputNameField;
    public GameObject inputAgeField;
    public GameObject displayField;
    string[] words = { "Labrit ", "Labdien ", "Sveiks ","Food " };
    int randomNumb;


   public void GetText()
    {
        randomNumb = Random.Range(0, words.Length);
        text = inputNameField.GetComponent<InputField>().text;
        num = int.Parse(inputAgeField.GetComponent<InputField>().text);
        int currentYear = System.DateTime.Now.Year;
        displayField.GetComponent<Text>().text =
            words[randomNumb] + text.ToLower() + "! You're " + (currentYear - num) + " years old";
    }
}

