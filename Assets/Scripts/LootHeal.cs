
using UnityEngine;

public class LootHeal : MonoBehaviour
{
    [SerializeField] private int _healValue = 1;
   private void OnTriggerEnter(Collider other)
    {      
       if(other.attachedRigidbody.GetComponent<PlayerHealth>())
           {
               other.attachedRigidbody.GetComponent<PlayerHealth>().AddHealth(_healValue);
                Destroy(gameObject);
           }            
   }
}
