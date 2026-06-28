/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SubscribePos.cs
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
    public class SubscribePos : MonoBehaviour
    {
        private void Awake()
        {
            Global.MessageBus.Subscribe<PosMessage>(OnPosMessage);
        }

        private void OnDestroy()
        {
            Global.MessageBus.Unsubscribe<PosMessage>(OnPosMessage);
        }

        void OnPosMessage(PosMessage message)
        {
            transform.position = message.position;
        }
    }
}