using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
     public int EnemyHealth = 30;
     public bool IsEnemyDead = false;

     void Update()
     {
        if (EnemyHealth <= 0)
        {
               Debug.Log("Enemy is dead!");
               IsEnemyDead = true;
        }

        if (IsEnemyDead)
        {
               // Gérer la mort du joueur (game over, respawn, etc...)
        }
     }

     public void TakeDamage(int damage)
     {
          EnemyHealth -= damage; ///créer une variable pour stocker les dégâts
     }

}
