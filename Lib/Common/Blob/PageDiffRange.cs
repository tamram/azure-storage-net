﻿//-----------------------------------------------------------------------
// <copyright file="PageDiffRange.cs" company="Microsoft">
//    Copyright 2013 Microsoft Corporation
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//      http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

namespace Microsoft.Azure.Storage.Blob
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Represents a range of pages in a page blob.
    /// </summary>
    public sealed class PageDiffRange : PageRange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageDiffRange"/> class.
        /// </summary>
        /// <param name="start">The starting offset.</param>
        /// <param name="end">The ending offset.</param>
        /// <param name="isCleared">True if the page range is a cleared range, false otherwise.</param>
        public PageDiffRange(long start, long end, bool isCleared):
            base(start, end)
        {
            this.IsClearedPageRange = isCleared;
        }

        /// <summary>
        /// True if the page range is a cleared range, false otherwise.
        /// </summary>
        public bool IsClearedPageRange { get; internal set; }
    }
}
