using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : CharacterGUID, IDamageable
{
    [SerializeField] private AudioClip _chop;
    [SerializeField] private AudioSource _source;

    private void Start()
    {
        _source.clip = _chop;
    }

    public void TakeDamage(int amount)
    {
        _health -= amount;

        if (_health <= 0 )
        {
            _source.Play();
            this.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (_health <= 0 )
        {
            this.gameObject.SetActive(false);
        }
    }
}
