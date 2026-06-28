/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MessageBus.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  09/22/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using System.Collections.Generic;

namespace MGS.MessageBus
{
    public class MessageBus : IMessageBus
    {
        protected IDictionary<Type, Delegate> registry = new Dictionary<Type, Delegate>();

        public void Subscribe<T>(Action<T> action)
        {
            var key = typeof(T);
            if (registry.ContainsKey(key))
            {
                registry[key] = Delegate.Combine(registry[key], action);
            }
            else
            {
                registry[key] = action;
            }
        }

        public void Unsubscribe<T>(Action<T> action)
        {
            var key = typeof(T);
            if (registry.ContainsKey(key))
            {
                var actions = Delegate.Remove(registry[key], action);
                if (actions == null)
                {
                    registry.Remove(key);
                }
                else
                {
                    registry[key] = actions;
                }
            }
        }

        public void Spread<T>(T message)
        {
            var key = typeof(T);
            if (registry.ContainsKey(key))
            {
                registry[key].DynamicInvoke(message);
            }
        }

        public void Clear()
        {
            registry.Clear();
        }
    }
}