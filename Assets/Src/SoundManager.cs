using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource backroundAudioSource;
    [SerializeField] private AudioSource effectAudioSource;
    [SerializeField] private AudioClip backgroundClip;
    [SerializeField] private AudioClip jumpClip;
    [SerializeField] private AudioClip coinClip;
    [SerializeField] private AudioClip hurtClip;

    private void Start()
    {
        PlayBackGroundMusic();
    }

    private void PlayBackGroundMusic()
    {
        backroundAudioSource.clip = backgroundClip;
        backroundAudioSource.Play();
    }
    public void PlayJumpSound()
    {
        effectAudioSource.PlayOneShot(jumpClip);
    }
    public void PlayCoinSound()
    {
        effectAudioSource.PlayOneShot(coinClip);
    }
    public void PlayHurtSound()
    {
        effectAudioSource.PlayOneShot(hurtClip);
    }
}
