using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
   
   [SerializeField] private GameObject _iconPrefab;
   private List<GameObject> _healthIcons = new List<GameObject>();
 
  public void Setup(int maxHealth)
    {
     for(int i=0;i< maxHealth;i++)
       {
         var icon =  Instantiate(_iconPrefab,transform);
          _healthIcons.Add(icon);
       }   
    }
    public void DisplayHealth(int health)
    {
      for(int i=0; i< _healthIcons.Count;i++)
      {
         if(i<health)
           _healthIcons[i].SetActive(true);
         
         else 
           _healthIcons[i].SetActive(false);
      }
    }
}
