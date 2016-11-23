using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour
{
	void Update ()
	{
	    gameObject.transform.LookAt(Camera.main.transform);
	}
}
