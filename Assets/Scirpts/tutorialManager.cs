using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialManager : MonoBehaviour
{
    [SerializeField] private GameObject tutorialOverPanel;
    [SerializeField] float tutorialDuration = 15.0f; 
    private bool tutorialActive = true;

    private void Start()
    {
        tutorialOverPanel.SetActive(false); 
        StartCoroutine(TutorialTimer());
    }

    private IEnumerator TutorialTimer()
    {
        yield return new WaitForSeconds(tutorialDuration);
        EndTutorial();
    }

    private void EndTutorial()
    {
        tutorialActive = false;
        tutorialOverPanel.SetActive(true);
        Time.timeScale = 0;
        PlayerPrefs.SetInt("TutorialCompleted", 1); 
        PlayerPrefs.Save(); 
    }

    public void CompleteTutorial() 
    {
        if (tutorialActive)
        {
            StopCoroutine(TutorialTimer());
            EndTutorial();
        }
    }

    public void GoToMainGame() 
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainGameScene");
    }
}
