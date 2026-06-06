using UnityEngine;

public class PlayerHealth : Monobehaviour
{
     public int Health = 100;

     void Update()
     {
        if (Health <= 0)
        {
             Debug.Log("Player is dead!");
        }
        
     }
     

}
