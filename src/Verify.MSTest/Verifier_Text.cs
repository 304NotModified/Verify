﻿using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Verify;

namespace VerifyMSTest
{
    public static partial class Verifier
    {
        public static Task Verify(
            string target,
            VerifySettings? settings = null,
            [CallerFilePath] string sourceFile = "",
            [CallerMemberName] string methodName = "")
        {
            var verifier = GetVerifier(sourceFile, methodName, settings);
            return verifier.Verify(target, settings);
        }
    }
}