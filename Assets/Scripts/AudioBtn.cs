using UnityEngine;
using UnityEngine.UI;

public class AudioBtn : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private AudioSource _audio;

    private void OnEnable()
    {
        _button?.onClick.AddListener(PlayEffect);
    }

    private void OnDisable()
    {
        _button?.onClick.RemoveListener(PlayEffect);
    }

    private void PlayEffect()
    {
        _audio?.Play();
    }
}