using UnityEngine;

public class PlayerHealth : Monobehaviour
{
     public int Health = 100;
     public bool IsDead = false;

     void Update()
     {
        if (Health <= 0)
        {
               Debug.Log("Player is dead!");
               IsDead = true;
        }

        if (IsDead)
        {
               // Gérer la mort du joueur (game over, respawn, etc...)
        }
     }

     public void TakeDamage(int damage)
     {
          Health -= damage; ///créer une variable pour stocker les dégâts
     }
}
