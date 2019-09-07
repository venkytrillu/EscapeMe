using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSoundController : MonoBehaviour
{
    public Button[] buttons;
    void Start()
    {
        OnClickEvent();
    }

    void OnClickEvent()
    {
        if (buttons.Length > 0)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].onClick.AddListener(ApplyBtnSound);
            }
        }
    }
    public void ApplyBtnSound()
    {
        SoundManager.instance.ButtonSoundFX();
    }
}// class




























