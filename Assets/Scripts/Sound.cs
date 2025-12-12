using UnityEngine;
using UnityEngine.Audio;

public abstract class Sound : MonoBehaviour
{
    [field: SerializeField] protected AudioMixerGroup MixerGroup { get; private set; }

    public void Change(string name, float volume)
    {
        MixerGroup.audioMixer.SetFloat(name, Mathf.Log10(volume) * 20);

        if (volume == 0)
            MixerGroup.audioMixer.SetFloat(name, -80);
    }
}