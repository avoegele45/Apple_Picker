using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;

    // Create a reference for the ApplePicker GameObject
    [SerializeField] private GameObject applePickerObject;

    void Start()
    {
        // Optional: If the applePickerObject is not assigned in the Inspector, try to find it by name
        if (applePickerObject == null)
        {
            applePickerObject = GameObject.Find("ApplePicker"); // Ensure this matches the name of your ApplePicker GameObject in the scene
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);

            // Get a reference to the ApplePicker component from the GameObject
            ApplePicker apScript = applePickerObject.GetComponent<ApplePicker>();

            // Call the public AppleMissed() method of apScript
            if (apScript != null)
            {
                apScript.AppleMissed();
            }
            else
            {
                Debug.LogError("ApplePicker script not found on the referenced object.");
            }
        }
    }
}
