using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource _audioSource;
    public AudioClip _audioClip;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        if (_audioClip != null)
        {
            _audioSource.PlayOneShot(_audioClip);
        }
    }
}
