using Hashtable;
using System;
using Xunit;

namespace HashtableTests
{
    public class UnitTest1
    {
        // 1. Adding a key/value to your hashtable results in the value being in the data structure
        [Fact]
        public void CanAddItemToHashTable()
        {
            HashTable<int> table = new HashTable<int>(16);

            table.Add("Josie", 9);

            Assert.NotNull(table);
        }

        // 2. Retrieving based on a key returns the value stored
        [Fact]
        public void GetValue()
        {
            HashTable<int> table = new HashTable<int>(16);

            table.Add("Josie", 9);
            table.Add("Dog", 10);
            table.Add("Cupcake", 5);

            var result = table.Get("Dog");

            Assert.Equal(10, result);
        }

        // 2. Retrieving based on a key returns the value stored
        [Fact]
        public void FindsContainedValue()
        {
            HashTable<int> table = new HashTable<int>(16);

            table.Add("Josie", 9);
            table.Add("Dog", 10);
            table.Add("Cupcake", 5);

            var contains = table.Contains("Cupcake");

            Assert.True(contains);
        }

        // 3. Successfully returns null for a key that does not exist in the hashtable
        [Fact]
        public void CanReturnNull()
        {
            HashTable<int> table = new HashTable<int>(16);

            var doesNotContain = table.Contains("Cupcake");

            Assert.False(doesNotContain);
        }

        // 4. Successfully handle a collision within the hashtable
        [Fact]
        public void CanHandleCollsion()
        {
            HashTable<int> table = new HashTable<int>(16);

            table.Add("Brain", 9);
            table.Add("Brian", 10);

            var result = table.Get("Brian");

            Assert.Equal(10, result);
        }
        
        // 5. Successfully retrieve a value from a bucket within the hashtable that has a collision
        [Fact]
        public void CanRetreiveFromBucketWithCollision()
        {
            HashTable<int> table = new HashTable<int>(16);

            table.Add("Brain", 9);
            table.Add("Brian", 10);

            var result = table.Get("Brian");

            Assert.Equal(10, result);
        }

        // 6. Successfully hash a key to an in-range value
        [Fact]
        public void SuccessfullyHashesKey()
        {
            // Key = "Cat"
            // 67 + 97 + 116 = 280
            // 280 * 599 = 69648
            // 69648 % 1024 = 16
            // Key gets placed in the index of 16

            HashTable<int> table = new HashTable<int>(1024);

            var result = table.GetHash("Cat");

            Assert.Equal(808, result);
        }
    }
}
