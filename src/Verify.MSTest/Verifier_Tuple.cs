﻿#if !NETSTANDARD2_0
using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Verify;

namespace VerifyMSTest
{
    public static partial class Verifier
    {
        public static Task Verify(
            Expression<Func<ITuple>> expression,
            VerifySettings? settings = null,
            [CallerFilePath] string sourceFile = "",
            [CallerMemberName] string methodName = "")
        {
            var verifier = GetVerifier(sourceFile, methodName, settings);
            return verifier.Verify(expression, settings);
        }
    }
}
#endif