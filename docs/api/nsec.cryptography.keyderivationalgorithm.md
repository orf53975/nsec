# KeyDerivationAlgorithm Class

Represents a key derivation algorithm.

    public abstract class KeyDerivationAlgorithm : Algorithm

Key derivation is deterministic, i.e., the same argument values result in the
same derived value.


## Inheritance Hierarchy

* [[Algorithm|Algorithm Class]]
    * **KeyDerivationAlgorithm**
        * HkdfSha256
        * HkdfSha512


## [TOC] Summary


## Properties


### MaxOutputSize

Gets the maximum size, in bytes, of the key derivation output.

    public int MaxOutputSize { get; }

#### Propery value

The maximum size, in bytes, of the key derivation output.


### MaxSaltSize

Gets the maximum size, in bytes, of the salt to use in key derivation.

    public int MaxSaltSize { get; }

#### Propery value

The maximum size, in bytes, of the salt.


## Methods


### DeriveBytes(SharedSecret, ReadOnlySpan<byte>, ReadOnlySpan<byte>, int)

Derives the specified number of bytes from a shared secret.

    public byte[] DeriveBytes(
        SharedSecret sharedSecret,
        ReadOnlySpan<byte> salt,
        ReadOnlySpan<byte> info,
        int count)

#### Parameters

sharedSecret
: The shared secret to derive bytes from.

salt
: Optional salt.

info
: Optional context and application specific information.

count
: The number of bytes to derive.

#### Return value

An array of bytes that contains the derived bytes.

#### Exceptions

ArgumentNullException
: `sharedSecret` is `null`

ArgumentException
: The length of `salt` is larger than
    [[MaxSaltSize|KeyDerivationAlgorithm Class#MaxSaltSize]].

ArgumentOutOfRangeException
: `count` is less than zero or larger than
    [[MaxOutputSize|KeyDerivationAlgorithm Class#MaxOutputSize]].

ObjectDisposedException
: `sharedSecret` has been disposed.


### DeriveBytes(SharedSecret, ReadOnlySpan<byte>, ReadOnlySpan<byte>, Span<byte>)

Fills the specified span of bytes with bytes derived from a shared secret.

    public void DeriveBytes(
        SharedSecret sharedSecret,
        ReadOnlySpan<byte> salt,
        ReadOnlySpan<byte> info,
        Span<byte> bytes)

#### Parameters

sharedSecret
: The shared secret to derive bytes from.

salt
: Optional salt.

info
: Optional context and application specific information.

bytes
: The span to fill with bytes derived from the shared secret.

#### Exceptions

ArgumentNullException
: `sharedSecret` is `null`

ArgumentException
: The length of `salt` is larger than
    [[MaxSaltSize|KeyDerivationAlgorithm Class#MaxSaltSize]].

ArgumentException
: The length of `bytes` is larger than
    [[MaxOutputSize|KeyDerivationAlgorithm Class#MaxOutputSize]].

ObjectDisposedException
: `sharedSecret` has been disposed.


### DeriveKey(SharedSecret, ReadOnlySpan<byte>, ReadOnlySpan<byte>, Algorithm, KeyFlags)

Derives a key for the specified algorithm from a shared secret.

    public Key DeriveKey(
        SharedSecret sharedSecret,
        ReadOnlySpan<byte> salt,
        ReadOnlySpan<byte> info,
        Algorithm algorithm,
        KeyFlags flags = KeyFlags.None)

#### Parameters

sharedSecret
: The shared secret to derive a key from.

salt
: Optional salt.

info
: Optional context and application specific information.

algorithm
: The algorithm for the new key.

flags
: A bitwise combination of [[KeyFlags|KeyFlags Enum]] values that specifies
    the flags for the new key.
    
#### Return value

A new instance of the [[Key|Key Class]] class that represents the derived key.

#### Exceptions

ArgumentNullException
: `sharedSecret` or `algorithm` is `null`.

ArgumentException
: The length of `salt` is larger than
    [[MaxSaltSize|KeyDerivationAlgorithm Class#MaxSaltSize]].

NotSupportedException
: The specified algorithm does not supported derived keys.

ObjectDisposedException
: `sharedSecret` has been disposed.


## See also

* API Reference
    * [[Algorithm Class]]
    * [[SharedSecret Class]]