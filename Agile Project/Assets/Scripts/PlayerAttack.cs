using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<PlayerInteraction>().CurWeapon != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _anim.SetBool("isAttacking", true);
                _anim.SetFloat("Vertical", 0f);
                StartCoroutine(ResetBool());
            }
        }
    }

    private void Reset()
    {
       _anim.SetBool("isAttacking", false);
    }

    IEnumerator ResetBool()
    {
        yield return new WaitForSeconds(2.233f);
        _anim.SetBool("isAttacking", false);
    }
}
