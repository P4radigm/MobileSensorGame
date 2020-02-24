using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensorDebugDebug : MonoBehaviour
{

    [Header("Sensor Data text")]
    [SerializeField] private Text dataGyroRotationRate;
    [SerializeField] private Text dataGyroRotationRateUnbiased;
    [SerializeField] private Text dataGyroGravity;
    [SerializeField] private Text dataGyroUserAcceleration;
    [SerializeField] private Text dataGyroAttitude;
    [SerializeField] private Text dataAccelerometer;
    [SerializeField] private Text dataCompMagneticHeading;
    [SerializeField] private Text dataCompTrueHeading;
    [SerializeField] private Text dataCompHeadingAccuracy;
    [SerializeField] private Text dataCompRawVector;

    [Header("Enabled Check Fields")]
    [SerializeField] private Image statusGyroscope;
    [SerializeField] private Image statusCompass;
    [SerializeField] private Image statusAccelerometer;
    //[SerializeField] private Image statusGyroGravity;
    //[SerializeField] private Image statusGyroUserAcceleration;
    //[SerializeField] private Image statusGyroAttitude;

    UnityEngine.Gyroscope m_Gyro;
    Compass m_Compass;

    // Start is called before the first frame update
    void Start()
    {
        m_Compass = Input.compass;
        m_Compass.enabled = true;
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
        m_Gyro.updateInterval = 0.1f;

    }

    // Update is called once per frame
    void Update()
    {
        dataCompTrueHeading.text = m_Compass.trueHeading.ToString();
        dataCompHeadingAccuracy.text = m_Compass.headingAccuracy.ToString();
        dataCompMagneticHeading.text = m_Compass.magneticHeading.ToString();
        dataCompRawVector.text = m_Compass.rawVector.ToString();
        dataAccelerometer.text = Input.acceleration.ToString();
        dataGyroRotationRate.text = m_Gyro.rotationRate.ToString();
        dataGyroRotationRateUnbiased.text = m_Gyro.rotationRateUnbiased.ToString();
        dataGyroGravity.text = m_Gyro.gravity.ToString();
        dataGyroUserAcceleration.text = m_Gyro.userAcceleration.ToString();
        dataGyroAttitude.text = m_Gyro.attitude.ToString();

        if (m_Compass.enabled)
        {
            statusCompass.color = Color.green;
        }
        else
        {
            statusCompass.color = Color.red;
        }

        if (m_Gyro.enabled)
        {
            statusGyroscope.color = Color.green;
        }
        else
        {
            statusGyroscope.color = Color.red;
        }

        if (Input.acceleration != Vector3.zero)
        {
            statusAccelerometer.color = Color.green;
        }
        else
        {
            statusAccelerometer.color = Color.red;
        }
    }
}
