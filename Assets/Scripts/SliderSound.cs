using UnityEngine;

public class SliderSound : Sound
{
    [SerializeField] private string _button;

    public void ChangeVolume(float volume)
    {
        MixerGroup.audioMixer.SetFloat(_button, Mathf.Log10(volume) * 20);

        if (volume == 0)
            MixerGroup.audioMixer.SetFloat(_button, -80);
    }
}
