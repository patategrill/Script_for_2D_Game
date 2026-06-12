using UnityEngine;
using system.Collections;

public class PlayerStamina : Monobehaviour
{
    public float Stamina = 100f;
    public float MaxStamina = 100f;

    ///[SerializeField] private ;
    [serializeField] private PlayerDash playerdash;

    void Update()
    {
        ///in construction
    }
    
}
