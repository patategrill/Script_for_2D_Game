using UnityEngine;
using system.Collections;

public class PlayerStamina : Monobehaviour
{
    public float Stamina = 100f;
    public float MaxStamina = 100f;

    ///[SerializeField] private ;
    [serializeField] private PlayerDash playerdash;

    void Start()
    {
        playerdash = GetComponent<PlayerDash>();

        Stamina = MaxStamina;
    }

    void Update()
    {
        if (playerdash.isDashing == true)
        {
            Stamina -= 10f ;
        }

        if (Stamina < 100f)
        {
            while (Stamina < 100f)
            {
                Stamina = Time.deltaTime * 20f;
            }
        } 

        if (Stamina > MaxStamina)
        {
            Stamina = MaxStamina;
        }
    }
    
}
