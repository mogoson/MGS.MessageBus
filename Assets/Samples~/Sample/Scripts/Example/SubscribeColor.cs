/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SubscribeColor.cs
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
    public class SubscribeColor : MonoBehaviour
    {
        Renderer render;

        private void Awake()
        {
            render = GetComponent<Renderer>();
            Global.MessageBus.Subscribe<ColorMessage>(OnColorMessage);
        }

        private void OnDestroy()
        {
            Global.MessageBus.Unsubscribe<ColorMessage>(OnColorMessage);
        }

        void OnColorMessage(ColorMessage message)
        {
            render.material.color = message.color;
        }
    }
}