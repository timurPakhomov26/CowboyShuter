
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Hen : MonoBehaviour
{
    
    [Range(0,5)] [SerializeField] private float _speed;
    [SerializeField] private float _timeToReachSpeed;
     private Rigidbody _rigidbody;
     private Transform _player;


   private void Start()
    {
       _rigidbody = GetComponent<Rigidbody>(); 
       _player = FindObjectOfType<PlayerHealth>().transform;
    }

    private void FixedUpdate()
    {
       FollowPlayer(); 
    }
    private void FollowPlayer()
    {
       Vector3 _direction = (_player.position - transform.position).normalized;
       Vector3 _force = _rigidbody.mass * ( _direction * _speed - _rigidbody.velocity) / _timeToReachSpeed;
        _rigidbody.AddForce( _force * _speed);
    }
}
