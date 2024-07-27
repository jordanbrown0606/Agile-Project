using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DoorScript
{
	[RequireComponent(typeof(AudioSource))]


public class Door : MonoBehaviour, IInteractable {
	public bool open;
	public float smooth = 1.0f;
	float DoorOpenAngle = 90.0f;
    float DoorCloseAngle = 0.0f;
	public AudioSource asource;
	public AudioClip openDoor,closeDoor;
        // Use this for initialization
        [SerializeField] private Collider _inventory;
        [SerializeField] private GameObject _key;

        void Start () {
		asource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (open)
		{
            var target = Quaternion.Euler (0, DoorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, target, Time.deltaTime * 5 * smooth);
	
		}
		else
		{
            var target1= Quaternion.Euler (0, DoorCloseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, target1, Time.deltaTime * 5 * smooth);
	
		}  
	}

    public void Interact(GameObject objAttemptingInteraction)
        {
            if (objAttemptingInteraction.tag == "Player")
            {
				if (_key == null)
				{
					OpenDoor();
				}
				else if(_key != null)
				{
                    if (_inventory.bounds.Contains(_key.transform.position))
                    {
						OpenDoor();
                    }
                }
            }
        }

        public void OpenDoor(){
		open =!open;
		asource.clip = open?openDoor:closeDoor;
		asource.Play ();
	}
}
}