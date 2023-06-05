using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using LangugeNamespace;

public class informationTextManager : MonoBehaviour
{
    [SerializeField]
    private Button nextButton;
    [SerializeField]
    private Button backButton;
    [SerializeField]
    private TMP_Text text;

    private int textCounter = -1;
    string[] englishTexts = { "Saturday afternoon October 1973 Yom Kippur War", "The 53rd Battalion of the 188th Brigade, under the command of Lt. Col. Oded Erez, fought to contain the Syrian army",
        "During the first day of fighting, the battery bombarded the Syrian enemy and provided supporting fire to the Israeli infantry positions.", "" };
    string[] hebrewTexts = { "שבת אחר הצהריים אוקטובר 1973 מלחמת יום כיפור", "גדוד 53 של חטיבה 188, בפיקודו של סא\"ל עודד ארז, נלחם לבלימת הצבא הסורי",
        "במהלך היום הראשון ללחימה הפציצה הסוללה את האויב הסורי וסיפקה אש תומכת לעמדות החי\"ר הישראליות", "" };


    public int textLen()
    {
        Language language = languageManager.languageFlag;

        return language == Language.English? englishTexts.Length : hebrewTexts.Length;
    }
    public void ShowText()
    {
        bool isTextActive = text.gameObject.activeSelf;
        text.gameObject.SetActive(!isTextActive);
        SetText();
    }

    public void NextText()
    {
        textCounter++;
        SetText();
    }

    public void BackText()
    {
        if (!(textCounter == 0))
            textCounter--;
        SetText();
    }

    private void SetText()
    {
        Language language = languageManager.languageFlag;
        text.text = language == Language.English ? englishTexts[textCounter] : hebrewTexts[textCounter];
    }
}
