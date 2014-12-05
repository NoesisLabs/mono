//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
#if NET_4_5
namespace System.IdentityModel.Tokens
{
    /// <summary>
    /// This class implements a SecurityTokenHandler for a Saml11 token.  It contains functionality for: Creating, Serializing and Validating 
    /// a Saml 11 Token.
    /// </summary>
    public class SamlSecurityTokenHandler : SecurityTokenHandler
    {
        /// <summary>
        /// Gets the token type supported by this handler.
        /// </summary>
        public override Type TokenType
        {
            get { return typeof(SamlSecurityToken); }
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
