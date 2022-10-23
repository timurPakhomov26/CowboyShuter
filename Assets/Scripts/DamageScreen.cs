using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DamageScreen : MonoBehaviour
{  
    [SerializeField] private Image _screenImage;

    private void Start()
    {
        _screenImage.enabled = false;
    }
    public void StartScreen()
    { 
       StartCoroutine(ShowScreen());
    }
    public IEnumerator ShowScreen()
    {
        _screenImage.enabled=true;
        for(float t = 1f;t>0f;t-=Time.deltaTime)
        {
            _screenImage.color = new Color(1,0,0,t);
            yield return null; 
        }
        _screenImage.enabled=false;
    }
}
