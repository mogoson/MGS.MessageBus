/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SpreadMessage.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  09/22/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using System.Collections;
using UnityEngine;

namespace MGS.MessageBus.Sample
{
    public class SpreadMessage : MonoBehaviour
    {
        private void Start()
        {
            StartCoroutine(SpreadMessages());
        }

        IEnumerator SpreadMessages()
        {
            yield return new WaitForSeconds(1.0f);
            var colorMsg = new ColorMessage { color = Color.cyan };
            Global.MessageBus.Spread(colorMsg);

            yield return new WaitForSeconds(1.0f);
            var posMsg = new PosMessage { position = Vector3.up };
            Global.MessageBus.Spread(posMsg);

            yield return new WaitForSeconds(1.0f);
            var scaleMsg = new ScaleMessage { scale = Vector3.one * 0.5f };
            Global.MessageBus.Spread(scaleMsg);
        }
    }
}