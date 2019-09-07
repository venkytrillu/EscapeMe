using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerHome : MonoBehaviour
{
    public GameObject HomePanel;
    public string RatingUrl;

    private void Start()
    {
        SoundManager.instance.GameHomeBG_Music();
    }
    public void Rating()
    {
        Application.OpenURL(RatingUrl);
    }

   
}// class













































