using UnityEngine;

public class TextAnimation : MonoBehaviour
{
    private TextMesh text;
    Animation anim;
    float len;
    private void Awake()
    {
        anim = GetComponent<Animation>();
        len = anim.clip.length;
        text = GetComponent<TextMesh>();
    }
    void Start()
    {
        text.color = Getcolor();
        anim.Play();
        Invoke("DestroyObj", len);
    }
    private void DestroyObj()
    {
        Destroy(gameObject);
    }

    Color Getcolor()
    {
       return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }



}// class
