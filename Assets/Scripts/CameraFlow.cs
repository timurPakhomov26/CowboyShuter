
using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    [SerializeField] private Transform _cameraCenter;
    [SerializeField] private float _speedOfflow;
    private  float _speed = 1f;

    private void Update()
    {
       transform.position = Vector3.Lerp(transform.position,_cameraCenter.position,Time.deltaTime*_speedOfflow);
    }
}
