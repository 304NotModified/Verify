﻿using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VerifyMSTest;
[TestClass]
public class VerifyTextSample :
    VerifyBase
{
    [TestMethod]
    public Task Simple()
    {
        return Verify("Foo");
    }
}