using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{

   

    private bool isPaused = false; // 게임 일시 정지 여부를 저장하는 변수 추가

   

    private IEnumerator GameClear()
    {
        AudioManager.instance.PlayBgm(false);
        Time.timeScale = 0f; // 게임 일시 정지

        yield return new WaitForSecondsRealtime(3f); // 3초 대기 (실제 시간 기준)

        Time.timeScale = 1f; // 게임 재개
        SceneManager.LoadScene(0); // 다음 씬으로 이동 (씬 이름을 적절히 변경해야 함)
    }


    public void GameStart()
    {

        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        AudioManager.instance.PlayBgm(false);
        
        SceneManager.LoadScene(1);
    }

    public void PauseGame()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        isPaused = true;
        Time.timeScale = 0f; // 게임 일시 정지

    }

    public void ResumeGame()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        isPaused = false;
        Time.timeScale = 1f; // 게임 재개

    }


    public void Nextsin(string name)
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        SceneManager.LoadScene(name); // 다음 씬으로 이동
    }

    public void ComeBackHome()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        SceneManager.LoadScene(0);
    }

    public void PlayMusic()
    {
        AudioManager.instance.PlayBgm(true);
    }


    public void StopMusic()
    {
        AudioManager.instance.PlayBgm(false);
    }


    public void aoao(string name)
    {

        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        
        
        SceneManager.LoadScene(name);
    }

}