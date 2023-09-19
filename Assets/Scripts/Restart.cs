using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Restart : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _timer;
    public void UpdateTimer()
    {
        _timer.text = "You took " + Time.timeSinceLevelLoad + " seconds";
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void DoNotRestart()
    {
        Application.Quit();
    }
}
