public class MasterSound : Sound
{
    private const string Master = nameof(Master);

    private readonly int _minVolume = -80;
    private readonly int _maxVolume = 0;

    public void OnToggle(bool enabled)
    {
        if (enabled)
            MixerGroup.audioMixer.SetFloat(Master, _maxVolume);
        else
            MixerGroup.audioMixer.SetFloat(Master, _minVolume);
    }
}
