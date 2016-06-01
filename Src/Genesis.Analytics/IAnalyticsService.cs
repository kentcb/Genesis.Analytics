namespace Genesis.Analytics
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Facilitates the recording of analytics.
    /// </summary>
    public interface IAnalyticsService
    {
        /// <summary>
        /// Identifies the current user.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If users authenticate against your application, you should call this to ensure any future analytics are recorded
        /// against that user. If your user logs out, pass in <see langword="null"/> for <paramref name="userId"/>.
        /// </para>
        /// </remarks>
        /// <param name="userId">
        /// The ID of the user, or <see langword="null"/> if there is no user.
        /// </param>
        void Identify(
            string userId);

        /// <summary>
        /// Tracks an event with a given ID.
        /// </summary>
        /// <param name="id">
        /// The event ID.
        /// </param>
        /// <param name="metadata">
        /// Any metadata related to the event.
        /// </param>
        void Track(
            string id,
            IDictionary<string, string> metadata = null);

        /// <summary>
        /// Tracks, with timing information, an event with a given ID.
        /// </summary>
        /// <param name="id">
        /// The event ID.
        /// </param>
        /// <param name="metadata">
        /// Any metadata related to the event.
        /// </param>
        /// <returns>
        /// A <see cref="IDisposable"/> that should be disposed when the event to track completes.
        /// </returns>
        IDisposable TrackTime(
            string id,
            IDictionary<string, string> metadata = null);

        /// <summary>
        /// Records an exception at a specific level.
        /// </summary>
        /// <param name="exception">
        /// The exception to record.
        /// </param>
        /// <param name="exceptionLevel">
        /// The exception level.
        /// </param>
        /// <param name="metadata">
        /// Any metadata related to the exception.
        /// </param>
        void RecordException(
            Exception exception,
            ExceptionLevel exceptionLevel = ExceptionLevel.Error,
            IDictionary metadata = null);
    }
}