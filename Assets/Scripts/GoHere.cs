using UnityEngine;
using System.Collections;

public class GoHere : MonoBehaviour
{
    public float GazeTime = 3.0f; //also change value in CheckTimer() method
    private bool timerIsTicking = false;

    void Update()
    {
        if (timerIsTicking)
        {
            if ((GazeTime -= Time.deltaTime) < 0) Move();
        }
    }

	public void Countdown() //starts 3 seconds timer
	{
	    timerIsTicking = true;
	}

    public void CheckTimer() //stops timer
    {
        timerIsTicking = false;
        GazeTime = 3.0f; //also change default value
    }

    void Move()
    {
        Camera.main.transform.position = gameObject.transform.position;
    }
}
