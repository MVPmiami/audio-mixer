using UnityEngine;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;

    private const string MasterVolume = "MasterVolume";
    private const string EffectsVolume = "EffectsVolume";
    private const string MusicVolume = "MusicVolume";
    private const float MutedVolume = -80f;
    private const float MaxVolume = 0f;
    private const float VolumeScaleFactor = 20f;

    private bool _isMuted = false;

    private void ChangeVolume(string mixerGroupName,float volume)
    {
        _mixer.audioMixer.SetFloat(mixerGroupName, Mathf.Log10(volume) * VolumeScaleFactor);
    }

    public void Mute()
    {
        _isMuted = !_isMuted;

        _mixer.audioMixer.SetFloat(MasterVolume,_isMuted ? MutedVolume : MaxVolume);
    }

    public void ChangeMasterVolume(float volume)
    {
        ChangeVolume(MasterVolume, volume);
    }

    public void ChangeEffectsVolume(float volume)
    {
        ChangeVolume(EffectsVolume, volume);
    }

    public void ChangeMusicVolume(float volume)
    {
        ChangeVolume(MusicVolume, volume);
    }
}