
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth;
    [SerializeField] private AudioSource _pickUpHealth;
     [SerializeField] private HealthBar _healthBar;
     [SerializeField] private UnityEvent _onTakeDamage;
    private bool _invulnerable= false;
   
 
     private void Start()
     {
        _healthBar.Setup(_maxHealth);
        _healthBar.DisplayHealth(_health);
     }
    public void AddHealth(int value)
    {
      _health += value;
      _pickUpHealth.Play();

      if(_health >= _maxHealth)
         _health = _maxHealth;

       _healthBar.DisplayHealth(_health);
    }

    public void TakeDamage(int value)
    {
        if(_invulnerable == false)
        {
         _health -= value;
        
          if(_health <=0)
          {
              _health = 0;
              Die();           
          }
             _invulnerable = true;
               _healthBar.DisplayHealth(_health);
            
             Invoke(nameof(InvulnurableDisActivate), 1f);  
              _onTakeDamage?.Invoke();
        }  
    }
    private void Die()
    {
        Debug.Log("you Die!!!");
    }
    private void InvulnurableDisActivate() => _invulnerable = false;

}
