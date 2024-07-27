using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _clue;

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<Enemy>().Health <= 0)
        {
            StartCoroutine(WaitforSpawn());
        }
    }

    public IEnumerator WaitforSpawn()
    {
        yield return new WaitForSeconds(1.2f);
        _clue.transform.position = transform.position + new Vector3(0, 1.5f, 0);
    }
}
