// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.Serialization;

namespace System
{
    /// <summary>
    /// An exception class used when an invalid Uniform Resource Identifier is detected.
    /// </summary>
    public class UriFormatException : FormatException, ISerializable
    {
        public UriFormatException() : base()
        {
        }

        public UriFormatException(string textString) : base(textString)
        {
        }

        public UriFormatException(string textString, Exception e) : base(textString, e)
        {
        }

        protected UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }

        void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {
            base.GetObjectData(serializationInfo, streamingContext);
        }
    }; // class UriFormatException
} // namespace System
