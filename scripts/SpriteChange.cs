using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    private SpriteRenderer sr;
    public Sprite idleSprite;
    public Sprite moveSprite;

    private float timer = 0f;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        bool move = false;
        
        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow))
        {
            move = true;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
           move = true;
        }

        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
        {
            move = true;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            move = true;
        }

        if (move)
        {
            timer += Time.deltaTime;
            
            if (timer >= 0.2f)
            {
                sr.sprite = moveSprite;
                timer = 0f;
            }

        }
        else
        {
            sr.sprite = idleSprite;
        }
    }
}
