using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
     public int MaxHealth = 100;
     public int Health;
     public bool IsPlayerDead = false;

     void Start()
     {
          Health = MaxHealth; ///initialiser la santé du joueur à sa santé maximale
     }

     void Update()
     {
        if (Health <= 0)
        {
               Debug.Log("Player is dead!");
               IsPlayerDead = true;
        }

        if (IsPlayerDead)
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
