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

#![allow(unused_results)]

use super::super::super::DecoderOptions;
#[cfg(not(feature = "std"))]
use hashbrown::HashMap;
#[cfg(feature = "std")]
use std::collections::HashMap;

lazy_static! {
	pub(super) static ref TO_DECODER_OPTIONS_HASH: HashMap<&'static str, u32> = {
		// GENERATOR-BEGIN: DecoderOptionsHash
		// ⚠️This was generated by GENERATOR!🦹‍♂️
		let mut h = HashMap::with_capacity(20);
		h.insert("None", DecoderOptions::NONE);
		h.insert("NoInvalidCheck", DecoderOptions::NO_INVALID_CHECK);
		h.insert("AMD", DecoderOptions::AMD);
		h.insert("ForceReservedNop", DecoderOptions::FORCE_RESERVED_NOP);
		h.insert("Umov", DecoderOptions::UMOV);
		h.insert("Xbts", DecoderOptions::XBTS);
		h.insert("Cmpxchg486A", DecoderOptions::CMPXCHG486A);
		h.insert("OldFpu", DecoderOptions::OLD_FPU);
		h.insert("Pcommit", DecoderOptions::PCOMMIT);
		h.insert("Loadall286", DecoderOptions::LOADALL286);
		h.insert("Loadall386", DecoderOptions::LOADALL386);
		h.insert("Cl1invmb", DecoderOptions::CL1INVMB);
		h.insert("MovTr", DecoderOptions::MOV_TR);
		h.insert("Jmpe", DecoderOptions::JMPE);
		h.insert("NoPause", DecoderOptions::NO_PAUSE);
		h.insert("NoWbnoinvd", DecoderOptions::NO_WBNOINVD);
		h.insert("NoLockMovCR0", DecoderOptions::NO_LOCK_MOV_CR0);
		h.insert("NoMPFX_0FBC", DecoderOptions::NO_MPFX_0FBC);
		h.insert("NoMPFX_0FBD", DecoderOptions::NO_MPFX_0FBD);
		h.insert("NoLahfSahf64", DecoderOptions::NO_LAHF_SAHF_64);
		// GENERATOR-END: DecoderOptionsHash
		h
	};
}
