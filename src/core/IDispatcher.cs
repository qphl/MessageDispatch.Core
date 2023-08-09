// <copyright file="IDispatcher.cs" company="Corsham Science">
// Copyright (c) Corsham Science. All rights reserved.
// </copyright>

namespace CorshamScience.MessageDispatch.Core
{
    /// <summary>
    /// A common interface for a message dispatcher.
    /// </summary>
    /// <typeparam name="TMessage">The type of message this dispatcher handles.</typeparam>
    public interface IDispatcher<in TMessage>
    {
        /// <summary>
        /// The method which controls dispatching messages.
        /// </summary>
        /// <param name="message">Represents a message for the dispatcher to attempt to process.</param>
        void Dispatch(TMessage message);
    }
}
