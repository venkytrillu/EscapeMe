using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHome : MonoBehaviour
{
    public GameObject logo,PlayBtn,ShareBtn, RatingBtn;

    private void Start()
    {
        iTween.ScaleFrom(PlayBtn, iTween.Hash("scale", new Vector3(0.9f, 0.9f, 0.9f), "speed", 0.8f, "loopType", iTween.LoopType.pingPong));
        iTween.MoveFrom(logo, iTween.Hash("position", new Vector3(-500, 0, 0),"islocal",true));
        iTween.RotateFrom(ShareBtn, iTween.Hash("rotation", new Vector3(90f, 0f, 0), "time", 1.0f, "easyType", iTween.EaseType.linear));
        iTween.RotateFrom(RatingBtn, iTween.Hash("rotation", new Vector3(90f, 0f, 0), "time", 1.0f, "easyType", iTween.EaseType.linear));
    }







}// class






























