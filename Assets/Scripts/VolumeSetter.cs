using System;
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
        _volumeSlider?.onValueChanged.AddListener(delegate { ChangeVolume(); });
    }

    public void ChangeVolume()
    {
        if (_volumeSlider.value == 0f)
            _mixer?.audioMixer.SetFloat(_mixer.name, MutedVolume);
        else
            _mixer?.audioMixer.SetFloat(_mixer.name, Mathf.Log10(_volumeSlider.value) * VolumeScaleFactor);
    }
}
