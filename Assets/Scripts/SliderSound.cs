using UnityEngine;

public class SliderSound : Sound
{
    [SerializeField] private string _button;

    public void ChangeVolume(float volume)
    {
        Change(_button, volume);
    }
}
