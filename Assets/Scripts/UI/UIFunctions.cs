using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFunctions : MonoBehaviour
{
    public BoolReference isPlayerActive;
    
    public void ToggleVisibility()
    {
        this.GetComponent<Text>().enabled =! this.GetComponent<Text>().enabled;
    }

    public void StartFadingImage()
    {
        Image inputImage = this.GetComponent<Image>();
        StartCoroutine(ImageFadeInAndOut(inputImage, 1f));
    }

    public IEnumerator ImageFadeInAndOut(Image ImageToFade, float LerpTime)
    {
        float timeStarted = Time.time;
        bool cycleSwitch = true;
        
        float percentage;
        
        Debug.Log("Enter the loop");

        while (isPlayerActive.value == false)
        {
            float timeSinceStart = Time.time - timeStarted;
            if (cycleSwitch) { percentage = timeSinceStart / LerpTime; }
            else { percentage = 1 - (timeSinceStart / LerpTime); }

            Debug.Log(percentage);
            SetImageOpacity(ImageToFade, percentage);

            if (percentage > 1 || percentage < 0)
            {
                timeStarted = Time.time;
                cycleSwitch = !cycleSwitch;
            }
            yield return new WaitForEndOfFrame();
        }
        SetImageOpacity(ImageToFade, 0f);
    }

    public void SetImageOpacity(Image TargetImage, float Percentage)
    {
        TargetImage.color = new Color(0, 0, 0, Percentage);
    }
}