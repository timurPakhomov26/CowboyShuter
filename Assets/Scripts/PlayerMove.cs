
using UnityEngine;

public class PlayerMove : MonoBehaviour
{ 
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpSpeed;
    [SerializeField] private float _friction;
    [SerializeField] private Transform _colliderTransform;
    [SerializeField] private float _maxSpeed;
    private bool _isGrounded;


   private void Update() 
    {
        Jump();
    }

   private void FixedUpdate()
    {
     Move();

      if(Input.GetKey(KeyCode.S) || _isGrounded==false)
         _colliderTransform.localScale = Vector3.Lerp(_colliderTransform.localScale, new Vector3(1.0f,0.5f,1.0f),Time.deltaTime*15f);
  
      else   
         _colliderTransform.localScale = Vector3.Lerp(_colliderTransform.localScale, new Vector3(1.0f,1.0f,1.0f),Time.deltaTime*15f);
    }

   private void OnCollisionStay(Collision other) 
    {
     float angle = Vector3.Angle(other.contacts[0].normal,Vector3.up);

     if(angle < 45)
        _isGrounded=true;
    
    }
   private void OnCollisionExit(Collision other) 
    {
     _isGrounded=false;
    }

   private void Jump()
    {
      if(Input.GetKeyDown(KeyCode.Space)  && _isGrounded==true)
          _rigidbody.AddForce(0,_jumpSpeed,0,ForceMode.VelocityChange); 
    }

 private void Move()
   {
      float speedmultiplyer=1f;

     if(_isGrounded == false)
      {
         speedmultiplyer = 0.1f;

       if(_rigidbody.velocity.x > _maxSpeed && Input.GetAxis("Horizontal") > 0)
         speedmultiplyer = 0;
      
        if(_rigidbody.velocity.x < -_maxSpeed && Input.GetAxis("Horizontal") < 0)
           speedmultiplyer = 0;
       }
       
     _rigidbody.AddForce(Input.GetAxis("Horizontal") * _moveSpeed * speedmultiplyer,0,0,ForceMode.VelocityChange);

    if(_isGrounded == true)     
        _rigidbody.AddForce(-_rigidbody.velocity.x * _friction,0,0,ForceMode.VelocityChange);
   }
}
