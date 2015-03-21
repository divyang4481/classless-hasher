# Project hosting has been moved to Bitbucket: #
## https://bitbucket.org/jayclassless/classless-hasher/ ##



### Calculate the SHA1 Hash of a String ###
```
using System;
using Classless.Hasher;
using Classless.Hasher.Utilities;

namespace TestProgram {
	public class TestProgram {
		static void Main(string[] args) {
			// Get the array of bytes representing the string.
			byte[] input = System.Text.Encoding.ASCII.GetBytes("Hello World!");

			// Instantiate our hashing algorithm.
			Sha1 shaHasher = new Sha1();

			// Calculate the hash and write it to the console.
			Console.WriteLine(Conversions.ByteToHexadecimal(shaHasher.ComputeHash(input)));
		}
	}
}
```


### Calculate a PKZIP-Compatible CRC Checksum of a String ###
```
using System;
using Classless.Hasher;
using Classless.Hasher.Utilities;

namespace TestProgram {
	public class TestProgram {
		static void Main(string[] args) {
			// Get the array of bytes representing the string.
			byte[] input = System.Text.Encoding.ASCII.GetBytes("Hello World!");

			// Instantiate our hashing algorithm.
			Crc crcHasher = new Crc(CrcParameters.GetParameters(CrcStandard.Crc32Bit));

			// Calculate the hash and write it to the console.
			Console.WriteLine(Conversions.ByteToHexadecimal(crcHasher.ComputeHash(input)));
		}
	}
}
```


### Calculate the MD5 Hash of a File ###
```
using System;
using System.IO;
using Classless.Hasher;
using Classless.Hasher.Utilities;

namespace TestProgram {
	public class TestProgram {
		static void Main(string[] args) {
			// Open the file specified on the command line.
			FileStream inputFile = new FileStream(args[0], FileMode.Open, FileAccess.Read);

			// Instantiate our hashing algorithm.
			MD5 md5Hasher = new MD5();

			// Calculate the hash and write it to the console.
			Console.WriteLine(Conversions.ByteToHexadecimal(md5Hasher.ComputeHash(inputFile)));

			// Clean up.
			inputFile.Close();
		}
	}
}
```


### Calculate the Tiger Tree Hash of a File ###
```
using System;
using System.IO;
using Classless.Hasher;
using Classless.Hasher.Methods;
using Classless.Hasher.Utilities;

namespace TestProgram {
	public class TestProgram {
		static void Main(string[] args) {
			// Open the file specified on the command line.
			FileStream inputFile = new FileStream(args[0], FileMode.Open, FileAccess.Read);

			// Instantiate our hashing algorithm.
			HashTree treeHasher = new HashTree(new Tiger(TigerParameters.GetParameters(TigerStandard.Tiger192BitVersion1)), 1024);

			// Construct the tree and write the Top hash to the console.
			Console.WriteLine(Conversions.ByteToHexadecimal(treeHasher.ComputeHash(inputFile)));

			// Clean up.
			inputFile.Close();
		}
	}
}
```