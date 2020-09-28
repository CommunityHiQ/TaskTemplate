#pragma warning disable 1591

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frends.Community.Echo
{
    /// <summary>
    /// Parameters class usually contains parameters that are required.
    /// </summary>
    public class Parameters
    {
        /// <summary>
        /// Something that will be repeated.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        [DefaultValue("Lorem ipsum dolor sit amet.")]
        public string Message { get; set; }
    }

    /// <summary>
    /// Options class provides additional optional parameters.
    /// </summary>
    public class Options
    {
        /// <summary>
        /// Number of times input is repeated.
        /// </summary>
        [DefaultValue(3)]
        public int Amount { get; set; }

        /// <summary>
        /// How repeats of the input are separated.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        [DefaultValue(" ")]
        public string Delimiter { get; set; }
    }

    public class Result
    {
        /// <summary>
        /// Contains the input repeated the specified number of times.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        public string Replication;
    }
}
