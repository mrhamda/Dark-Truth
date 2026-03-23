using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(SetVolumeToSoundEffects))]

public class MouseHover : MonoBehaviour
{
    private AudioSource soundEffectsAudioSource;

    public AudioClip hoverAudioEffect;
    // Start is called before the first frame update
    void Start()
    {
        soundEffectsAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        soundEffectsAudioSource.volume = PlayerPrefs.GetFloat("SoundEffectVolume");
    }

    public void PlayAudioHoverAnimEffect()
    {
        soundEffectsAudioSource.PlayOneShot(hoverAudioEffect);
    }
}
