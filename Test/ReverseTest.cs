using NUnit.Framework;
using System;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReverseStringMethodA()
        {
            string original = "abcdefg";
            char[] originalArray = original.ToCharArray();
            Array.Reverse(originalArray);
            string reversed = new string(originalArray);
            Console.WriteLine(reversed);
            Assert.That(reversed, Is.EqualTo("gfedcba"));
        }

        [Test]
        public void ReverseStringMethodB()
        {
            string original = "abcdefg";
            char[] originalArray = original.ToCharArray();
            int length = originalArray.Length;
            int i = 0;
            int j = length - 1;
            while (i < j)
            {
                char temp = originalArray[i];
                originalArray[i] = originalArray[j];
                originalArray[j] = temp;

                i++;
                j--;
            }

            string reversed = new string(originalArray);
            Console.WriteLine(reversed);
            Assert.That(reversed, Is.EqualTo("gfedcba"));
        }
    }
}