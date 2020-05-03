// Copyright (c) Six Labors and contributors.
// Licensed under the GNU Affero General Public License, Version 3.

namespace SixLabors.ImageSharp.Formats.WebP.Lossy
{
    /// <summary>
    /// Segment features.
    /// </summary>
    internal class Vp8SegmentHeader
    {
        private const int NumMbSegments = 4;

        public Vp8SegmentHeader()
        {
            this.Quantizer = new byte[NumMbSegments];
            this.FilterStrength = new byte[NumMbSegments];
        }

        public bool UseSegment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to update the segment map or not.
        /// </summary>
        public bool UpdateMap { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use delta values for quantizer and filter.
        /// If this value is false, absolute values are used.
        /// </summary>
        public bool Delta { get; set; }

        /// <summary>
        /// Gets quantization changes.
        /// </summary>
        public byte[] Quantizer { get; }

        /// <summary>
        /// Gets the filter strength for segments.
        /// </summary>
        public byte[] FilterStrength { get; }
    }
}