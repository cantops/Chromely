﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CefGlueHttpSchemeHandlerFactory.cs" company="Chromely Projects">
//   Copyright (c) 2017-2018 Chromely Projects
// </copyright>
// <license>
//      See the LICENSE.md file in the project root for more information.
// </license>
// --------------------------------------------------------------------------------------------------------------------

namespace Chromely.CefGlue.Libui.Browser.Handlers
{
    using Xilium.CefGlue;

    /// <summary>
    /// The CefGlue http scheme handler factory.
    /// </summary>
    public class CefGlueHttpSchemeHandlerFactory : CefSchemeHandlerFactory
    {
        /// <summary>
        /// The create.
        /// </summary>
        /// <param name="browser">
        /// The browser.
        /// </param>
        /// <param name="frame">
        /// The frame.
        /// </param>
        /// <param name="schemeName">
        /// The scheme name.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="CefResourceHandler"/>.
        /// </returns>
        protected override CefResourceHandler Create(CefBrowser browser, CefFrame frame, string schemeName, CefRequest request)
        {
            return new CefGlueHttpSchemeHandler();
        }
    }
}