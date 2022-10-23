
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _spawn;
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private float _shotPeriod;
    [SerializeField]private AudioSource _shot;
    [SerializeField] private GameObject _flash;
    private float time;

    private void Start()
    {
       _flash.SetActive(false);
    }
    private void Update() 
    {
        BulletCreate();    
    }
    private void BulletCreate()
    {
         time += Time.deltaTime;
      if(Input.GetMouseButton(0) && time > _shotPeriod)
        {
            time = 0f;
            var newBullet =  Instantiate(_bulletPrefab,_spawn.position,Quaternion.identity);
            _shot.Play();
            newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * _bulletSpeed,ForceMode.VelocityChange);
            _flash.SetActive(true);
            Invoke(nameof(HideFlash),0.1f);
        }
    }
    private void HideFlash() => _flash.SetActive(false);    
}
