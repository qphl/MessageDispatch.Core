// <copyright file="TransactionalDispatcher.cs" company="Corsham Science">
// Copyright (c) Corsham Science. All rights reserved.
// </copyright>

namespace CorshamScience.MessageDispatch.Core
{
    using System.Transactions;

    /// <summary>
    /// A wrapping message dispatcher which creates a transaction for each of its dispatch attempts.
    /// </summary>
    /// <typeparam name="TMessage">Message Type.</typeparam>
    public class TransactionalDispatcher<TMessage> : IDispatcher<TMessage>
    {
        private readonly IDispatcher<TMessage> _dispatcher;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionalDispatcher{TMessage}"/> class.
        /// </summary>
        /// <param name="dispatcher">The inner dispatcher that this dispatcher will wrap.</param>
        public TransactionalDispatcher(IDispatcher<TMessage> dispatcher)
        {
            _dispatcher = dispatcher;
        }

        /// <inheritdoc />
        public void Dispatch(TMessage message)
        {
            using (var transaction = new TransactionScope())
            {
                _dispatcher.Dispatch(message);
                transaction.Complete();
            }
        }
    }
}
