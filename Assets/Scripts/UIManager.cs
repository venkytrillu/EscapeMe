using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject GameOverPanel,GamePausePanel;
    public Image musicImageSprite;
    public Text scoreField, currentScoreField, bestScoreField;
    public int scoreValue;
    public float delayToLoad;
    int scoreCount;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        GameManager.instance.gameState = GameState.Play;
    }

    void Start()
    {
        SetUITextValue(bestScoreField, DataSave.instance.GetScoreValue(Tags.BestScore));
        SoundManager.instance.GameINBG_Music();
    }
    int Floor(float n1, float n2)
    {
        int num = Convert.ToInt32(n1) + Convert.ToInt32(n1);

        return num;
    }

    public void SetGameObjectStatus(GameObject obj,bool action)
    {
        obj.SetActive(action);
    }

   public IEnumerator ShowUI_CO(GameObject obj, bool action,float delay)
    {
        yield return new WaitForSeconds(delay);
        SetGameObjectStatus(obj, action);
        print("enable");
    }



    public void SetScore()
    {
        scoreCount += scoreValue;
        SetUITextValue(currentScoreField, scoreCount);
        UpdateBestScore();
    }

    void UpdateBestScore()
    {
        SetUITextValue(scoreField, scoreCount);
        if (scoreCount > DataSave.instance.GetScoreValue(Tags.BestScore))
        {
            DataSave.instance.SetScoreValue(Tags.BestScore, scoreCount);
            SetUITextValue(bestScoreField, DataSave.instance.GetScoreValue(Tags.BestScore));
        }
    }


    void SetUITextValue(Text textObj, int value)
    {
        textObj.text = value.ToString();
    }

    public void PlayStoreUrl()
    {

    }


    public void PrivacyPolicyUrl()
    {

    }


    public void ShowGameOverPanel()
    {
        StartCoroutine(ShowUI_CO(GameOverPanel, true, delayToLoad));
        SoundManager.instance.GamePauseOrOverBG_Music();
        AnimationHandler.instacne.PlayGameOverMenu();
    }


    public void Pause()
    {        
        GameManager.instance.gameState = GameState.Pause;
        GamePausePanel.SetActive(true);
        SoundManager.instance.GamePauseOrOverBG_Music();
        AnimationHandler.instacne.PlayPauseMenu();
    }

    public void UnPause()
    {
        GamePausePanel.SetActive(false);
        GameManager.instance.gameState = GameState.Play;
        SoundManager.instance.GameINBG_Music();
    }

    public void MusicOnOff()
    {
        AudioController.instacne.MusicOnOff(musicImageSprite);
    }

} // class
































































