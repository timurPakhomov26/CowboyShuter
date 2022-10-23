
using UnityEngine;

public class Rabbit : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbodyPlayer;
    [SerializeField] private float _attackPeriod;
    [SerializeField] private Animator _animatorRabbit;
    private float _time;
    
   private void Update()
    {
         Attack();
    }
    private void Attack()
    {
       _time += Time.deltaTime;

       if(_time > _attackPeriod)
       {
        _time=0;
         _animatorRabbit.SetTrigger("Attack");  
       }        
    }
}
