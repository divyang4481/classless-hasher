# Project hosting has been moved to Bitbucket: #
## https://bitbucket.org/jayclassless/classless-hasher/ ##



| **Algorithm** | **Digest Size (bits)** | **Notes** | **Object Identifier (OID)** | **Version Introduced** |
|:--------------|:-----------------------|:----------|:----------------------------|:-----------------------|
| Adler32 | 32 | RFC [1950](ftp://ftp.rfc-editor.org/in-notes/rfc1950.txt), ZLIB Compressed Data Format Specification version 3.3 |  | 0.1 |
| AP | 32 | [Arash Partow](http://www.partow.net/programming/hashfunctions/#APHashFunction) |  | 0.8 |
| BKDR | 32 | Brian Kernighan, Dennis Ritchie, "The C Programming Language" |  | 0.8 |
| Cksum | 32 | POSIX [1003.2-1992](http://standards.ieee.org/reading/ieee/std/posix/1003.2-1992_INT_DEC94.pdf) |  | 0.4 |
| CRC | 8, 16, 24, 32, 40, 48, 56, 64 | See ProvidedCrcStandards | Crc32Bit=[1.3.6.1.4.1.11591.14.1](http://www.oid-info.com/get/1.3.6.1.4.1.11591.14.1) | 0.1 |
| DHA256 | 256 | 2005, [Jesang Lee, Donghoon Chang, Hyun Kim, Eunjin Lee, Deukjo Hong, Jaechul Sung, Seokhie Hong, Sangjin Lee](http://csrc.nist.gov/groups/ST/hash/documents/ChangD_DHA256.pdf) |  | 0.8 |
| DJB | 32 | Daniel J. Bernstein |  | 0.8 |
| ElfHash | 32 | UNIX ELF format hash for object files |  | 0.5 |
| FCS | 16, 32 | RFC [1331](ftp://ftp.rfc-editor.org/in-notes/rfc1331.txt), Fast Frame Check Sequence |  | 0.2 |
| Fletcher | 8, 16, 32 | RFC [1146](ftp://ftp.rfc-editor.org/in-notes/rfc1146.txt) |  | 0.8 |
| FNV | 32, 64 | [Glenn Fowler, Landon Curt Noll, Phong Vo](http://www.isthe.com/chongo/tech/comp/fnv/index.html) |  | 0.5 |
| GHash | 32 |  |  | 0.2 |
| GOSTHash | 256 | 1994, GOST-R-34.11-94, Gosudarstvennyi Standard of Russian Federation | [1.2.643.2.2.9](http://www.oid-info.com/get/1.2.643.2.2.9), [1.2.643.2.2.20](http://www.oid-info.com/get/1.2.643.2.2.20), [1.2.643.2.2.1.1.7](http://www.oid-info.com/get/1.2.643.2.2.1.1.7) | 0.2 |
| HAS-160 | 160 | [[TTAS.KO-12.0011/R1](http://files.randombit.net/misc/has160.pdf) |  | 0.8 |
| HAVAL | 128, 160, 192, 224, 256 | 1992, [Y. Zheng, J. Pieprzyk and J. Seberry](http://www.calyptix.com/files/haval-paper.pdf) | 1.3.6.1.4.1.18105.2.1.1 (1-15) | 0.3 |
| HMAC | variable | RFC [2104](ftp://ftp.rfc-editor.org/in-notes/rfc2104.txt), Keyed-Hashing for Message Authentication |  | 0.4 |
| JenkinsHash | 32 | 1996, [Bob Jenkins](http://burtleburtle.net/bob/hash/doobs.html) |  | 0.5 |
| JS | 32 | Justin Sobel |  | 0.8 |
| MD2 | 128 | RFC [1319](ftp://ftp.rfc-editor.org/in-notes/rfc1319.txt), MD2 Message-Digest Algorithm | [1.2.840.113549.2.2](http://www.oid-info.com/get/1.2.840.113549.2.2) | 0.1 |
| MD4 | 128 | RFC [1320](ftp://ftp.rfc-editor.org/in-notes/rfc1320.txt), MD4 Message-Digest Algorithm | [1.2.840.113549.2.4](http://www.oid-info.com/get/1.2.840.113549.2.4) | 0.1 |
| MD5 | 128 | RFC [1321](ftp://ftp.rfc-editor.org/in-notes/rfc1321.txt), MD5 Message-Digest Algorithm | [1.2.840.113549.2.5](http://www.oid-info.com/get/1.2.840.113549.2.5) | 0.1 |
| Panama | 256 |  |  | 0.7 |
| PJW32 | 32 | Peter J. Weinberger |  | 0.8 |
| RIPEMD128 | 128 | 1996, [Hans Dobbertin, Antoon Bosselaers, and Bart Preneel](http://www.esat.kuleuven.ac.be/~bosselae/ripemd160.html) | [1.3.36.3.2.2](http://www.oid-info.com/get/1.3.36.3.2.2), [1.0.10118.3.0.50](http://www.oid-info.com/get/1.0.10118.3.0.50) | 0.1 |
| RIPEMD160 | 160 | 1996, [Hans Dobbertin, Antoon Bosselaers, and Bart Preneel](http://www.esat.kuleuven.ac.be/~bosselae/ripemd160.html) | [1.3.36.3.2.1](http://www.oid-info.com/get/1.3.36.3.2.1), [1.0.10118.3.0.49](http://www.oid-info.com/get/1.0.10118.3.0.49) | 0.1 |
| RIPEMD256 | 256 | 1996, [Hans Dobbertin, Antoon Bosselaers, and Bart Preneel](http://www.esat.kuleuven.ac.be/~bosselae/ripemd160.html) | [1.3.36.3.2.3](http://www.oid-info.com/get/1.3.36.3.2.3) | 0.1 |
| RIPEMD320 | 320 | 1996, [Hans Dobbertin, Antoon Bosselaers, and Bart Preneel](http://www.esat.kuleuven.ac.be/~bosselae/ripemd160.html) |  | 0.1 |
| RS | 32 |  Robert Sedgwicks, "Algorithms in C" |  | 0.8 |
| SDBM | 32 |  |  | 0.8 |
| SHA0 | 160 | NIST FIPS PUB 180 | [1.3.14.3.2.18](http://www.oid-info.com/get/1.3.14.3.2.18) | 0.2 |
| SHA1 | 160 | NIST FIPS PUB [180-1](http://www.itl.nist.gov/fipspubs/fip180-1.htm) | [1.3.14.3.2.26](http://www.oid-info.com/get/1.3.14.3.2.26) | 0.1 |
| SHA224 | 224 | NIST FIPS PUB [180-2](http://csrc.nist.gov/publications/fips/fips180-2/fips180-2withchangenotice.pdf) | [2.16.840.1.101.3.4.2.4](http://www.oid-info.com/get/2.16.840.1.101.3.4.2.4) | 0.5 |
| SHA256 | 256 | NIST FIPS PUB [180-2](http://csrc.nist.gov/publications/fips/fips180-2/fips180-2withchangenotice.pdf) | [2.16.840.1.101.3.4.2.1](http://www.oid-info.com/get/2.16.840.1.101.3.4.2.1) | 0.1 |
| SHA384 | 384 | NIST FIPS PUB [180-2](http://csrc.nist.gov/publications/fips/fips180-2/fips180-2withchangenotice.pdf) | [2.16.840.1.101.3.4.2.2](http://www.oid-info.com/get/2.16.840.1.101.3.4.2.2) | 0.1 |
| SHA512 | 512 | NIST FIPS PUB [180-2](http://csrc.nist.gov/publications/fips/fips180-2/fips180-2withchangenotice.pdf) | [2.16.840.1.101.3.4.2.3](http://www.oid-info.com/get/2.16.840.1.101.3.4.2.3) | 0.1 |
| Snefru2 | 128, 256 | 1990, Ralph Merkle, [Secure Hash Function](ftp://arisia.xerox.com/pub/hash/">Xerox) |  | 0.3 |
| Sum | 8, 16, 24, 32, 64 |  |  | 0.8 |
| Sum (BSD) | 16 | BSD Sum Algorithm |  | 0.4 |
| Sum (SYSV) | 16 | System V Sum Algorithm |  | 0.4 |
| Tiger | 128, 160, 192 | 1996, [Ross Anderson and Eli Biham](http://www.cs.technion.ac.il/~biham/Reports/Tiger/) | [1.3.6.1.4.1.11591.12.2](http://www.oid-info.com/get/1.3.6.1.4.1.11591.12.2) | 0.1 |
| Tiger2 | 128, 160, 192 | 1996, [Ross Anderson and Eli Biham](http://www.cs.technion.ac.il/~biham/Reports/Tiger/) |  | 0.8 |
| Whirlpool | 512 | 2000, [Paulo Barreto and Vincent Rijmen](http://planeta.terra.com.br/informatica/paulobarreto/WhirlpoolPage.html) | [1.0.10118.3.0.55](http://www.oid-info.com/get/1.0.10118.3.0.55) | 0.2 |
| XOR8 | 8 |  |  | 0.8 |
| XUM32 | 32 | Ilya O. Levin, [Nattyware](http://www.nattyware.com/xum32txt.html) |  | 0.5 |