# Project hosting has been moved to Bitbucket: #
## https://bitbucket.org/jayclassless/classless-hasher/ ##



Contrary to popular belief, there is more than one way to perform a Cyclic Redundency Check. Classless.Hasher will support polynomials that are 8, 16, 32 or 64 bits long, as well as an assortment of algorithm options. Classless.Hasher has built-in support for the following standards:


| **Name** | **Polynomial** | **Initial Value** | **XOR Output** | **Reflection** | **Aliases** |
|:---------|:---------------|:------------------|:---------------|:---------------|:------------|
| Crc8Bit | 0x07 | 0 | 0 | No |  |
| Crc8BitIcode | 0x1D | 0xFD | 0 | No |  |
| Crc8BitItu | 0x07 | 0 | 0x55 | No |  |
| Crc8BitMaxim | 0x31 | 0 | 0 | Yes |  |
| Crc8BitWcdma | 0x9B | 0 | 0 | Yes |  |
| Crc16Bit | 0x8005 | 0 | 0 | Yes | Crc16BitArc, Crc16BitIbm, Crc16BitLha |
| Crc16BitCcitt | 0x1021 | 0 | 0 | Yes | Crc16BitKermit |
| Crc16BitCcittFalse | 0x1021 | 0xFFFF | 0 | No |  |
| Crc16BitMaxim | 0x8005 | 0 | 0xFFFF | Yes |  |
| Crc16BitUsb | 0x8005 | 0xFFFF | 0xFFFF | Yes |  |
| Crc16BitX25 | 0x1021 | 0xFFFF | 0xFFFF | Yes |  |
| Crc16BitXmodem | 0x1021 | 0 | 0 | No | Crc16BitZmodem |
| Crc16BitXkermit | 0x8408 | 0 | 0 | Yes |  |
| Crc24Bit | 0x864CFB | 0xB704CE | 0 | No | Crc24BitOpenPgp |
| Crc32Bit | 0x04C11DB7 | 0xFFFFFFFF | 0xFFFFFFFF | Yes | Crc32BitPkzip, Crc32BitItu |
| Crc32BitBzip2 | 0x04C11DB7 | 0xFFFFFFFF | 0xFFFFFFFF | No |  |
| Crc32BitIscsi | 0x1EDC6F41 | 0xFFFFFFFF | 0xFFFFFFFF | Yes |  |
| Crc32BitJam | 0x04C11DB7 | 0xFFFFFFFF | 0 | Yes |  |
| Crc32BitPosix | 0x04C11DB7 | 0 | 0xFFFFFFFF | No | Crc32BitCksum |
| Crc32BitMpeg2 | 0x04C11DB7 | 0xFFFFFFFF | 0 | No |  |
| Crc64Bit | 0x42F0E1EBA9EA3693 | 0 | 0 | No |  |
| Crc64BitWE | 0x42F0E1EBA9EA3693 | 0xFFFFFFFFFFFFFFFF | 0xFFFFFFFFFFFFFFFF | No |  |
| Crc64BitIso | 0x000000000000001B | 0 | 0 | Yes |  |
| Crc64BitJones | 0xAD93D23594C935A9  | 0 | 0 | Yes |  |


More information and other standards can be found here:
  * http://homepages.tesco.net/~rainstorm/crc-catalogue.htm
  * http://en.wikipedia.org/wiki/Cyclic_redundancy_check#Commonly_used_and_standardized_CRCs