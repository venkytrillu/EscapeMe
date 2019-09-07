using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public bool isBreakablePlatform, isStarplatform;
    public GameObject _startPrefab ;
    GameObject star;
    private Animator anim;
    public float speed;
    float time = 1;
    public float xMinStar, xMaxStar;
    public float endOffset;
    void Start()
    {
        if (isBreakablePlatform)
        {
            anim = transform.GetChild(0).GetComponent<Animator>();
        }

        InstatiateStar();
    }

    void InstatiateStar()
    {
        if (isStarplatform)
        {
            star = Instantiate(_startPrefab);
            star.transform.parent = transform;
            star.transform.localPosition = new Vector2(Random.Range(xMinStar, xMaxStar),  0.23f);
            star.transform.localRotation = Quaternion.identity;
        }
    }
    void Update()
    {
        if (GameManager.instance.gameState == GameState.Play)
        {
            if (transform.position.y > endOffset)
                DestoryObject();
            transform.position = new Vector3(transform.position.x,
                                          transform.position.y + speed * Time.deltaTime,
                                          transform.position.z);
        }
    }

   public void DestoryObject()
    {
        Destroy(this.gameObject);
    }

    public void AnimationSet(string action)
    {
        if(anim!=null)
        anim.SetTrigger(action);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.transform.tag == Tags.player)
        {
           // print("Star Hitted..");
         //   Destroy(star);
        }
    }

} // class
