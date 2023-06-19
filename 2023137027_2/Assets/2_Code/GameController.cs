using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private bool isPaused = false;

    private void TogglePause()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        isPaused = !isPaused;

        if (isPaused)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    private void PauseGame()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        Time.timeScale = 0f;
        // 포즈 상태에 맞게 추가 동작 수행
    }

    private void ResumeGame()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        Time.timeScale = 1f;
        // 포즈 상태 해제에 맞게 추가 동작 수행
    }
}
