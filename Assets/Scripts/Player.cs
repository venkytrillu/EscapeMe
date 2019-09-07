using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public GameObject _startEffectPrefab,deadEffectPrefab,textEffectprefab;
    private Rigidbody2D rb;
    bool isLeftPlatform,isRightPlatform;
    private void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (GameManager.instance.gameState == GameState.Play)
                Move();
    }

    private void Move()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetAxisRaw("Mouse X") > 0f)
            {
                RB_Velocity(moveSpeed);
            }
            else if (Input.GetAxisRaw("Mouse X") < 0f)
            {
                RB_Velocity(-moveSpeed);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            RB_Velocity(0f);
        }
    }

    void RB_Velocity(float value)
    {
        rb.velocity = new Vector2(value, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == Tags.spike)
        {
            print("Spike Enter");
            SoundManager.instance.GameOverSoundFX();
            GameManager.instance.gameState = GameState.GameOver;
            UIManager.instance.ShowGameOverPanel();
            PlayerDead(gameObject);
        }

        if (collision.transform.tag == Tags.Breakable)
        {
            collision.transform.gameObject.GetComponentInParent<PlatformMove>().AnimationSet(Tags.Break);
            Destroy(collision.transform.gameObject, 0.5f);
            print("Breakable Enter");
        }

        if (collision.transform.tag == Tags.Star)
        {
            SoundManager.instance.CollectSoundFX();
            StarEffect(collision.transform.gameObject);
            UIManager.instance.SetScore();
        }
    }

    void PlayerDead( GameObject ParentObj)
    {
        GameObject Obj = Instantiate(deadEffectPrefab);
        Obj.transform.parent = ParentObj.transform.parent;
        Obj.transform.localPosition = ParentObj.transform.localPosition;
        Destroy(ParentObj.transform.gameObject);
        Destroy(Obj, 0.5f);
    }

    void StarEffect(GameObject ParentObj)
    {
        GameObject stareffect = Instantiate(_startEffectPrefab);
        GameObject texteffect = Instantiate(textEffectprefab);
        stareffect.transform.parent= texteffect.transform.parent = ParentObj.transform.parent;
        stareffect.transform.localPosition = texteffect.transform.localPosition = ParentObj.transform.localPosition;
        ParentObj.transform.gameObject.GetComponent<SpriteRenderer>().enabled=false;
        Destroy(ParentObj, 0.5f);
        Destroy(stareffect, 0.3f);
    }

}// class




















































