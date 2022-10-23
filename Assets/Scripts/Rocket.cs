
using UnityEngine;

public class Rocket : MonoBehaviour
{
   [SerializeField] private float _speed;
    [SerializeField] private float _rotateSpeed;
   private Transform _player;
   private void Start()
    {
        _player = FindObjectOfType<PlayerHealth>().transform;
    }
 
   private void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.position += Time.deltaTime * transform.forward * _speed;
      var direction = _player.position - transform.position;
      var targetRotation = Quaternion.LookRotation(direction,Vector3.forward);

       transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation
         ,Time.deltaTime * _rotateSpeed);
       
    }
}
