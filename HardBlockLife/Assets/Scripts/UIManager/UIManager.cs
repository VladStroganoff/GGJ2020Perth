using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public RectTransform TitleScreen;
    public RectTransform GameUI;
    public RectTransform TitleScreen3;
    public RectTransform TitleScreen4;
    public RectTransform TitleScreen5;
    public RectTransform TitleScreen6;


    void ChangeState(string button)
    {
        switch (button)
        {
            case "titlescreen":
                TitleScreen.gameObject.SetActive(true);
                TitleScreen.anchoredPosition = Vector3.zero;
                return;
            case "GameUI":
                GameUI.gameObject.SetActive(true);
                GameUI.anchoredPosition = Vector3.zero;
                return;
            case "titlescreen3":
                TitleScreen3.gameObject.SetActive(true);
                TitleScreen3.anchoredPosition = Vector3.zero;
                return;
            case "titlescreen4":
                TitleScreen4.gameObject.SetActive(true);
                TitleScreen4.anchoredPosition = Vector3.zero;
                return;
            case "titlescreen5":
                TitleScreen5.gameObject.SetActive(true);
                TitleScreen5.anchoredPosition = Vector3.zero;
                return;
            case "titlescreen6":
                TitleScreen6.gameObject.SetActive(true);
                TitleScreen6.anchoredPosition = Vector3.zero;
                return;
        }


    }

    public void OpenWebbsite()
    {

    }

}
