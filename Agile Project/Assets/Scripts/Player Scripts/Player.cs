using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Handles the save and load.
/// Protip: This script is bad and should not handle that stuff.
/// Maybe you should use an input manager instead.
/// </summary>

public class Player : CharacterGUID, IDamageable
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Image _sliderFill;

    public GameObject deathScreen;

    public void TakeDamage(int amount)
    {
        _health -= amount;
        UpdateHealthBar();
    }

    private void Update()
    {
        if (_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        GetComponent<CharacterController>().enabled = false;
        deathScreen.SetActive(true);

    }

    private void UpdateHealthBar()
    {
        _healthBar.value = _health;

        if (_healthBar.value <= 4)
        {
            _sliderFill.color = Color.red;
        }
    }
}
