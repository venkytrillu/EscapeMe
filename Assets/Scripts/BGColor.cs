using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGColor : MonoBehaviour
{
    public static BGColor instance;
    public Material bgMat;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    public float speedScroll;
    Color color, color2,bgColor;
    bool isSetColor;
    float t, t1 = 15f;

    void Start()
    {
        bgColor = bgMat.GetColor("_Color1");
    }


    void Update()
    {
       if(GameManager.instance.gameState == GameState.Play)
          RandomColor();
    }


    void RandomColor()
    {
        t1 -= Time.deltaTime;
       
        if (t1<0)
        {
            bgColor = bgMat.GetColor("_Color1");
            color2 = SetColor();
            t1 = 15;
            isSetColor = true;
        }

        if (isSetColor)
        {
            bgMat.SetColor("_Color1", Color.Lerp(bgColor, color2, 1));
            isSetColor = false;
        }

    }

    Color SetColor()
    {
        // t -= Time.deltaTime;

        color = new Color(RandomFloat(), RandomFloat(), RandomFloat());
        if (t<0)
        {
            color= new Color(RandomFloat(), RandomFloat(), RandomFloat());
            t = 1;
        }
        return color;
    }

    float RandomFloat()
    {
        return Random.Range(0f, 1f);
    }

}// class
