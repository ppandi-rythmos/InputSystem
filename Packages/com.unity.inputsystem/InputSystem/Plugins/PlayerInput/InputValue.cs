using System;

////TODO: ToString()

namespace UnityEngine.Experimental.Input.Plugins.PlayerInput
{
    /// <summary>
    /// Wraps around values provided by input actions.
    /// </summary>
    /// <remarks>
    /// This is a wrapper around <see cref="InputAction.CallbackContext"/> chiefly for use
    /// with GameObject messages (i.e. <see cref="GameObject.SendMessage(string,object)"/>). It exists
    /// so that action callback data can be represented as an object, can be reused, and shields
    /// the receiver from having to know about action callback specifics.
    /// </remarks>
    /// <seealso cref="InputAction"/>
    public class InputValue
    {
        ////TODO: add automatic conversions
        public TValue Get<TValue>()
            where TValue : struct
        {
            if (!m_Context.HasValue)
                throw new InvalidOperationException($"Values can only be retrieved while in message callbacks");

            return m_Context.Value.ReadValue<TValue>();
        }

        internal InputAction.CallbackContext? m_Context;
    }
}