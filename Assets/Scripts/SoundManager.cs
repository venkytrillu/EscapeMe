using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    static bool created;
    [SerializeField]
    private AudioSource SoundBackgroundFX;

    [SerializeField]
    private AudioClip BG_GameHome,BG_GameIN,BG_GamePause;


    [SerializeField]
    private AudioSource SoundFX;

    [SerializeField]
    private AudioClip colletclip, gameOverClip, buttonClip;
   
    void Awake()
    {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        
    }


    public void GameHomeBG_Music()
    {
        SoundBackgroundFX.clip = BG_GameHome;
        SoundBackgroundFX.Play();
    }



    public void GameINBG_Music()
    {
        SoundBackgroundFX.clip = BG_GameIN;
        SoundBackgroundFX.Play();
    }


    public void GamePauseOrOverBG_Music()
    {
        SoundBackgroundFX.clip = BG_GamePause;
        SoundBackgroundFX.Play();
    }


    public void CollectSoundFX()
    {
        SoundFX.clip = colletclip;
        SoundFX.Play();
    }

    public void GameOverSoundFX()
    {
        SoundFX.clip = gameOverClip;
        SoundFX.Play();
    }

    public void ButtonSoundFX()
    {
        SoundFX.clip = buttonClip;
        SoundFX.Play();
    }


}// class
