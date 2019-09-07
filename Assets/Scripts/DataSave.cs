using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSave : MonoBehaviour
{
    public static DataSave instance;

    void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }

    public void SetScoreValue(string name,int value)
    {
        PlayerPrefs.SetInt(name, value);
    }
    public int GetScoreValue(string name)
    {
      return  PlayerPrefs.GetInt(name);
    }

   
}// class
