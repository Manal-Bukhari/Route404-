using UnityEngine;

public class RouterEffectTrigger : MonoBehaviour
{
    [SerializeField] private ParticleSystem sparkEffect;
    [SerializeField] private AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Packet"))
        {
            if (sparkEffect != null) sparkEffect.Play();
            if (audioSource != null) audioSource.Play();
        }
    }
}
