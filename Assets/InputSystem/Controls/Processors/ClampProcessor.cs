﻿using UnityEngine;

namespace ISX
{
    public class ClampProcessor : IInputProcessor<float>
    {
        public float min;
        public float max;

        public float Process(float value)
        {
            return Mathf.Clamp(value, min, max);
        }
    }
}