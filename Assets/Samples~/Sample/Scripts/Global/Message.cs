/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Message.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  09/22/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.MessageBus.Sample
{
    public struct ColorMessage
    {
        public Color color;
    }

    public struct PosMessage
    {
        public Vector3 position;
    }

    public struct ScaleMessage
    {
        public Vector3 scale;
    }
}