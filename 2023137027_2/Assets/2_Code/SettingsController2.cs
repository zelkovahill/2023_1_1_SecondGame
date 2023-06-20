using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsController2 : MonoBehaviour
{
    [SerializeField]
    private Button backButton;
    public GameObject sina;

    public GameObject settingsPanel;
    public Button[] buttons;
    public Button gameStartButton;
    public Button settingsButton;
    public Button quitButton;
    private bool isSettingsOpen = false;

    public Slider soundSlider;

    private bool isGamePaused = false;

    private void Start()
    {
        settingsPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleSettings();
        }
    }

    public void ToggleSettings()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        isSettingsOpen = !isSettingsOpen;

        if (isSettingsOpen)
        {
            OpenSettings();
        }
        else
        {
            CloseSettings();
        }
    }

    private void OpenSettings()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);

        isGamePaused = true;
        Time.timeScale = 0f;
        settingsPanel.SetActive(true);

       
    }

    private void CloseSettings()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        isGamePaused = false;
        settingsPanel.SetActive(false);

      
    }

    private void SetButtonsInteractable(bool interactable)
    {
        foreach (Button button in buttons)
        {
            button.interactable = interactable;
            button.gameObject.SetActive(interactable);
        }
    }

    public void GoBack()
    {
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        CloseSettings();
        
    }

    public void OnSoundSliderValueChanged(float value)
    {
       
    }


    public void HomeBack()
    {

        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        SceneManager.LoadScene(0); // 다음 씬으로 이동
    }

    public void Nextsin(string name)
    {
        AudioManager.instance.PlayBgm(false);
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
        SceneManager.LoadScene(name); 
    }    

public void dab()
{
    sina.SetActive(true);
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);

}
public void Nodab()
{
    sina.SetActive(false);
        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);

}


   

    private void FixedUpdate()
    {
        if (isGamePaused)
        {

        }
    }
}