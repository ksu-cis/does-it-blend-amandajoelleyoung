﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// Interface for items that can be blended.
    /// </summary>
    interface IBlendable
    {
        /// <summary>
        /// Blends the object.
        /// </summary>
        /// <returns>a string that returns the blended object.</returns>
        string Blend();
    }
}
