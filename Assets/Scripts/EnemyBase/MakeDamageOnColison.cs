
using UnityEngine;

public class MakeDamageOnColison : MonoBehaviour
{
    [SerializeField] private int _damageValue = 1;

    private void OnCollisionEnter(Collision other) 
    {
       if(other.gameObject.GetComponent<PlayerHealth>())
       {
          other.gameObject.GetComponent<PlayerHealth>().TakeDamage(_damageValue);
       }  
    }
}
