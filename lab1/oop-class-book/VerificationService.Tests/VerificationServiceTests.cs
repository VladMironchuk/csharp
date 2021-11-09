using System;
using NUnit.Framework;

#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable SA1600 // Elements should be documented

namespace VerificationService.Tests
{
    [TestFixture]
    public class VerificationTests
    {
        [TestCase("1-455-67657-7")]
        [TestCase("2-057-61257-0")]
        [TestCase("8-482-12697-3")]
        public void IsbnVerifier_isValid_isbn10(string isbn10)
        {
            Assert.IsTrue(IsbnVerifier.IsValid(isbn10));
        }

        [TestCase("512-4-676-89127-0")]
        [TestCase("581-5-123-75907-5")]
        [TestCase("913-1-402-12456-8")]
        public void IsbnVerifier_isValid_isbn13(string isbn13)
        {
            Assert.IsTrue(IsbnVerifier.IsValid(isbn13));
        }

        [TestCase("052112-41-676-89123127")]
        [TestCase("581-5-12123113-757-5")]
        [TestCase("413-52-156-8")]
        [TestCase("0213")]
        [TestCase("a-34v-abcab-1")]
        [TestCase("-3-e45-45678-1132132")]
        public void IsbnVerifier_isNotValid(string isbn)
        {
            Assert.IsFalse(IsbnVerifier.IsValid(isbn));
        }

        [TestCase("USD")]
        [TestCase("EUR")]
        [TestCase("RUB")]
        public void IsoCurrencyValidator_Tests(string currency)
        {
            Assert.IsTrue(IsoCurrencyValidator.IsValid(currency));
        }

        [TestCase("ddd")]
        [TestCase("---")]
        [TestCase("adafad")]
        public void IsoCurrencyValidator_ArgumentException(string currency)
        {
            Assert.Throws<ArgumentException>(() => IsoCurrencyValidator.IsValid(currency), "not ISO format");
        }
    }
}
