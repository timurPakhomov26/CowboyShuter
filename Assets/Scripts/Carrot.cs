
using UnityEngine;

public class Carrot : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    private Transform _player;
    
    private void Start()
    {
       _player = FindObjectOfType<PlayerHealth>().transform; 
       _rigidbody = GetComponent<Rigidbody>();
       FollowToPlayer();
    }
    private void FollowToPlayer()
    {
        var direction = (_player.position - transform.position).normalized;
        _rigidbody.velocity = direction * _speed;
    }
}
