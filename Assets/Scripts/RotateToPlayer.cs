
using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed =4f;
     [SerializeField] private Vector3 _rightRotation;
     [SerializeField] private Vector3 _leftRotation;
     private Vector3 _rotationTarget;
    private Transform _player;


    private void Start()
    {
        _player = FindObjectOfType<PlayerHealth>().transform;
    }
     
    private void Update() {
        Rotate();
    }
    private void Rotate()
    {
      if(_player.position.x < transform.position.x)
         _rotationTarget  = _leftRotation;

       else 
         _rotationTarget = _rightRotation;

         transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(_rotationTarget),
           Time.deltaTime * _rotationSpeed);
    }
}
