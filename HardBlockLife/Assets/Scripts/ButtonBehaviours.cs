using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviours : MonoBehaviour
{
    // Start is called before the first frame update

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Link()
    {
        Application.OpenURL("http://unity3d.com/");
    }
}
