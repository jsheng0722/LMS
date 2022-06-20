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
        private static string userId = string.Empty;

        /// <summary>
        /// user name.
        /// </summary>
        private static string userName = string.Empty;

        /// <summary>
        /// Gets or sets user name.
        /// </summary>
        public static string UName { get => userName; set => userName = value; }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        public static string UId { get => userId; set => userId = value; }
    }
}
