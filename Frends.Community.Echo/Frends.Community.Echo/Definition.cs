#pragma warning disable 1591

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frends.Community.Echo
{
    /// <summary>
    /// Parameters class usually requires parameters that are required.
    /// </summary>
    public class Parameters
    {
        /// <summary>
        /// Something that will be repeated.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        [DefaultValue("Lorem ipsum dolor sit amet.")]
        public string Message;
    }

    /// <summary>
    /// Options class provides additional parameters.
    /// </summary>
    public class Options
    {
        /// <summary>
        /// Number of times input is echoed.
        /// </summary>
        [DefaultValue(3)]
        public int Amount;

        /// <summary>
        /// How repeats of input are separated.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        [DefaultValue(" ")]
        public string Delimiter;
    }

    public class Result
    {
        /// <summary>
        /// Contains input repeated specified times.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        public string Replication;
    }
}
