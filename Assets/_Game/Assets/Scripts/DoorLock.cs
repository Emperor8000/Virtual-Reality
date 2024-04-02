using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorLock : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public bool isLocked = false;
    [SerializeField] public GameObject key = null;
    [SerializeField] private GameObject turnKeyPrefab = null;
    [SerializeField] private UnityEvent onStart;
    [SerializeField] private UnityEvent correctKeyEntered;
    [SerializeField] public UnityEvent unlock;

    [HideInInspector]public List<GameObject> currentKeys = new List<GameObject>();
    void Start()
    {
        onStart.Invoke();
    }

    public void keyEntered()
    {
        //unlock the door
        foreach(GameObject givenKey in currentKeys)
        {
            if(givenKey == key)
            {
                correctKeyEntered.Invoke();
                Rigidbody keyRB = key.GetComponent<Rigidbody>();
                keyRB.isKinematic = true;
                Collider keyCollider = key.GetComponent<Collider>();
                keyCollider.enabled = false;

                if (turnKeyPrefab)
                {
                    GameObject turnKey = Instantiate(turnKeyPrefab, key.transform.position, key.transform.rotation);
                    MeshRenderer turnKeyTexture = turnKey.GetComponentInChildren<MeshRenderer>();
                    MeshRenderer keyTexture = key.GetComponentInChildren<MeshRenderer>();
                    turnKeyTexture.material = keyTexture.material;
                    key.SetActive(false);
                    TurnKey keyScript = turnKey.GetComponent<TurnKey>();
                    keyScript.doorLock = this;
                }
            }
        }
    }
}
