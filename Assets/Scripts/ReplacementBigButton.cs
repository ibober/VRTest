using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReplacementBigButton : MonoBehaviour
{
    public float GazeTime = 2.0f; // also change value in ExitIcon() method
    public Button OptionOne;
    public Button OptionTwo;

    private bool timerIsTicking = false;
    private bool done = false;

	void Update ()
	{
	    if (!done)
	    {
            if (timerIsTicking)
            {
                if ((GazeTime -= Time.deltaTime) < 0) ShowChildIcons();
            }
        }
    }

    public void EnterIcon()
    {
        done = false;
	    timerIsTicking = true;
    }

    public void ExitIcon()
    {
        timerIsTicking = false;
        GazeTime = 2.0f; //also change default value
    }

    void ShowChildIcons()
    {
        OptionOne.gameObject.SetActive(true);
        OptionTwo.gameObject.SetActive(true);
        done = true;
    }
}
