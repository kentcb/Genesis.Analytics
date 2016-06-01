namespace Genesis.Analytics.Raygun.iOS
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Genesis.Analytics;
    using Mindscape.Raygun4Net;

    /// <summary>
    /// An implementation of <see cref="IAnalyticsService"/> for Raygun on Android.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Note that Raygun Pulse is currently pre-beta. As such, tracking is not implemented.
    /// </para>
    /// </remarks>
    public sealed class RaygunAnalyticsService : IAnalyticsService
    {
        /// <inheritdoc/>
        public void Identify(string userId) =>
            RaygunClient.Current.User = userId;

        /// <inheritdoc/>
        public void RecordException(Exception exception, ExceptionLevel exceptionLevel = ExceptionLevel.Error, IDictionary metadata = null) =>
            RaygunClient.Current.Send(exception, new[] { exceptionLevel.ToString() }.ToList(), metadata);

        /// <inheritdoc/>
        // TODO: implement with Raygun Pulse when it becomes available
        public void Track(string id, IDictionary<string, string> metadata = null)
        {
        }

        /// <inheritdoc/>
        // TODO: implement with Raygun Pulse when it becomes available
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