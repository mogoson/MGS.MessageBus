/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SubscribeScale.cs
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
    public class SubscribeScale : MonoBehaviour
    {
        private void Awake()
        {
            Global.MessageBus.Subscribe<ScaleMessage>(OnScaleMessage);
        }

        private void OnDestroy()
        {
            Global.MessageBus.Unsubscribe<ScaleMessage>(OnScaleMessage);
        }

        void OnScaleMessage(ScaleMessage message)
        {
            transform.localScale = message.scale;
        }
    }
}