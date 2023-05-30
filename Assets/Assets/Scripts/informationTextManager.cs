using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class informationTextManager : MonoBehaviour
{
    [SerializeField]
    private Button nextButton;
    [SerializeField]
    private Button backButton;
    [SerializeField]
    private TextMeshProUGUI text;

    private int textCounter = -1;
    string[] texts = { "Saturday afternoon October 1973 Yom Kippur War", "The 53rd Battalion of the 188th Brigade, under the command of Lt. Col. Oded Erez, fought to contain the Syrian army",
        "During the first day of fighting, the battery bombarded the Syrian enemy and provided supporting fire to the Israeli infantry positions.", "" };


    public int textLen()
    {
        return texts.Length;
    }
    public void ShowText()
    {
        bool isTextActive = text.gameObject.activeSelf;
        text.gameObject.SetActive(!isTextActive);
        text.text = texts[textCounter];
    }

    public void NextText()
    {
        textCounter++;
        text.text = texts[textCounter];
    }

    public void BackText()
    {
        if (!(textCounter == 0))
            textCounter--;
        text.text = texts[textCounter];
    }
}
