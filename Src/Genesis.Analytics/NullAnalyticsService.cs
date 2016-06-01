namespace Genesis.Analytics
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// An implementation of <see cref="IAnalyticsService"/> that does nothing.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Pass this implementation to consumers if you want to effectively disable analytics.
    /// </para>
    /// </remarks>
    public sealed class NullAnalyticsService : IAnalyticsService
    {
        /// <inheritdoc/>
        public void Identify(string userId)
        {
        }

        /// <inheritdoc/>
        public void RecordException(Exception exception, ExceptionLevel exceptionLevel = ExceptionLevel.Error, IDictionary metadata = null)
        {
        }

        /// <inheritdoc/>
        public void Track(string id, IDictionary<string, string> metadata = null)
        {
        }

        /// <inheritdoc/>
        public IDisposable TrackTime(string id, IDictionary<string, string> metadata = null) =>
            EmptyDisposable.Instance;

        // saves a dependency on Rx just for Disposable.Empty
        private sealed class EmptyDisposable : IDisposable
        {
            public static readonly EmptyDisposable Instance = new EmptyDisposable();

            private EmptyDisposable()
            {
            }

            public void Dispose()
            {
            }
        }
    }
}