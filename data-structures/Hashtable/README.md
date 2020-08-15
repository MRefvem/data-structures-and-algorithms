# Hashtables
Hashtables are a data structure that utilize key value pairs. This means every Node or Bucket has both a key, and a value.
The basic idea of a hashtable is the ability to store the key into this data structure, and quickly retrieve the value. This is done through what we call a hash. A hash is the ability to encode the key that will eventually map to a specific location in the data structure that we can look at directly to retrieve the value.
Since we are able to hash our key and determine the exact location where our value is stored, we can do a lookup in an O(1) time complexity. This is ideal when quick lookups are required.

## Challenge
Features: Implement a Hashtable with the following methods: Add(), Get(), Contains(), GetHash().
Structure: Utilizes the Single-repository principle.
Tests:
1. CanAddItemToHashTable(): adding a key/value to the hashtable results in the value being in the data structure.
2. GetValue(): retrieving based on a key returns the value stored
3. FindsContainedValue(): retrieving based on a key returns the value stored
4. CanReturnNull(): successfully returns null for a key that does not exist in the hashtable
5. CanHandleCollsion(): successfully handle a collision within the hashtable
6. CanRetreiveFromBucketWithCollision(): successfully retrieve a value from a bucket within the hashtable that has a collision
7. SuccessfullyHashesKey(): successfully hash a key to an in-range value

## Approach & Efficiency
The efficiency for looking up the index number of a bucket is an O(1) operation.
The efficiency for hashing a key is an O(n) operation.
The efficiency of searching for a key value in a bucket is an O(n) operation.


## API
There are four internal methods in this Data Structure:
- Add(): takes in both the key and the value. This method should has the key, and add the key and value pair to the table, handling collisions as needed.
- Get(): takes in the key and returns the value from the table.
- Contains(): takes in the key and returns a boolean, indicating if the key exists in the table already.
- GetHash(): takes in an arbitrary key and returns an index in the collection.
