using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NailStart : MonoBehaviour
{
    [SerializeField] private Transform hammerTransform;

    [SerializeField] private Quaternion initialRotation;
    [SerializeField] private Quaternion tweakRot;
    [SerializeField] private Quaternion multQuat;

    private UnityEngine.Gyroscope m_Gyro;

    // Start is called before the first frame update
    void Start()
    {
        hammerTransform = this.transform;
        initialRotation = hammerTransform.rotation;
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
        m_Gyro.updateInterval = 0.1f;
        //multQuat = initialRotation * tweakRot;
    }

    // Update is called once per frame
    void Update()
    {
        hammerTransform.localEulerAngles = new Vector3(360 * ((m_Gyro.gravity.x+1)/2), 360 * ((m_Gyro.gravity.y + 1) / 2), 360 * ((m_Gyro.gravity.z + 1) / 2));
    }
}
