
using UnityEngine;

public class CarrotCreator : MonoBehaviour
{
   [SerializeField] GameObject _carrotPrefabl;
   [SerializeField] private Transform _spawn;

    public void Create()
    {
         Instantiate(_carrotPrefabl,_spawn.position,Quaternion.identity);
    }
}
