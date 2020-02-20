using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class SensorDebugData : MonoBehaviour
{
    [Header("Sensor Data text")]
    [SerializeField] private Text dataAccelerometer;
    [SerializeField] private Text dataGyroscope;
    [SerializeField] private Text dataGravitySensor;
    [SerializeField] private Text dataAttitudeSensor;
    [SerializeField] private Text dataLinearAccelerationSensor;
    [SerializeField] private Text dataMagneticFieldSensor;
    [SerializeField] private Text dataLightSensor;
    [SerializeField] private Text dataPressureSensor;
    [SerializeField] private Text dataProximitySensor;
    [SerializeField] private Text dataHumiditySensor;
    [SerializeField] private Text dataAmbientTemperatureSensor;
    [SerializeField] private Text dataStepCounter;

    [Header("Enabled Check Fields")]
    [SerializeField] private Image statusAccelerometer;
    [SerializeField] private Image statusGyroscope;
    [SerializeField] private Image statusGravitySensor;
    [SerializeField] private Image statusAttitudeSensor;
    [SerializeField] private Image statusLinearAccelerationSensor;
    [SerializeField] private Image statusMagneticFieldSensor;
    [SerializeField] private Image statusLightSensor;
    [SerializeField] private Image statusPressureSensor;
    [SerializeField] private Image statusProximitySensor;
    [SerializeField] private Image statusHumiditySensor;
    [SerializeField] private Image statusAmbientTemperatureSensor;
    [SerializeField] private Image statusStepCounter;

    // Start is called before the first frame update
    void Start()
    {
        InputSystem.EnableDevice(Accelerometer.current);
        InputSystem.EnableDevice(UnityEngine.InputSystem.Gyroscope.current);
        InputSystem.EnableDevice(GravitySensor.current);
        InputSystem.EnableDevice(AttitudeSensor.current);
        InputSystem.EnableDevice(LinearAccelerationSensor.current);
        InputSystem.EnableDevice(MagneticFieldSensor.current);
        InputSystem.EnableDevice(LightSensor.current);
        InputSystem.EnableDevice(PressureSensor.current);
        InputSystem.EnableDevice(ProximitySensor.current);
        InputSystem.EnableDevice(HumiditySensor.current);
        InputSystem.EnableDevice(AmbientTemperatureSensor.current);
        InputSystem.EnableDevice(StepCounter.current);

        Accelerometer.current.samplingFrequency = 10;
        UnityEngine.InputSystem.Gyroscope.current.samplingFrequency = 10;
        GravitySensor.current.samplingFrequency = 10;
        AttitudeSensor.current.samplingFrequency = 10;
        LinearAccelerationSensor.current.samplingFrequency = 10;
        MagneticFieldSensor.current.samplingFrequency = 10;
        LightSensor.current.samplingFrequency = 10;
        PressureSensor.current.samplingFrequency = 10;
        ProximitySensor.current.samplingFrequency = 10;
        HumiditySensor.current.samplingFrequency = 10;
        AmbientTemperatureSensor.current.samplingFrequency = 10;
        StepCounter.current.samplingFrequency = 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dataAccelerometer.text = Accelerometer.current.acceleration.x.ToString() + "\n" + Accelerometer.current.acceleration.y.ToString() + "\n" + Accelerometer.current.acceleration.z.ToString();
        dataGyroscope.text = UnityEngine.InputSystem.Gyroscope.current.angularVelocity.ToString();
        dataGravitySensor.text = GravitySensor.current.gravity.ToString();
        dataAttitudeSensor.text = AttitudeSensor.current.attitude.ToString();
        dataLinearAccelerationSensor.text = LinearAccelerationSensor.current.acceleration.ToString();
        dataMagneticFieldSensor.text = MagneticFieldSensor.current.magneticField.ToString();
        dataLightSensor.text = LightSensor.current.lightLevel.ToString();
        dataPressureSensor.text = PressureSensor.current.atmosphericPressure.ToString();
        dataProximitySensor.text = ProximitySensor.current.distance.ToString();
        dataHumiditySensor.text = HumiditySensor.current.relativeHumidity.ToString();
        dataAmbientTemperatureSensor.text = AmbientTemperatureSensor.current.ambientTemperature.ToString();
        dataStepCounter.text = StepCounter.current.stepCounter.ToString();

        if (Accelerometer.current.enabled)
        {
            statusAccelerometer.color = Color.green;
        }
        else
        {
            statusAccelerometer.color = Color.red;
        }

        if (UnityEngine.InputSystem.Gyroscope.current.enabled)
        {
            statusGyroscope.color = Color.green;
        }
        else
        {
            statusGyroscope.color = Color.red;
        }

        if(GravitySensor.current.enabled)
        {
            statusGravitySensor.color = Color.green;
        }
        else
        {
            statusGravitySensor.color = Color.red;
        }

        if (AttitudeSensor.current.enabled)
        {
            statusAttitudeSensor.color = Color.green;
        }
        else
        {
            statusAttitudeSensor.color = Color.red;
        }

        if (LinearAccelerationSensor.current.enabled)
        {
            statusLinearAccelerationSensor.color = Color.green;
        }
        else
        {
            statusLinearAccelerationSensor.color = Color.red;
        }

        if (MagneticFieldSensor.current.enabled)
        {
            statusMagneticFieldSensor.color = Color.green;
        }
        else
        {
            statusMagneticFieldSensor.color = Color.red;
        }

        if (LightSensor.current.enabled)
        {
            statusLightSensor.color = Color.green;
        }
        else
        {
            statusLightSensor.color = Color.red;
        }

        if (PressureSensor.current.enabled)
        {
            statusPressureSensor.color = Color.green;
        }
        else
        {
            statusPressureSensor.color = Color.red;
        }

        if (ProximitySensor.current.enabled)
        {
            statusProximitySensor.color = Color.green;
        }
        else
        {
            statusProximitySensor.color = Color.red;
        }

        if (HumiditySensor.current.enabled)
        {
            statusHumiditySensor.color = Color.green;
        }
        else
        {
            statusHumiditySensor.color = Color.red;
        }

        if (AmbientTemperatureSensor.current.enabled)
        {
            statusAmbientTemperatureSensor.color = Color.green;
        }
        else
        {
            statusAmbientTemperatureSensor.color = Color.red;
        }

        if (StepCounter.current.enabled)
        {
            statusStepCounter.color = Color.green;
        }
        else
        {
            statusStepCounter.color = Color.red;
        }
    }
}
