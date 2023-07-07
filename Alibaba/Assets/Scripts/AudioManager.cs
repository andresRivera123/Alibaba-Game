using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioClip backgroundMusicClip;

    private AudioSource audioSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
            audioSource.loop = true;
            audioSource.clip = backgroundMusicClip;
            audioSource.Play();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ChangeBackgroundMusic(AudioClip newClip)
    {
        backgroundMusicClip = newClip;
        audioSource.clip = backgroundMusicClip;
        audioSource.Play();
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }
}