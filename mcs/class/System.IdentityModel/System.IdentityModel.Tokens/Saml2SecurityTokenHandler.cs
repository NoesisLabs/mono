//-----------------------------------------------------------------------
// <copyright file="Saml2SecurityTokenHandler.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
#if NET_4_5
namespace System.IdentityModel.Tokens
{
    /// <summary>
    /// Creates SAML2 assertion-based security tokens
    /// </summary>
    public class Saml2SecurityTokenHandler : SecurityTokenHandler
    {
        /// <summary>
        /// Gets the token type supported by this handler.
        /// </summary>
        public override Type TokenType
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the token type identifier(s) supported by this handler.
        /// </summary>
        /// <returns>A collection of strings that identify the tokens this instance can handle.</returns>
        public override string[] GetTokenTypeIdentifiers()
        {
            throw new NotImplementedException();
        }
    }
}
#endif
