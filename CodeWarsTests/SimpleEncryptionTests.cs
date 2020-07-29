using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Tests
{
    [TestClass()]
    public class SimpleEncryptionTests
    {
        [TestMethod()]
        public void EncryptTest()
        {
            Assert.AreEqual("This is a test!", SimpleEncryption.Encrypt("This is a test!", 0));
            Assert.AreEqual("hsi  etTi sats!", SimpleEncryption.Encrypt("This is a test!", 1));
            Assert.AreEqual("s eT ashi tist!", SimpleEncryption.Encrypt("This is a test!", 2)); 
            Assert.AreEqual(" Tah itse sits!", SimpleEncryption.Encrypt("This is a test!", 3));
            Assert.AreEqual("This is a test!", SimpleEncryption.Encrypt("This is a test!", 4));
            Assert.AreEqual("This is a test!", SimpleEncryption.Encrypt("This is a test!", -1));
            Assert.AreEqual("hskt svr neetn!Ti aai eyitrsig", SimpleEncryption.Encrypt("This kata is very interesting!", 1));
        }
        [TestMethod()]
        public void DecryptTest()
        {
            Assert.AreEqual("This is a test!", SimpleEncryption.Decrypt("This is a test!", 0));
            Assert.AreEqual("This is a test!", SimpleEncryption.Decrypt("hsi  etTi sats!", 1));
            Assert.AreEqual("This is a test!", SimpleEncryption.Decrypt("s eT ashi tist!", 2));
            Assert.AreEqual("This is a test!", SimpleEncryption.Decrypt(" Tah itse sits!", 3));
            Assert.AreEqual("This is a test!", SimpleEncryption.Decrypt("This is a test!", 4));
            Assert.AreEqual("This is a test!", SimpleEncryption.Decrypt("This is a test!", -1));
            Assert.AreEqual("This kata is very interesting!", SimpleEncryption.Decrypt("hskt svr neetn!Ti aai eyitrsig", 1));
        }

        [TestMethod()]
        public void EmptyTests()
        {
            Assert.AreEqual("", SimpleEncryption.Encrypt("", 0));
            Assert.AreEqual("", SimpleEncryption.Decrypt("", 0));
        }

        [TestMethod()]
        public void NullTests()
        {
            Assert.AreEqual(null, SimpleEncryption.Encrypt(null, 0));
            Assert.AreEqual(null, SimpleEncryption.Decrypt(null, 0));
        }
    }
}