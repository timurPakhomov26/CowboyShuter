
using UnityEngine;

public class TakeDamageOnTrigger : MonoBehaviour
{
  [SerializeField] private bool _dieToCollisionEveryThing = false;
   [SerializeField] private EnemyHealth _enemyHealth;
   
   private void OnTriggerEnter(Collider other)
     {
        if(other.attachedRigidbody)
          if(other.attachedRigidbody.GetComponent<Bullet>()) 
            _enemyHealth.TakeDamage(1);
        
          if(_dieToCollisionEveryThing == true)
             if(other.isTrigger == false)
               _enemyHealth.TakeDamage(1000);
             
    }
}
