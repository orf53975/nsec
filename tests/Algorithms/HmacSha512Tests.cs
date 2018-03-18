using System;
using NSec.Cryptography;
using Xunit;

namespace NSec.Tests.Algorithms
{
    public static class HmacSha512Tests
    {
        #region Properties

        [Fact]
        public static void Properties()
        {
            var a = MacAlgorithm.HmacSha512;

            Assert.Equal(64, a.MinKeySize);
            Assert.Equal(64, a.DefaultKeySize);
            Assert.Equal(64, a.MaxKeySize);

            Assert.Equal(64, a.MacSize);
        }

        #endregion
    }
}
