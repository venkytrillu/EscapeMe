using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    public static AnimationHandler instacne;

    public GameObject pauseHomeBtn, pausePlayBtn, pausemusicBtn, gameOverRestartBtn, gameOverHomeBtn, gameOvershareBtn;
    public GameObject pauseMenuLogo, gameOverMenuLogo;
    private void Awake()
    {
        if(instacne==null)
        {
            instacne = this;
        }
    }
    public void PlayPauseMenu()
    {
        iTween.MoveFrom(pauseMenuLogo, iTween.Hash("position", new Vector3(0, 50, 0), "islocal", true));
        iTween.ScaleFrom(pausePlayBtn, iTween.Hash("scale", new Vector3(0.9f, 0.9f, 0.9f), "speed", 0.8f, "loopType", iTween.LoopType.pingPong));
        iTween.RotateFrom(pausemusicBtn, iTween.Hash("rotation", new Vector3(-90f, 0f, 0), "time", 1.0f, "easyType", iTween.EaseType.linear));
        iTween.RotateFrom(pauseHomeBtn, iTween.Hash("rotation", new Vector3(-90f, 0f, 0), "time", 1.0f, "easyType", iTween.EaseType.linear));
    }

    public void PlayGameOverMenu()
    {
        iTween.MoveFrom(gameOverMenuLogo, iTween.Hash("position", new Vector3(0, -50, 0), "islocal", true));
        iTween.ScaleFrom(gameOverRestartBtn, iTween.Hash("scale", new Vector3(0.9f, 0.9f, 0.9f), "speed", 0.8f, "loopType", iTween.LoopType.pingPong));
        iTween.RotateFrom(gameOverHomeBtn, iTween.Hash("rotation", new Vector3(-90f, 0f, 0), "time", 1.0f, "easyType", iTween.EaseType.linear));
        iTween.RotateFrom(gameOvershareBtn, iTween.Hash("rotation", new Vector3(-90f, 0f, 0), "time", 1.0f, "easyType", iTween.EaseType.linear));
    }


}// class
