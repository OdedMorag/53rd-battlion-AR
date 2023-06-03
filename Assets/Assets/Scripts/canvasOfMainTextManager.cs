using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LangugeNamespace;
using TMPro;
using RTLTMPro;
using static System.Net.Mime.MediaTypeNames;


public class canvasOfMainTextManager : MonoBehaviour
{
    [SerializeField]
    private Button playButton;
    [SerializeField]
    private Button aboutButton;
    [SerializeField]
    private Button exitButton;
    [SerializeField]
    private Button mapButton;
    private languageManager languageManager= languageManager.GetInstance();

    public TMP_Dropdown languageDropdown;

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnDropdownValueChanged(int index)
    {
    }

    public void ChangeLanguage()
    {
        Language language = languageManager.languageFlag;
        Debug.Log("Selected option: " + language);
        switch (language)
        {
            case Language.Hebrew:
                playButton.GetComponentInChildren<TMP_Text>().text = "נגן";
                aboutButton.GetComponentInChildren<TMP_Text>().text = "אודות";
                exitButton.GetComponentInChildren<TMP_Text>().text = "יציאה";
                mapButton.GetComponentInChildren<TMP_Text>().text = "מפה";

                break;
            case Language.English:
                playButton.GetComponentInChildren<TMP_Text>().text = "Play";
                aboutButton.GetComponentInChildren<TMP_Text>().text = "About";
                exitButton.GetComponentInChildren<TMP_Text>().text = "Exit";
                mapButton.GetComponentInChildren<TMP_Text>().text = "Map";
                break;
        }
    }
}
