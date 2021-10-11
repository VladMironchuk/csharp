using System;
using System.Text.RegularExpressions;

namespace VerificationService
{
    /// <summary>
    /// Verifies if the string representation of number is a valid ISBN-10 or ISBN-13 identification number of book.
    /// </summary>
    public static class IsbnVerifier
    {
        /// <summary>
        /// Verifies if the string representation of number is a valid ISBN-10 or ISBN-13 identification number of book.
        /// </summary>
        /// <param name="isbn">The string representation of book's isbn.</param>
        /// <returns>true if number is a valid ISBN-10 or ISBN-13 identification number of book, false otherwise.</returns>
        /// <exception cref="ArgumentNullException">Thrown if isbn is null.</exception>
        public static bool IsValid(string isbn)
        {
            switch (isbn.Length)
            {
                case 0: return true;
                case 13: return IsValidIsbn10(isbn);
                case 17: return IsValidIsbn13(isbn);
            }

            return false;
        }

        /// <summary>
        /// Validates ISBN10 codes
        /// </summary>
        /// <param name="isbn10">code to validate</param>
        /// <returns>true if valid</returns>
        private static bool IsValidIsbn10(string isbn10)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(isbn10))
            {
                long j;
                if (isbn10.Contains('-')) isbn10 = isbn10.Replace("-", "");

                if (!Int64.TryParse(isbn10.Substring(0, isbn10.Length - 1), out j))
                    return false;

                char lastChar = isbn10[isbn10.Length - 1];
                if (lastChar == 'X' && !Int64.TryParse(lastChar.ToString(), out j))
                    return false;
                int sum = 0;

                for (int i = 0; i < 9; i++)
                    sum += Int32.Parse(isbn10[i].ToString()) * (i + 1);

                int remainder = sum % 11;

                result = (remainder == int.Parse(isbn10[9].ToString()));
            }

            return result;
        }


        /// <summary>
        /// Validates ISBN13 codes
        /// </summary>
        /// <param name="isbn13">code to validate></param>
        /// <returns>true, if valid</returns>
        private static bool IsValidIsbn13(string isbn13)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(isbn13))
            {
                long j;
                if (isbn13.Contains('-')) isbn13 = isbn13.Replace("-", "");
 
                if (!Int64.TryParse(isbn13, out j))
                    return false;
                int sum = 0;

                for (int i = 0; i < 12; i++)
                {
                    sum += Int32.Parse(isbn13[i].ToString()) * (i % 2 == 1 ? 3 : 1);
                }

                int remainder = sum % 10;
                int checkDigit = 10 - remainder;
                if (checkDigit == 10) checkDigit = 0;
                result = (checkDigit == int.Parse(isbn13[12].ToString()));
            }

            return result;
        }
    }
}
