using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public float dashSpeed = 20f;
    public float dashDuration = 0.2f;
    public int dashrefresh;


    public float timer = 0f;

    void Start()
    {
        dashrefresh = 1;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.ControlKey) && dashrefresh == 1)
        {
            Dash();
            dashrefresh = 0;

            while (timer < 2f)
            {
                timer += Time.deltaTime;
            }

            if (timer >= 2f)
            {
                dashrefresh = 1;
                timer = 0f;
            }
            
        }
    }

    void Dash()
    {
        
    }
}
