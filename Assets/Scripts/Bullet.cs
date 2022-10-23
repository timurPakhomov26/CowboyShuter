
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject _effect;
    
    private void Start()
    {
       Destroy(gameObject,3f);
    }
    private void OnCollisionEnter(Collision other)
     {
       BulletDestroy();
     }
    private void OnTriggerEnter(Collider other)
    {
       BulletDestroy();  
    }
    private void BulletDestroy()
    {
       Instantiate(_effect,transform.position,Quaternion.identity);
         Destroy(gameObject);
    }
}
