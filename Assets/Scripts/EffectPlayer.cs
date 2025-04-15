using UnityEngine;
using UnityEngine.UI;

public class Effectplayer : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private AudioSource _audio;

    private void OnEnable()
    {
        _button?.onClick.AddListener(delegate { PlayEffect(); } );
    }

    private void PlayEffect()
    {
        _audio?.Play();
    }
}