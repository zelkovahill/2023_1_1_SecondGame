using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    public void Quit()
    {

        AudioManager.instance.PlaySfx(AudioManager.Sfx.Select);
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}