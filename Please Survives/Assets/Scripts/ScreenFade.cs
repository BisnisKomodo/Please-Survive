using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ScreenFade : MonoBehaviour
{
    private Image screenfadeimage;
    private void Awake()
    {
        screenfadeimage = GetComponent<Image>();
        // if (screenfadeimage == null)
        // {
        //     Debug.LogError("Image component is missing from this GameObject.");
        // }
    }

    public IEnumerator FadeInCoroutine(float duration)
    {
        Color startcolor = new Color(screenfadeimage.color.r, screenfadeimage.color.g, screenfadeimage.color.b, 1);
        Color targetcolor = new Color(screenfadeimage.color.r, screenfadeimage.color.g, screenfadeimage.color.b, 0);

        yield return FadeCoroutine(startcolor, targetcolor, duration);
        gameObject.SetActive(false);
    }

    public IEnumerator FadeOutCoroutine(float duration)
    {
        Color startcolor = new Color(screenfadeimage.color.r, screenfadeimage.color.g, screenfadeimage.color.b, 0);
        Color targetcolor = new Color(screenfadeimage.color.r, screenfadeimage.color.g, screenfadeimage.color.b, 1);

        gameObject.SetActive(true);
        yield return FadeCoroutine(startcolor, targetcolor, duration);
    }

    private IEnumerator FadeCoroutine(Color startcolor, Color targetcolor, float duration)
    {
        float elapsedtime = 0;
        float elapsedpercentage = 0;

        while (elapsedpercentage < 1)
        {
            elapsedpercentage = elapsedtime / duration;
            screenfadeimage.color = Color.Lerp(startcolor, targetcolor, elapsedpercentage);

            yield return null;
            elapsedtime += Time.deltaTime;
        }
    }
}
