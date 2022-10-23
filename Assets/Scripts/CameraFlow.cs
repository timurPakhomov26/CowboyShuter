
using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    [SerializeField] private Transform _cameraCenter;
    [SerializeField] private float _speedOfflow;

    private void Update()
    {
       transform.position = Vector3.Lerp(transform.position,_cameraCenter.position,Time.deltaTime*_speedOfflow);
    }
}
