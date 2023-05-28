using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public string PlayerTag = "Player";
    public string NextSceneName;
    public Image ScreenBackground;

    private bool finished;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (finished)
            return;
        if (!other.gameObject.CompareTag(PlayerTag))
            return;

        finished = true;
        //SceneManager.LoadScene(NextSceneName);
    }
    private void Update()
    {
        UpdateScreenBackground();
    }

    private void UpdateScreenBackground()
    {
        if (!finished)
            return;
        if (ScreenBackground.color.a >= 1f)
        {
            SceneManager.LoadScene(NextSceneName);

            enabled = false;
        }

        var color = ScreenBackground.color;
        color.a += 0.02f;
        ScreenBackground.color = color;
    }
}
