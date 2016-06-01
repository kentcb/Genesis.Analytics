namespace Genesis.Analytics
{
    /// <summary>
    /// Defines available exception levels.
    /// </summary>
    public enum ExceptionLevel
    {
        /// <summary>
        /// The exception should be treated as a warning.
        /// </summary>
        Warning,

        /// <summary>
        /// The exception should be treated as an error.
        /// </summary>
        Error,

        /// <summary>
        /// The exception should be treated as critical.
        /// </summary>
        Critial
    }
}