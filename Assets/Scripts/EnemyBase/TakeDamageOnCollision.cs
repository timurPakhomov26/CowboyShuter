
using UnityEngine;

public class TakeDamageOnCollision : MonoBehaviour
{
   [SerializeField] private bool _dieToCollisionEveryThing = false;
     [SerializeField] private  EnemyHealth enemyHealth;
     
     private void OnCollisionEnter(Collision other) 
     {
        if(other.gameObject.GetComponent<Bullet>())        
            enemyHealth.TakeDamage(1);
          
         if(_dieToCollisionEveryThing == true)
            enemyHealth.TakeDamage(1000);
             
        
     }
}
