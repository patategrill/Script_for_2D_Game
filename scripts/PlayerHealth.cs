using UnityEngine;

public class PlayerHealth : Monobehaviour
{
     public int MaxHealth = 100;
     public int Health;
     public bool IsDead = false;

     void start()
     {
          Health = MaxHealth; ///initialiser la santé du joueur à sa santé maximale
     }

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

     public void Heal(int heal)
     {

          while (Health < MaxHealth)
          {
               Health += heal; ///créer une variable pour stocker les soin
          }

          if (Health > MaxHealth)
          {
               Health = MaxHealth;
          }
     }

}
