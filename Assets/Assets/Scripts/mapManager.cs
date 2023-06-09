﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using LangugeNamespace;

public class mapManager : MonoBehaviour
{
    [SerializeField]
    private RawImage imageToDisplay;
    [SerializeField]
    private Image panel;
    [SerializeField]
    public AudioSource record;
    [SerializeField]
    private Button nextButton;
    [SerializeField]
    private Button backButton;
    [SerializeField]
    private TMP_Text mapName;

    private Texture texture;
    private bool recordFlag = false;
    private int imgCounter = 0;
    private Dictionary<int, string> mapNamesHEB = new Dictionary<int, string>()
    {
        { 0, "התקיפה הסורית" },
        
        { 1, "הכוחות"},
        {2, "השיירה"}
    };

    private Dictionary<int, string> mapNamesENG = new Dictionary<int, string>()
    {
        { 0, "The syrian attack" },

        { 1, "Forces"},
        {2, "The convoy"}
    };


    public void ShowImage()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            if (record.isPlaying)
            {
                record.Pause();
                recordFlag = true;
            }
                
        }
        else
        {
            Time.timeScale = 1;
            if(recordFlag)
            {
                record.Play();
                recordFlag = false;
            }

        }
            
        bool isImageActive = imageToDisplay.gameObject.activeSelf;
        imageToDisplay.gameObject.SetActive(!isImageActive);
        panel.gameObject.SetActive(!isImageActive);
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
        Language language = languageManager.languageFlag;
        mapName.text = language == Language.English ? mapNamesENG[imgCounter] : mapNamesHEB[imgCounter];
    }

}
