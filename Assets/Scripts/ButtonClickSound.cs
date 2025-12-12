using UnityEngine;

public class ButtonClickSound : MonoBehaviour
{
    public void OnButton(AudioSource audioSource)
    {
        audioSource.Play();
    }
}
