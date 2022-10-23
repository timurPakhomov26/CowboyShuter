
using UnityEngine;

public class Pointer: MonoBehaviour
{
    [SerializeField] private Transform _aim;
    [SerializeField] private Transform _player;
    [SerializeField] private Camera _mainCamera;
    private float _yEyler;
    private Vector3 rotation;
 
   
   private void LateUpdate()
    {
      ShowAim();
      RotateGun();
    }
    private void ShowAim()
    {
       var ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
       var plane = new Plane(-Vector3.forward,Vector3.zero);
       float distance;
       plane.Raycast(ray,out distance);
       var point = ray.GetPoint(distance);
       _aim.position = point;
    }
    private void RotateGun()
    {
        rotation = _aim.position - transform.position;
       transform.rotation = Quaternion.LookRotation(rotation,Vector3.up);

       if(rotation.x  < 0f)
          _yEyler = Mathf.Lerp(_yEyler,45f,Time.deltaTime * 8f);
           
         else 
           _yEyler = Mathf.Lerp(_yEyler,-45f,Time.deltaTime * 8f);

         _player.localEulerAngles = new Vector3(0f,_yEyler,0f); 
    }
    
}
