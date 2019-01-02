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

#if !NO_GAS_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Gas {
	public sealed class GasFormatterTest64_NoSuffix_008 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, GasFormatterFactory.Create_NoSuffix());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_008.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_008.AllInfos_Length] {
			"vpcompressb %zmm10,%zmm19{%k3}{z}",
			"vpcompressb %zmm2,1(%rax)",
			"vpcompressw %xmm2,%xmm3",
			"vpcompressw %xmm2,2(%rax)",
			"vpcompressw %ymm2,%ymm3{%k3}",
			"vpcompressw %ymm2,2(%rax){%k3}",
			"vpcompressw %zmm10,%zmm19{%k3}{z}",
			"vpcompressw %zmm2,2(%rax)",
			"vpshldvw %xmm3,%xmm6,%xmm2{%k3}",
			"vpshldvw 0x10(%rax),%xmm6,%xmm2",
			"vpshldvw %ymm3,%ymm6,%ymm2{%k3}",
			"vpshldvw 0x20(%rax),%ymm6,%ymm2{%k3}",
			"vpshldvw %zmm3,%zmm14,%zmm18{%k3}{z}",
			"vpshldvw 0x40(%rax),%zmm6,%zmm2{%k3}{z}",
			"vpshldvd %xmm3,%xmm14,%xmm18{%k3}",
			"vpshldvd 0x10(%rax),%xmm6,%xmm2",
			"vpshldvd 4(%rax){1to4},%xmm6,%xmm2{%k5}{z}",
			"vpshldvd %ymm3,%ymm14,%ymm18{%k3}",
			"vpshldvd 0x20(%rax),%ymm6,%ymm2{%k3}",
			"vpshldvd 4(%rax){1to8},%ymm6,%ymm2{%k5}{z}",
			"vpshldvd %zmm3,%zmm6,%zmm2{%k3}{z}",
			"vpshldvd 0x40(%rax),%zmm6,%zmm2",
			"vpshldvd 4(%rax){1to16},%zmm6,%zmm2{%k5}{z}",
			"vpshldvq %xmm3,%xmm14,%xmm18{%k3}",
			"vpshldvq 0x10(%rax),%xmm6,%xmm2",
			"vpshldvq 8(%rax){1to2},%xmm6,%xmm2{%k5}{z}",
			"vpshldvq %ymm3,%ymm14,%ymm18{%k3}",
			"vpshldvq 0x20(%rax),%ymm6,%ymm2{%k3}",
			"vpshldvq 8(%rax){1to4},%ymm6,%ymm2{%k5}{z}",
			"vpshldvq %zmm3,%zmm6,%zmm2{%k3}{z}",
			"vpshldvq 0x40(%rax),%zmm6,%zmm2",
			"vpshldvq 8(%rax){1to8},%zmm6,%zmm2{%k5}{z}",
			"vpshrdvw %xmm3,%xmm6,%xmm2{%k3}",
			"vpshrdvw 0x10(%rax),%xmm6,%xmm2",
			"vpshrdvw %ymm3,%ymm6,%ymm2{%k3}",
			"vpshrdvw 0x20(%rax),%ymm6,%ymm2{%k3}",
			"vpshrdvw %zmm3,%zmm14,%zmm18{%k3}{z}",
			"vpshrdvw 0x40(%rax),%zmm6,%zmm2{%k3}{z}",
			"vpshrdvd %xmm3,%xmm14,%xmm18{%k3}",
			"vpshrdvd 0x10(%rax),%xmm6,%xmm2",
			"vpshrdvd 4(%rax){1to4},%xmm6,%xmm2{%k5}{z}",
			"vpshrdvd %ymm3,%ymm14,%ymm18{%k3}",
			"vpshrdvd 0x20(%rax),%ymm6,%ymm2{%k3}",
			"vpshrdvd 4(%rax){1to8},%ymm6,%ymm2{%k5}{z}",
			"vpshrdvd %zmm3,%zmm6,%zmm2{%k3}{z}",
			"vpshrdvd 0x40(%rax),%zmm6,%zmm2",
			"vpshrdvd 4(%rax){1to16},%zmm6,%zmm2{%k5}{z}",
			"vpshrdvq %xmm3,%xmm14,%xmm18{%k3}",
			"vpshrdvq 0x10(%rax),%xmm6,%xmm2",
			"vpshrdvq 8(%rax){1to2},%xmm6,%xmm2{%k5}{z}",
			"vpshrdvq %ymm3,%ymm14,%ymm18{%k3}",
			"vpshrdvq 0x20(%rax),%ymm6,%ymm2{%k3}",
			"vpshrdvq 8(%rax){1to4},%ymm6,%ymm2{%k5}{z}",
			"vpshrdvq %zmm3,%zmm6,%zmm2{%k3}{z}",
			"vpshrdvq 0x40(%rax),%zmm6,%zmm2",
			"vpshrdvq 8(%rax){1to8},%zmm6,%zmm2{%k5}{z}",
			"vpshufbitqmb %xmm3,%xmm6,%k2{%k3}",
			"vpshufbitqmb 0x10(%rax),%xmm6,%k2",
			"vpshufbitqmb %ymm3,%ymm6,%k2{%k3}",
			"vpshufbitqmb 0x20(%rax),%ymm6,%k2{%k3}",
			"vpshufbitqmb %zmm3,%zmm6,%k2{%k3}",
			"vpshufbitqmb 0x40(%rax),%zmm6,%k2",
			"gf2p8mulb %xmm5,%xmm1",
			"gf2p8mulb (%rax),%xmm1",
			"vgf2p8mulb %xmm3,%xmm6,%xmm2",
			"vgf2p8mulb (%rax),%xmm6,%xmm2",
			"vgf2p8mulb %ymm3,%ymm6,%ymm2",
			"vgf2p8mulb (%rax),%ymm6,%ymm2",
			"vgf2p8mulb %xmm3,%xmm6,%xmm2{%k3}",
			"vgf2p8mulb 0x10(%rax),%xmm6,%xmm2",
			"vgf2p8mulb %ymm3,%ymm6,%ymm2{%k3}",
			"vgf2p8mulb 0x20(%rax),%ymm6,%ymm2{%k3}",
			"vgf2p8mulb %zmm3,%zmm14,%zmm18{%k3}{z}",
			"vgf2p8mulb 0x40(%rax),%zmm6,%zmm2{%k5}{z}",
			"vaesenc %ymm3,%ymm6,%ymm2",
			"vaesenc (%rax),%ymm6,%ymm2",
			"vaesenc %xmm3,%xmm6,%xmm2",
			"vaesenc 0x10(%rax),%xmm6,%xmm2",
			"vaesenc %ymm3,%ymm6,%ymm2",
			"vaesenc 0x20(%rax),%ymm6,%ymm2",
			"vaesenc %zmm3,%zmm6,%zmm2",
			"vaesenc 0x40(%rax),%zmm6,%zmm2",
			"vaesenclast %ymm3,%ymm6,%ymm2",
			"vaesenclast (%rax),%ymm6,%ymm2",
			"vaesenclast %xmm3,%xmm6,%xmm2",
			"vaesenclast 0x10(%rax),%xmm6,%xmm2",
			"vaesenclast %ymm3,%ymm6,%ymm2",
			"vaesenclast 0x20(%rax),%ymm6,%ymm2",
			"vaesenclast %zmm3,%zmm6,%zmm2",
			"vaesenclast 0x40(%rax),%zmm6,%zmm2",
			"vaesdec %ymm3,%ymm6,%ymm2",
			"vaesdec (%rax),%ymm6,%ymm2",
			"vaesdec %xmm3,%xmm6,%xmm2",
			"vaesdec 0x10(%rax),%xmm6,%xmm2",
			"vaesdec %ymm3,%ymm6,%ymm2",
			"vaesdec 0x20(%rax),%ymm6,%ymm2",
			"vaesdec %zmm3,%zmm6,%zmm2",
			"vaesdec 0x40(%rax),%zmm6,%zmm2",
			"vaesdeclast %ymm3,%ymm6,%ymm2",
			"vaesdeclast (%rax),%ymm6,%ymm2",
			"vaesdeclast %xmm3,%xmm6,%xmm2",
			"vaesdeclast 0x10(%rax),%xmm6,%xmm2",
			"vaesdeclast %ymm3,%ymm6,%ymm2",
			"vaesdeclast 0x20(%rax),%ymm6,%ymm2",
			"vaesdeclast %zmm3,%zmm6,%zmm2",
			"vaesdeclast 0x40(%rax),%zmm6,%zmm2",
			"wrussd %ebx,(%rax)",
			"wrussq %rbx,(%rax)",
			"wrssd %ebx,(%rax)",
			"wrssq %rbx,(%rax)",
			"movdir64b (%eax),%ebx",
			"movdir64b (%rax),%rbx",
			"movdiri %ebx,(%rax)",
			"movdiri %rbx,(%rax)",
			"vpclmulqdq $0xa5,%ymm3,%ymm6,%ymm2",
			"vpclmulqdq $0xa5,(%rax),%ymm6,%ymm2",
			"vpclmulqdq $0xa5,%xmm3,%xmm6,%xmm2",
			"vpclmulqdq $0xa5,0x10(%rax),%xmm6,%xmm2",
			"vpclmulqdq $0xa5,%ymm3,%ymm6,%ymm2",
			"vpclmulqdq $0xa5,0x20(%rax),%ymm6,%ymm2",
			"vpclmulqdq $0xa5,%zmm3,%zmm6,%zmm2",
			"vpclmulqdq $0xa5,0x40(%rax),%zmm6,%zmm2",
			"vpshldw $0xa5,%xmm3,%xmm6,%xmm2{%k3}",
			"vpshldw $0xa5,0x10(%rax),%xmm6,%xmm2{%k3}",
			"vpshldw $0xa5,%ymm3,%ymm14,%ymm18{%k3}{z}",
			"vpshldw $0xa5,0x20(%rax),%ymm6,%ymm2{%k5}{z}",
			"vpshldw $0xa5,%zmm3,%zmm6,%zmm2{%k3}",
			"vpshldw $0xa5,0x40(%rax),%zmm6,%zmm2",
			"vpshldd $0xa5,%xmm3,%xmm6,%xmm2{%k3}",
			"vpshldd $0xa5,0x10(%rax),%xmm6,%xmm2{%k3}",
			"vpshldd $0xa5,4(%rax){1to4},%xmm6,%xmm2{%k5}{z}",
			"vpshldd $0xa5,%ymm3,%ymm6,%ymm2{%k3}{z}",
			"vpshldd $0xa5,0x20(%rax),%ymm6,%ymm2",
			"vpshldd $0xa5,4(%rax){1to8},%ymm6,%ymm2{%k5}{z}",
			"vpshldd $0xa5,%zmm3,%zmm6,%zmm2{%k3}",
			"vpshldd $0xa5,0x40(%rax),%zmm6,%zmm2",
			"vpshldd $0xa5,4(%rax){1to16},%zmm6,%zmm2{%k5}{z}",
			"vpshldq $0xa5,%xmm3,%xmm14,%xmm18{%k3}",
			"vpshldq $0xa5,0x10(%rax),%xmm6,%xmm2{%k3}",
			"vpshldq $0xa5,8(%rax){1to2},%xmm6,%xmm2{%k5}{z}",
			"vpshldq $0xa5,%ymm3,%ymm6,%ymm2{%k3}{z}",
			"vpshldq $0xa5,0x20(%rax),%ymm6,%ymm2",
			"vpshldq $0xa5,8(%rax){1to4},%ymm6,%ymm2{%k5}{z}",
			"vpshldq $0xa5,%zmm3,%zmm14,%zmm18{%k3}",
			"vpshldq $0xa5,0x40(%rax),%zmm6,%zmm2",
			"vpshldq $0xa5,8(%rax){1to8},%zmm6,%zmm2{%k5}{z}",
			"vpshrdw $0xa5,%xmm3,%xmm6,%xmm2{%k3}",
			"vpshrdw $0xa5,0x10(%rax),%xmm6,%xmm2{%k3}",
			"vpshrdw $0xa5,%ymm3,%ymm14,%ymm18{%k3}{z}",
			"vpshrdw $0xa5,0x20(%rax),%ymm6,%ymm2{%k5}{z}",
			"vpshrdw $0xa5,%zmm3,%zmm6,%zmm2{%k3}",
			"vpshrdw $0xa5,0x40(%rax),%zmm6,%zmm2",
			"vpshrdd $0xa5,%xmm3,%xmm6,%xmm2{%k3}",
			"vpshrdd $0xa5,0x10(%rax),%xmm6,%xmm2{%k3}",
			"vpshrdd $0xa5,4(%rax){1to4},%xmm6,%xmm2{%k5}{z}",
			"vpshrdd $0xa5,%ymm3,%ymm6,%ymm2{%k3}{z}",
			"vpshrdd $0xa5,0x20(%rax),%ymm6,%ymm2",
			"vpshrdd $0xa5,4(%rax){1to8},%ymm6,%ymm2{%k5}{z}",
			"vpshrdd $0xa5,%zmm3,%zmm6,%zmm2{%k3}",
			"vpshrdd $0xa5,0x40(%rax),%zmm6,%zmm2",
			"vpshrdd $0xa5,4(%rax){1to16},%zmm6,%zmm2{%k5}{z}",
			"vpshrdq $0xa5,%xmm3,%xmm14,%xmm18{%k3}",
			"vpshrdq $0xa5,0x10(%rax),%xmm6,%xmm2{%k3}",
			"vpshrdq $0xa5,8(%rax){1to2},%xmm6,%xmm2{%k5}{z}",
			"vpshrdq $0xa5,%ymm3,%ymm6,%ymm2{%k3}{z}",
			"vpshrdq $0xa5,0x20(%rax),%ymm6,%ymm2",
			"vpshrdq $0xa5,8(%rax){1to4},%ymm6,%ymm2{%k5}{z}",
			"vpshrdq $0xa5,%zmm3,%zmm14,%zmm18{%k3}",
			"vpshrdq $0xa5,0x40(%rax),%zmm6,%zmm2",
			"vpshrdq $0xa5,8(%rax){1to8},%zmm6,%zmm2{%k5}{z}",
			"gf2p8affineqb $0xa5,%xmm5,%xmm1",
			"gf2p8affineqb $0xa5,(%rax),%xmm1",
			"vgf2p8affineqb $0xa5,%xmm3,%xmm6,%xmm2",
			"vgf2p8affineqb $0xa5,(%rax),%xmm6,%xmm2",
			"vgf2p8affineqb $0xa5,%ymm3,%ymm6,%ymm2",
			"vgf2p8affineqb $0xa5,(%rax),%ymm6,%ymm2",
			"vgf2p8affineqb $0xa5,%xmm3,%xmm14,%xmm18{%k3}",
			"vgf2p8affineqb $0xa5,0x10(%rax),%xmm6,%xmm2{%k3}",
			"vgf2p8affineqb $0xa5,8(%rax){1to2},%xmm6,%xmm2{%k5}{z}",
			"vgf2p8affineqb $0xa5,%ymm3,%ymm6,%ymm2{%k3}{z}",
			"vgf2p8affineqb $0xa5,0x20(%rax),%ymm6,%ymm2",
			"vgf2p8affineqb $0xa5,8(%rax){1to4},%ymm6,%ymm2{%k5}{z}",
			"vgf2p8affineqb $0xa5,%zmm3,%zmm14,%zmm18{%k3}",
			"vgf2p8affineqb $0xa5,0x40(%rax),%zmm6,%zmm2",
			"vgf2p8affineqb $0xa5,8(%rax){1to8},%zmm6,%zmm2{%k5}{z}",
			"gf2p8affineinvqb $0xa5,%xmm5,%xmm1",
			"gf2p8affineinvqb $0xa5,(%rax),%xmm1",
			"vgf2p8affineinvqb $0xa5,%xmm3,%xmm6,%xmm2",
			"vgf2p8affineinvqb $0xa5,(%rax),%xmm6,%xmm2",
			"vgf2p8affineinvqb $0xa5,%ymm3,%ymm6,%ymm2",
			"vgf2p8affineinvqb $0xa5,(%rax),%ymm6,%ymm2",
			"vgf2p8affineinvqb $0xa5,%xmm3,%xmm14,%xmm18{%k3}",
			"vgf2p8affineinvqb $0xa5,0x10(%rax),%xmm6,%xmm2{%k3}",
			"vgf2p8affineinvqb $0xa5,8(%rax){1to2},%xmm6,%xmm2{%k5}{z}",
			"vgf2p8affineinvqb $0xa5,%ymm3,%ymm6,%ymm2{%k3}{z}",
			"vgf2p8affineinvqb $0xa5,0x20(%rax),%ymm6,%ymm2",
			"vgf2p8affineinvqb $0xa5,8(%rax){1to4},%ymm6,%ymm2{%k5}{z}",
			"vgf2p8affineinvqb $0xa5,%zmm3,%zmm14,%zmm18{%k3}",
			"vgf2p8affineinvqb $0xa5,0x40(%rax),%zmm6,%zmm2",
			"vgf2p8affineinvqb $0xa5,8(%rax){1to8},%zmm6,%zmm2{%k5}{z}",
			"addr32 fs monitor",
			"fs monitor",
			"addr32 fs monitorx",
			"fs monitorx",
			"addr32 fs clzero",
			"fs clzero",
			"fs umonitor %ebp",
			"fs umonitor %rbp",
			"rep montmul",
			"addr32 rep montmul",
			"montmul",
			"addr32 montmul",
			"rep xsha1",
			"addr32 rep xsha1",
			"xsha1",
			"addr32 xsha1",
			"rep xsha256",
			"addr32 rep xsha256",
			"xsha256",
			"addr32 xsha256",
			"rep xstore",
			"addr32 rep xstore",
			"xstore",
			"addr32 xstore",
			"rep xcryptecb",
			"addr32 rep xcryptecb",
			"xcryptecb",
			"addr32 xcryptecb",
			"rep xcryptcbc",
			"addr32 rep xcryptcbc",
			"xcryptcbc",
			"addr32 xcryptcbc",
			"rep xcryptctr",
			"addr32 rep xcryptctr",
			"xcryptctr",
			"addr32 xcryptctr",
			"rep xcryptcfb",
			"addr32 rep xcryptcfb",
			"xcryptcfb",
			"addr32 xcryptcfb",
			"rep xcryptofb",
			"addr32 rep xcryptofb",
			"xcryptofb",
			"addr32 xcryptofb",
		};
	}
}
#endif
