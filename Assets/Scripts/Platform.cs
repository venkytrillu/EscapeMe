using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] StarPlatform;
    public GameObject NormalPlatform,SpikePlatform,BreakablePlatform;

    public float xMin, xMax;//, yMin, yMax;
    public bool isBreakble;

   public float timeToSpwan;
    float waitSec;


   
    void Update()
    {
        if (GameManager.instance.gameState == GameState.Play)
        {
            waitSec = waitSec - Time.deltaTime;
            if (waitSec < 0)
            {
                SpwanPlatforms();
                waitSec = timeToSpwan;
            }
        }
    }

    GameObject spwnObj;
    void SpwanPlatforms()
    {
        int random = Random.Range(0, 100);
        Vector2 tempPos = transform.position;
        tempPos.x = Random.Range(xMin, xMax);
         if (random <50)
        {
            spwnObj = Instantiate(NormalPlatform, tempPos, Quaternion.identity);
        }
        else if (random > 50 && random < 85)
        {
            spwnObj = Instantiate(StarPlatform[Random.Range(0, StarPlatform.Length)], tempPos, Quaternion.identity);
        }
        else if (random > 85 && random < 95)
        {
            spwnObj = Instantiate(SpikePlatform, tempPos, Quaternion.identity);
        }
        else if (random > 95 && random < 100)
        {
            spwnObj = Instantiate(BreakablePlatform, tempPos, Quaternion.identity);
           
        }


    }












} // class





























































