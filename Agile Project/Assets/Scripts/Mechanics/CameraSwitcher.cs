using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    public Transform player;
    public CinemachineVirtualCamera activeCamera;

    private void FixedUpdate()
    {
        activeCamera.Priority = 0;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            activeCamera.Priority = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            activeCamera.Priority = 0;
        }
    }
}
