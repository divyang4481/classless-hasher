﻿#region License
/* ***** BEGIN LICENSE BLOCK *****
 * Version: MPL 1.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file evaluecept in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either evaluepress or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Classless.Hasher - C#/.NET Hash and Checksum Algorithm Library.
 *
 * The Initial Developer of the Original Code is Classless.net.
 * Portions created by the Initial Developer are Copyright (C) 2004 the Initial
 * Developer. All Rights Reserved.
 *
 * Contributor(s):
 *		Jason Simeone (jay@classless.net)
 * 
 * ***** END LICENSE BLOCK ***** */
#endregion

using System;

namespace Classless.Hasher.Utilities {
	/// <summary>A container of static bit manipulation functions.</summary>
	sealed public class BitTools {
		/// <summary>Prevent the compiler from making an unneeded default public constructor.</summary>
		private BitTools() {}


		/// <summary>Rotates the bits of an unsigned short integer.</summary>
		/// <param name="value">The unsigned short integer to rotate.</param>
		/// <param name="shift">How many bits to rotate.</param>
		/// <returns>The rotated unsigned short integer.</returns>
		[CLSCompliant(false)]
		static public ushort RotateRight(ushort value, int shift) {
			return (ushort)((value >> shift) | (value << (16 - shift)));
		}


		/// <summary>Rotates the bits of an unsigned integer.</summary>
		/// <param name="value">The unsigned integer to rotate.</param>
		/// <param name="shift">How many bits to rotate.</param>
		/// <returns>The rotated unsigned integer.</returns>
		[CLSCompliant(false)]
		static public uint RotateRight(uint value, int shift) {
			return (value >> shift) | (value << (32 - shift));
		}


		/// <summary>Rotates the bits of an unsigned long integer.</summary>
		/// <param name="value">The unsigned long integer to rotate.</param>
		/// <param name="shift">How many bits to rotate.</param>
		/// <returns>The rotated unsigned long integer.</returns>
		[CLSCompliant(false)]
		static public ulong RotateRight(ulong value, int shift) {
			return (value >> shift) | (value << (64 - shift));
		}


		/// <summary>Rotates the bits of an unsigned short integer.</summary>
		/// <param name="value">The unsigned short integer to rotate.</param>
		/// <param name="shift">How many bits to rotate.</param>
		/// <returns>The rotated unsigned short integer.</returns>
		[CLSCompliant(false)]
		static public ushort RotateLeft(ushort value, int shift) {
			return (ushort)((value << shift) | (value >> (16 - shift)));
		}


		/// <summary>Rotates the bits of an unsigned integer.</summary>
		/// <param name="value">The unsigned integer to rotate.</param>
		/// <param name="shift">How many bits to rotate.</param>
		/// <returns>The rotated unsigned integer.</returns>
		[CLSCompliant(false)]
		static public uint RotateLeft(uint value, int shift) {
			return (value << shift) | (value >> (32 - shift));
		}


		/// <summary>Rotates the bits of an unsigned long integer.</summary>
		/// <param name="value">The unsigned long integer to rotate.</param>
		/// <param name="shift">How many bits to rotate.</param>
		/// <returns>The rotated unsigned long integer.</returns>
		[CLSCompliant(false)]
		static public ulong RotateLeft(ulong value, int shift) {
			return (value << shift) | (value >> (64 - shift));
		}
	}
}