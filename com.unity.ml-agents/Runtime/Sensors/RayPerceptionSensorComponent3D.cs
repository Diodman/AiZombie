using UnityEngine;
using UnityEngine.Serialization;

namespace Unity.MLAgents.Sensors
{
    /// <summary>
    /// Компонент для трехмерного восприятия лучей.
    /// </summary>
    [AddComponentMenu("ML Agents/Ray Perception Sensor 3D", (int)MenuGroup.Sensors)]
    public class RayPerceptionSensorComponent3D : RayPerceptionSensorComponentBase
    {
        [HideInInspector, SerializeField, FormerlySerializedAs("startVerticalOffset")]
        [Range(-10f, 10f)]
        [Tooltip("Начальное вертикальное смещение луча.")]
        float m_StartVerticalOffset;

        /// <summary>
        /// Начальное вертикальное смещение луча.
        /// </summary>
        public float StartVerticalOffset
        {
            get => m_StartVerticalOffset;
            set { m_StartVerticalOffset = value; UpdateSensor(); }
        }

        [HideInInspector, SerializeField, FormerlySerializedAs("endVerticalOffset")]
        [Range(-10f, 10f)]
        [Tooltip("Конечное вертикальное смещение луча.")]
        float m_EndVerticalOffset;

        /// <summary>
        /// Конечное вертикальное смещение луча.
        /// </summary>
        public float EndVerticalOffset
        {
            get => m_EndVerticalOffset;
            set { m_EndVerticalOffset = value; UpdateSensor(); }
        }

        /// <inheritdoc/>
        public override RayPerceptionCastType GetCastType()
        {
            return RayPerceptionCastType.Cast3D;
        }

        /// <inheritdoc/>
        public override float GetStartVerticalOffset()
        {
            return StartVerticalOffset;
        }

        /// <inheritdoc/>
        public override float GetEndVerticalOffset()
        {
            return EndVerticalOffset;
        }
    }
}
