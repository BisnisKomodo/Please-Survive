using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneController : MonoBehaviour
{
    [SerializeField] private float scenefadeduration;
    private ScreenFade scenefade;
    private void Awake()
    {
        scenefade = GetComponentInChildren<ScreenFade>();
        // if (scenefade == null)
        // {
        //     Debug.LogError("ScreenFade component is missing from this GameObject.");
        // }
    }

    private IEnumerator Start()
    {
        yield return scenefade.FadeInCoroutine(scenefadeduration);
    }

    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadSceneCoroutine(sceneName));
    }

    private IEnumerator LoadSceneCoroutine(string sceneName)
    {
        yield return scenefade.FadeOutCoroutine(scenefadeduration);
        yield return SceneManager.LoadSceneAsync(sceneName);
    }
}
