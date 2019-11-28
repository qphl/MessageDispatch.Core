// <copyright file="IMessageHandlerLookup.cs" company="Corsham Science">
// Copyright (c) Corsham Science. All rights reserved.
// </copyright>

namespace CorshamScience.MessageDispatch.Core
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for implementing a method to lookup the handler methods for a specific message type from a <see cref="MessageHandlerRegistry{TKey}"/>.
    /// </summary>
    /// <typeparam name="TKey">The type of message handler lookup keys the message handler can handle.</typeparam>
    public interface IMessageHandlerLookup<in TKey>
    {
        /// <summary>
        /// Gets the handler methods for a specified message type.
        /// </summary>
        /// <param name="messageType">The message type whose handler methods should be returned.</param>
        /// <returns>A list of message handlers.</returns>
        List<object> HandlersForMessageType(TKey messageType);
    }
}
