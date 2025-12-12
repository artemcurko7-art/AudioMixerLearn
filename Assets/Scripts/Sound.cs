using UnityEngine;
using UnityEngine.Audio;

public abstract class Sound : MonoBehaviour
{
    [field: SerializeField] protected AudioMixerGroup MixerGroup { get; private set; }
}