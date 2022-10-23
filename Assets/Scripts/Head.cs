
using UnityEngine;

public class Head : MonoBehaviour
{
    [SerializeField] private Transform _headTarget;

   private void Update()
    {
       transform.position =  _headTarget.position;
    }
}
