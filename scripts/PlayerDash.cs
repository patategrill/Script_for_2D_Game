using UnityEngine;
using System.Collections;

public class PlayerDash : MonoBehaviour
{
    public float dashSpeed = 20f;
    public float dashDuration = 0.5f;
    public int dashrefresh;

    public float timer = 2f;

    [SerializeField] private Player player;
    void Start()
    {
        dashrefresh = 1;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.ControlKey) && dashrefresh == 1)
        {
            if (dashrefresh == 0)
            {
                return;
            }

            dashDuration = 0.5f;
            StartCoroutine(Dash());
            
        }
    }

    IEnumerator Dash()
    {
        dashrefresh = 0;
        player = GetComponent<Player>();
        player.speed = dashSpeed;
        yield return new WaitForSeconds(dashDuration);

        while (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            player.speed = 2f;
            dashrefresh = 1;
            timer = 2f;
        }
    }
    
}
