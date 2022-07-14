using UnityEngine.SceneManagement;
using UnityEngine;

public class BtnFX : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Fx;
    public AudioClip hoverFx;
    public AudioClip clickFx;

    private static bool created = false;

    private void Start()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }
    public void HoverSound()
    {
        Fx.PlayOneShot(hoverFx);
    }

    public void ClickSound()
    {
        Fx.PlayOneShot(clickFx);
        
    }
}
