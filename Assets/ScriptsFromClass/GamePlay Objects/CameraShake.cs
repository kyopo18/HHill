using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Transform cameraTransform; // Reference to the camera's transform
    public float shakeDuration = 0.5f; // Duration of the shake
    public float shakeMagnitude = 0.1f; // Magnitude of the shake
    public float dampingSpeed = 1.0f; // Speed at which the shake decreases

    private Vector3 initialPosition;
    private float currentShakeDuration = 0f;

    public static CameraShake instance;

    void Start()
    {
        if (cameraTransform == null)
        {
            cameraTransform = GetComponent<Transform>();
        }
        initialPosition = cameraTransform.localPosition;

        instance = this;
    }

    void Update()
    {
        if (currentShakeDuration > 0)
        {
            cameraTransform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            currentShakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            currentShakeDuration = 0f;
            cameraTransform.localPosition = initialPosition;
        }
    }

    // Call this method to start the shake effect
    public void TriggerShake()
    {
        currentShakeDuration = shakeDuration;
    }
}
