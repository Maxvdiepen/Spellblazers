using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFunctions : MonoBehaviour
{
    public void ToggleVisibility()
    {
        this.GetComponent<Text>().enabled =! this.GetComponent<Text>().enabled;
    }

    public void StartFadingImage()
    {
        Image inputSuggestion = this.GetComponent<Image>();
        StartCoroutine(ImageFadeInAndOut(inputSuggestion, 0.9f));
    }

    public IEnumerator ImageFadeInAndOut(Image ImageToFade, float lerpTime)
    {
        float timeStarted = Time.time;
        float timeSinceStart = Time.time - timeStarted;
        float percentage = timeSinceStart / lerpTime;
        bool cycleSwitch = false;
        
        while (true)
        {
            while (cycleSwitch == false)
            {
                timeSinceStart = Time.time - timeStarted;
                percentage = timeSinceStart / lerpTime;

                ImageToFade.color = new Color(0, 0, 0, percentage);

                if (percentage >= 1)
                {
                    timeStarted = Time.time;
                    cycleSwitch = !cycleSwitch;
                    break;
                }
                yield return new WaitForEndOfFrame();
            }

            while (cycleSwitch == true)
            {
                timeSinceStart = Time.time - timeStarted;
                percentage = 1 - (timeSinceStart / lerpTime);

                ImageToFade.color = new Color(0, 0, 0, percentage);

                if (percentage <= 0)
                {
                    timeStarted = Time.time;
                    cycleSwitch = !cycleSwitch;
                    break;
                }
                yield return new WaitForEndOfFrame();
            }
        }
    }
}