using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGatewayTeleport : MonoBehaviour
{
	public Transform teleportTarget;
	public GameObject thePlayer;

	public void OnTriggerEnter(Collider other)
	{
		CharacterController cc = thePlayer.GetComponent<CharacterController>();
		cc.enabled = false;

		Debug.Log("Something should teleport now");
		thePlayer.transform.position = teleportTarget.transform.position;
		Debug.Log("Something should have been teleported now");

		cc.enabled = true;
	}
}
