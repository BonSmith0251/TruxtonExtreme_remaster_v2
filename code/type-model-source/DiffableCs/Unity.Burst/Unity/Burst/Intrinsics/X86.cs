namespace Unity.Burst.Intrinsics;

[BurstCompile]
[Token(Token = "0x200003C")]
public static class X86
{
	[Token(Token = "0x200003D")]
	internal static class Avx
	{
		[Token(Token = "0x200003E")]
		internal enum CMP : int
		{
			EQ_OQ = 0,
			LT_OS = 1,
			LE_OS = 2,
			UNORD_Q = 3,
			NEQ_UQ = 4,
			NLT_US = 5,
			NLE_US = 6,
			ORD_Q = 7,
			EQ_UQ = 8,
			NGE_US = 9,
			NGT_US = 10,
			FALSE_OQ = 11,
			NEQ_OQ = 12,
			GE_OS = 13,
			GT_OS = 14,
			TRUE_UQ = 15,
			EQ_OS = 16,
			LT_OQ = 17,
			LE_OQ = 18,
			UNORD_S = 19,
			NEQ_US = 20,
			NLT_UQ = 21,
			NLE_UQ = 22,
			ORD_S = 23,
			EQ_US = 24,
			NGE_UQ = 25,
			NGT_UQ = 26,
			FALSE_OS = 27,
			NEQ_OS = 28,
			GE_OQ = 29,
			GT_OQ = 30,
			TRUE_US = 31,
		}


		[Token(Token = "0x17000041")]
		public static bool IsAvxSupported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000ACC")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27E5EB0", Offset = "0x27E52B0", Length = "0x11")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B0F")]
		public static v128 broadcast_ss(Void* ptr) { }

		[Address(RVA = "0x27EBDC0", Offset = "0x27EB1C0", Length = "0x6AC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AEE")]
		public static v128 cmp_pd(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27EC4F0", Offset = "0x27EB8F0", Length = "0x1898")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AF0")]
		public static v128 cmp_ps(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27EDE10", Offset = "0x27ED210", Length = "0x56")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AF2")]
		public static v128 cmp_sd(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27EDE70", Offset = "0x27ED270", Length = "0x5E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AF3")]
		public static v128 cmp_ss(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000ACC")]
		public static bool get_IsAvxSupported() { }

		[Address(RVA = "0x27EDED0", Offset = "0x27ED2D0", Length = "0x25")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B29")]
		public static v128 maskload_pd(Void* mem_addr, v128 mask) { }

		[Address(RVA = "0x27EDF00", Offset = "0x27ED300", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B2D")]
		public static v128 maskload_ps(Void* mem_addr, v128 mask) { }

		[Address(RVA = "0x27EDF40", Offset = "0x27ED340", Length = "0x1C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B2B")]
		public static void maskstore_pd(Void* mem_addr, v128 mask, v128 a) { }

		[Address(RVA = "0x27EDF60", Offset = "0x27ED360", Length = "0x32")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B2F")]
		public static void maskstore_ps(Void* mem_addr, v128 mask, v128 a) { }

		[Address(RVA = "0x27EDFA0", Offset = "0x27ED3A0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000ACD")]
		public static v256 mm256_add_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27EE030", Offset = "0x27ED430", Length = "0xC8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000ACE")]
		public static v256 mm256_add_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27EE100", Offset = "0x27ED500", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000ACF")]
		public static v256 mm256_addsub_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27EE190", Offset = "0x27ED590", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AD0")]
		public static v256 mm256_addsub_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27E6F90", Offset = "0x27E6390", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AD1")]
		public static v256 mm256_and_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27EE220", Offset = "0x27ED620", Length = "0x88")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AD2")]
		public static v256 mm256_and_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27E7020", Offset = "0x27E6420", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AD3")]
		public static v256 mm256_andnot_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27EE2B0", Offset = "0x27ED6B0", Length = "0xC4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AD4")]
		public static v256 mm256_andnot_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27EE380", Offset = "0x27ED780", Length = "0xB2")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AD5")]
		public static v256 mm256_blend_pd(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27EE440", Offset = "0x27ED840", Length = "0xB2")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AD6")]
		public static v256 mm256_blend_ps(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27EE500", Offset = "0x27ED900", Length = "0xC8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AD7")]
		public static v256 mm256_blendv_pd(v256 a, v256 b, v256 mask) { }

		[Address(RVA = "0x27EE5D0", Offset = "0x27ED9D0", Length = "0xC8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AD8")]
		public static v256 mm256_blendv_ps(v256 a, v256 b, v256 mask) { }

		[Address(RVA = "0x27EE6A0", Offset = "0x27EDAA0", Length = "0x16")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B12")]
		public static v256 mm256_broadcast_pd(Void* ptr) { }

		[Address(RVA = "0x27E7500", Offset = "0x27E6900", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B11")]
		public static v256 mm256_broadcast_ps(Void* ptr) { }

		[Address(RVA = "0x27E74E0", Offset = "0x27E68E0", Length = "0x13")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B10")]
		public static v256 mm256_broadcast_sd(Void* ptr) { }

		[Address(RVA = "0x27E74A0", Offset = "0x27E68A0", Length = "0x1D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B0E")]
		public static v256 mm256_broadcast_ss(Void* ptr) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B71")]
		public static v256 mm256_castpd_ps(v256 a) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B74")]
		public static v256 mm256_castpd_si256(v256 a) { }

		[Address(RVA = "0x27EE6C0", Offset = "0x27EDAC0", Length = "0x11")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B7B")]
		public static v256 mm256_castpd128_pd256(v128 a) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B78")]
		public static v128 mm256_castpd256_pd128(v256 a) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B72")]
		public static v256 mm256_castps_pd(v256 a) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B73")]
		public static v256 mm256_castps_si256(v256 a) { }

		[Address(RVA = "0x27EE6C0", Offset = "0x27EDAC0", Length = "0x11")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B7A")]
		public static v256 mm256_castps128_ps256(v128 a) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B77")]
		public static v128 mm256_castps256_ps128(v256 a) { }

		[Address(RVA = "0x27EE6C0", Offset = "0x27EDAC0", Length = "0x11")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B7C")]
		public static v256 mm256_castsi128_si256(v128 a) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B76")]
		public static v256 mm256_castsi256_pd(v256 a) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B75")]
		public static v256 mm256_castsi256_ps(v256 a) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B79")]
		public static v128 mm256_castsi256_si128(v256 a) { }

		[Address(RVA = "0x27EE6E0", Offset = "0x27EDAE0", Length = "0x8A")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B3D")]
		public static v256 mm256_ceil_pd(v256 val) { }

		[Address(RVA = "0x27EE770", Offset = "0x27EDB70", Length = "0x8A")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B40")]
		public static v256 mm256_ceil_ps(v256 val) { }

		[Address(RVA = "0x27EE800", Offset = "0x27EDC00", Length = "0xAB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AEF")]
		public static v256 mm256_cmp_pd(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27EE8B0", Offset = "0x27EDCB0", Length = "0xAB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AF1")]
		public static v256 mm256_cmp_ps(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27EE960", Offset = "0x27EDD60", Length = "0x3A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AF4")]
		public static v256 mm256_cvtepi32_pd(v128 a) { }

		[Address(RVA = "0x27EE9A0", Offset = "0x27EDDA0", Length = "0x6A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AF5")]
		public static v256 mm256_cvtepi32_ps(v256 a) { }

		[Address(RVA = "0x27EEA10", Offset = "0x27EDE10", Length = "0xA6")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AFA")]
		public static v128 mm256_cvtpd_epi32(v256 a) { }

		[Address(RVA = "0x27EEAC0", Offset = "0x27EDEC0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AF6")]
		public static v128 mm256_cvtpd_ps(v256 a) { }

		[Address(RVA = "0x27EEB50", Offset = "0x27EDF50", Length = "0x6A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AF7")]
		public static v256 mm256_cvtps_epi32(v256 a) { }

		[Address(RVA = "0x27EEBC0", Offset = "0x27EDFC0", Length = "0x36")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AF8")]
		public static v256 mm256_cvtps_pd(v128 a) { }

		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AFC")]
		public static float mm256_cvtss_f32(v256 a) { }

		[Address(RVA = "0x27EEC00", Offset = "0x27EE000", Length = "0x22")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AF9")]
		public static v128 mm256_cvttpd_epi32(v256 a) { }

		[Address(RVA = "0x27EEC30", Offset = "0x27EE030", Length = "0x6A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AFB")]
		public static v256 mm256_cvttps_epi32(v256 a) { }

		[Address(RVA = "0x27EECA0", Offset = "0x27EE0A0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AD9")]
		public static v256 mm256_div_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27EED30", Offset = "0x27EE130", Length = "0x106")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000ADA")]
		public static v256 mm256_div_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27EEE40", Offset = "0x27EE240", Length = "0xAB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000ADB")]
		public static v256 mm256_dp_ps(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27EEEF0", Offset = "0x27EE2F0", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B8A")]
		public static int mm256_extract_epi32(v256 a, int index) { }

		[Address(RVA = "0x27EEF00", Offset = "0x27EE300", Length = "0x8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B8B")]
		public static long mm256_extract_epi64(v256 a, int index) { }

		[Address(RVA = "0x27EEF10", Offset = "0x27EE310", Length = "0x23")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AFE")]
		public static v128 mm256_extractf128_pd(v256 a, int imm8) { }

		[Address(RVA = "0x27EEF10", Offset = "0x27EE310", Length = "0x23")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AFD")]
		public static v128 mm256_extractf128_ps(v256 a, int imm8) { }

		[Address(RVA = "0x27EEF10", Offset = "0x27EE310", Length = "0x23")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AFF")]
		public static v128 mm256_extractf128_si256(v256 a, int imm8) { }

		[Address(RVA = "0x27EEF40", Offset = "0x27EE340", Length = "0x8A")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B3E")]
		public static v256 mm256_floor_pd(v256 val) { }

		[Address(RVA = "0x27EEFD0", Offset = "0x27EE3D0", Length = "0x8A")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B41")]
		public static v256 mm256_floor_ps(v256 val) { }

		[Address(RVA = "0x27EF060", Offset = "0x27EE460", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000ADC")]
		public static v256 mm256_hadd_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27EF0F0", Offset = "0x27EE4F0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000ADD")]
		public static v256 mm256_hadd_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27EF180", Offset = "0x27EE580", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000ADE")]
		public static v256 mm256_hsub_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27EF210", Offset = "0x27EE610", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000ADF")]
		public static v256 mm256_hsub_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27EF2A0", Offset = "0x27EE6A0", Length = "0x1B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B87")]
		public static v256 mm256_insert_epi16(v256 a, int i, int index) { }

		[Address(RVA = "0x27EF2C0", Offset = "0x27EE6C0", Length = "0x1A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B88")]
		public static v256 mm256_insert_epi32(v256 a, int i, int index) { }

		[Address(RVA = "0x27EF2E0", Offset = "0x27EE6E0", Length = "0x1A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B89")]
		public static v256 mm256_insert_epi64(v256 a, long i, int index) { }

		[Address(RVA = "0x27EF300", Offset = "0x27EE700", Length = "0x1A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B86")]
		public static v256 mm256_insert_epi8(v256 a, int i, int index) { }

		[Address(RVA = "0x27E8690", Offset = "0x27E7A90", Length = "0x37")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B14")]
		public static v256 mm256_insertf128_pd(v256 a, v128 b, int imm8) { }

		[Address(RVA = "0x27EF320", Offset = "0x27EE720", Length = "0x30")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B13")]
		public static v256 mm256_insertf128_ps(v256 a, v128 b, int imm8) { }

		[Address(RVA = "0x27E8690", Offset = "0x27E7A90", Length = "0x37")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B15")]
		public static v256 mm256_insertf128_si256(v256 a, v128 b, int imm8) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B34")]
		public static v256 mm256_lddqu_si256(Void* mem_addr) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B18")]
		public static v256 mm256_load_pd(Void* ptr) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B16")]
		public static v256 mm256_load_ps(Void* ptr) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B1E")]
		public static v256 mm256_load_si256(Void* ptr) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B1A")]
		public static v256 mm256_loadu_pd(Void* ptr) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B1C")]
		public static v256 mm256_loadu_ps(Void* ptr) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B20")]
		public static v256 mm256_loadu_si256(Void* ptr) { }

		[Address(RVA = "0x27EF350", Offset = "0x27EE750", Length = "0x1A")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B22")]
		public static v256 mm256_loadu2_m128(Void* hiaddr, Void* loaddr) { }

		[Address(RVA = "0x27EF350", Offset = "0x27EE750", Length = "0x1A")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B23")]
		public static v256 mm256_loadu2_m128d(Void* hiaddr, Void* loaddr) { }

		[Address(RVA = "0x27EF350", Offset = "0x27EE750", Length = "0x1A")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B24")]
		public static v256 mm256_loadu2_m128i(Void* hiaddr, Void* loaddr) { }

		[Address(RVA = "0x27EF370", Offset = "0x27EE770", Length = "0x70")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B2A")]
		public static v256 mm256_maskload_pd(Void* mem_addr, v256 mask) { }

		[Address(RVA = "0x27EF3E0", Offset = "0x27EE7E0", Length = "0xCE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B2E")]
		public static v256 mm256_maskload_ps(Void* mem_addr, v256 mask) { }

		[Address(RVA = "0x27EF4B0", Offset = "0x27EE8B0", Length = "0x50")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B2C")]
		public static void mm256_maskstore_pd(Void* mem_addr, v256 mask, v256 a) { }

		[Address(RVA = "0x27EF500", Offset = "0x27EE900", Length = "0x9E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B30")]
		public static void mm256_maskstore_ps(Void* mem_addr, v256 mask, v256 a) { }

		[Address(RVA = "0x27EF5A0", Offset = "0x27EE9A0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AE0")]
		public static v256 mm256_max_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27EF630", Offset = "0x27EEA30", Length = "0x1F1")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AE1")]
		public static v256 mm256_max_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27EF830", Offset = "0x27EEC30", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AE2")]
		public static v256 mm256_min_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27EF8C0", Offset = "0x27EECC0", Length = "0x1F1")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AE3")]
		public static v256 mm256_min_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27EFAC0", Offset = "0x27EEEC0", Length = "0x1A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B33")]
		public static v256 mm256_movedup_pd(v256 a) { }

		[Address(RVA = "0x27EFAE0", Offset = "0x27EEEE0", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B31")]
		public static v256 mm256_movehdup_ps(v256 a) { }

		[Address(RVA = "0x27EFB10", Offset = "0x27EEF10", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B32")]
		public static v256 mm256_moveldup_ps(v256 a) { }

		[Address(RVA = "0x27EFB40", Offset = "0x27EEF40", Length = "0x48")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B55")]
		public static int mm256_movemask_pd(v256 a) { }

		[Address(RVA = "0x27EFB90", Offset = "0x27EEF90", Length = "0x9A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B56")]
		public static int mm256_movemask_ps(v256 a) { }

		[Address(RVA = "0x27EFC30", Offset = "0x27EF030", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AE4")]
		public static v256 mm256_mul_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27EFCC0", Offset = "0x27EF0C0", Length = "0xC8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AE5")]
		public static v256 mm256_mul_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27E99F0", Offset = "0x27E8DF0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AE6")]
		public static v256 mm256_or_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27EFD90", Offset = "0x27EF190", Length = "0xB4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AE7")]
		public static v256 mm256_or_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27EFE50", Offset = "0x27EF250", Length = "0x6C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B08")]
		public static v256 mm256_permute_pd(v256 a, int imm8) { }

		[Address(RVA = "0x27EA000", Offset = "0x27E9400", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B05")]
		public static v256 mm256_permute_ps(v256 a, int imm8) { }

		[Address(RVA = "0x27E9CC0", Offset = "0x27E90C0", Length = "0x91")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B0C")]
		public static v256 mm256_permute2f128_pd(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27E9CC0", Offset = "0x27E90C0", Length = "0x91")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B0B")]
		public static v256 mm256_permute2f128_ps(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27E9CC0", Offset = "0x27E90C0", Length = "0x91")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B0D")]
		public static v256 mm256_permute2f128_si256(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27EFEC0", Offset = "0x27EF2C0", Length = "0x5F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B07")]
		public static v256 mm256_permutevar_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27EFF20", Offset = "0x27EF320", Length = "0xE9")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B03")]
		public static v256 mm256_permutevar_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27F0010", Offset = "0x27EF410", Length = "0x106")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B38")]
		public static v256 mm256_rcp_ps(v256 a) { }

		[Address(RVA = "0x27F0120", Offset = "0x27EF520", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B3C")]
		public static v256 mm256_round_pd(v256 a, int rounding) { }

		[Address(RVA = "0x27F01A0", Offset = "0x27EF5A0", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B3F")]
		public static v256 mm256_round_ps(v256 a, int rounding) { }

		[Address(RVA = "0x27F0220", Offset = "0x27EF620", Length = "0x6A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B39")]
		public static v256 mm256_rsqrt_ps(v256 a) { }

		[Address(RVA = "0x27F03B0", Offset = "0x27EF7B0", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B5D")]
		public static v256 mm256_set_epi16(short e15_, short e14_, short e13_, short e12_, short e11_, short e10_, short e9_, short e8_, short e7_, short e6_, short e5_, short e4_, short e3_, short e2_, short e1_, short e0_) { }

		[Address(RVA = "0x27F0440", Offset = "0x27EF840", Length = "0x31")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B5E")]
		public static v256 mm256_set_epi32(int e7, int e6, int e5, int e4, int e3, int e2, int e1, int e0) { }

		[Address(RVA = "0x27F0480", Offset = "0x27EF880", Length = "0x18")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B5F")]
		public static v256 mm256_set_epi64x(long e3, long e2, long e1, long e0) { }

		[Address(RVA = "0x27F04A0", Offset = "0x27EF8A0", Length = "0x12C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B5C")]
		public static v256 mm256_set_epi8(byte e31_, byte e30_, byte e29_, byte e28_, byte e27_, byte e26_, byte e25_, byte e24_, byte e23_, byte e22_, byte e21_, byte e20_, byte e19_, byte e18_, byte e17_, byte e16_, byte e15_, byte e14_, byte e13_, byte e12_, byte e11_, byte e10_, byte e9_, byte e8_, byte e7_, byte e6_, byte e5_, byte e4_, byte e3_, byte e2_, byte e1_, byte e0_) { }

		[Address(RVA = "0x27F05D0", Offset = "0x27EF9D0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B25")]
		public static v256 mm256_set_m128(v128 hi, v128 lo) { }

		[Address(RVA = "0x27F05D0", Offset = "0x27EF9D0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B60")]
		public static v256 mm256_set_m128d(v128 hi, v128 lo) { }

		[Address(RVA = "0x27F05D0", Offset = "0x27EF9D0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B61")]
		public static v256 mm256_set_m128i(v128 hi, v128 lo) { }

		[Address(RVA = "0x27F05F0", Offset = "0x27EF9F0", Length = "0x1D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B5A")]
		public static v256 mm256_set_pd(double d, double c, double b, double a) { }

		[Address(RVA = "0x27F0610", Offset = "0x27EFA10", Length = "0x49")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B5B")]
		public static v256 mm256_set_ps(float e7, float e6, float e5, float e4, float e3, float e2, float e1, float e0) { }

		[Address(RVA = "0x27F0290", Offset = "0x27EF690", Length = "0x43")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B6E")]
		public static v256 mm256_set1_epi16(short a) { }

		[Address(RVA = "0x27F02E0", Offset = "0x27EF6E0", Length = "0x1B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B6F")]
		public static v256 mm256_set1_epi32(int a) { }

		[Address(RVA = "0x27F0300", Offset = "0x27EF700", Length = "0x13")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B70")]
		public static v256 mm256_set1_epi64x(long a) { }

		[Address(RVA = "0x27F0320", Offset = "0x27EF720", Length = "0x63")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B6D")]
		public static v256 mm256_set1_epi8(byte a) { }

		[Address(RVA = "0x27F0390", Offset = "0x27EF790", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B6B")]
		public static v256 mm256_set1_pd(double a) { }

		[Address(RVA = "0x27F03A0", Offset = "0x27EF7A0", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B6C")]
		public static v256 mm256_set1_ps(float a) { }

		[Address(RVA = "0x27F0660", Offset = "0x27EFA60", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B65")]
		public static v256 mm256_setr_epi16(short e15_, short e14_, short e13_, short e12_, short e11_, short e10_, short e9_, short e8_, short e7_, short e6_, short e5_, short e4_, short e3_, short e2_, short e1_, short e0_) { }

		[Address(RVA = "0x27F06F0", Offset = "0x27EFAF0", Length = "0x31")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B66")]
		public static v256 mm256_setr_epi32(int e7, int e6, int e5, int e4, int e3, int e2, int e1, int e0) { }

		[Address(RVA = "0x27F0730", Offset = "0x27EFB30", Length = "0x18")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B67")]
		public static v256 mm256_setr_epi64x(long e3, long e2, long e1, long e0) { }

		[Address(RVA = "0x27F0750", Offset = "0x27EFB50", Length = "0x12C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B64")]
		public static v256 mm256_setr_epi8(byte e31_, byte e30_, byte e29_, byte e28_, byte e27_, byte e26_, byte e25_, byte e24_, byte e23_, byte e22_, byte e21_, byte e20_, byte e19_, byte e18_, byte e17_, byte e16_, byte e15_, byte e14_, byte e13_, byte e12_, byte e11_, byte e10_, byte e9_, byte e8_, byte e7_, byte e6_, byte e5_, byte e4_, byte e3_, byte e2_, byte e1_, byte e0_) { }

		[Address(RVA = "0x27F0880", Offset = "0x27EFC80", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B68")]
		public static v256 mm256_setr_m128(v128 hi, v128 lo) { }

		[Address(RVA = "0x27F0880", Offset = "0x27EFC80", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B69")]
		public static v256 mm256_setr_m128d(v128 hi, v128 lo) { }

		[Address(RVA = "0x27F0880", Offset = "0x27EFC80", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B6A")]
		public static v256 mm256_setr_m128i(v128 hi, v128 lo) { }

		[Address(RVA = "0x27F08A0", Offset = "0x27EFCA0", Length = "0x1D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B62")]
		public static v256 mm256_setr_pd(double d, double c, double b, double a) { }

		[Address(RVA = "0x27F08C0", Offset = "0x27EFCC0", Length = "0x49")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B63")]
		public static v256 mm256_setr_ps(float e7, float e6, float e5, float e4, float e3, float e2, float e1, float e0) { }

		[Address(RVA = "0x137CFF0", Offset = "0x137C3F0", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B57")]
		public static v256 mm256_setzero_pd() { }

		[Address(RVA = "0x137CFF0", Offset = "0x137C3F0", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B58")]
		public static v256 mm256_setzero_ps() { }

		[Address(RVA = "0x137CFF0", Offset = "0x137C3F0", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B59")]
		public static v256 mm256_setzero_si256() { }

		[Address(RVA = "0x27F0910", Offset = "0x27EFD10", Length = "0xB2")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AE8")]
		public static v256 mm256_shuffle_pd(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27F09D0", Offset = "0x27EFDD0", Length = "0xCA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AE9")]
		public static v256 mm256_shuffle_ps(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27F0AA0", Offset = "0x27EFEA0", Length = "0x6A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B3A")]
		public static v256 mm256_sqrt_pd(v256 a) { }

		[Address(RVA = "0x27F0B10", Offset = "0x27EFF10", Length = "0x21E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B3B")]
		public static v256 mm256_sqrt_ps(v256 a) { }

		[Address(RVA = "0x27F0D30", Offset = "0x27F0130", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B19")]
		public static void mm256_store_pd(Void* ptr, v256 a) { }

		[Address(RVA = "0x27F0D30", Offset = "0x27F0130", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B17")]
		public static void mm256_store_ps(Void* ptr, v256 val) { }

		[Address(RVA = "0x27F0D30", Offset = "0x27F0130", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B1F")]
		public static void mm256_store_si256(Void* ptr, v256 v) { }

		[Address(RVA = "0x27F0D30", Offset = "0x27F0130", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B1B")]
		public static void mm256_storeu_pd(Void* ptr, v256 a) { }

		[Address(RVA = "0x27F0D30", Offset = "0x27F0130", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B1D")]
		public static void mm256_storeu_ps(Void* ptr, v256 a) { }

		[Address(RVA = "0x27F0D30", Offset = "0x27F0130", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B21")]
		public static void mm256_storeu_si256(Void* ptr, v256 v) { }

		[Address(RVA = "0x27F0D40", Offset = "0x27F0140", Length = "0x10")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B26")]
		public static void mm256_storeu2_m128(Void* hiaddr, Void* loaddr, v256 val) { }

		[Address(RVA = "0x27F0D40", Offset = "0x27F0140", Length = "0x10")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B27")]
		public static void mm256_storeu2_m128d(Void* hiaddr, Void* loaddr, v256 val) { }

		[Address(RVA = "0x27F0D40", Offset = "0x27F0140", Length = "0x10")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B28")]
		public static void mm256_storeu2_m128i(Void* hiaddr, Void* loaddr, v256 val) { }

		[Address(RVA = "0x27F0D30", Offset = "0x27F0130", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B36")]
		public static void mm256_stream_pd(Void* mem_addr, v256 a) { }

		[Address(RVA = "0x27F0D30", Offset = "0x27F0130", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B37")]
		public static void mm256_stream_ps(Void* mem_addr, v256 a) { }

		[Address(RVA = "0x27F0D30", Offset = "0x27F0130", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B35")]
		public static void mm256_stream_si256(Void* mem_addr, v256 a) { }

		[Address(RVA = "0x27F0D50", Offset = "0x27F0150", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AEA")]
		public static v256 mm256_sub_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27F0DE0", Offset = "0x27F01E0", Length = "0x106")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AEB")]
		public static v256 mm256_sub_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27F0EF0", Offset = "0x27F02F0", Length = "0x32")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B4A")]
		public static int mm256_testc_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27F0F30", Offset = "0x27F0330", Length = "0x25")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B50")]
		public static int mm256_testc_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27F0F60", Offset = "0x27F0360", Length = "0x6F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B47")]
		public static int mm256_testc_si256(v256 a, v256 b) { }

		[Address(RVA = "0x27F0FD0", Offset = "0x27F03D0", Length = "0xA8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B4B")]
		public static int mm256_testnzc_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27F1080", Offset = "0x27F0480", Length = "0xA5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B51")]
		public static int mm256_testnzc_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27F1130", Offset = "0x27F0530", Length = "0x10F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B48")]
		public static int mm256_testnzc_si256(v256 a, v256 b) { }

		[Address(RVA = "0x27F1240", Offset = "0x27F0640", Length = "0x25")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B49")]
		public static int mm256_testz_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27F1270", Offset = "0x27F0670", Length = "0x23")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B4F")]
		public static int mm256_testz_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27F12A0", Offset = "0x27F06A0", Length = "0x6F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B46")]
		public static int mm256_testz_si256(v256 a, v256 b) { }

		[Address(RVA = "0x137CFF0", Offset = "0x137C3F0", Length = "0xE")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B81")]
		public static v256 mm256_undefined_pd() { }

		[Address(RVA = "0x137CFF0", Offset = "0x137C3F0", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B80")]
		public static v256 mm256_undefined_ps() { }

		[Address(RVA = "0x137CFF0", Offset = "0x137C3F0", Length = "0xE")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B82")]
		public static v256 mm256_undefined_si256() { }

		[Address(RVA = "0x27EB7B0", Offset = "0x27EABB0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B42")]
		public static v256 mm256_unpackhi_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27F1310", Offset = "0x27F0710", Length = "0x9B")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B44")]
		public static v256 mm256_unpackhi_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27EB9F0", Offset = "0x27EADF0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B43")]
		public static v256 mm256_unpacklo_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27F13B0", Offset = "0x27F07B0", Length = "0x8B")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B45")]
		public static v256 mm256_unpacklo_ps(v256 a, v256 b) { }

		[Address(RVA = "0x27EBB10", Offset = "0x27EAF10", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AEC")]
		public static v256 mm256_xor_pd(v256 a, v256 b) { }

		[Address(RVA = "0x27F1440", Offset = "0x27F0840", Length = "0xB4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000AED")]
		public static v256 mm256_xor_ps(v256 a, v256 b) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B00")]
		public static void mm256_zeroall() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B01")]
		public static void mm256_zeroupper() { }

		[Address(RVA = "0x27F1500", Offset = "0x27F0900", Length = "0x19")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B84")]
		public static v256 mm256_zextpd128_pd256(v128 a) { }

		[Address(RVA = "0x27EE6C0", Offset = "0x27EDAC0", Length = "0x11")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B83")]
		public static v256 mm256_zextps128_ps256(v128 a) { }

		[Address(RVA = "0x27F1500", Offset = "0x27F0900", Length = "0x19")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B85")]
		public static v256 mm256_zextsi128_si256(v128 a) { }

		[Address(RVA = "0x27F1520", Offset = "0x27F0920", Length = "0x29")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B09")]
		public static v128 permute_pd(v128 a, int imm8) { }

		[Address(RVA = "0x27F1550", Offset = "0x27F0950", Length = "0x32")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B04")]
		public static v128 permute_ps(v128 a, int imm8) { }

		[Address(RVA = "0x27F1590", Offset = "0x27F0990", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B06")]
		public static v128 permutevar_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F15C0", Offset = "0x27F09C0", Length = "0x46")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B02")]
		public static v128 permutevar_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27EBD70", Offset = "0x27EB170", Length = "0x4F")]
		[Token(Token = "0x6000B0A")]
		private static v128 Select4(v256 src1, v256 src2, int control) { }

		[Address(RVA = "0x27F1610", Offset = "0x27F0A10", Length = "0x32")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B4D")]
		public static int testc_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F1650", Offset = "0x27F0A50", Length = "0x25")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B53")]
		public static int testc_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F1680", Offset = "0x27F0A80", Length = "0x78")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B4E")]
		public static int testnzc_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F1700", Offset = "0x27F0B00", Length = "0x75")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B54")]
		public static int testnzc_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F1780", Offset = "0x27F0B80", Length = "0x25")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B4C")]
		public static int testz_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F17B0", Offset = "0x27F0BB0", Length = "0x23")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B52")]
		public static int testz_ps(v128 a, v128 b) { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B7E")]
		public static v128 undefined_pd() { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B7D")]
		public static v128 undefined_ps() { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B7F")]
		public static v128 undefined_si128() { }

	}

	[Token(Token = "0x200003F")]
	internal static class Avx2
	{

		[Token(Token = "0x17000042")]
		public static bool IsAvx2Supported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000B8C")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27E5E20", Offset = "0x27E5220", Length = "0x46")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BF2")]
		public static v128 blend_epi32(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27E5E70", Offset = "0x27E5270", Length = "0x36")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C0D")]
		public static v128 broadcastb_epi8(v128 a) { }

		[Address(RVA = "0x27E5EB0", Offset = "0x27E52B0", Length = "0x11")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C0F")]
		public static v128 broadcastd_epi32(v128 a) { }

		[Address(RVA = "0x27E5ED0", Offset = "0x27E52D0", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C10")]
		public static v128 broadcastq_epi64(v128 a) { }

		[Address(RVA = "0x27E5EE0", Offset = "0x27E52E0", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C0B")]
		public static v128 broadcastsd_pd(v128 a) { }

		[Address(RVA = "0x27E5EF0", Offset = "0x27E52F0", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C09")]
		public static v128 broadcastss_ps(v128 a) { }

		[Address(RVA = "0x27E5F00", Offset = "0x27E5300", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C0E")]
		public static v128 broadcastw_epi16(v128 a) { }

		[Address(RVA = "0x9EFF80", Offset = "0x9EF380", Length = "0xBC")]
		[Token(Token = "0x6000C30")]
		private static void EmulatedGather(T* dptr, Void* base_addr, Int64* indexPtr, int scale, int n, U* mask) { }

		[Address(RVA = "0x9EFEC0", Offset = "0x9EF2C0", Length = "0xBE")]
		[Token(Token = "0x6000C31")]
		private static void EmulatedGather(T* dptr, Void* base_addr, Int32* indexPtr, int scale, int n, U* mask) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000B8C")]
		public static bool get_IsAvx2Supported() { }

		[Address(RVA = "0x27E5F30", Offset = "0x27E5330", Length = "0x88")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C3E")]
		public static v128 i32gather_epi32(Void* base_addr, v128 vindex, int scale) { }

		[Address(RVA = "0x27E5FC0", Offset = "0x27E53C0", Length = "0x88")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C3F")]
		public static v128 i32gather_epi64(Void* base_addr, v128 vindex, int scale) { }

		[Address(RVA = "0x27E6050", Offset = "0x27E5450", Length = "0x88")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C37")]
		public static v128 i32gather_pd(Void* base_addr, v128 vindex, int scale) { }

		[Address(RVA = "0x27E60E0", Offset = "0x27E54E0", Length = "0x88")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C38")]
		public static v128 i32gather_ps(Void* base_addr, v128 vindex, int scale) { }

		[Address(RVA = "0x27E6170", Offset = "0x27E5570", Length = "0x88")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C40")]
		public static v128 i64gather_epi32(Void* base_addr, v128 vindex, int scale) { }

		[Address(RVA = "0x27E6200", Offset = "0x27E5600", Length = "0x88")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C41")]
		public static v128 i64gather_epi64(Void* base_addr, v128 vindex, int scale) { }

		[Address(RVA = "0x27E6290", Offset = "0x27E5690", Length = "0x88")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C39")]
		public static v128 i64gather_pd(Void* base_addr, v128 vindex, int scale) { }

		[Address(RVA = "0x27E6320", Offset = "0x27E5720", Length = "0x88")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C3A")]
		public static v128 i64gather_ps(Void* base_addr, v128 vindex, int scale) { }

		[Address(RVA = "0x27E63B0", Offset = "0x27E57B0", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C4E")]
		public static v128 mask_i32gather_epi32(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[Address(RVA = "0x27E6440", Offset = "0x27E5840", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C4F")]
		public static v128 mask_i32gather_epi64(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[Address(RVA = "0x27E64D0", Offset = "0x27E58D0", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C4A")]
		public static v128 mask_i32gather_pd(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[Address(RVA = "0x27E6560", Offset = "0x27E5960", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C4B")]
		public static v128 mask_i32gather_ps(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[Address(RVA = "0x27E65F0", Offset = "0x27E59F0", Length = "0x92")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C50")]
		public static v128 mask_i64gather_epi32(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[Address(RVA = "0x27E6690", Offset = "0x27E5A90", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C51")]
		public static v128 mask_i64gather_epi64(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[Address(RVA = "0x27E6720", Offset = "0x27E5B20", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C4C")]
		public static v128 mask_i64gather_pd(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[Address(RVA = "0x27E67B0", Offset = "0x27E5BB0", Length = "0x92")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C4D")]
		public static v128 mask_i64gather_ps(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[Address(RVA = "0x27E6850", Offset = "0x27E5C50", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C22")]
		public static v128 maskload_epi32(Void* mem_addr, v128 mask) { }

		[Address(RVA = "0x27E6890", Offset = "0x27E5C90", Length = "0x25")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C23")]
		public static v128 maskload_epi64(Void* mem_addr, v128 mask) { }

		[Address(RVA = "0x27E68C0", Offset = "0x27E5CC0", Length = "0x29")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C24")]
		public static void maskstore_epi32(Void* mem_addr, v128 mask, v128 a) { }

		[Address(RVA = "0x27E68F0", Offset = "0x27E5CF0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C25")]
		public static void maskstore_epi64(Void* mem_addr, v128 mask, v128 a) { }

		[Address(RVA = "0x27E6910", Offset = "0x27E5D10", Length = "0x6A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BAC")]
		public static v256 mm256_abs_epi16(v256 a) { }

		[Address(RVA = "0x27E6980", Offset = "0x27E5D80", Length = "0x6A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BAD")]
		public static v256 mm256_abs_epi32(v256 a) { }

		[Address(RVA = "0x27E69F0", Offset = "0x27E5DF0", Length = "0x6A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BAB")]
		public static v256 mm256_abs_epi8(v256 a) { }

		[Address(RVA = "0x27E6A60", Offset = "0x27E5E60", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BAF")]
		public static v256 mm256_add_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E6AF0", Offset = "0x27E5EF0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BB0")]
		public static v256 mm256_add_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27E6B80", Offset = "0x27E5F80", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BB1")]
		public static v256 mm256_add_epi64(v256 a, v256 b) { }

		[Address(RVA = "0x27E6C10", Offset = "0x27E6010", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BAE")]
		public static v256 mm256_add_epi8(v256 a, v256 b) { }

		[Address(RVA = "0x27E6CA0", Offset = "0x27E60A0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BB3")]
		public static v256 mm256_adds_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E6D30", Offset = "0x27E6130", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BB2")]
		public static v256 mm256_adds_epi8(v256 a, v256 b) { }

		[Address(RVA = "0x27E6DC0", Offset = "0x27E61C0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BB5")]
		public static v256 mm256_adds_epu16(v256 a, v256 b) { }

		[Address(RVA = "0x27E6E50", Offset = "0x27E6250", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BB4")]
		public static v256 mm256_adds_epu8(v256 a, v256 b) { }

		[Address(RVA = "0x27E6EE0", Offset = "0x27E62E0", Length = "0xAB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BF4")]
		public static v256 mm256_alignr_epi8(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27E6F90", Offset = "0x27E6390", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BA7")]
		public static v256 mm256_and_si256(v256 a, v256 b) { }

		[Address(RVA = "0x27E7020", Offset = "0x27E6420", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BA8")]
		public static v256 mm256_andnot_si256(v256 a, v256 b) { }

		[Address(RVA = "0x27E70B0", Offset = "0x27E64B0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BBF")]
		public static v256 mm256_avg_epu16(v256 a, v256 b) { }

		[Address(RVA = "0x27E7140", Offset = "0x27E6540", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BBE")]
		public static v256 mm256_avg_epu8(v256 a, v256 b) { }

		[Address(RVA = "0x27E71D0", Offset = "0x27E65D0", Length = "0xAB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BF6")]
		public static v256 mm256_blend_epi16(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27E7280", Offset = "0x27E6680", Length = "0xD8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BF3")]
		public static v256 mm256_blend_epi32(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27E7360", Offset = "0x27E6760", Length = "0xC8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BF5")]
		public static v256 mm256_blendv_epi8(v256 a, v256 b, v256 mask) { }

		[Address(RVA = "0x27E7430", Offset = "0x27E6830", Length = "0x66")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C11")]
		public static v256 mm256_broadcastb_epi8(v128 a) { }

		[Address(RVA = "0x27E74A0", Offset = "0x27E68A0", Length = "0x1D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C13")]
		public static v256 mm256_broadcastd_epi32(v128 a) { }

		[Address(RVA = "0x27E74C0", Offset = "0x27E68C0", Length = "0x16")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C14")]
		public static v256 mm256_broadcastq_epi64(v128 a) { }

		[Address(RVA = "0x27E74E0", Offset = "0x27E68E0", Length = "0x13")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C0C")]
		public static v256 mm256_broadcastsd_pd(v128 a) { }

		[Address(RVA = "0x27E7500", Offset = "0x27E6900", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C15")]
		public static v256 mm256_broadcastsi128_si256(v128 a) { }

		[Address(RVA = "0x27E7510", Offset = "0x27E6910", Length = "0x13")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C0A")]
		public static v256 mm256_broadcastss_ps(v128 a) { }

		[Address(RVA = "0x27E7530", Offset = "0x27E6930", Length = "0x46")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C12")]
		public static v256 mm256_broadcastw_epi16(v128 a) { }

		[Address(RVA = "0x27E7580", Offset = "0x27E6980", Length = "0x89")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BD5")]
		public static v256 mm256_bslli_epi128(v256 a, int imm8) { }

		[Address(RVA = "0x27E7610", Offset = "0x27E6A10", Length = "0x89")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BD7")]
		public static v256 mm256_bsrli_epi128(v256 a, int imm8) { }

		[Address(RVA = "0x27E76A0", Offset = "0x27E6AA0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B94")]
		public static v256 mm256_cmpeq_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E7730", Offset = "0x27E6B30", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B95")]
		public static v256 mm256_cmpeq_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27E77C0", Offset = "0x27E6BC0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B96")]
		public static v256 mm256_cmpeq_epi64(v256 a, v256 b) { }

		[Address(RVA = "0x27E7850", Offset = "0x27E6C50", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B93")]
		public static v256 mm256_cmpeq_epi8(v256 a, v256 b) { }

		[Address(RVA = "0x27E78E0", Offset = "0x27E6CE0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B98")]
		public static v256 mm256_cmpgt_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E7970", Offset = "0x27E6D70", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B99")]
		public static v256 mm256_cmpgt_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27E7A00", Offset = "0x27E6E00", Length = "0xE7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B9A")]
		public static v256 mm256_cmpgt_epi64(v256 a, v256 b) { }

		[Address(RVA = "0x27E7AF0", Offset = "0x27E6EF0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B97")]
		public static v256 mm256_cmpgt_epi8(v256 a, v256 b) { }

		[Address(RVA = "0x27E7B80", Offset = "0x27E6F80", Length = "0x4A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C19")]
		public static v256 mm256_cvtepi16_epi32(v128 a) { }

		[Address(RVA = "0x27E7BD0", Offset = "0x27E6FD0", Length = "0x36")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C1A")]
		public static v256 mm256_cvtepi16_epi64(v128 a) { }

		[Address(RVA = "0x27E7C10", Offset = "0x27E7010", Length = "0x24")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C1B")]
		public static v256 mm256_cvtepi32_epi64(v128 a) { }

		[Address(RVA = "0x27E7C40", Offset = "0x27E7040", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C16")]
		public static v256 mm256_cvtepi8_epi16(v128 a) { }

		[Address(RVA = "0x27E7C70", Offset = "0x27E7070", Length = "0x4A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C17")]
		public static v256 mm256_cvtepi8_epi32(v128 a) { }

		[Address(RVA = "0x27E7CC0", Offset = "0x27E70C0", Length = "0x36")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C18")]
		public static v256 mm256_cvtepi8_epi64(v128 a) { }

		[Address(RVA = "0x27E7D00", Offset = "0x27E7100", Length = "0x4A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C1F")]
		public static v256 mm256_cvtepu16_epi32(v128 a) { }

		[Address(RVA = "0x27E7D50", Offset = "0x27E7150", Length = "0x24")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C20")]
		public static v256 mm256_cvtepu16_epi64(v128 a) { }

		[Address(RVA = "0x27E7D80", Offset = "0x27E7180", Length = "0x2E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C21")]
		public static v256 mm256_cvtepu32_epi64(v128 a) { }

		[Address(RVA = "0x27E7DB0", Offset = "0x27E71B0", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C1C")]
		public static v256 mm256_cvtepu8_epi16(v128 a) { }

		[Address(RVA = "0x27E7DE0", Offset = "0x27E71E0", Length = "0x4A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C1D")]
		public static v256 mm256_cvtepu8_epi32(v128 a) { }

		[Address(RVA = "0x27E7E30", Offset = "0x27E7230", Length = "0x24")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C1E")]
		public static v256 mm256_cvtepu8_epi64(v128 a) { }

		[Address(RVA = "0x20205C0", Offset = "0x201F9C0", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B90")]
		public static double mm256_cvtsd_f64(v256 a) { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B91")]
		public static int mm256_cvtsi256_si32(v256 a) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B92")]
		public static long mm256_cvtsi256_si64(v256 a) { }

		[Address(RVA = "0x27E7E60", Offset = "0x27E7260", Length = "0x8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B8F")]
		public static int mm256_extract_epi16(v256 a, int index) { }

		[Address(RVA = "0x27E7E70", Offset = "0x27E7270", Length = "0x8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B8E")]
		public static int mm256_extract_epi8(v256 a, int index) { }

		[Address(RVA = "0x27E7E80", Offset = "0x27E7280", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C07")]
		public static v128 mm256_extracti128_si256(v256 a, int imm8) { }

		[Address(RVA = "0x27E7EB0", Offset = "0x27E72B0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BC0")]
		public static v256 mm256_hadd_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E7F40", Offset = "0x27E7340", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BC1")]
		public static v256 mm256_hadd_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27E7FD0", Offset = "0x27E73D0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BC2")]
		public static v256 mm256_hadds_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E8060", Offset = "0x27E7460", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BC3")]
		public static v256 mm256_hsub_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E80F0", Offset = "0x27E74F0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BC4")]
		public static v256 mm256_hsub_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27E8180", Offset = "0x27E7580", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BC5")]
		public static v256 mm256_hsubs_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E8210", Offset = "0x27E7610", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C32")]
		public static v256 mm256_i32gather_epi32(Void* base_addr, v256 vindex, int scale) { }

		[Address(RVA = "0x27E82A0", Offset = "0x27E76A0", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C3B")]
		public static v256 mm256_i32gather_epi64(Void* base_addr, v128 vindex, int scale) { }

		[Address(RVA = "0x27E8330", Offset = "0x27E7730", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C33")]
		public static v256 mm256_i32gather_pd(Void* base_addr, v128 vindex, int scale) { }

		[Address(RVA = "0x27E83C0", Offset = "0x27E77C0", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C34")]
		public static v256 mm256_i32gather_ps(Void* base_addr, v256 vindex, int scale) { }

		[Address(RVA = "0x27E8450", Offset = "0x27E7850", Length = "0x88")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C3C")]
		public static v128 mm256_i64gather_epi32(Void* base_addr, v256 vindex, int scale) { }

		[Address(RVA = "0x27E84E0", Offset = "0x27E78E0", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C3D")]
		public static v256 mm256_i64gather_epi64(Void* base_addr, v256 vindex, int scale) { }

		[Address(RVA = "0x27E8570", Offset = "0x27E7970", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C35")]
		public static v256 mm256_i64gather_pd(Void* base_addr, v256 vindex, int scale) { }

		[Address(RVA = "0x27E8600", Offset = "0x27E7A00", Length = "0x88")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C36")]
		public static v128 mm256_i64gather_ps(Void* base_addr, v256 vindex, int scale) { }

		[Address(RVA = "0x27E8690", Offset = "0x27E7A90", Length = "0x37")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C08")]
		public static v256 mm256_inserti128_si256(v256 a, v128 b, int imm8) { }

		[Address(RVA = "0x27E86D0", Offset = "0x27E7AD0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BC6")]
		public static v256 mm256_madd_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E8760", Offset = "0x27E7B60", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BC7")]
		public static v256 mm256_maddubs_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E87F0", Offset = "0x27E7BF0", Length = "0x93")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C46")]
		public static v256 mm256_mask_i32gather_epi32(v256 src, Void* base_addr, v256 vindex, v256 mask, int scale) { }

		[Address(RVA = "0x27E8890", Offset = "0x27E7C90", Length = "0x93")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C47")]
		public static v256 mm256_mask_i32gather_epi64(v256 src, Void* base_addr, v128 vindex, v256 mask, int scale) { }

		[Address(RVA = "0x27E8930", Offset = "0x27E7D30", Length = "0x93")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C42")]
		public static v256 mm256_mask_i32gather_pd(v256 src, Void* base_addr, v128 vindex, v256 mask, int scale) { }

		[Address(RVA = "0x27E89D0", Offset = "0x27E7DD0", Length = "0x93")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C43")]
		public static v256 mm256_mask_i32gather_ps(v256 src, Void* base_addr, v256 vindex, v256 mask, int scale) { }

		[Address(RVA = "0x27E8A70", Offset = "0x27E7E70", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C49")]
		public static v128 mm256_mask_i64gather_epi32(v128 src, Void* base_addr, v256 vindex, v128 mask, int scale) { }

		[Address(RVA = "0x27E8B00", Offset = "0x27E7F00", Length = "0x93")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C48")]
		public static v256 mm256_mask_i64gather_epi64(v256 src, Void* base_addr, v256 vindex, v256 mask, int scale) { }

		[Address(RVA = "0x27E8BA0", Offset = "0x27E7FA0", Length = "0x93")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C44")]
		public static v256 mm256_mask_i64gather_pd(v256 src, Void* base_addr, v256 vindex, v256 mask, int scale) { }

		[Address(RVA = "0x27E8C40", Offset = "0x27E8040", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C45")]
		public static v128 mm256_mask_i64gather_ps(v128 src, Void* base_addr, v256 vindex, v128 mask, int scale) { }

		[Address(RVA = "0x27E8CD0", Offset = "0x27E80D0", Length = "0x73")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C26")]
		public static v256 mm256_maskload_epi32(Void* mem_addr, v256 mask) { }

		[Address(RVA = "0x27E8D50", Offset = "0x27E8150", Length = "0x47")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C27")]
		public static v256 mm256_maskload_epi64(Void* mem_addr, v256 mask) { }

		[Address(RVA = "0x27E8DA0", Offset = "0x27E81A0", Length = "0x29")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C28")]
		public static void mm256_maskstore_epi32(Void* mem_addr, v256 mask, v256 a) { }

		[Address(RVA = "0x27E8DD0", Offset = "0x27E81D0", Length = "0x3C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C29")]
		public static void mm256_maskstore_epi64(Void* mem_addr, v256 mask, v256 a) { }

		[Address(RVA = "0x27E8E10", Offset = "0x27E8210", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B9C")]
		public static v256 mm256_max_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E8EA0", Offset = "0x27E82A0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B9D")]
		public static v256 mm256_max_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27E8F30", Offset = "0x27E8330", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B9B")]
		public static v256 mm256_max_epi8(v256 a, v256 b) { }

		[Address(RVA = "0x27E8FC0", Offset = "0x27E83C0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B9F")]
		public static v256 mm256_max_epu16(v256 a, v256 b) { }

		[Address(RVA = "0x27E9050", Offset = "0x27E8450", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BA0")]
		public static v256 mm256_max_epu32(v256 a, v256 b) { }

		[Address(RVA = "0x27E90E0", Offset = "0x27E84E0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B9E")]
		public static v256 mm256_max_epu8(v256 a, v256 b) { }

		[Address(RVA = "0x27E9170", Offset = "0x27E8570", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BA2")]
		public static v256 mm256_min_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E9200", Offset = "0x27E8600", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BA3")]
		public static v256 mm256_min_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27E9290", Offset = "0x27E8690", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BA1")]
		public static v256 mm256_min_epi8(v256 a, v256 b) { }

		[Address(RVA = "0x27E9320", Offset = "0x27E8720", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BA5")]
		public static v256 mm256_min_epu16(v256 a, v256 b) { }

		[Address(RVA = "0x27E93B0", Offset = "0x27E87B0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BA6")]
		public static v256 mm256_min_epu32(v256 a, v256 b) { }

		[Address(RVA = "0x27E9440", Offset = "0x27E8840", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BA4")]
		public static v256 mm256_min_epu8(v256 a, v256 b) { }

		[Address(RVA = "0x27E94D0", Offset = "0x27E88D0", Length = "0x70")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000B8D")]
		public static int mm256_movemask_epi8(v256 a) { }

		[Address(RVA = "0x27E9540", Offset = "0x27E8940", Length = "0xB5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BD3")]
		public static v256 mm256_mpsadbw_epu8(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27E9600", Offset = "0x27E8A00", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BCD")]
		public static v256 mm256_mul_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27E9690", Offset = "0x27E8A90", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BCC")]
		public static v256 mm256_mul_epu32(v256 a, v256 b) { }

		[Address(RVA = "0x27E9720", Offset = "0x27E8B20", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BC8")]
		public static v256 mm256_mulhi_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E97B0", Offset = "0x27E8BB0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BC9")]
		public static v256 mm256_mulhi_epu16(v256 a, v256 b) { }

		[Address(RVA = "0x27E9840", Offset = "0x27E8C40", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BD1")]
		public static v256 mm256_mulhrs_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E98D0", Offset = "0x27E8CD0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BCA")]
		public static v256 mm256_mullo_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E9960", Offset = "0x27E8D60", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BCB")]
		public static v256 mm256_mullo_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27E99F0", Offset = "0x27E8DF0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BA9")]
		public static v256 mm256_or_si256(v256 a, v256 b) { }

		[Address(RVA = "0x27E9A80", Offset = "0x27E8E80", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BF7")]
		public static v256 mm256_packs_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E9B10", Offset = "0x27E8F10", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BF8")]
		public static v256 mm256_packs_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27E9BA0", Offset = "0x27E8FA0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BF9")]
		public static v256 mm256_packus_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27E9C30", Offset = "0x27E9030", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BFA")]
		public static v256 mm256_packus_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27E9CC0", Offset = "0x27E90C0", Length = "0x91")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C2E")]
		public static v256 mm256_permute2x128_si256(v256 a, v256 b, int imm8) { }

		[Address(RVA = "0x27E9D60", Offset = "0x27E9160", Length = "0x5B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C2C")]
		public static v256 mm256_permute4x64_epi64(v256 a, int imm8) { }

		[Address(RVA = "0x27E9DC0", Offset = "0x27E91C0", Length = "0x7F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C2D")]
		public static v256 mm256_permute4x64_pd(v256 a, int imm8) { }

		[Address(RVA = "0x27E9E40", Offset = "0x27E9240", Length = "0x7E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C2A")]
		public static v256 mm256_permutevar8x32_epi32(v256 a, v256 idx) { }

		[Address(RVA = "0x27E9EC0", Offset = "0x27E92C0", Length = "0xAF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C2B")]
		public static v256 mm256_permutevar8x32_ps(v256 a, v256 idx) { }

		[Address(RVA = "0x27E9F70", Offset = "0x27E9370", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BD2")]
		public static v256 mm256_sad_epu8(v256 a, v256 b) { }

		[Address(RVA = "0x27EA000", Offset = "0x27E9400", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C04")]
		public static v256 mm256_shuffle_epi32(v256 a, int imm8) { }

		[Address(RVA = "0x27EA080", Offset = "0x27E9480", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C03")]
		public static v256 mm256_shuffle_epi8(v256 a, v256 b) { }

		[Address(RVA = "0x27EA110", Offset = "0x27E9510", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C05")]
		public static v256 mm256_shufflehi_epi16(v256 a, int imm8) { }

		[Address(RVA = "0x27EA190", Offset = "0x27E9590", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C06")]
		public static v256 mm256_shufflelo_epi16(v256 a, int imm8) { }

		[Address(RVA = "0x27EA210", Offset = "0x27E9610", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BCF")]
		public static v256 mm256_sign_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27EA2A0", Offset = "0x27E96A0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BD0")]
		public static v256 mm256_sign_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27EA330", Offset = "0x27E9730", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BCE")]
		public static v256 mm256_sign_epi8(v256 a, v256 b) { }

		[Address(RVA = "0x27EA3C0", Offset = "0x27E97C0", Length = "0x8E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BD8")]
		public static v256 mm256_sll_epi16(v256 a, v128 count) { }

		[Address(RVA = "0x27EA450", Offset = "0x27E9850", Length = "0x8E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BD9")]
		public static v256 mm256_sll_epi32(v256 a, v128 count) { }

		[Address(RVA = "0x27EA4E0", Offset = "0x27E98E0", Length = "0x8E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BDA")]
		public static v256 mm256_sll_epi64(v256 a, v128 count) { }

		[Address(RVA = "0x27EA570", Offset = "0x27E9970", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BDB")]
		public static v256 mm256_slli_epi16(v256 a, int imm8) { }

		[Address(RVA = "0x27EA5F0", Offset = "0x27E99F0", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BDC")]
		public static v256 mm256_slli_epi32(v256 a, int imm8) { }

		[Address(RVA = "0x27EA670", Offset = "0x27E9A70", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BDD")]
		public static v256 mm256_slli_epi64(v256 a, int imm8) { }

		[Address(RVA = "0x27EA6F0", Offset = "0x27E9AF0", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BD4")]
		public static v256 mm256_slli_si256(v256 a, int imm8) { }

		[Address(RVA = "0x27EA770", Offset = "0x27E9B70", Length = "0xCE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BDE")]
		public static v256 mm256_sllv_epi32(v256 a, v256 count) { }

		[Address(RVA = "0x27EA840", Offset = "0x27E9C40", Length = "0xD0")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BDF")]
		public static v256 mm256_sllv_epi64(v256 a, v256 count) { }

		[Address(RVA = "0x27EA910", Offset = "0x27E9D10", Length = "0x8E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BE2")]
		public static v256 mm256_sra_epi16(v256 a, v128 count) { }

		[Address(RVA = "0x27EA9A0", Offset = "0x27E9DA0", Length = "0x8E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BE3")]
		public static v256 mm256_sra_epi32(v256 a, v128 count) { }

		[Address(RVA = "0x27EAA30", Offset = "0x27E9E30", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BE4")]
		public static v256 mm256_srai_epi16(v256 a, int imm8) { }

		[Address(RVA = "0x27EAAB0", Offset = "0x27E9EB0", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BE5")]
		public static v256 mm256_srai_epi32(v256 a, int imm8) { }

		[Address(RVA = "0x27EAB30", Offset = "0x27E9F30", Length = "0x170")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BE6")]
		public static v256 mm256_srav_epi32(v256 a, v256 count) { }

		[Address(RVA = "0x27EACA0", Offset = "0x27EA0A0", Length = "0x8E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BE8")]
		public static v256 mm256_srl_epi16(v256 a, v128 count) { }

		[Address(RVA = "0x27EAD30", Offset = "0x27EA130", Length = "0x8E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BE9")]
		public static v256 mm256_srl_epi32(v256 a, v128 count) { }

		[Address(RVA = "0x27EADC0", Offset = "0x27EA1C0", Length = "0x8E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BEA")]
		public static v256 mm256_srl_epi64(v256 a, v128 count) { }

		[Address(RVA = "0x27EAE50", Offset = "0x27EA250", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BEB")]
		public static v256 mm256_srli_epi16(v256 a, int imm8) { }

		[Address(RVA = "0x27EAED0", Offset = "0x27EA2D0", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BEC")]
		public static v256 mm256_srli_epi32(v256 a, int imm8) { }

		[Address(RVA = "0x27EAF50", Offset = "0x27EA350", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BED")]
		public static v256 mm256_srli_epi64(v256 a, int imm8) { }

		[Address(RVA = "0x27EAFD0", Offset = "0x27EA3D0", Length = "0x7A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BD6")]
		public static v256 mm256_srli_si256(v256 a, int imm8) { }

		[Address(RVA = "0x27EB050", Offset = "0x27EA450", Length = "0xCE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BEE")]
		public static v256 mm256_srlv_epi32(v256 a, v256 count) { }

		[Address(RVA = "0x27EB120", Offset = "0x27EA520", Length = "0xD0")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BEF")]
		public static v256 mm256_srlv_epi64(v256 a, v256 count) { }

		[Address(RVA = "0x27EB1F0", Offset = "0x27EA5F0", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C2F")]
		public static v256 mm256_stream_load_si256(Void* mem_addr) { }

		[Address(RVA = "0x27EB210", Offset = "0x27EA610", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BB7")]
		public static v256 mm256_sub_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27EB2A0", Offset = "0x27EA6A0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BB8")]
		public static v256 mm256_sub_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27EB330", Offset = "0x27EA730", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BB9")]
		public static v256 mm256_sub_epi64(v256 a, v256 b) { }

		[Address(RVA = "0x27EB3C0", Offset = "0x27EA7C0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BB6")]
		public static v256 mm256_sub_epi8(v256 a, v256 b) { }

		[Address(RVA = "0x27EB450", Offset = "0x27EA850", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BBB")]
		public static v256 mm256_subs_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27EB4E0", Offset = "0x27EA8E0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BBA")]
		public static v256 mm256_subs_epi8(v256 a, v256 b) { }

		[Address(RVA = "0x27EB570", Offset = "0x27EA970", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BBD")]
		public static v256 mm256_subs_epu16(v256 a, v256 b) { }

		[Address(RVA = "0x27EB600", Offset = "0x27EAA00", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BBC")]
		public static v256 mm256_subs_epu8(v256 a, v256 b) { }

		[Address(RVA = "0x27EB690", Offset = "0x27EAA90", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BFC")]
		public static v256 mm256_unpackhi_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27EB720", Offset = "0x27EAB20", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BFD")]
		public static v256 mm256_unpackhi_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27EB7B0", Offset = "0x27EABB0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BFE")]
		public static v256 mm256_unpackhi_epi64(v256 a, v256 b) { }

		[Address(RVA = "0x27EB840", Offset = "0x27EAC40", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BFB")]
		public static v256 mm256_unpackhi_epi8(v256 a, v256 b) { }

		[Address(RVA = "0x27EB8D0", Offset = "0x27EACD0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C00")]
		public static v256 mm256_unpacklo_epi16(v256 a, v256 b) { }

		[Address(RVA = "0x27EB960", Offset = "0x27EAD60", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C01")]
		public static v256 mm256_unpacklo_epi32(v256 a, v256 b) { }

		[Address(RVA = "0x27EB9F0", Offset = "0x27EADF0", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C02")]
		public static v256 mm256_unpacklo_epi64(v256 a, v256 b) { }

		[Address(RVA = "0x27EBA80", Offset = "0x27EAE80", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BFF")]
		public static v256 mm256_unpacklo_epi8(v256 a, v256 b) { }

		[Address(RVA = "0x27EBB10", Offset = "0x27EAF10", Length = "0x8F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BAA")]
		public static v256 mm256_xor_si256(v256 a, v256 b) { }

		[Address(RVA = "0x27EBBA0", Offset = "0x27EAFA0", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BE0")]
		public static v128 sllv_epi32(v128 a, v128 count) { }

		[Address(RVA = "0x27EBBE0", Offset = "0x27EAFE0", Length = "0x3D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BE1")]
		public static v128 sllv_epi64(v128 a, v128 count) { }

		[Address(RVA = "0x27EBC20", Offset = "0x27EB020", Length = "0xCA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BE7")]
		public static v128 srav_epi32(v128 a, v128 count) { }

		[Address(RVA = "0x27EBCF0", Offset = "0x27EB0F0", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BF0")]
		public static v128 srlv_epi32(v128 a, v128 count) { }

		[Address(RVA = "0x27EBD30", Offset = "0x27EB130", Length = "0x3D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000BF1")]
		public static v128 srlv_epi64(v128 a, v128 count) { }

	}

	[Token(Token = "0x2000040")]
	internal static class Bmi1
	{

		[Token(Token = "0x17000043")]
		public static bool IsBmi1Supported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000C52")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27F17E0", Offset = "0x27F0BE0", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C53")]
		public static uint andn_u32(uint a, uint b) { }

		[Address(RVA = "0x27F17F0", Offset = "0x27F0BF0", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C54")]
		public static ulong andn_u64(ulong a, ulong b) { }

		[Address(RVA = "0x27F1870", Offset = "0x27F0C70", Length = "0x2B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C55")]
		public static uint bextr_u32(uint a, uint start, uint len) { }

		[Address(RVA = "0x27F18A0", Offset = "0x27F0CA0", Length = "0x2D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C56")]
		public static ulong bextr_u64(ulong a, uint start, uint len) { }

		[Address(RVA = "0x27F1800", Offset = "0x27F0C00", Length = "0x35")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C57")]
		public static uint bextr2_u32(uint a, uint control) { }

		[Address(RVA = "0x27F1840", Offset = "0x27F0C40", Length = "0x30")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C58")]
		public static ulong bextr2_u64(ulong a, ulong control) { }

		[Address(RVA = "0x27F18D0", Offset = "0x27F0CD0", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C59")]
		public static uint blsi_u32(uint a) { }

		[Address(RVA = "0x27F18E0", Offset = "0x27F0CE0", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C5A")]
		public static ulong blsi_u64(ulong a) { }

		[Address(RVA = "0x27F18F0", Offset = "0x27F0CF0", Length = "0x6")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C5B")]
		public static uint blsmsk_u32(uint a) { }

		[Address(RVA = "0x27F1900", Offset = "0x27F0D00", Length = "0x8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C5C")]
		public static ulong blsmsk_u64(ulong a) { }

		[Address(RVA = "0x27F1910", Offset = "0x27F0D10", Length = "0x6")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C5D")]
		public static uint blsr_u32(uint a) { }

		[Address(RVA = "0x27F1920", Offset = "0x27F0D20", Length = "0x8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C5E")]
		public static ulong blsr_u64(ulong a) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C52")]
		public static bool get_IsBmi1Supported() { }

		[Address(RVA = "0x27F1930", Offset = "0x27F0D30", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C5F")]
		public static uint tzcnt_u32(uint a) { }

		[Address(RVA = "0x27F1980", Offset = "0x27F0D80", Length = "0x84")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C60")]
		public static ulong tzcnt_u64(ulong a) { }

	}

	[Token(Token = "0x2000041")]
	internal static class Bmi2
	{

		[Token(Token = "0x17000044")]
		public static bool IsBmi2Supported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000C61")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27F1A10", Offset = "0x27F0E10", Length = "0x1C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C62")]
		public static uint bzhi_u32(uint a, uint index) { }

		[Address(RVA = "0x27F1A30", Offset = "0x27F0E30", Length = "0x1F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C63")]
		public static ulong bzhi_u64(ulong a, ulong index) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C61")]
		public static bool get_IsBmi2Supported() { }

		[Address(RVA = "0x27F1A50", Offset = "0x27F0E50", Length = "0x13")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C64")]
		public static uint mulx_u32(uint a, uint b, out uint hi) { }

		[Address(RVA = "0x27F1A70", Offset = "0x27F0E70", Length = "0x56")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C65")]
		public static ulong mulx_u64(ulong a, ulong b, out ulong hi) { }

		[Address(RVA = "0x27F1AD0", Offset = "0x27F0ED0", Length = "0x43")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C66")]
		public static uint pdep_u32(uint a, uint mask) { }

		[Address(RVA = "0x27F1B20", Offset = "0x27F0F20", Length = "0x4F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C67")]
		public static ulong pdep_u64(ulong a, ulong mask) { }

		[Address(RVA = "0x27F1B70", Offset = "0x27F0F70", Length = "0x43")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C68")]
		public static uint pext_u32(uint a, uint mask) { }

		[Address(RVA = "0x27F1BC0", Offset = "0x27F0FC0", Length = "0x4F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C69")]
		public static ulong pext_u64(ulong a, ulong mask) { }

	}

	[Token(Token = "0x2000055")]
	public static class DoGetCSRTrampoline_0000012A$BurstDirectCall
	{
		[Token(Token = "0x40002D3")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x27F7070", Offset = "0x27F6470", Length = "0x167")]
		[Token(Token = "0x6000E40")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x27F6EF0", Offset = "0x27F62F0", Length = "0x174")]
		[BurstDiscard]
		[Token(Token = "0x6000E3F")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x27F71E0", Offset = "0x27F65E0", Length = "0x1D7")]
		[Token(Token = "0x6000E41")]
		public static int Invoke() { }

	}

	[Token(Token = "0x2000054")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class DoGetCSRTrampoline_0000012A$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x17C9CC0", Offset = "0x17C90C0", Length = "0xA5")]
		[Token(Token = "0x6000E3B")]
		public DoGetCSRTrampoline_0000012A$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
		[Token(Token = "0x6000E3D")]
		public override IAsyncResult BeginInvoke(AsyncCallback unnamed_param_0, object unnamed_param_1) { }

		[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
		[Token(Token = "0x6000E3E")]
		public override int EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x6000E3C")]
		public override int Invoke() { }

	}

	[Token(Token = "0x2000053")]
	public static class DoSetCSRTrampoline_00000129$BurstDirectCall
	{
		[Token(Token = "0x40002D2")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x27F7540", Offset = "0x27F6940", Length = "0x168")]
		[Token(Token = "0x6000E39")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x27F73C0", Offset = "0x27F67C0", Length = "0x175")]
		[BurstDiscard]
		[Token(Token = "0x6000E38")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x27F76B0", Offset = "0x27F6AB0", Length = "0x1DE")]
		[Token(Token = "0x6000E3A")]
		public static void Invoke(int bits) { }

	}

	[Token(Token = "0x2000052")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class DoSetCSRTrampoline_00000129$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
		[Token(Token = "0x6000E34")]
		public DoSetCSRTrampoline_00000129$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x63A130", Offset = "0x639530", Length = "0x5D")]
		[Token(Token = "0x6000E36")]
		public override IAsyncResult BeginInvoke(int bits, AsyncCallback unnamed_param_1, object unnamed_param_2) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000E37")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000E35")]
		public override void Invoke(int bits) { }

	}

	[Token(Token = "0x2000045")]
	internal static class F16C
	{
		[Token(Token = "0x40002BA")]
		private static readonly UInt16[] BaseTable; //Field offset: 0x0
		[Token(Token = "0x40002BB")]
		private static readonly SByte[] ShiftTable; //Field offset: 0x8

		[Token(Token = "0x17000045")]
		public static bool IsF16CSupported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000C6C")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27F1EF0", Offset = "0x27F12F0", Length = "0xF6")]
		[Token(Token = "0x6000C73")]
		private static F16C() { }

		[Address(RVA = "0x27F1FF0", Offset = "0x27F13F0", Length = "0x85")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C6E")]
		public static v128 cvtph_ps(v128 a) { }

		[Address(RVA = "0x27F2080", Offset = "0x27F1480", Length = "0x113")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C71")]
		public static v128 cvtps_ph(v128 a, int rounding) { }

		[Address(RVA = "0x27F1C70", Offset = "0x27F1070", Length = "0x1ED")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C70")]
		private static ushort FloatToHalf(uint f, int rounding) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C6C")]
		public static bool get_IsF16CSupported() { }

		[Address(RVA = "0x27F1E60", Offset = "0x27F1260", Length = "0x8D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C6D")]
		private static uint HalfToFloat(ushort h) { }

		[Address(RVA = "0x27F21A0", Offset = "0x27F15A0", Length = "0xBD")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C6F")]
		public static v256 mm256_cvtph_ps(v128 a) { }

		[Address(RVA = "0x27F2260", Offset = "0x27F1660", Length = "0x18D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C72")]
		public static v128 mm256_cvtps_ph(v256 a, int rounding) { }

	}

	[Token(Token = "0x2000046")]
	internal static class Fma
	{
		[Token(Token = "0x2000047")]
		private struct Union
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40002BC")]
			public float f; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40002BD")]
			public uint u; //Field offset: 0x0

		}


		[Token(Token = "0x17000046")]
		public static bool IsFmaSupported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000C74")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27F2450", Offset = "0x27F1850", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C77")]
		public static v128 fmadd_pd(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F24A0", Offset = "0x27F18A0", Length = "0xAC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C79")]
		public static v128 fmadd_ps(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F2550", Offset = "0x27F1950", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C7B")]
		public static v128 fmadd_sd(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F25A0", Offset = "0x27F19A0", Length = "0x31")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C7C")]
		public static v128 fmadd_ss(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F25E0", Offset = "0x27F19E0", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C7D")]
		public static v128 fmaddsub_pd(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F2630", Offset = "0x27F1A30", Length = "0xC2")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C7F")]
		public static v128 fmaddsub_ps(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F23F0", Offset = "0x27F17F0", Length = "0x22")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C75")]
		private static float FmaHelper(float a, float b, float c) { }

		[Address(RVA = "0x27F2700", Offset = "0x27F1B00", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C81")]
		public static v128 fmsub_pd(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F2750", Offset = "0x27F1B50", Length = "0xD0")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C83")]
		public static v128 fmsub_ps(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F2820", Offset = "0x27F1C20", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C85")]
		public static v128 fmsub_sd(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F2870", Offset = "0x27F1C70", Length = "0x39")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C86")]
		public static v128 fmsub_ss(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F28B0", Offset = "0x27F1CB0", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C87")]
		public static v128 fmsubadd_pd(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F2900", Offset = "0x27F1D00", Length = "0xBF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C89")]
		public static v128 fmsubadd_ps(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F29C0", Offset = "0x27F1DC0", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C8B")]
		public static v128 fnmadd_pd(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F2A10", Offset = "0x27F1E10", Length = "0xD0")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C8D")]
		public static v128 fnmadd_ps(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F2AE0", Offset = "0x27F1EE0", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C8F")]
		public static v128 fnmadd_sd(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F2B30", Offset = "0x27F1F30", Length = "0x3C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C90")]
		public static v128 fnmadd_ss(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F2420", Offset = "0x27F1820", Length = "0x29")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C76")]
		private static float FnmaHelper(float a, float b, float c) { }

		[Address(RVA = "0x27F2B70", Offset = "0x27F1F70", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C91")]
		public static v128 fnmsub_pd(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F2BC0", Offset = "0x27F1FC0", Length = "0xEC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C93")]
		public static v128 fnmsub_ps(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F2CB0", Offset = "0x27F20B0", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C95")]
		public static v128 fnmsub_sd(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x27F2D00", Offset = "0x27F2100", Length = "0x47")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C96")]
		public static v128 fnmsub_ss(v128 a, v128 b, v128 c) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C74")]
		public static bool get_IsFmaSupported() { }

		[Address(RVA = "0x27F2D50", Offset = "0x27F2150", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C78")]
		public static v256 mm256_fmadd_pd(v256 a, v256 b, v256 c) { }

		[Address(RVA = "0x27F2DA0", Offset = "0x27F21A0", Length = "0x158")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C7A")]
		public static v256 mm256_fmadd_ps(v256 a, v256 b, v256 c) { }

		[Address(RVA = "0x27F2F00", Offset = "0x27F2300", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C7E")]
		public static v256 mm256_fmaddsub_pd(v256 a, v256 b, v256 c) { }

		[Address(RVA = "0x27F2F50", Offset = "0x27F2350", Length = "0x17C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C80")]
		public static v256 mm256_fmaddsub_ps(v256 a, v256 b, v256 c) { }

		[Address(RVA = "0x27F30D0", Offset = "0x27F24D0", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C82")]
		public static v256 mm256_fmsub_pd(v256 a, v256 b, v256 c) { }

		[Address(RVA = "0x27F3120", Offset = "0x27F2520", Length = "0x198")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C84")]
		public static v256 mm256_fmsub_ps(v256 a, v256 b, v256 c) { }

		[Address(RVA = "0x27F32C0", Offset = "0x27F26C0", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C88")]
		public static v256 mm256_fmsubadd_pd(v256 a, v256 b, v256 c) { }

		[Address(RVA = "0x27F3310", Offset = "0x27F2710", Length = "0x179")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C8A")]
		public static v256 mm256_fmsubadd_ps(v256 a, v256 b, v256 c) { }

		[Address(RVA = "0x27F3490", Offset = "0x27F2890", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C8C")]
		public static v256 mm256_fnmadd_pd(v256 a, v256 b, v256 c) { }

		[Address(RVA = "0x27F34E0", Offset = "0x27F28E0", Length = "0x198")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C8E")]
		public static v256 mm256_fnmadd_ps(v256 a, v256 b, v256 c) { }

		[Address(RVA = "0x27F3680", Offset = "0x27F2A80", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C92")]
		public static v256 mm256_fnmsub_pd(v256 a, v256 b, v256 c) { }

		[Address(RVA = "0x27F36D0", Offset = "0x27F2AD0", Length = "0x1D0")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C94")]
		public static v256 mm256_fnmsub_ps(v256 a, v256 b, v256 c) { }

	}

	[Flags]
	[Token(Token = "0x2000042")]
	internal enum MXCSRBits : int
	{
		FlushToZero = 32768,
		RoundingControlMask = 24576,
		RoundToNearest = 0,
		RoundDown = 8192,
		RoundUp = 16384,
		RoundTowardZero = 24576,
		PrecisionMask = 4096,
		UnderflowMask = 2048,
		OverflowMask = 1024,
		DivideByZeroMask = 512,
		DenormalOperationMask = 256,
		InvalidOperationMask = 128,
		ExceptionMask = 8064,
		DenormalsAreZeroes = 64,
		PrecisionFlag = 32,
		UnderflowFlag = 16,
		OverflowFlag = 8,
		DivideByZeroFlag = 4,
		DenormalFlag = 2,
		InvalidOperationFlag = 1,
		FlagMask = 63,
	}

	[Token(Token = "0x2000048")]
	internal static class Popcnt
	{

		[Token(Token = "0x17000047")]
		public static bool IsPopcntSupported
		{
			[Address(RVA = "0x27F38A0", Offset = "0x27F2CA0", Length = "0x40")]
			[Token(Token = "0x6000C97")]
			 get { } //Length: 64
		}

		[Address(RVA = "0x27F38A0", Offset = "0x27F2CA0", Length = "0x40")]
		[Token(Token = "0x6000C97")]
		public static bool get_IsPopcntSupported() { }

		[Address(RVA = "0x27F38E0", Offset = "0x27F2CE0", Length = "0x23")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C98")]
		public static int popcnt_u32(uint v) { }

		[Address(RVA = "0x27F3910", Offset = "0x27F2D10", Length = "0x23")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C99")]
		public static int popcnt_u64(ulong v) { }

	}

	[Flags]
	[Token(Token = "0x2000043")]
	internal enum RoundingMode : int
	{
		FROUND_TO_NEAREST_INT = 0,
		FROUND_TO_NEG_INF = 1,
		FROUND_TO_POS_INF = 2,
		FROUND_TO_ZERO = 3,
		FROUND_CUR_DIRECTION = 4,
		FROUND_RAISE_EXC = 0,
		FROUND_NO_EXC = 8,
		FROUND_NINT = 0,
		FROUND_FLOOR = 1,
		FROUND_CEIL = 2,
		FROUND_TRUNC = 3,
		FROUND_RINT = 4,
		FROUND_NEARBYINT = 12,
		FROUND_NINT_NOEXC = 8,
		FROUND_FLOOR_NOEXC = 9,
		FROUND_CEIL_NOEXC = 10,
		FROUND_TRUNC_NOEXC = 11,
		FROUND_RINT_NOEXC = 12,
	}

	[Token(Token = "0x2000044")]
	public struct RoundingScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B9")]
		private MXCSRBits OldBits; //Field offset: 0x0

		[Address(RVA = "0x27F3950", Offset = "0x27F2D50", Length = "0x32")]
		[Token(Token = "0x6000C6A")]
		public RoundingScope(MXCSRBits roundingMode) { }

		[Address(RVA = "0x27F3940", Offset = "0x27F2D40", Length = "0x9")]
		[Token(Token = "0x6000C6B")]
		public override void Dispose() { }

	}

	[Token(Token = "0x2000049")]
	internal static class Sse
	{

		[Token(Token = "0x17000048")]
		public static bool IsSseSupported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000C9A")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27F3B30", Offset = "0x27F2F30", Length = "0x43")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CA3")]
		public static v128 add_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F3B80", Offset = "0x27F2F80", Length = "0x13")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CA2")]
		public static v128 add_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F3BA0", Offset = "0x27F2FA0", Length = "0x24")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CB4")]
		public static v128 and_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F3BD0", Offset = "0x27F2FD0", Length = "0x31")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CB5")]
		public static v128 andnot_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F3C10", Offset = "0x27F3010", Length = "0x6F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CB9")]
		public static v128 cmpeq_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F3C80", Offset = "0x27F3080", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CB8")]
		public static v128 cmpeq_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F3CB0", Offset = "0x27F30B0", Length = "0x75")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CC1")]
		public static v128 cmpge_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F3D30", Offset = "0x27F3130", Length = "0x2B")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CC0")]
		public static v128 cmpge_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F3D60", Offset = "0x27F3160", Length = "0x75")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CBF")]
		public static v128 cmpgt_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F3DE0", Offset = "0x27F31E0", Length = "0x2B")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CBE")]
		public static v128 cmpgt_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F3E10", Offset = "0x27F3210", Length = "0x5A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CBD")]
		public static v128 cmple_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F3E70", Offset = "0x27F3270", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CBC")]
		public static v128 cmple_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F3E90", Offset = "0x27F3290", Length = "0x5A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CBB")]
		public static v128 cmplt_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F3EF0", Offset = "0x27F32F0", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CBA")]
		public static v128 cmplt_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F3F10", Offset = "0x27F3310", Length = "0x6F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CC3")]
		public static v128 cmpneq_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F3F80", Offset = "0x27F3380", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CC2")]
		public static v128 cmpneq_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F3FB0", Offset = "0x27F33B0", Length = "0x75")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CCB")]
		public static v128 cmpnge_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F4030", Offset = "0x27F3430", Length = "0x2B")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CCA")]
		public static v128 cmpnge_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4060", Offset = "0x27F3460", Length = "0x75")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CC9")]
		public static v128 cmpngt_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F40E0", Offset = "0x27F34E0", Length = "0x2B")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CC8")]
		public static v128 cmpngt_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4110", Offset = "0x27F3510", Length = "0x5A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CC7")]
		public static v128 cmpnle_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F4170", Offset = "0x27F3570", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CC6")]
		public static v128 cmpnle_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4190", Offset = "0x27F3590", Length = "0x5A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CC5")]
		public static v128 cmpnlt_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F41F0", Offset = "0x27F35F0", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CC4")]
		public static v128 cmpnlt_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4210", Offset = "0x27F3610", Length = "0xAB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CCD")]
		public static v128 cmpord_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F42C0", Offset = "0x27F36C0", Length = "0x35")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CCC")]
		public static v128 cmpord_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4300", Offset = "0x27F3700", Length = "0xAB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CCF")]
		public static v128 cmpunord_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F43B0", Offset = "0x27F37B0", Length = "0x35")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CCE")]
		public static v128 cmpunord_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F43F0", Offset = "0x27F37F0", Length = "0x14")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CD0")]
		public static int comieq_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4410", Offset = "0x27F3810", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CD4")]
		public static int comige_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4420", Offset = "0x27F3820", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CD3")]
		public static int comigt_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4430", Offset = "0x27F3830", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CD2")]
		public static int comile_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4440", Offset = "0x27F3840", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CD1")]
		public static int comilt_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4450", Offset = "0x27F3850", Length = "0x14")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CD5")]
		public static int comineq_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4470", Offset = "0x27F3870", Length = "0x96")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CDD")]
		public static int cvt_ss2si(v128 a) { }

		[Address(RVA = "0x27F4510", Offset = "0x27F3910", Length = "0x16")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CA0")]
		public static v128 cvtsi32_ss(v128 a, int b) { }

		[Address(RVA = "0x27F4530", Offset = "0x27F3930", Length = "0x16")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CA1")]
		public static v128 cvtsi64_ss(v128 a, long b) { }

		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CDF")]
		public static float cvtss_f32(v128 a) { }

		[Address(RVA = "0x27F4550", Offset = "0x27F3950", Length = "0x90")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CDC")]
		public static int cvtss_si32(v128 a) { }

		[Address(RVA = "0x27F45E0", Offset = "0x27F39E0", Length = "0x97")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CDE")]
		public static long cvtss_si64(v128 a) { }

		[Address(RVA = "0x27F4680", Offset = "0x27F3A80", Length = "0x1D")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CE1")]
		public static int cvtt_ss2si(v128 a) { }

		[Address(RVA = "0x27F46A0", Offset = "0x27F3AA0", Length = "0x68")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CE0")]
		public static int cvttss_si32(v128 a) { }

		[Address(RVA = "0x27F4710", Offset = "0x27F3B10", Length = "0x6C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CE2")]
		public static long cvttss_si64(v128 a) { }

		[Address(RVA = "0x27F4780", Offset = "0x27F3B80", Length = "0x43")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CA9")]
		public static v128 div_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F47D0", Offset = "0x27F3BD0", Length = "0x17")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CA8")]
		public static v128 div_ss(v128 a, v128 b) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C9A")]
		public static bool get_IsSseSupported() { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C9B")]
		public static v128 load_ps(Void* ptr) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C9C")]
		public static v128 loadu_ps(Void* ptr) { }

		[Address(RVA = "0x27F47F0", Offset = "0x27F3BF0", Length = "0x17")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CF2")]
		public static v128 loadu_si16(Void* mem_addr) { }

		[Address(RVA = "0x27F4810", Offset = "0x27F3C10", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CF4")]
		public static v128 loadu_si64(Void* mem_addr) { }

		[Address(RVA = "0x27F4830", Offset = "0x27F3C30", Length = "0xBB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CB3")]
		public static v128 max_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F48F0", Offset = "0x27F3CF0", Length = "0x76")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CB2")]
		public static v128 max_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4970", Offset = "0x27F3D70", Length = "0xBB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CB1")]
		public static v128 min_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F4A30", Offset = "0x27F3E30", Length = "0x76")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CB0")]
		public static v128 min_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4AB0", Offset = "0x27F3EB0", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CE8")]
		public static v128 move_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4AC0", Offset = "0x27F3EC0", Length = "0x1D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CED")]
		public static v128 movehl_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F4AE0", Offset = "0x27F3EE0", Length = "0x1B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CEE")]
		public static v128 movelh_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F4B00", Offset = "0x27F3F00", Length = "0x2F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CEF")]
		public static int movemask_ps(v128 a) { }

		[Address(RVA = "0x27F4B30", Offset = "0x27F3F30", Length = "0x43")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CA7")]
		public static v128 mul_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F4B80", Offset = "0x27F3F80", Length = "0x17")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CA6")]
		public static v128 mul_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4BA0", Offset = "0x27F3FA0", Length = "0x29")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CB6")]
		public static v128 or_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F4BD0", Offset = "0x27F3FD0", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CAD")]
		public static v128 rcp_ps(v128 a) { }

		[Address(RVA = "0x27F4C10", Offset = "0x27F4010", Length = "0x1A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CAC")]
		public static v128 rcp_ss(v128 a) { }

		[Address(RVA = "0x27F4C30", Offset = "0x27F4030", Length = "0x11E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CAF")]
		public static v128 rsqrt_ps(v128 a) { }

		[Address(RVA = "0x27F4D50", Offset = "0x27F4150", Length = "0x87")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CAE")]
		public static v128 rsqrt_ss(v128 a) { }

		[Address(RVA = "0x27F4E10", Offset = "0x27F4210", Length = "0x1D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CE6")]
		public static v128 set_ps(float e3, float e2, float e1, float e0) { }

		[Address(RVA = "0x27F4DF0", Offset = "0x27F41F0", Length = "0x1A")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CE5")]
		public static v128 set_ps1(float a) { }

		[Address(RVA = "0x27F4E30", Offset = "0x27F4230", Length = "0x11")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CE3")]
		public static v128 set_ss(float a) { }

		[Address(RVA = "0x27F4DE0", Offset = "0x27F41E0", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CE4")]
		public static v128 set1_ps(float a) { }

		[Address(RVA = "0x27F4E50", Offset = "0x27F4250", Length = "0x1D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CE7")]
		public static v128 setr_ps(float e3, float e2, float e1, float e0) { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CF1")]
		public static v128 setzero_ps() { }

		[Address(RVA = "0x27F3990", Offset = "0x27F2D90", Length = "0x22")]
		[Token(Token = "0x6000CE9")]
		public static int SHUFFLE(int d, int c, int b, int a) { }

		[Address(RVA = "0x27F4E70", Offset = "0x27F4270", Length = "0x42")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CEA")]
		public static v128 shuffle_ps(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27F4EC0", Offset = "0x27F42C0", Length = "0xEA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CAB")]
		public static v128 sqrt_ps(v128 a) { }

		[Address(RVA = "0x27F4FB0", Offset = "0x27F43B0", Length = "0x7B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CAA")]
		public static v128 sqrt_ss(v128 a) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C9D")]
		public static void store_ps(Void* ptr, v128 val) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C9E")]
		public static void storeu_ps(Void* ptr, v128 val) { }

		[Address(RVA = "0x1E88D70", Offset = "0x1E88170", Length = "0x7")]
		[Token(Token = "0x6000CF3")]
		public static void storeu_si16(Void* mem_addr, v128 a) { }

		[Address(RVA = "0xE9E120", Offset = "0xE9D520", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CF5")]
		public static void storeu_si64(Void* mem_addr, v128 a) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000C9F")]
		public static void stream_ps(Void* mem_addr, v128 a) { }

		[Address(RVA = "0x27F5030", Offset = "0x27F4430", Length = "0x43")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CA5")]
		public static v128 sub_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F5080", Offset = "0x27F4480", Length = "0x17")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CA4")]
		public static v128 sub_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F39C0", Offset = "0x27F2DC0", Length = "0x16D")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CF0")]
		public static void TRANSPOSE4_PS(ref v128 row0, ref v128 row1, ref v128 row2, ref v128 row3) { }

		[Address(RVA = "0x27F43F0", Offset = "0x27F37F0", Length = "0x14")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CD6")]
		public static int ucomieq_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4410", Offset = "0x27F3810", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CDA")]
		public static int ucomige_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4420", Offset = "0x27F3820", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CD9")]
		public static int ucomigt_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4430", Offset = "0x27F3830", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CD8")]
		public static int ucomile_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4440", Offset = "0x27F3840", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CD7")]
		public static int ucomilt_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F4450", Offset = "0x27F3850", Length = "0x14")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CDB")]
		public static int ucomineq_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27F50A0", Offset = "0x27F44A0", Length = "0x1D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CEB")]
		public static v128 unpackhi_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F50C0", Offset = "0x27F44C0", Length = "0x1B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CEC")]
		public static v128 unpacklo_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27F50E0", Offset = "0x27F44E0", Length = "0x29")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CB7")]
		public static v128 xor_ps(v128 a, v128 b) { }

	}

	[Token(Token = "0x200004A")]
	internal static class Sse2
	{

		[Token(Token = "0x17000049")]
		public static bool IsSse2Supported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000CF6")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27F78A0", Offset = "0x27F6CA0", Length = "0x6B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CFD")]
		public static v128 add_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F7910", Offset = "0x27F6D10", Length = "0x29")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CFE")]
		public static v128 add_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27F7940", Offset = "0x27F6D40", Length = "0x19")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CFF")]
		public static v128 add_epi64(v128 a, v128 b) { }

		[Address(RVA = "0x27F7960", Offset = "0x27F6D60", Length = "0x92")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CFC")]
		public static v128 add_epi8(v128 a, v128 b) { }

		[Address(RVA = "0x27F7A00", Offset = "0x27F6E00", Length = "0x21")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D63")]
		public static v128 add_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F7A30", Offset = "0x27F6E30", Length = "0x19")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D62")]
		public static v128 add_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F7A50", Offset = "0x27F6E50", Length = "0x7D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D01")]
		public static v128 adds_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F7AD0", Offset = "0x27F6ED0", Length = "0x7C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D00")]
		public static v128 adds_epi8(v128 a, v128 b) { }

		[Address(RVA = "0x27F7B50", Offset = "0x27F6F50", Length = "0x7D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D03")]
		public static v128 adds_epu16(v128 a, v128 b) { }

		[Address(RVA = "0x27F7BD0", Offset = "0x27F6FD0", Length = "0x7C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D02")]
		public static v128 adds_epu8(v128 a, v128 b) { }

		[Address(RVA = "0x27F7C50", Offset = "0x27F7050", Length = "0x19")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D70")]
		public static v128 and_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F7C50", Offset = "0x27F7050", Length = "0x19")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D2C")]
		public static v128 and_si128(v128 a, v128 b) { }

		[Address(RVA = "0x27F7C70", Offset = "0x27F7070", Length = "0x1F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D71")]
		public static v128 andnot_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F7C70", Offset = "0x27F7070", Length = "0x1F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D2D")]
		public static v128 andnot_si128(v128 a, v128 b) { }

		[Address(RVA = "0x27F7C90", Offset = "0x27F7090", Length = "0xBD")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D05")]
		public static v128 avg_epu16(v128 a, v128 b) { }

		[Address(RVA = "0x27F7D50", Offset = "0x27F7150", Length = "0xD0")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D04")]
		public static v128 avg_epu8(v128 a, v128 b) { }

		[Address(RVA = "0x27F7E20", Offset = "0x27F7220", Length = "0xBC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D19")]
		public static v128 bslli_si128(v128 a, int imm8) { }

		[Address(RVA = "0x27F7EE0", Offset = "0x27F72E0", Length = "0xD9")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D1A")]
		public static v128 bsrli_si128(v128 a, int imm8) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DB7")]
		public static void clflush(Void* ptr) { }

		[Address(RVA = "0x27F7FC0", Offset = "0x27F73C0", Length = "0xCF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D31")]
		public static v128 cmpeq_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F8090", Offset = "0x27F7490", Length = "0x67")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D32")]
		public static v128 cmpeq_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27F8100", Offset = "0x27F7500", Length = "0x3F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D30")]
		public static v128 cmpeq_epi8(v128 a, v128 b) { }

		[Address(RVA = "0x27F8140", Offset = "0x27F7540", Length = "0x42")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D80")]
		public static v128 cmpeq_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8190", Offset = "0x27F7590", Length = "0x34")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D74")]
		public static v128 cmpeq_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F81D0", Offset = "0x27F75D0", Length = "0x34")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D84")]
		public static v128 cmpge_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8210", Offset = "0x27F7610", Length = "0x36")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D78")]
		public static v128 cmpge_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8250", Offset = "0x27F7650", Length = "0xCF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D34")]
		public static v128 cmpgt_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F8320", Offset = "0x27F7720", Length = "0x67")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D35")]
		public static v128 cmpgt_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27F8390", Offset = "0x27F7790", Length = "0x3F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D33")]
		public static v128 cmpgt_epi8(v128 a, v128 b) { }

		[Address(RVA = "0x27F83D0", Offset = "0x27F77D0", Length = "0x34")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D83")]
		public static v128 cmpgt_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8410", Offset = "0x27F7810", Length = "0x36")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D77")]
		public static v128 cmpgt_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8450", Offset = "0x27F7850", Length = "0x34")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D82")]
		public static v128 cmple_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8490", Offset = "0x27F7890", Length = "0x22")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D76")]
		public static v128 cmple_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F84C0", Offset = "0x27F78C0", Length = "0x11A")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D37")]
		public static v128 cmplt_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F85E0", Offset = "0x27F79E0", Length = "0x88")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D38")]
		public static v128 cmplt_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27F8670", Offset = "0x27F7A70", Length = "0x5C")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D36")]
		public static v128 cmplt_epi8(v128 a, v128 b) { }

		[Address(RVA = "0x27F86D0", Offset = "0x27F7AD0", Length = "0x34")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D81")]
		public static v128 cmplt_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8710", Offset = "0x27F7B10", Length = "0x22")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D75")]
		public static v128 cmplt_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8740", Offset = "0x27F7B40", Length = "0x42")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D87")]
		public static v128 cmpneq_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8790", Offset = "0x27F7B90", Length = "0x34")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D7B")]
		public static v128 cmpneq_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F87D0", Offset = "0x27F7BD0", Length = "0x34")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D8B")]
		public static v128 cmpnge_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8810", Offset = "0x27F7C10", Length = "0x36")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D7F")]
		public static v128 cmpnge_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8850", Offset = "0x27F7C50", Length = "0x34")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D8A")]
		public static v128 cmpngt_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8890", Offset = "0x27F7C90", Length = "0x36")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D7E")]
		public static v128 cmpngt_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F88D0", Offset = "0x27F7CD0", Length = "0x34")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D89")]
		public static v128 cmpnle_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8910", Offset = "0x27F7D10", Length = "0x22")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D7D")]
		public static v128 cmpnle_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8940", Offset = "0x27F7D40", Length = "0x34")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D88")]
		public static v128 cmpnlt_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8980", Offset = "0x27F7D80", Length = "0x22")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D7C")]
		public static v128 cmpnlt_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F89B0", Offset = "0x27F7DB0", Length = "0x9C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D85")]
		public static v128 cmpord_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8A50", Offset = "0x27F7E50", Length = "0x63")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D79")]
		public static v128 cmpord_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8AC0", Offset = "0x27F7EC0", Length = "0x9C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D86")]
		public static v128 cmpunord_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8B60", Offset = "0x27F7F60", Length = "0x63")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D7A")]
		public static v128 cmpunord_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8BD0", Offset = "0x27F7FD0", Length = "0x15")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D8C")]
		public static int comieq_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8BF0", Offset = "0x27F7FF0", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D90")]
		public static int comige_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8C00", Offset = "0x27F8000", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D8F")]
		public static int comigt_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8C10", Offset = "0x27F8010", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D8E")]
		public static int comile_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8C20", Offset = "0x27F8020", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D8D")]
		public static int comilt_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8C30", Offset = "0x27F8030", Length = "0x15")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D91")]
		public static int comineq_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8C50", Offset = "0x27F8050", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D39")]
		public static v128 cvtepi32_pd(v128 a) { }

		[Address(RVA = "0x27F8C70", Offset = "0x27F8070", Length = "0x36")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D3D")]
		public static v128 cvtepi32_ps(v128 a) { }

		[Address(RVA = "0x27F8CB0", Offset = "0x27F80B0", Length = "0x75")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D9A")]
		public static v128 cvtpd_epi32(v128 a) { }

		[Address(RVA = "0x27F8D30", Offset = "0x27F8130", Length = "0x24")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D98")]
		public static v128 cvtpd_ps(v128 a) { }

		[Address(RVA = "0x27F8D60", Offset = "0x27F8160", Length = "0xA3")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DA5")]
		public static v128 cvtps_epi32(v128 a) { }

		[Address(RVA = "0x27F8E10", Offset = "0x27F8210", Length = "0x1C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D99")]
		public static v128 cvtps_pd(v128 a) { }

		[Address(RVA = "0x20205C0", Offset = "0x201F9C0", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D9F")]
		public static double cvtsd_f64(v128 a) { }

		[Address(RVA = "0x27F8E30", Offset = "0x27F8230", Length = "0x4D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D9B")]
		public static int cvtsd_si32(v128 a) { }

		[Address(RVA = "0x27F8E80", Offset = "0x27F8280", Length = "0x4E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D9C")]
		public static long cvtsd_si64(v128 a) { }

		[Address(RVA = "0x27F8ED0", Offset = "0x27F82D0", Length = "0x5A")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D9D")]
		public static long cvtsd_si64x(v128 a) { }

		[Address(RVA = "0x27F8F30", Offset = "0x27F8330", Length = "0x17")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D9E")]
		public static v128 cvtsd_ss(v128 a, v128 b) { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D41")]
		public static int cvtsi128_si32(v128 a) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D42")]
		public static long cvtsi128_si64(v128 a) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D43")]
		public static long cvtsi128_si64x(v128 a) { }

		[Address(RVA = "0x27F8F50", Offset = "0x27F8350", Length = "0x17")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D3A")]
		public static v128 cvtsi32_sd(v128 a, int b) { }

		[Address(RVA = "0x27F8F70", Offset = "0x27F8370", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D3E")]
		public static v128 cvtsi32_si128(int a) { }

		[Address(RVA = "0x27F8F80", Offset = "0x27F8380", Length = "0x16")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D3B")]
		public static v128 cvtsi64_sd(v128 a, long b) { }

		[Address(RVA = "0x27F8FA0", Offset = "0x27F83A0", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D3F")]
		public static v128 cvtsi64_si128(long a) { }

		[Address(RVA = "0x27F8FB0", Offset = "0x27F83B0", Length = "0x1E")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D3C")]
		public static v128 cvtsi64x_sd(v128 a, long b) { }

		[Address(RVA = "0x27F8FD0", Offset = "0x27F83D0", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D40")]
		public static v128 cvtsi64x_si128(long a) { }

		[Address(RVA = "0x27F8FF0", Offset = "0x27F83F0", Length = "0x1C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DA0")]
		public static v128 cvtss_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F9010", Offset = "0x27F8410", Length = "0x1A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DA1")]
		public static v128 cvttpd_epi32(v128 a) { }

		[Address(RVA = "0x27F9030", Offset = "0x27F8430", Length = "0x22")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DA6")]
		public static v128 cvttps_epi32(v128 a) { }

		[Address(RVA = "0x27F9060", Offset = "0x27F8460", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DA2")]
		public static int cvttsd_si32(v128 a) { }

		[Address(RVA = "0x27F9070", Offset = "0x27F8470", Length = "0x6")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DA3")]
		public static long cvttsd_si64(v128 a) { }

		[Address(RVA = "0x27F9070", Offset = "0x27F8470", Length = "0x6")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DA4")]
		public static long cvttsd_si64x(v128 a) { }

		[Address(RVA = "0x27F9080", Offset = "0x27F8480", Length = "0x21")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D65")]
		public static v128 div_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F90B0", Offset = "0x27F84B0", Length = "0x19")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D64")]
		public static v128 div_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F90D0", Offset = "0x27F84D0", Length = "0x8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D54")]
		public static ushort extract_epi16(v128 a, int imm8) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000CF6")]
		public static bool get_IsSse2Supported() { }

		[Address(RVA = "0x27F90E0", Offset = "0x27F84E0", Length = "0x13")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D55")]
		public static v128 insert_epi16(v128 a, int i, int imm8) { }

		[Address(RVA = "0x27F9100", Offset = "0x27F8500", Length = "0x25")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DB3")]
		public static v128 load_si128(Void* ptr) { }

		[Address(RVA = "0x27F9100", Offset = "0x27F8500", Length = "0x25")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DB4")]
		public static v128 loadu_si128(Void* ptr) { }

		[Address(RVA = "0x27F9130", Offset = "0x27F8530", Length = "0x30")]
		[Token(Token = "0x6000DB1")]
		public static v128 loadu_si32(Void* mem_addr) { }

		[Address(RVA = "0x27F9160", Offset = "0x27F8560", Length = "0x95")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D06")]
		public static v128 madd_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F9200", Offset = "0x27F8600", Length = "0xB1")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D07")]
		public static v128 max_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F92C0", Offset = "0x27F86C0", Length = "0xAF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D08")]
		public static v128 max_epu8(v128 a, v128 b) { }

		[Address(RVA = "0x27F9370", Offset = "0x27F8770", Length = "0x8D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D67")]
		public static v128 max_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F9400", Offset = "0x27F8800", Length = "0x7E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D66")]
		public static v128 max_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F9480", Offset = "0x27F8880", Length = "0xB1")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D09")]
		public static v128 min_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F9540", Offset = "0x27F8940", Length = "0xAF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D0A")]
		public static v128 min_epu8(v128 a, v128 b) { }

		[Address(RVA = "0x27F95F0", Offset = "0x27F89F0", Length = "0x8D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D69")]
		public static v128 min_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F9680", Offset = "0x27F8A80", Length = "0x7E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D68")]
		public static v128 min_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F4810", Offset = "0x27F3C10", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D50")]
		public static v128 move_epi64(v128 a) { }

		[Address(RVA = "0x27F9700", Offset = "0x27F8B00", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DB0")]
		public static v128 move_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F9720", Offset = "0x27F8B20", Length = "0x60")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D56")]
		public static int movemask_epi8(v128 a) { }

		[Address(RVA = "0x27F9780", Offset = "0x27F8B80", Length = "0x17")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DAE")]
		public static int movemask_pd(v128 a) { }

		[Address(RVA = "0x27F97A0", Offset = "0x27F8BA0", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D0E")]
		public static v128 mul_epu32(v128 a, v128 b) { }

		[Address(RVA = "0x27F97C0", Offset = "0x27F8BC0", Length = "0x21")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D6B")]
		public static v128 mul_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F97F0", Offset = "0x27F8BF0", Length = "0x19")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D6A")]
		public static v128 mul_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F9810", Offset = "0x27F8C10", Length = "0xB7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D0B")]
		public static v128 mulhi_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F98D0", Offset = "0x27F8CD0", Length = "0xB7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D0C")]
		public static v128 mulhi_epu16(v128 a, v128 b) { }

		[Address(RVA = "0x27F9990", Offset = "0x27F8D90", Length = "0x9D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D0D")]
		public static v128 mullo_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F9A30", Offset = "0x27F8E30", Length = "0x19")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D72")]
		public static v128 or_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27F9A30", Offset = "0x27F8E30", Length = "0x19")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D2E")]
		public static v128 or_si128(v128 a, v128 b) { }

		[Address(RVA = "0x27F9A50", Offset = "0x27F8E50", Length = "0x87")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D51")]
		public static v128 packs_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F9AE0", Offset = "0x27F8EE0", Length = "0x89")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D52")]
		public static v128 packs_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27F9B70", Offset = "0x27F8F70", Length = "0x87")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D53")]
		public static v128 packus_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F9C00", Offset = "0x27F9000", Length = "0x11D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D0F")]
		public static v128 sad_epu8(v128 a, v128 b) { }

		[Address(RVA = "0x27F9DA0", Offset = "0x27F91A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D46")]
		public static v128 set_epi16(short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0) { }

		[Address(RVA = "0x27F9DE0", Offset = "0x27F91E0", Length = "0x15")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D45")]
		public static v128 set_epi32(int e3, int e2, int e1, int e0) { }

		[Address(RVA = "0x27F9E00", Offset = "0x27F9200", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D44")]
		public static v128 set_epi64x(long e1, long e0) { }

		[Address(RVA = "0x27F9E10", Offset = "0x27F9210", Length = "0x7C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D47")]
		public static v128 set_epi8(sbyte e15_, sbyte e14_, sbyte e13_, sbyte e12_, sbyte e11_, sbyte e10_, sbyte e9_, sbyte e8_, sbyte e7_, sbyte e6_, sbyte e5_, sbyte e4_, sbyte e3_, sbyte e2_, sbyte e1_, sbyte e0_) { }

		[Address(RVA = "0x27F9EA0", Offset = "0x27F92A0", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DAA")]
		public static v128 set_pd(double e1, double e0) { }

		[Address(RVA = "0x27F9E90", Offset = "0x27F9290", Length = "0xE")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DA9")]
		public static v128 set_pd1(double a) { }

		[Address(RVA = "0x27F9EB0", Offset = "0x27F92B0", Length = "0x10")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DA7")]
		public static v128 set_sd(double a) { }

		[Address(RVA = "0x27F9D20", Offset = "0x27F9120", Length = "0x23")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D4A")]
		public static v128 set1_epi16(short a) { }

		[Address(RVA = "0x27F9D50", Offset = "0x27F9150", Length = "0xF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D49")]
		public static v128 set1_epi32(int a) { }

		[Address(RVA = "0x27F9D60", Offset = "0x27F9160", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D48")]
		public static v128 set1_epi64x(long a) { }

		[Address(RVA = "0x27F9D70", Offset = "0x27F9170", Length = "0x1D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D4B")]
		public static v128 set1_epi8(sbyte a) { }

		[Address(RVA = "0x27F9D90", Offset = "0x27F9190", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DA8")]
		public static v128 set1_pd(double a) { }

		[Address(RVA = "0x27F9EC0", Offset = "0x27F92C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D4D")]
		public static v128 setr_epi16(short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0) { }

		[Address(RVA = "0x27F9F00", Offset = "0x27F9300", Length = "0x15")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D4C")]
		public static v128 setr_epi32(int e3, int e2, int e1, int e0) { }

		[Address(RVA = "0x27F9F20", Offset = "0x27F9320", Length = "0x7C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D4E")]
		public static v128 setr_epi8(sbyte e15_, sbyte e14_, sbyte e13_, sbyte e12_, sbyte e11_, sbyte e10_, sbyte e9_, sbyte e8_, sbyte e7_, sbyte e6_, sbyte e5_, sbyte e4_, sbyte e3_, sbyte e2_, sbyte e1_, sbyte e0_) { }

		[Address(RVA = "0x27F9FA0", Offset = "0x27F93A0", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DAB")]
		public static v128 setr_pd(double e1, double e0) { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D4F")]
		public static v128 setzero_si128() { }

		[Address(RVA = "0x27F9FB0", Offset = "0x27F93B0", Length = "0x47")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D57")]
		public static v128 shuffle_epi32(v128 a, int imm8) { }

		[Address(RVA = "0x27FA000", Offset = "0x27F9400", Length = "0x23")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DAF")]
		public static v128 shuffle_pd(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27F7890", Offset = "0x27F6C90", Length = "0x6")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CF7")]
		public static int SHUFFLE2(int x, int y) { }

		[Address(RVA = "0x27FA030", Offset = "0x27F9430", Length = "0x55")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D58")]
		public static v128 shufflehi_epi16(v128 a, int imm8) { }

		[Address(RVA = "0x27FA090", Offset = "0x27F9490", Length = "0x4F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D59")]
		public static v128 shufflelo_epi16(v128 a, int imm8) { }

		[Address(RVA = "0x27FA0E0", Offset = "0x27F94E0", Length = "0xEE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D1C")]
		public static v128 sll_epi16(v128 a, v128 count) { }

		[Address(RVA = "0x27FA1D0", Offset = "0x27F95D0", Length = "0xB6")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D1E")]
		public static v128 sll_epi32(v128 a, v128 count) { }

		[Address(RVA = "0x27FA290", Offset = "0x27F9690", Length = "0x97")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D20")]
		public static v128 sll_epi64(v128 a, v128 count) { }

		[Address(RVA = "0x27FA330", Offset = "0x27F9730", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D1B")]
		public static v128 slli_epi16(v128 a, int imm8) { }

		[Address(RVA = "0x27FA3C0", Offset = "0x27F97C0", Length = "0xB7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D1D")]
		public static v128 slli_epi32(v128 a, int imm8) { }

		[Address(RVA = "0x27FA480", Offset = "0x27F9880", Length = "0x98")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D1F")]
		public static v128 slli_epi64(v128 a, int imm8) { }

		[Address(RVA = "0x27FA520", Offset = "0x27F9920", Length = "0xCE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D18")]
		public static v128 slli_si128(v128 a, int imm8) { }

		[Address(RVA = "0x27FA5F0", Offset = "0x27F99F0", Length = "0xA3")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D6D")]
		public static v128 sqrt_pd(v128 a) { }

		[Address(RVA = "0x27FA6A0", Offset = "0x27F9AA0", Length = "0x86")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D6C")]
		public static v128 sqrt_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27FA730", Offset = "0x27F9B30", Length = "0x104")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D22")]
		public static v128 sra_epi16(v128 a, v128 count) { }

		[Address(RVA = "0x27FA840", Offset = "0x27F9C40", Length = "0xA9")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D24")]
		public static v128 sra_epi32(v128 a, v128 count) { }

		[Address(RVA = "0x27FA8F0", Offset = "0x27F9CF0", Length = "0x104")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D21")]
		public static v128 srai_epi16(v128 a, int imm8) { }

		[Address(RVA = "0x27FAA00", Offset = "0x27F9E00", Length = "0xA9")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D23")]
		public static v128 srai_epi32(v128 a, int imm8) { }

		[Address(RVA = "0x27FAAB0", Offset = "0x27F9EB0", Length = "0x11C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D27")]
		public static v128 srl_epi16(v128 a, v128 count) { }

		[Address(RVA = "0x27FABD0", Offset = "0x27F9FD0", Length = "0xAF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D29")]
		public static v128 srl_epi32(v128 a, v128 count) { }

		[Address(RVA = "0x27FAC80", Offset = "0x27FA080", Length = "0xA1")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D2B")]
		public static v128 srl_epi64(v128 a, v128 count) { }

		[Address(RVA = "0x27FAD30", Offset = "0x27FA130", Length = "0x11C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D26")]
		public static v128 srli_epi16(v128 a, int imm8) { }

		[Address(RVA = "0x27FAE50", Offset = "0x27FA250", Length = "0xAF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D28")]
		public static v128 srli_epi32(v128 a, int imm8) { }

		[Address(RVA = "0x27FAF00", Offset = "0x27FA300", Length = "0xA1")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D2A")]
		public static v128 srli_epi64(v128 a, int imm8) { }

		[Address(RVA = "0x27FAFB0", Offset = "0x27FA3B0", Length = "0xCB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D25")]
		public static v128 srli_si128(v128 a, int imm8) { }

		[Address(RVA = "0x27FB080", Offset = "0x27FA480", Length = "0x1E")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DB5")]
		public static void store_si128(Void* ptr, v128 val) { }

		[Address(RVA = "0x27FB080", Offset = "0x27FA480", Length = "0x1E")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DB6")]
		public static void storeu_si128(Void* ptr, v128 val) { }

		[Address(RVA = "0x1E88D80", Offset = "0x1E88180", Length = "0x5")]
		[Token(Token = "0x6000DB2")]
		public static void storeu_si32(Void* mem_addr, v128 a) { }

		[Address(RVA = "0x27FB080", Offset = "0x27FA480", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CFA")]
		public static void stream_pd(Void* mem_addr, v128 a) { }

		[Address(RVA = "0x27FB080", Offset = "0x27FA480", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CFB")]
		public static void stream_si128(Void* mem_addr, v128 a) { }

		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CF8")]
		public static void stream_si32(Int32* mem_addr, int a) { }

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000CF9")]
		public static void stream_si64(Int64* mem_addr, long a) { }

		[Address(RVA = "0x27FB0A0", Offset = "0x27FA4A0", Length = "0x6B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D11")]
		public static v128 sub_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27FB110", Offset = "0x27FA510", Length = "0x2B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D12")]
		public static v128 sub_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27FB140", Offset = "0x27FA540", Length = "0x1B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D13")]
		public static v128 sub_epi64(v128 a, v128 b) { }

		[Address(RVA = "0x27FB160", Offset = "0x27FA560", Length = "0x92")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D10")]
		public static v128 sub_epi8(v128 a, v128 b) { }

		[Address(RVA = "0x27FB200", Offset = "0x27FA600", Length = "0x21")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D6F")]
		public static v128 sub_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27FB230", Offset = "0x27FA630", Length = "0x19")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D6E")]
		public static v128 sub_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27FB250", Offset = "0x27FA650", Length = "0x7D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D15")]
		public static v128 subs_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27FB2D0", Offset = "0x27FA6D0", Length = "0x7C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D14")]
		public static v128 subs_epi8(v128 a, v128 b) { }

		[Address(RVA = "0x27FB350", Offset = "0x27FA750", Length = "0x7D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D17")]
		public static v128 subs_epu16(v128 a, v128 b) { }

		[Address(RVA = "0x27FB3D0", Offset = "0x27FA7D0", Length = "0x7C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D16")]
		public static v128 subs_epu8(v128 a, v128 b) { }

		[Address(RVA = "0x27F8BD0", Offset = "0x27F7FD0", Length = "0x15")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D92")]
		public static int ucomieq_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8BF0", Offset = "0x27F7FF0", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D96")]
		public static int ucomige_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8C00", Offset = "0x27F8000", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D95")]
		public static int ucomigt_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8C10", Offset = "0x27F8010", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D94")]
		public static int ucomile_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8C20", Offset = "0x27F8020", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D93")]
		public static int ucomilt_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27F8C30", Offset = "0x27F8030", Length = "0x15")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D97")]
		public static int ucomineq_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27FB450", Offset = "0x27FA850", Length = "0x57")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D5B")]
		public static v128 unpackhi_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F50A0", Offset = "0x27F44A0", Length = "0x1D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D5C")]
		public static v128 unpackhi_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27FB4B0", Offset = "0x27FA8B0", Length = "0x13")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D5D")]
		public static v128 unpackhi_epi64(v128 a, v128 b) { }

		[Address(RVA = "0x27FB4D0", Offset = "0x27FA8D0", Length = "0x7D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D5A")]
		public static v128 unpackhi_epi8(v128 a, v128 b) { }

		[Address(RVA = "0x27FB4B0", Offset = "0x27FA8B0", Length = "0x13")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DAC")]
		public static v128 unpackhi_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27FB550", Offset = "0x27FA950", Length = "0x47")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D5F")]
		public static v128 unpacklo_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27F50C0", Offset = "0x27F44C0", Length = "0x1B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D60")]
		public static v128 unpacklo_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27FB5A0", Offset = "0x27FA9A0", Length = "0x11")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D61")]
		public static v128 unpacklo_epi64(v128 a, v128 b) { }

		[Address(RVA = "0x27FB5C0", Offset = "0x27FA9C0", Length = "0x89")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D5E")]
		public static v128 unpacklo_epi8(v128 a, v128 b) { }

		[Address(RVA = "0x27FB5A0", Offset = "0x27FA9A0", Length = "0x11")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DAD")]
		public static v128 unpacklo_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27FB650", Offset = "0x27FAA50", Length = "0x19")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D73")]
		public static v128 xor_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27FB650", Offset = "0x27FAA50", Length = "0x19")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000D2F")]
		public static v128 xor_si128(v128 a, v128 b) { }

	}

	[Token(Token = "0x200004B")]
	internal static class Sse3
	{

		[Token(Token = "0x1700004A")]
		public static bool IsSse3Supported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000DB8")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27FB670", Offset = "0x27FAA70", Length = "0x21")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DBA")]
		public static v128 addsub_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27FB6A0", Offset = "0x27FAAA0", Length = "0x41")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DB9")]
		public static v128 addsub_ps(v128 a, v128 b) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000DB8")]
		public static bool get_IsSse3Supported() { }

		[Address(RVA = "0x27FB6F0", Offset = "0x27FAAF0", Length = "0x21")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DBB")]
		public static v128 hadd_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27FB720", Offset = "0x27FAB20", Length = "0x41")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DBC")]
		public static v128 hadd_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27FB770", Offset = "0x27FAB70", Length = "0x21")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DBD")]
		public static v128 hsub_pd(v128 a, v128 b) { }

		[Address(RVA = "0x27FB7A0", Offset = "0x27FABA0", Length = "0x41")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DBE")]
		public static v128 hsub_ps(v128 a, v128 b) { }

		[Address(RVA = "0x27FB7F0", Offset = "0x27FABF0", Length = "0xE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DBF")]
		public static v128 movedup_pd(v128 a) { }

		[Address(RVA = "0x27FB800", Offset = "0x27FAC00", Length = "0x15")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DC0")]
		public static v128 movehdup_ps(v128 a) { }

		[Address(RVA = "0x27FB820", Offset = "0x27FAC20", Length = "0x14")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DC1")]
		public static v128 moveldup_ps(v128 a) { }

	}

	[Token(Token = "0x200004C")]
	internal static class Sse4_1
	{

		[Token(Token = "0x1700004B")]
		public static bool IsSse41Supported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000DC2")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27FB9C0", Offset = "0x27FADC0", Length = "0xA7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DC9")]
		public static v128 blend_epi16(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27FBA70", Offset = "0x27FAE70", Length = "0x35")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DC4")]
		public static v128 blend_pd(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27FBAB0", Offset = "0x27FAEB0", Length = "0x53")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DC5")]
		public static v128 blend_ps(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27FBB10", Offset = "0x27FAF10", Length = "0x45")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DC8")]
		public static v128 blendv_epi8(v128 a, v128 b, v128 mask) { }

		[Address(RVA = "0x27FBB60", Offset = "0x27FAF60", Length = "0x36")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DC6")]
		public static v128 blendv_pd(v128 a, v128 b, v128 mask) { }

		[Address(RVA = "0x27FBBA0", Offset = "0x27FAFA0", Length = "0x56")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DC7")]
		public static v128 blendv_ps(v128 a, v128 b, v128 mask) { }

		[Address(RVA = "0x27FBC00", Offset = "0x27FB000", Length = "0x54")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DF6")]
		public static v128 ceil_pd(v128 a) { }

		[Address(RVA = "0x27FBC60", Offset = "0x27FB060", Length = "0xF0")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DF9")]
		public static v128 ceil_ps(v128 a) { }

		[Address(RVA = "0x27FBD50", Offset = "0x27FB150", Length = "0x3B")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DFC")]
		public static v128 ceil_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27FBD90", Offset = "0x27FB190", Length = "0x87")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DFF")]
		public static v128 ceil_ss(v128 a, v128 b) { }

		[Address(RVA = "0x27FBE20", Offset = "0x27FB220", Length = "0x2F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DDE")]
		public static v128 cmpeq_epi64(v128 a, v128 b) { }

		[Address(RVA = "0x27FBE50", Offset = "0x27FB250", Length = "0x2E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DE2")]
		public static v128 cvtepi16_epi32(v128 a) { }

		[Address(RVA = "0x27FBE80", Offset = "0x27FB280", Length = "0x24")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DE3")]
		public static v128 cvtepi16_epi64(v128 a) { }

		[Address(RVA = "0x27FBEB0", Offset = "0x27FB2B0", Length = "0x14")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DE4")]
		public static v128 cvtepi32_epi64(v128 a) { }

		[Address(RVA = "0x27FBED0", Offset = "0x27FB2D0", Length = "0x44")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DDF")]
		public static v128 cvtepi8_epi16(v128 a) { }

		[Address(RVA = "0x27FBF20", Offset = "0x27FB320", Length = "0x2E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DE0")]
		public static v128 cvtepi8_epi32(v128 a) { }

		[Address(RVA = "0x27FBF50", Offset = "0x27FB350", Length = "0x24")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DE1")]
		public static v128 cvtepi8_epi64(v128 a) { }

		[Address(RVA = "0x27FBF80", Offset = "0x27FB380", Length = "0x2E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DE8")]
		public static v128 cvtepu16_epi32(v128 a) { }

		[Address(RVA = "0x27FBFB0", Offset = "0x27FB3B0", Length = "0x14")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DE9")]
		public static v128 cvtepu16_epi64(v128 a) { }

		[Address(RVA = "0x27FBFD0", Offset = "0x27FB3D0", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DEA")]
		public static v128 cvtepu32_epi64(v128 a) { }

		[Address(RVA = "0x27FBFF0", Offset = "0x27FB3F0", Length = "0x44")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DE5")]
		public static v128 cvtepu8_epi16(v128 a) { }

		[Address(RVA = "0x27FC040", Offset = "0x27FB440", Length = "0x2E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DE6")]
		public static v128 cvtepu8_epi32(v128 a) { }

		[Address(RVA = "0x27FC070", Offset = "0x27FB470", Length = "0x14")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DE7")]
		public static v128 cvtepu8_epi64(v128 a) { }

		[Address(RVA = "0x27FC090", Offset = "0x27FB490", Length = "0x58")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DCA")]
		public static v128 dp_pd(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27FC0F0", Offset = "0x27FB4F0", Length = "0xB1")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DCB")]
		public static v128 dp_ps(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27FC1B0", Offset = "0x27FB5B0", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DCF")]
		public static int extract_epi32(v128 a, int imm8) { }

		[Address(RVA = "0x27FC1C0", Offset = "0x27FB5C0", Length = "0x8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DD0")]
		public static long extract_epi64(v128 a, int imm8) { }

		[Address(RVA = "0x27FC1D0", Offset = "0x27FB5D0", Length = "0x8")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DCE")]
		public static byte extract_epi8(v128 a, int imm8) { }

		[Address(RVA = "0x27FC1B0", Offset = "0x27FB5B0", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DCC")]
		public static int extract_ps(v128 a, int imm8) { }

		[Address(RVA = "0x27FC1E0", Offset = "0x27FB5E0", Length = "0x9")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DCD")]
		public static float extractf_ps(v128 a, int imm8) { }

		[Address(RVA = "0x27FC1F0", Offset = "0x27FB5F0", Length = "0x54")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DF5")]
		public static v128 floor_pd(v128 a) { }

		[Address(RVA = "0x27FC250", Offset = "0x27FB650", Length = "0xF0")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DF8")]
		public static v128 floor_ps(v128 a) { }

		[Address(RVA = "0x27FC340", Offset = "0x27FB740", Length = "0x3B")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DFB")]
		public static v128 floor_sd(v128 a, v128 b) { }

		[Address(RVA = "0x27FC380", Offset = "0x27FB780", Length = "0x87")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DFE")]
		public static v128 floor_ss(v128 a, v128 b) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000DC2")]
		public static bool get_IsSse41Supported() { }

		[Address(RVA = "0x27FC410", Offset = "0x27FB810", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DD3")]
		public static v128 insert_epi32(v128 a, int i, int imm8) { }

		[Address(RVA = "0x27FC430", Offset = "0x27FB830", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DD4")]
		public static v128 insert_epi64(v128 a, long i, int imm8) { }

		[Address(RVA = "0x27FC450", Offset = "0x27FB850", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DD2")]
		public static v128 insert_epi8(v128 a, byte i, int imm8) { }

		[Address(RVA = "0x27FC470", Offset = "0x27FB870", Length = "0x50")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DD1")]
		public static v128 insert_ps(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27FC4C0", Offset = "0x27FB8C0", Length = "0xAE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DD6")]
		public static v128 max_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27FC570", Offset = "0x27FB970", Length = "0xAF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DD5")]
		public static v128 max_epi8(v128 a, v128 b) { }

		[Address(RVA = "0x27FC620", Offset = "0x27FBA20", Length = "0xB1")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DD8")]
		public static v128 max_epu16(v128 a, v128 b) { }

		[Address(RVA = "0x27FC6E0", Offset = "0x27FBAE0", Length = "0xAE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DD7")]
		public static v128 max_epu32(v128 a, v128 b) { }

		[Address(RVA = "0x27FC790", Offset = "0x27FBB90", Length = "0xAE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DDA")]
		public static v128 min_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27FC840", Offset = "0x27FBC40", Length = "0xAF")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DD9")]
		public static v128 min_epi8(v128 a, v128 b) { }

		[Address(RVA = "0x27FC8F0", Offset = "0x27FBCF0", Length = "0xB1")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DDC")]
		public static v128 min_epu16(v128 a, v128 b) { }

		[Address(RVA = "0x27FC9B0", Offset = "0x27FBDB0", Length = "0xAE")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DDB")]
		public static v128 min_epu32(v128 a, v128 b) { }

		[Address(RVA = "0x27FCA60", Offset = "0x27FBE60", Length = "0xC4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E00")]
		public static v128 minpos_epu16(v128 a) { }

		[Address(RVA = "0x27FB840", Offset = "0x27FAC40", Length = "0x10")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E02")]
		public static int MK_INSERTPS_NDX(int srcField, int dstField, int zeroMask) { }

		[Address(RVA = "0x27FCB30", Offset = "0x27FBF30", Length = "0x106")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E01")]
		public static v128 mpsadbw_epu8(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27FCC40", Offset = "0x27FC040", Length = "0x21")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DEB")]
		public static v128 mul_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27FCC70", Offset = "0x27FC070", Length = "0x3D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DEC")]
		public static v128 mullo_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27FCCB0", Offset = "0x27FC0B0", Length = "0x9E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DDD")]
		public static v128 packus_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27FCD50", Offset = "0x27FC150", Length = "0x57")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DF4")]
		public static v128 round_pd(v128 a, int rounding) { }

		[Address(RVA = "0x27FCDB0", Offset = "0x27FC1B0", Length = "0xA7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DF7")]
		public static v128 round_ps(v128 a, int rounding) { }

		[Address(RVA = "0x27FCE60", Offset = "0x27FC260", Length = "0x42")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DFA")]
		public static v128 round_sd(v128 a, v128 b, int rounding) { }

		[Address(RVA = "0x27FCEB0", Offset = "0x27FC2B0", Length = "0x36")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DFD")]
		public static v128 round_ss(v128 a, v128 b, int rounding) { }

		[Address(RVA = "0x27FB850", Offset = "0x27FAC50", Length = "0x169")]
		[Token(Token = "0x6000DF3")]
		private static double RoundDImpl(double d, int roundingMode) { }

		[Address(RVA = "0x27F9100", Offset = "0x27F8500", Length = "0x25")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DC3")]
		public static v128 stream_load_si128(Void* mem_addr) { }

		[Address(RVA = "0x27FCEF0", Offset = "0x27FC2F0", Length = "0x81")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DF2")]
		public static int test_all_ones(v128 a) { }

		[Address(RVA = "0x27FCF80", Offset = "0x27FC380", Length = "0x26")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DF0")]
		public static int test_all_zeros(v128 a, v128 mask) { }

		[Address(RVA = "0x27FCFB0", Offset = "0x27FC3B0", Length = "0x59")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DF1")]
		public static int test_mix_ones_zeroes(v128 a, v128 mask) { }

		[Address(RVA = "0x27FD010", Offset = "0x27FC410", Length = "0x22")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DEE")]
		public static int testc_si128(v128 a, v128 b) { }

		[Address(RVA = "0x27FD040", Offset = "0x27FC440", Length = "0x46")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DEF")]
		public static int testnzc_si128(v128 a, v128 b) { }

		[Address(RVA = "0x27FD090", Offset = "0x27FC490", Length = "0x1C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000DED")]
		public static int testz_si128(v128 a, v128 b) { }

	}

	[Token(Token = "0x200004D")]
	internal static class Sse4_2
	{
		[Flags]
		[Token(Token = "0x200004E")]
		internal enum SIDD : int
		{
			UBYTE_OPS = 0,
			UWORD_OPS = 1,
			SBYTE_OPS = 2,
			SWORD_OPS = 3,
			CMP_EQUAL_ANY = 0,
			CMP_RANGES = 4,
			CMP_EQUAL_EACH = 8,
			CMP_EQUAL_ORDERED = 12,
			POSITIVE_POLARITY = 0,
			NEGATIVE_POLARITY = 16,
			MASKED_POSITIVE_POLARITY = 32,
			MASKED_NEGATIVE_POLARITY = 48,
			LEAST_SIGNIFICANT = 0,
			MOST_SIGNIFICANT = 64,
			BIT_MASK = 0,
			UNIT_MASK = 64,
		}

		[Token(Token = "0x200004F")]
		private struct StrBoolArray
		{
			[CompilerGenerated]
			[Token(Token = "0x2000050")]
			[UnsafeValueType]
			internal struct <Bits>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x40002D1")]
				public ushort FixedElementField; //Field offset: 0x0

			}

			[FieldOffset(Offset = "0x0")]
			[FixedBuffer(typeof(ushort), 16)]
			[Token(Token = "0x40002D0")]
			public <Bits>e__FixedBuffer Bits; //Field offset: 0x0

			[Address(RVA = "0x27FF1C0", Offset = "0x27FE5C0", Length = "0x23")]
			[Token(Token = "0x6000E22")]
			public bool GetBit(int aindex, int bindex) { }

			[Address(RVA = "0x27FF1F0", Offset = "0x27FE5F0", Length = "0x29")]
			[Token(Token = "0x6000E21")]
			public void SetBit(int aindex, int bindex, bool val) { }

		}

		[Token(Token = "0x40002BE")]
		private static readonly UInt32[] crctab; //Field offset: 0x0

		[Token(Token = "0x1700004C")]
		public static bool IsSse42Supported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000E03")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27FD100", Offset = "0x27FC500", Length = "0x8C")]
		[Token(Token = "0x6000E20")]
		private static Sse4_2() { }

		[Address(RVA = "0x27FD190", Offset = "0x27FC590", Length = "0x234")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E19")]
		public static int cmpestra(v128 a, int la, v128 b, int lb, int imm8) { }

		[Address(RVA = "0x27FD3D0", Offset = "0x27FC7D0", Length = "0x1BA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E16")]
		public static int cmpestrc(v128 a, int la, v128 b, int lb, int imm8) { }

		[Address(RVA = "0x27FD590", Offset = "0x27FC990", Length = "0x1CC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E0F")]
		public static int cmpestri(v128 a, int la, v128 b, int lb, int imm8) { }

		[Address(RVA = "0x9F8870", Offset = "0x9F7C70", Length = "0xC9")]
		[Token(Token = "0x6000E08")]
		private static int cmpestri_emulation(T* a, int alen, T* b, int blen, int len, int imm8, int allOnes, T allOnesT) { }

		[Address(RVA = "0x27FD760", Offset = "0x27FCB60", Length = "0x217")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E0E")]
		public static v128 cmpestrm(v128 a, int la, v128 b, int lb, int imm8) { }

		[Address(RVA = "0x9F8C80", Offset = "0x9F8080", Length = "0x117")]
		[Token(Token = "0x6000E05")]
		private static v128 cmpestrm_emulation(T* a, int alen, T* b, int blen, int len, int imm8, int allOnes, T allOnesT) { }

		[Address(RVA = "0x27FD980", Offset = "0x27FCD80", Length = "0x1B4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E18")]
		public static int cmpestro(v128 a, int la, v128 b, int lb, int imm8) { }

		[Address(RVA = "0x27FDB40", Offset = "0x27FCF40", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E17")]
		public static int cmpestrs(v128 a, int la, v128 b, int lb, int imm8) { }

		[Address(RVA = "0x27FDB70", Offset = "0x27FCF70", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E15")]
		public static int cmpestrz(v128 a, int la, v128 b, int lb, int imm8) { }

		[Address(RVA = "0x27FDBA0", Offset = "0x27FCFA0", Length = "0x2F")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E1A")]
		public static v128 cmpgt_epi64(v128 val1, v128 val2) { }

		[Address(RVA = "0x27FDBD0", Offset = "0x27FCFD0", Length = "0x128")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E14")]
		public static int cmpistra(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27FDD00", Offset = "0x27FD100", Length = "0x243")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E11")]
		public static int cmpistrc(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27FDF50", Offset = "0x27FD350", Length = "0x1B1")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E0D")]
		public static int cmpistri(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x9F9270", Offset = "0x9F8670", Length = "0xE0")]
		[Token(Token = "0x6000E07")]
		private static int cmpistri_emulation(T* a, T* b, int len, int imm8, int allOnes, T allOnesT) { }

		[Address(RVA = "0x27FE110", Offset = "0x27FD510", Length = "0x1C4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E0C")]
		public static v128 cmpistrm(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x9F96E0", Offset = "0x9F8AE0", Length = "0x136")]
		[Token(Token = "0x6000E04")]
		private static v128 cmpistrm_emulation(T* a, T* b, int len, int imm8, int allOnes, T allOnesT) { }

		[Address(RVA = "0x27FE2E0", Offset = "0x27FD6E0", Length = "0x245")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E13")]
		public static int cmpistro(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27FE530", Offset = "0x27FD930", Length = "0xCB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E12")]
		public static int cmpistrs(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x27FE600", Offset = "0x27FDA00", Length = "0xCB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E10")]
		public static int cmpistrz(v128 a, v128 b, int imm8) { }

		[Address(RVA = "0x9F6670", Offset = "0x9F5A70", Length = "0x53A")]
		[Token(Token = "0x6000E0B")]
		private static int ComputeStrCmpIntRes2(T* a, int alen, T* b, int blen, int len, int imm8, int allOnes) { }

		[Address(RVA = "0x9F8270", Offset = "0x9F7670", Length = "0xA2")]
		[Token(Token = "0x6000E0A")]
		private static int ComputeStringLength(T* ptr, int max) { }

		[Address(RVA = "0x27FD0B0", Offset = "0x27FC4B0", Length = "0x46")]
		[Token(Token = "0x6000E09")]
		private static int ComputeStriOutput(int len, int imm8, int intRes2) { }

		[Address(RVA = "0x9F86A0", Offset = "0x9F7AA0", Length = "0x4F")]
		[Token(Token = "0x6000E06")]
		private static v128 ComputeStrmOutput(int len, int imm8, T allOnesT, int intRes2) { }

		[Address(RVA = "0x27FE6D0", Offset = "0x27FDAD0", Length = "0x68")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E1D")]
		public static uint crc32_u16(uint crc, ushort v) { }

		[Address(RVA = "0x27FE740", Offset = "0x27FDB40", Length = "0x92")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E1B")]
		public static uint crc32_u32(uint crc, uint v) { }

		[Address(RVA = "0x27FE8F0", Offset = "0x27FDCF0", Length = "0xD2")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E1F")]
		public static ulong crc32_u64(ulong crc_ul, ulong v) { }

		[Address(RVA = "0x27FE7E0", Offset = "0x27FDBE0", Length = "0x103")]
		[DebuggerStepThrough]
		[Obsolete("Use the ulong version of this intrinsic instead.")]
		[Token(Token = "0x6000E1E")]
		public static ulong crc32_u64(ulong crc_ul, long v) { }

		[Address(RVA = "0x27FE9D0", Offset = "0x27FDDD0", Length = "0x85")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E1C")]
		public static uint crc32_u8(uint crc, byte v) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000E03")]
		public static bool get_IsSse42Supported() { }

	}

	[Token(Token = "0x2000051")]
	internal static class Ssse3
	{

		[Token(Token = "0x1700004D")]
		public static bool IsSsse3Supported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000E23")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27FEA60", Offset = "0x27FDE60", Length = "0x9B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E25")]
		public static v128 abs_epi16(v128 a) { }

		[Address(RVA = "0x27FEB00", Offset = "0x27FDF00", Length = "0x97")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E26")]
		public static v128 abs_epi32(v128 a) { }

		[Address(RVA = "0x27FEBA0", Offset = "0x27FDFA0", Length = "0x99")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E24")]
		public static v128 abs_epi8(v128 a) { }

		[Address(RVA = "0x27FEC40", Offset = "0x27FE040", Length = "0x94")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E28")]
		public static v128 alignr_epi8(v128 a, v128 b, int count) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000E23")]
		public static bool get_IsSsse3Supported() { }

		[Address(RVA = "0x27FECE0", Offset = "0x27FE0E0", Length = "0x79")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E29")]
		public static v128 hadd_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27FED60", Offset = "0x27FE160", Length = "0x29")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E2B")]
		public static v128 hadd_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27FED90", Offset = "0x27FE190", Length = "0x80")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E2A")]
		public static v128 hadds_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27FEE10", Offset = "0x27FE210", Length = "0x6B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E2C")]
		public static v128 hsub_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27FEE80", Offset = "0x27FE280", Length = "0x29")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E2E")]
		public static v128 hsub_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27FEEB0", Offset = "0x27FE2B0", Length = "0x80")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E2D")]
		public static v128 hsubs_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27FEF30", Offset = "0x27FE330", Length = "0x8C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E2F")]
		public static v128 maddubs_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27FEFC0", Offset = "0x27FE3C0", Length = "0xD6")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E30")]
		public static v128 mulhrs_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27FF0A0", Offset = "0x27FE4A0", Length = "0x3A")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E27")]
		public static v128 shuffle_epi8(v128 a, v128 b) { }

		[Address(RVA = "0x27FF0E0", Offset = "0x27FE4E0", Length = "0x43")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E32")]
		public static v128 sign_epi16(v128 a, v128 b) { }

		[Address(RVA = "0x27FF130", Offset = "0x27FE530", Length = "0x3D")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E33")]
		public static v128 sign_epi32(v128 a, v128 b) { }

		[Address(RVA = "0x27FF170", Offset = "0x27FE570", Length = "0x41")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000E31")]
		public static v128 sign_epi8(v128 a, v128 b) { }

	}


	[Token(Token = "0x17000040")]
	public static MXCSRBits MXCSR
	{
		[Address(RVA = "0x27F6850", Offset = "0x27F5C50", Length = "0x7")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[Token(Token = "0x6000AC8")]
		 get { } //Length: 7
		[Address(RVA = "0x27F6860", Offset = "0x27F5C60", Length = "0x7")]
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[Token(Token = "0x6000AC9")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000AC3")]
	private static int BurstIntrinsicGetCSRFromManaged() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AC2")]
	private static void BurstIntrinsicSetCSRFromManaged(int _) { }

	[Address(RVA = "0x27F6850", Offset = "0x27F5C50", Length = "0x7")]
	[BurstCompile(CompileSynchronously = True)]
	[MonoPInvokeCallback(typeof(DoGetCSRTrampoline_0000012A$PostfixBurstDelegate))]
	[Token(Token = "0x6000AC7")]
	private static int DoGetCSRTrampoline() { }

	[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
	[BurstCompile(CompileSynchronously = True)]
	[Token(Token = "0x6000ACB")]
	internal static int DoGetCSRTrampoline$BurstManaged() { }

	[Address(RVA = "0x27F6860", Offset = "0x27F5C60", Length = "0x7")]
	[BurstCompile(CompileSynchronously = True)]
	[MonoPInvokeCallback(typeof(DoSetCSRTrampoline_00000129$PostfixBurstDelegate))]
	[Token(Token = "0x6000AC6")]
	private static void DoSetCSRTrampoline(int bits) { }

	[Address(RVA = "0x945130", Offset = "0x944530", Length = "0x3")]
	[BurstCompile(CompileSynchronously = True)]
	[Token(Token = "0x6000ACA")]
	internal static void DoSetCSRTrampoline$BurstManaged(int bits) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x6000ABA")]
	private static v128 GenericCSharpLoad(Void* ptr) { }

	[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
	[Token(Token = "0x6000ABB")]
	private static void GenericCSharpStore(Void* ptr, v128 val) { }

	[Address(RVA = "0x27F6850", Offset = "0x27F5C50", Length = "0x7")]
	[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
	[Token(Token = "0x6000AC8")]
	public static MXCSRBits get_MXCSR() { }

	[Address(RVA = "0x27F6850", Offset = "0x27F5C50", Length = "0x7")]
	[Token(Token = "0x6000AC4")]
	internal static int getcsr_raw() { }

	[Address(RVA = "0x27F6870", Offset = "0x27F5C70", Length = "0xE")]
	[Token(Token = "0x6000AC0")]
	private static bool IsNaN(uint v) { }

	[Address(RVA = "0x27F6880", Offset = "0x27F5C80", Length = "0x1E")]
	[Token(Token = "0x6000AC1")]
	private static bool IsNaN(ulong v) { }

	[Address(RVA = "0x27F68A0", Offset = "0x27F5CA0", Length = "0x15")]
	[Token(Token = "0x6000ABE")]
	private static short Saturate_To_Int16(int val) { }

	[Address(RVA = "0x27F68C0", Offset = "0x27F5CC0", Length = "0x17")]
	[Token(Token = "0x6000ABC")]
	private static sbyte Saturate_To_Int8(int val) { }

	[Address(RVA = "0x27F68E0", Offset = "0x27F5CE0", Length = "0x12")]
	[Token(Token = "0x6000ABF")]
	private static ushort Saturate_To_UnsignedInt16(int val) { }

	[Address(RVA = "0x27F6900", Offset = "0x27F5D00", Length = "0x16")]
	[Token(Token = "0x6000ABD")]
	private static byte Saturate_To_UnsignedInt8(int val) { }

	[Address(RVA = "0x27F6860", Offset = "0x27F5C60", Length = "0x7")]
	[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
	[Token(Token = "0x6000AC9")]
	public static void set_MXCSR(MXCSRBits value) { }

	[Address(RVA = "0x27F6860", Offset = "0x27F5C60", Length = "0x7")]
	[Token(Token = "0x6000AC5")]
	internal static void setcsr_raw(int bits) { }

}

