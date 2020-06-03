/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if DECODER
using System;
using System.Collections.Generic;
using Iced.Intel;

namespace Iced.UnitTests.Intel {
	static partial class ToEnumConverter {
		public static bool TryDecoderOptions(string value, out DecoderOptions decoderOptions) => decoderOptionsDict.TryGetValue(value, out decoderOptions);
		public static DecoderOptions GetDecoderOptions(string value) => TryDecoderOptions(value, out var decoderOptions) ? decoderOptions : throw new InvalidOperationException($"Invalid DecoderOptions value: {value}");

		static readonly Dictionary<string, DecoderOptions> decoderOptionsDict =
			// GENERATOR-BEGIN: DecoderOptionsHash
			// ⚠️This was generated by GENERATOR!🦹‍♂️
			new Dictionary<string, DecoderOptions>(20, StringComparer.Ordinal) {
				{ "None", DecoderOptions.None },
				{ "NoInvalidCheck", DecoderOptions.NoInvalidCheck },
				{ "AMD", DecoderOptions.AMD },
				{ "ForceReservedNop", DecoderOptions.ForceReservedNop },
				{ "Umov", DecoderOptions.Umov },
				{ "Xbts", DecoderOptions.Xbts },
				{ "Cmpxchg486A", DecoderOptions.Cmpxchg486A },
				{ "OldFpu", DecoderOptions.OldFpu },
				{ "Pcommit", DecoderOptions.Pcommit },
				{ "Loadall286", DecoderOptions.Loadall286 },
				{ "Loadall386", DecoderOptions.Loadall386 },
				{ "Cl1invmb", DecoderOptions.Cl1invmb },
				{ "MovTr", DecoderOptions.MovTr },
				{ "Jmpe", DecoderOptions.Jmpe },
				{ "NoPause", DecoderOptions.NoPause },
				{ "NoWbnoinvd", DecoderOptions.NoWbnoinvd },
				{ "NoLockMovCR0", DecoderOptions.NoLockMovCR0 },
				{ "NoMPFX_0FBC", DecoderOptions.NoMPFX_0FBC },
				{ "NoMPFX_0FBD", DecoderOptions.NoMPFX_0FBD },
				{ "NoLahfSahf64", DecoderOptions.NoLahfSahf64 },
			};
			// GENERATOR-END: DecoderOptionsHash
	}
}
#endif
