using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using TMPro;
using LangugeNamespace;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;


    public class recordManager : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text text;

        string[] audioHebrewText =
        {
        "עשרים כאן תשעים ושתיים, עבור", "כאן עשרים, רות עבור", " כאן תשעים ושתיים, יש לנו דיווח שהם עולים על מאה ושש עשרה, עבור", "כאן עשרים, בציר מחזה יש קריסה, יש קריסה", "אני החלפתי ואני מייצב קו בטיפה מחזה, בטיפה מחזה ושבע עשרה יורד על מחזה, עבור",
        "המוצב מודיע שעולים עליו, עולים עליו, עבור", "רות, אבל אין לי, זה כרגע מה שיש לי במקום הזה", "ואת היחידה של שקיק טרם קיבלתי וזה לוקח זמן, עבור", "כאן תשעים ושתיים, לעשות כל מאמץ שהמוצב לא יפול, עבור", ""
        };
        string[] audioEnglishText =
        {
        "Twenty here is ninety-two, over", "Here's twenty, over", "Here ninety-two, we have a report that they took one hundred and sixteen, over", "Here twenty, in the axis \"Mahaze\" there is a collapse, there is a collapse", "I switched and I stabilize a line at \"Tipa Mahaze\", at \"Tipa Mahaze\" and seventeen comes down on \"Mahaze\", over",
        "The outpost announces that it is being boarded, boarded up, over", "OK, but I don't have it, that's what I currently have in this place", "And I haven't received the \"Sakik\" unit yet and it takes time, for", "Here ninety-two, to make every effort that the outpost does not fall, over", ""
        };

        public void PlayAudio()
        {
            text.gameObject.SetActive(true);
            GetComponent<AudioSource>().Play();
            StartCoroutine(PlaySubtitles());
        }

        IEnumerator PlaySubtitles()
        {
            for (int i = 0; i < audioHebrewText.Length; i++)
            {
                yield return new WaitForSeconds(3);
                SetText(i);
            }
        }

        private void SetText(int textCounter)
        {
            Language language = languageManager.languageFlag;
            text.text = language == Language.English ? audioEnglishText[textCounter] : audioHebrewText[textCounter];
            UnityEngine.Debug.Log(text.text);
        }

    }
