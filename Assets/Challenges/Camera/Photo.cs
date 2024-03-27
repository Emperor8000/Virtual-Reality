using System.Collections;
using UnityEngine;

[RequireComponent(typeof(ApplyPhysics))]
public class Photo : MonoBehaviour
{
    public MeshRenderer imageRenderer = null;
    [SerializeField] private float seconds = 1f;

    private Collider currentCollider = null;
    private ApplyPhysics applyPhysics = null;

    public float elapsedTime = 0f;

    private void Awake()
    {
        currentCollider = GetComponent<Collider>();
        applyPhysics = GetComponent<ApplyPhysics>();
    }

    private void Start()
    {
        startupRoutine();
        StartCoroutine(moveImage());
    }

    private void startupRoutine()
    {
        applyPhysics.DisablePhysics();

        if (currentCollider)
        {
            currentCollider.enabled = false;
        }

        elapsedTime = 0f;
    }
    public IEnumerator moveImage()
    {
        while (elapsedTime <= seconds)
        {
            transform.position += transform.forward * Time.deltaTime * 0.15f;
            elapsedTime += Time.deltaTime;

            yield return null;
        }

        StopAllCoroutines();
    }
    public void SetImage(Texture2D texture)
    {
        imageRenderer.material.color = Color.white;
        imageRenderer.material.mainTexture = texture;
    }

    public void EnablePhysics()
    {
        applyPhysics.EnablePhysics();
        if (currentCollider)
        {
            currentCollider.enabled = true;
        }
        transform.parent = null;
    }
}
