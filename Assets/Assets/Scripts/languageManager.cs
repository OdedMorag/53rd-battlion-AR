using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace LangugeNamespace
{
    public class languageManager : MonoBehaviour
    {
        private static languageManager instance = null;
        public static Language languageFlag;
        public TMP_Dropdown dropdown;

        private languageManager()
        {
            languageFlag = Language.Hebrew;
        }

        public static languageManager GetInstance()
        {
            if (instance == null)
            {
                instance = new languageManager();
            }
            return instance;
        }

        void Start()
        {
            dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
        }

        public void OnDropdownValueChanged(int index)
        {
            switch (dropdown.options[index].text)
            {
                case "Hebrew":
                    languageFlag = Language.Hebrew;
                    break;
                case "English":
                    languageFlag = Language.English;
                    break;
            }
        }
    }

    public enum Language
    {
        Hebrew,
        English
    }
}
