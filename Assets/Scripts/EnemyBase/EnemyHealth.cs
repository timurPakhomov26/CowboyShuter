
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
   [SerializeField] private int _healthPoint;
   [SerializeField] private UnityEvent _onTakeDamage;

   public void TakeDamage(int damage)
   {
     _healthPoint -= damage;
     _onTakeDamage?.Invoke();

    if(_healthPoint <= 0)
    {
       _healthPoint=0;
       Die();
    }    
   }
  private void Die() 
  {
     Destroy(gameObject);
  } 
}
