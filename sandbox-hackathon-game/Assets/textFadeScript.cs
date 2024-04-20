using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class textFadeScript : MonoBehaviour
{
    public float fadeDuration = 3f; // Duration of the fade in seconds

    public Text textComponent;
    public CanvasGroup canvasGroup;

    private void Start()
    {
        textComponent = GetComponent<Text>();
        canvasGroup = GetComponent<CanvasGroup>();

        // Initially set the text to fully transparent
        canvasGroup.alpha = 0f;
        FadeOutText();
    }

    public void FadeInText()
    {
        // Fade the text in gradually over fadeDuration seconds
        StartCoroutine(FadeText(0f, 1f, fadeDuration));
    }

    public void FadeOutText()
    {
        // Fade the text out gradually over fadeDuration seconds
        StartCoroutine(FadeText(1f, 0f, fadeDuration));
    }

    private IEnumerator FadeText(float startAlpha, float targetAlpha, float duration)
    {
        float timer = 0f;
        while (timer < duration)
        {
            // Calculate the current alpha value using a linear interpolation
            canvasGroup.alpha = Mathf.Lerp(startAlpha, targetAlpha, timer / duration);
            timer += Time.deltaTime;
            yield return null;
        }

        // Ensure the final alpha value is set
        canvasGroup.alpha = targetAlpha;
    }
}
