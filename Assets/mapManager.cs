using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class mapManager : MonoBehaviour
{
    [SerializeField]
    private RawImage imageToDisplay;
    [SerializeField]
    private Button nextButton;
    [SerializeField]
    private Button backButton;
    [SerializeField]
    private TextMeshProUGUI mapName;

    private Texture texture;
    private int imgCounter = 0;
    private Dictionary<int, string> mapNames = new Dictionary<int, string>()
    {
        { 0, "תירוסה הפיקתה" },
        { 1, "תוחוכה"},
        {2, "הריישה"}
    };



    public void ShowImage()
    {
        bool isImageActive = imageToDisplay.gameObject.activeSelf;
        imageToDisplay.gameObject.SetActive(!isImageActive);
        ShowMap();

    }

    public void NextImage()
    {
        if(!(imgCounter == 2))
            imgCounter++;
        ShowMap();
    }

    public void BackImage()
    {
        if (!(imgCounter == 0))
            imgCounter--;
        ShowMap();
    }

    private void ShowMap()
    {
        texture = Resources.Load<Texture>(imgCounter.ToString());
        imageToDisplay.texture = texture;
        mapName.text = mapNames[imgCounter];
    }

}
