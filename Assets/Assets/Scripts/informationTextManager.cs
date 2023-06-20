using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using LangugeNamespace;

namespace TextManager
{

    public class informationTextManager : MonoBehaviour
    {
        [SerializeField]
        private Button nextButton;
        [SerializeField]
        private Button backButton;
        [SerializeField]
        private TMP_Text text;
        [SerializeField]
        private Button skipButton;

        private int textCounter = -1;
        string[] englishTexts = { "Saturday afternoon October 1973 Yom Kippur War", "The 53rd Battalion of the 188th Brigade, under the command of Lt. Col. Oded Erez, fought to contain the Syrian army",
        "During the first day of fighting, the battery bombarded the Syrian enemy and provided supporting fire to the Israeli infantry positions.", "" };
        string[] hebrewTexts = { "שבת אחר הצהריים אוקטובר אלף תשע מאות שבעים ושלוש מלחמת יום כיפור", "גדוד חמישים ושלוש של חטיבה מאה שמונים ושמונה, בפיקודו של סא\"ל עודד ארז, נלחם לבלימת הצבא הסורי",
        "במהלך היום הראשון ללחימה הפציצה הסוללה את האויב הסורי וסיפקה אש תומכת לעמדות החי\"ר הישראליות", "" };

        public static bool clickFlag = false;


        public int textLen()
        {
            Language language = languageManager.languageFlag;

            return language == Language.English ? englishTexts.Length : hebrewTexts.Length;
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
            skipButton.GetComponentInChildren<TMP_Text>().text = language == Language.English ? "skip" : "דלג";
        }

        public void SkipClicked()
        {
            clickFlag = !clickFlag;
        }
    }
}
