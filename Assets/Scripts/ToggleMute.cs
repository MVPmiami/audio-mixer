using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ToggleMute : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private AudioMixerGroup _mixer;

    private const float MutedVolume = -80f;
    private const float MaxVolume = 0f;

    private bool _isMuted = false;

    private void OnEnable()
    {
        _button.onClick.AddListener(Mute);
    }

    private void OnDisable()
    {
        _button?.onClick.RemoveListener(Mute);
    }

    public void Mute()
    {
        _isMuted = !_isMuted;

        _mixer.audioMixer.SetFloat(_mixer.name, _isMuted ? MutedVolume : MaxVolume);
    }
}