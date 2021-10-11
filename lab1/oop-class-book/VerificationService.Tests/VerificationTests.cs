using System;
using BookClass;
using NUnit.Framework;

#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable SA1600 // Elements should be documented

namespace VerificationService.Tests
{
    [TestFixture]
    public class VerificationTests
    {
        [TestCase("0-198-53453-1")]
        [TestCase("2-057-61257-0")]
        [TestCase("3-598-21500-2")]
        public void IsbnVerifier_isValid_isbn10(string isbn10)
        {
            Assert.IsTrue(IsbnVerifier.IsValid(isbn10));
        }
        
        [TestCase("978-7-460-37289-2")]
        [TestCase("978-5-223-43435-1")]
        [TestCase("978-7-460-37289-2")]
        public void IsbnVerifier_isValid_isbn13(string isbn13)
        {
            Assert.IsTrue(IsbnVerifier.IsValid(isbn13));
        }
        
        [TestCase("5-654-67656-8")]
        [TestCase("581-5-123-757-5")]
        [TestCase("9-126-12456-8")]
        [TestCase("913")]
        [TestCase("a-34v-abcab-1")]
        [TestCase("a35-3-e45-45678-1")]
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
        
        [TestCase("-+-")]
        [TestCase("abc")]
        [TestCase("qwerty")]
        public void IsoCurrencyValidator_ArgumentException(string currency)
        {
            Assert.Throws<ArgumentException>(() => IsoCurrencyValidator.IsValid(currency), "not ISO format");
        }
    }
}
