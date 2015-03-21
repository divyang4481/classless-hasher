# Project hosting has been moved to Bitbucket: #
## https://bitbucket.org/jayclassless/classless-hasher/ ##



## Version 0.9 (Build 4179; 6/11/2011) ##
  * Optimized numerous algorithms to gain some processing speed. Notable enhancements:
    * Dha256 is about 132% faster.
    * Haval is about 55% faster.
    * MD4 is about 40% faster.
    * MD5 is about 66% faster.
    * RipeMD128/256 is about 28% faster.
    * RipeMD160/320 is about 72% faster.
    * Sha0/1 are about 75% faster.
    * Sha224/256/384/512 are about 160% faster.
  * Upgraded project to Visual Studio 2010.
  * Made modifications to support Silverlight applications.

## Version [0.8](http://code.google.com/p/classless-hasher/downloads/list?can=1&q=v0.8) (Build 3649; 12/28/2009) ##
  * Hasher is re-reborn!
  * Moved project to Google Code (Sourceforge is really heinous).
  * Refactored the Cksum algorithm to leverage the CRC code.
  * Completely re-arranged the built-in [CRC standards](ProvidedCrcStandards.md) after finding a better source of definitions.
  * Refactored HMAC. It now only works with algorithms derived from BlockHashAlgorithm.
  * Renamed a ton of classes and enumerations to be more consistently named.
  * Enhanced Tiger to take parameters for specifying result hash length.
  * Added a much more thorough set of test vectors.
  * Fixed Whirlpool (for real this time!).
  * Fixed SumSysV.
  * Fixed bugs with CRC and Xum32.
  * Renamed JHash to JenkinsHash.
  * Cleaned up the HashAlgorithm.Create() factory to be more dynamic.
  * Added support for advanced structures like Hash Chains, Lists, and Trees.
  * Greatly expanded unit test coverage.
  * Improved thread safety a bit by lowering the chances of a deadlock.
  * Switched to Sandcastle for documentation generation.
  * Now only compiles under v2.0-compatible versions of the CLR.
  * Added [algorithms](ProvidedAlgorithms.md):
    * AP
    * BKDR
    * DHA256
    * DJB
    * Fletcher
    * HAS-160
    * JS
    * PJW32
    * RS
    * SDBM
    * Sum
    * Tiger2
    * XOR8


## Version [0.7](http://code.google.com/p/classless-hasher/downloads/list?can=1&q=v0.7) (Build 2247; 2/25/2006) ##
  * Hasher rises from the dead!
  * Fixed CRCStandards for CRC8 and CRC32.
  * Fixed CRC handling when the Order was 64bits.
  * Removed the REVERSED CRCStandards.
  * Added CRCStandards for CRC64\_ISO and CRC64\_ECMA.
  * Changed CRCStandard CRC16 to CRC16\_IBM.
  * Renamed CRC16\_CCITT\_REVERSED to CRC16\_XMODEM.
  * Fixed nasty bug that broke MD4, MD5, the RIPEMD's, Tiger, and the SHA's when large datasets were processed.
  * Added support for creating Panama hashes.
  * Fixed the NAnt build script to better support Mono and .NET v2.0.


## Version [0.6](http://code.google.com/p/classless-hasher/downloads/list?can=1&q=v0.6) (Build 1785; 11/20/2004) ##
  * The assembly successfully compiles under Mono v1.0, .NET v1.0, and .NET v1.1.
  * NAnt build script added to project.
  * Removed the old HasherTester project (it was a goofy program at best).
  * Added a new HasherTester library for use with NUnit. All algorithms can now be easily regression tested.
  * HMAC is now slightly more thread-safe (remember, it's not 100%).
  * UShortToByte, UIntToByte, and ULongToByte all crashed if given a non-zero offset. Fixed.
  * The HashAlgorithm.State is now correctly reset during initialization of all algorithms.
  * Fixed [bug #1069427](https://code.google.com/p/classless-hasher/issues/detail?id=1069427). Whirlpool was broken.
  * Added support for CRC parameters with orders of 24, 40, 48, and 56.
  * Added a CRCStandard for CRC24.
  * Fixed a bug with SHA384 and SHA512 where not enough room was reserved for the bit count.


## Version [0.5](http://code.google.com/p/classless-hasher/downloads/list?can=1&q=v0.5) (Build 1637; 6/25/2004) ##
  * This project is now released under the Mozilla Public License v1.1.
  * The project has been upgraded to VS.NET 2003. Now compiled against/for .NET v1.1.
  * Major restructuring of the classes. I hope no one was married to the original structure. This will most likely be the final organization going into the v1.0 baseline.
  * Added a Readme.html with information about the project.
  * All parameter classes now derive from HashAlgorithmParameters.
  * MAJOR speed enhancements to CRC. Processing time has sped up by a factor of 500-600%. (Yes, I'm serious -- the original implementation was not terribly efficient.)
  * CRC can now handle 64bit polynomials.
  * Added algorithms:
    * ElfHash
    * FNV
    * JHash (Jenkins Hash)
    * SHA224
    * XUM32


## Version 0.4 (1/31/2004) ##
  * Assembly is now CLS compliant. This may be a breaking change, as we had to ditch our public unsigned integers in favor of signed ones. Also, many of the methods in the Utilities class won't be available unless you're using a language that supports unsigned integers.
  * The precompiled assembly that is available via Classless.net is now strongly named.
  * Added a class that provides HMAC functionality. It will work with any hash algorithm provided in this library.
  * Added a Parallel hash calculator that will simultaneously calculate the hash of the given data using the HashAlgorithms provided and return a result that is the concatenation of all the individual HashAlgorithm results.
  * The algorithms that take parameters (CRC, GHash, HAVAL, Snefru2) now throw an exception if given a null pointer as the parameter.
  * Added algorithms:
    * BSD checksum
    * SysV checksum
    * Cksum (aka POSIX 1003.2 CRC)


## Version 0.3 (1/19/2004) ##
  * Started using FxCop to analyze the assembly (ignoring some of the silly naming convention rules).
  * Added the RotateRight and RotateLeft methods to the Utilities class (still cutting out repeated code).
  * Consolidated the CRC standards into the GetParameters() method.
  * HasherTester application can now print a suite of test vectors to a file with the "-testvectors" argument.
  * The Utilities class is now sealed.
  * Added a CRC standard to replicate the BZip2 CRC (it's a slight variation of PKZip's CRC).
  * Changed GHash to accept a parameters class like CRC.
  * Found that we're calling Initialize() one to three times more than we need to -- fixed.
  * All algorithms are now _mostly_ thread-safe (it's not 100% gaurenteed, so be careful).
  * Added algorithms:
    * HAVAL
    * Snefru2


## Version 0.2 (1/10/2004) ##
  * Consolidated data block processing into a base class (cuts down on repeated code!).
  * Added Utilites class that has some common conversion methods (even more repeated code gone!).
  * Fixed HashSizeValue of Tiger to be 192 instead of 160 (oops).
  * Incorporated our own code for the SHA1, SHA256, SHA384, and SHA512 algorithms instead of using .NET's.
  * Added algorithms:
    * FCS
    * GHash
    * GOSTHash
    * SHA0
    * Whirlpool


## Version 0.1 (12/29/2003) ##
  * First public release (be gentle).
  * Algorithms provided:
    * Adler32
    * CRC (generic -- can support any polynomial up to 32bits)
    * MD2, MD4, MD5
    * RIPEMD128, RIPEMD160, RIPEMD256, RIPEMD320
    * SHA1, SHA256, SHA384, SHA512
    * Tiger


## Version 0.0 (12/3/2003 - 12/28/2003) ##
  * A ridiculous number of builds for internal testing.