using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSetter : MonoBehaviour
{
    [SerializeField] private Slider _volumeSlider;
    [SerializeField] private AudioMixerGroup _mixer;

    private const float VolumeScaleFactor = 20f;
    private const float MutedVolume = -80f;

    private void OnEnable()
    {
        _volumeSlider?.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        _volumeSlider?.onValueChanged.RemoveListener(ChangeVolume);
    }

    public void ChangeVolume(float volumeValue)
    {
        if (volumeValue == 0f)
            _mixer?.audioMixer.SetFloat(_mixer.name, MutedVolume);
        else
            _mixer?.audioMixer.SetFloat(_mixer.name, Mathf.Log10(volumeValue) * VolumeScaleFactor);
    }
}