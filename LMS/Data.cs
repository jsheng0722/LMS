// <copyright file="Data.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace LMS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Data class.
    /// </summary>
    public class Data
    {
        /// <summary>
        /// user id.
        /// </summary>
#pragma warning disable SA1401 // Fields should be private
        public static string UId = string.Empty;
#pragma warning restore SA1401 // Fields should be private

        /// <summary>
        /// user name.
        /// </summary>
#pragma warning disable SA1401 // Fields should be private
        public static string UName = string.Empty;
#pragma warning restore SA1401 // Fields should be private
    }
}
