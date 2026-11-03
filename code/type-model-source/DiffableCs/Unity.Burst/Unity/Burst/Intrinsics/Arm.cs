namespace Unity.Burst.Intrinsics;

[Token(Token = "0x2000032")]
public static class Arm
{
	[Token(Token = "0x2000033")]
	internal class Neon
	{

		[Token(Token = "0x1700001E")]
		public static bool IsNeonArmv82FeaturesSupported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600053F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700001F")]
		public static bool IsNeonCryptoSupported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000999")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000020")]
		public static bool IsNeonDotProdSupported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60009B0")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000021")]
		public static bool IsNeonRDMASupported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60009BD")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700001D")]
		public static bool IsNeonSupported
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60000F4")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27C4F70", Offset = "0x27C4370", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009A4")]
		public static uint __crc32b(uint a0, byte a1) { }

		[Address(RVA = "0x27C4FB0", Offset = "0x27C43B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009A8")]
		public static uint __crc32cb(uint a0, byte a1) { }

		[Address(RVA = "0x27C4FF0", Offset = "0x27C43F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009AB")]
		public static uint __crc32cd(uint a0, ulong a1) { }

		[Address(RVA = "0x27C5030", Offset = "0x27C4430", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009A9")]
		public static uint __crc32ch(uint a0, ushort a1) { }

		[Address(RVA = "0x27C5070", Offset = "0x27C4470", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009AA")]
		public static uint __crc32cw(uint a0, uint a1) { }

		[Address(RVA = "0x27C50B0", Offset = "0x27C44B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009A7")]
		public static uint __crc32d(uint a0, ulong a1) { }

		[Address(RVA = "0x27C50F0", Offset = "0x27C44F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009A5")]
		public static uint __crc32h(uint a0, ushort a1) { }

		[Address(RVA = "0x27C5130", Offset = "0x27C4530", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009A6")]
		public static uint __crc32w(uint a0, uint a1) { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A5A")]
		public Neon() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600053F")]
		public static bool get_IsNeonArmv82FeaturesSupported() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000999")]
		public static bool get_IsNeonCryptoSupported() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60009B0")]
		public static bool get_IsNeonDotProdSupported() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60009BD")]
		public static bool get_IsNeonRDMASupported() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60000F4")]
		public static bool get_IsNeonSupported() { }

		[Address(RVA = "0x27C5170", Offset = "0x27C4570", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600024B")]
		public static v64 vaba_s16(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C51B0", Offset = "0x27C45B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600024D")]
		public static v64 vaba_s32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C51F0", Offset = "0x27C45F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000249")]
		public static v64 vaba_s8(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C5230", Offset = "0x27C4630", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000251")]
		public static v64 vaba_u16(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C5270", Offset = "0x27C4670", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000253")]
		public static v64 vaba_u32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C52B0", Offset = "0x27C46B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600024F")]
		public static v64 vaba_u8(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C52F0", Offset = "0x27C46F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006A1")]
		public static v128 vabal_high_s16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C5330", Offset = "0x27C4730", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006A2")]
		public static v128 vabal_high_s32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C5370", Offset = "0x27C4770", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006A0")]
		public static v128 vabal_high_s8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C53B0", Offset = "0x27C47B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006A4")]
		public static v128 vabal_high_u16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C53F0", Offset = "0x27C47F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006A5")]
		public static v128 vabal_high_u32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C5430", Offset = "0x27C4830", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006A3")]
		public static v128 vabal_high_u8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C5470", Offset = "0x27C4870", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000256")]
		public static v128 vabal_s16(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C54B0", Offset = "0x27C48B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000257")]
		public static v128 vabal_s32(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C54F0", Offset = "0x27C48F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000255")]
		public static v128 vabal_s8(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C5530", Offset = "0x27C4930", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000259")]
		public static v128 vabal_u16(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C5570", Offset = "0x27C4970", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600025A")]
		public static v128 vabal_u32(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C55B0", Offset = "0x27C49B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000258")]
		public static v128 vabal_u8(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C55F0", Offset = "0x27C49F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600024C")]
		public static v128 vabaq_s16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C5630", Offset = "0x27C4A30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600024E")]
		public static v128 vabaq_s32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C5670", Offset = "0x27C4A70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600024A")]
		public static v128 vabaq_s8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C56B0", Offset = "0x27C4AB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000252")]
		public static v128 vabaq_u16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C56F0", Offset = "0x27C4AF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000254")]
		public static v128 vabaq_u32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C5730", Offset = "0x27C4B30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000250")]
		public static v128 vabaq_u8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C5770", Offset = "0x27C4B70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000241")]
		public static v64 vabd_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C57B0", Offset = "0x27C4BB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000696")]
		public static v64 vabd_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C57F0", Offset = "0x27C4BF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000237")]
		public static v64 vabd_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C5830", Offset = "0x27C4C30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000239")]
		public static v64 vabd_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C5870", Offset = "0x27C4C70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000235")]
		public static v64 vabd_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C58B0", Offset = "0x27C4CB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600023D")]
		public static v64 vabd_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C58F0", Offset = "0x27C4CF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600023F")]
		public static v64 vabd_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C5930", Offset = "0x27C4D30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600023B")]
		public static v64 vabd_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C5970", Offset = "0x27C4D70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000699")]
		public static double vabdd_f64(double a0, double a1) { }

		[Address(RVA = "0x27C59B0", Offset = "0x27C4DB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600069B")]
		public static v128 vabdl_high_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C59F0", Offset = "0x27C4DF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600069C")]
		public static v128 vabdl_high_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C5A30", Offset = "0x27C4E30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600069A")]
		public static v128 vabdl_high_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C5A70", Offset = "0x27C4E70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600069E")]
		public static v128 vabdl_high_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C5AB0", Offset = "0x27C4EB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600069F")]
		public static v128 vabdl_high_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C5AF0", Offset = "0x27C4EF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600069D")]
		public static v128 vabdl_high_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C5B30", Offset = "0x27C4F30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000244")]
		public static v128 vabdl_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C5B70", Offset = "0x27C4F70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000245")]
		public static v128 vabdl_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C5BB0", Offset = "0x27C4FB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000243")]
		public static v128 vabdl_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C5BF0", Offset = "0x27C4FF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000247")]
		public static v128 vabdl_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C5C30", Offset = "0x27C5030", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000248")]
		public static v128 vabdl_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C5C70", Offset = "0x27C5070", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000246")]
		public static v128 vabdl_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C5CB0", Offset = "0x27C50B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000242")]
		public static v128 vabdq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C5CF0", Offset = "0x27C50F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000697")]
		public static v128 vabdq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C5D30", Offset = "0x27C5130", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000238")]
		public static v128 vabdq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C5D70", Offset = "0x27C5170", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600023A")]
		public static v128 vabdq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C5DB0", Offset = "0x27C51B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000236")]
		public static v128 vabdq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C5DF0", Offset = "0x27C51F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600023E")]
		public static v128 vabdq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C5E30", Offset = "0x27C5230", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000240")]
		public static v128 vabdq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C5E70", Offset = "0x27C5270", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600023C")]
		public static v128 vabdq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C5EB0", Offset = "0x27C52B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000698")]
		public static float vabds_f32(float a0, float a1) { }

		[Address(RVA = "0x27C5EF0", Offset = "0x27C52F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000404")]
		public static v64 vabs_f32(v64 a0) { }

		[Address(RVA = "0x27C5F30", Offset = "0x27C5330", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000831")]
		public static v64 vabs_f64(v64 a0) { }

		[Address(RVA = "0x27C5F70", Offset = "0x27C5370", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000400")]
		public static v64 vabs_s16(v64 a0) { }

		[Address(RVA = "0x27C5FB0", Offset = "0x27C53B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000402")]
		public static v64 vabs_s32(v64 a0) { }

		[Address(RVA = "0x27C5FF0", Offset = "0x27C53F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600082E")]
		public static v64 vabs_s64(v64 a0) { }

		[Address(RVA = "0x27C6030", Offset = "0x27C5430", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003FE")]
		public static v64 vabs_s8(v64 a0) { }

		[Address(RVA = "0x27C6070", Offset = "0x27C5470", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600082F")]
		public static long vabsd_s64(long a0) { }

		[Address(RVA = "0x27C60B0", Offset = "0x27C54B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000405")]
		public static v128 vabsq_f32(v128 a0) { }

		[Address(RVA = "0x27C60F0", Offset = "0x27C54F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000832")]
		public static v128 vabsq_f64(v128 a0) { }

		[Address(RVA = "0x27C6130", Offset = "0x27C5530", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000401")]
		public static v128 vabsq_s16(v128 a0) { }

		[Address(RVA = "0x27C6170", Offset = "0x27C5570", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000403")]
		public static v128 vabsq_s32(v128 a0) { }

		[Address(RVA = "0x27C61B0", Offset = "0x27C55B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000830")]
		public static v128 vabsq_s64(v128 a0) { }

		[Address(RVA = "0x27C61F0", Offset = "0x27C55F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003FF")]
		public static v128 vabsq_s8(v128 a0) { }

		[Address(RVA = "0x27C6230", Offset = "0x27C5630", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000105")]
		public static v64 vadd_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C6270", Offset = "0x27C5670", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000540")]
		public static v64 vadd_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C62B0", Offset = "0x27C56B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60000F7")]
		public static v64 vadd_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C62F0", Offset = "0x27C56F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60000F9")]
		public static v64 vadd_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C6330", Offset = "0x27C5730", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60000FB")]
		public static v64 vadd_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C6370", Offset = "0x27C5770", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60000F5")]
		public static v64 vadd_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C63B0", Offset = "0x27C57B0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60000FF")]
		public static v64 vadd_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C63C0", Offset = "0x27C57C0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000101")]
		public static v64 vadd_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C63D0", Offset = "0x27C57D0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000103")]
		public static v64 vadd_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C63E0", Offset = "0x27C57E0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60000FD")]
		public static v64 vadd_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C63F0", Offset = "0x27C57F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000542")]
		public static long vaddd_s64(long a0, long a1) { }

		[Address(RVA = "0x27C6430", Offset = "0x27C5830", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000543")]
		public static ulong vaddd_u64(ulong a0, ulong a1) { }

		[Address(RVA = "0x27C6470", Offset = "0x27C5870", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000570")]
		public static v128 vaddhn_high_s16(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C64B0", Offset = "0x27C58B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000571")]
		public static v128 vaddhn_high_s32(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C64F0", Offset = "0x27C58F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000572")]
		public static v128 vaddhn_high_s64(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C6530", Offset = "0x27C5930", Length = "0x33")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000573")]
		public static v128 vaddhn_high_u16(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C6570", Offset = "0x27C5970", Length = "0x33")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000574")]
		public static v128 vaddhn_high_u32(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C65B0", Offset = "0x27C59B0", Length = "0x33")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000575")]
		public static v128 vaddhn_high_u64(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C65F0", Offset = "0x27C59F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600013B")]
		public static v64 vaddhn_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6630", Offset = "0x27C5A30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600013C")]
		public static v64 vaddhn_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6670", Offset = "0x27C5A70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600013D")]
		public static v64 vaddhn_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C66B0", Offset = "0x27C5AB0", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x600013E")]
		public static v64 vaddhn_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C66E0", Offset = "0x27C5AE0", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x600013F")]
		public static v64 vaddhn_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6710", Offset = "0x27C5B10", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000140")]
		public static v64 vaddhn_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6740", Offset = "0x27C5B40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000545")]
		public static v128 vaddl_high_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6780", Offset = "0x27C5B80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000546")]
		public static v128 vaddl_high_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C67C0", Offset = "0x27C5BC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000544")]
		public static v128 vaddl_high_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6800", Offset = "0x27C5C00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000548")]
		public static v128 vaddl_high_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6840", Offset = "0x27C5C40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000549")]
		public static v128 vaddl_high_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6880", Offset = "0x27C5C80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000547")]
		public static v128 vaddl_high_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C68C0", Offset = "0x27C5CC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000108")]
		public static v128 vaddl_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C6900", Offset = "0x27C5D00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000109")]
		public static v128 vaddl_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C6940", Offset = "0x27C5D40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000107")]
		public static v128 vaddl_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C6980", Offset = "0x27C5D80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600010B")]
		public static v128 vaddl_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C69C0", Offset = "0x27C5DC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600010C")]
		public static v128 vaddl_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C6A00", Offset = "0x27C5E00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600010A")]
		public static v128 vaddl_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C6A40", Offset = "0x27C5E40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008EF")]
		public static int vaddlv_s16(v64 a0) { }

		[Address(RVA = "0x27C6A80", Offset = "0x27C5E80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008F1")]
		public static long vaddlv_s32(v64 a0) { }

		[Address(RVA = "0x27C6AC0", Offset = "0x27C5EC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008ED")]
		public static short vaddlv_s8(v64 a0) { }

		[Address(RVA = "0x27C6B00", Offset = "0x27C5F00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008F5")]
		public static uint vaddlv_u16(v64 a0) { }

		[Address(RVA = "0x27C6B40", Offset = "0x27C5F40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008F7")]
		public static ulong vaddlv_u32(v64 a0) { }

		[Address(RVA = "0x27C6B80", Offset = "0x27C5F80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008F3")]
		public static ushort vaddlv_u8(v64 a0) { }

		[Address(RVA = "0x27C6BC0", Offset = "0x27C5FC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008F0")]
		public static int vaddlvq_s16(v128 a0) { }

		[Address(RVA = "0x27C6C00", Offset = "0x27C6000", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008F2")]
		public static long vaddlvq_s32(v128 a0) { }

		[Address(RVA = "0x27C6C40", Offset = "0x27C6040", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008EE")]
		public static short vaddlvq_s8(v128 a0) { }

		[Address(RVA = "0x27C6C80", Offset = "0x27C6080", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008F6")]
		public static uint vaddlvq_u16(v128 a0) { }

		[Address(RVA = "0x27C6CC0", Offset = "0x27C60C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008F8")]
		public static ulong vaddlvq_u32(v128 a0) { }

		[Address(RVA = "0x27C6D00", Offset = "0x27C6100", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008F4")]
		public static ushort vaddlvq_u8(v128 a0) { }

		[Address(RVA = "0x27C6D40", Offset = "0x27C6140", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000106")]
		public static v128 vaddq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6D80", Offset = "0x27C6180", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000541")]
		public static v128 vaddq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6DC0", Offset = "0x27C61C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60000F8")]
		public static v128 vaddq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6E00", Offset = "0x27C6200", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60000FA")]
		public static v128 vaddq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6E40", Offset = "0x27C6240", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60000FC")]
		public static v128 vaddq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6E80", Offset = "0x27C6280", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60000F6")]
		public static v128 vaddq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6EC0", Offset = "0x27C62C0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000100")]
		public static v128 vaddq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6EF0", Offset = "0x27C62F0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000102")]
		public static v128 vaddq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6F20", Offset = "0x27C6320", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000104")]
		public static v128 vaddq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6F50", Offset = "0x27C6350", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x60000FE")]
		public static v128 vaddq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C6F80", Offset = "0x27C6380", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008EA")]
		public static float vaddv_f32(v64 a0) { }

		[Address(RVA = "0x27C6FC0", Offset = "0x27C63C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008DE")]
		public static short vaddv_s16(v64 a0) { }

		[Address(RVA = "0x27C7000", Offset = "0x27C6400", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008E0")]
		public static int vaddv_s32(v64 a0) { }

		[Address(RVA = "0x27C7040", Offset = "0x27C6440", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008DC")]
		public static sbyte vaddv_s8(v64 a0) { }

		[Address(RVA = "0x27C7080", Offset = "0x27C6480", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008E5")]
		public static ushort vaddv_u16(v64 a0) { }

		[Address(RVA = "0x27C70C0", Offset = "0x27C64C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008E7")]
		public static uint vaddv_u32(v64 a0) { }

		[Address(RVA = "0x27C7100", Offset = "0x27C6500", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008E3")]
		public static byte vaddv_u8(v64 a0) { }

		[Address(RVA = "0x27C7140", Offset = "0x27C6540", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008EB")]
		public static float vaddvq_f32(v128 a0) { }

		[Address(RVA = "0x27C7180", Offset = "0x27C6580", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008EC")]
		public static double vaddvq_f64(v128 a0) { }

		[Address(RVA = "0x27C71C0", Offset = "0x27C65C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008DF")]
		public static short vaddvq_s16(v128 a0) { }

		[Address(RVA = "0x27C7200", Offset = "0x27C6600", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008E1")]
		public static int vaddvq_s32(v128 a0) { }

		[Address(RVA = "0x27C7240", Offset = "0x27C6640", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008E2")]
		public static long vaddvq_s64(v128 a0) { }

		[Address(RVA = "0x27C7280", Offset = "0x27C6680", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008DD")]
		public static sbyte vaddvq_s8(v128 a0) { }

		[Address(RVA = "0x27C72C0", Offset = "0x27C66C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008E6")]
		public static ushort vaddvq_u16(v128 a0) { }

		[Address(RVA = "0x27C7300", Offset = "0x27C6700", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008E8")]
		public static uint vaddvq_u32(v128 a0) { }

		[Address(RVA = "0x27C7340", Offset = "0x27C6740", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008E9")]
		public static ulong vaddvq_u64(v128 a0) { }

		[Address(RVA = "0x27C7380", Offset = "0x27C6780", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008E4")]
		public static byte vaddvq_u8(v128 a0) { }

		[Address(RVA = "0x27C73C0", Offset = "0x27C67C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600054B")]
		public static v128 vaddw_high_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7400", Offset = "0x27C6800", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600054C")]
		public static v128 vaddw_high_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7440", Offset = "0x27C6840", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600054A")]
		public static v128 vaddw_high_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7480", Offset = "0x27C6880", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600054E")]
		public static v128 vaddw_high_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C74C0", Offset = "0x27C68C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600054F")]
		public static v128 vaddw_high_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7500", Offset = "0x27C6900", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600054D")]
		public static v128 vaddw_high_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7540", Offset = "0x27C6940", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600010E")]
		public static v128 vaddw_s16(v128 a0, v64 a1) { }

		[Address(RVA = "0x27C7580", Offset = "0x27C6980", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600010F")]
		public static v128 vaddw_s32(v128 a0, v64 a1) { }

		[Address(RVA = "0x27C75C0", Offset = "0x27C69C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600010D")]
		public static v128 vaddw_s8(v128 a0, v64 a1) { }

		[Address(RVA = "0x27C7600", Offset = "0x27C6A00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000111")]
		public static v128 vaddw_u16(v128 a0, v64 a1) { }

		[Address(RVA = "0x27C7640", Offset = "0x27C6A40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000112")]
		public static v128 vaddw_u32(v128 a0, v64 a1) { }

		[Address(RVA = "0x27C7680", Offset = "0x27C6A80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000110")]
		public static v128 vaddw_u8(v128 a0, v64 a1) { }

		[Address(RVA = "0x27C76C0", Offset = "0x27C6AC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009AD")]
		public static v128 vaesdq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7700", Offset = "0x27C6B00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009AC")]
		public static v128 vaeseq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7740", Offset = "0x27C6B40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009AF")]
		public static v128 vaesimcq_u8(v128 a0) { }

		[Address(RVA = "0x27C7780", Offset = "0x27C6B80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009AE")]
		public static v128 vaesmcq_u8(v128 a0) { }

		[Address(RVA = "0x27C77C0", Offset = "0x27C6BC0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600044A")]
		public static v64 vand_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C77C0", Offset = "0x27C6BC0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600044C")]
		public static v64 vand_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C77C0", Offset = "0x27C6BC0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600044E")]
		public static v64 vand_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C77D0", Offset = "0x27C6BD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000448")]
		public static v64 vand_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C77C0", Offset = "0x27C6BC0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000452")]
		public static v64 vand_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C77C0", Offset = "0x27C6BC0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000454")]
		public static v64 vand_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C77C0", Offset = "0x27C6BC0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000456")]
		public static v64 vand_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C77C0", Offset = "0x27C6BC0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000450")]
		public static v64 vand_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7810", Offset = "0x27C6C10", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600044B")]
		public static v128 vandq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7810", Offset = "0x27C6C10", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600044D")]
		public static v128 vandq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7810", Offset = "0x27C6C10", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600044F")]
		public static v128 vandq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7840", Offset = "0x27C6C40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000449")]
		public static v128 vandq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7810", Offset = "0x27C6C10", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000453")]
		public static v128 vandq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7810", Offset = "0x27C6C10", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000455")]
		public static v128 vandq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7810", Offset = "0x27C6C10", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000457")]
		public static v128 vandq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7810", Offset = "0x27C6C10", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000451")]
		public static v128 vandq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7880", Offset = "0x27C6C80", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600047A")]
		public static v64 vbic_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7880", Offset = "0x27C6C80", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600047C")]
		public static v64 vbic_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7880", Offset = "0x27C6C80", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600047E")]
		public static v64 vbic_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7890", Offset = "0x27C6C90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000478")]
		public static v64 vbic_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7880", Offset = "0x27C6C80", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000482")]
		public static v64 vbic_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7880", Offset = "0x27C6C80", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000484")]
		public static v64 vbic_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7880", Offset = "0x27C6C80", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000486")]
		public static v64 vbic_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7880", Offset = "0x27C6C80", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000480")]
		public static v64 vbic_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C78D0", Offset = "0x27C6CD0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600047B")]
		public static v128 vbicq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C78D0", Offset = "0x27C6CD0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600047D")]
		public static v128 vbicq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C78D0", Offset = "0x27C6CD0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600047F")]
		public static v128 vbicq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7900", Offset = "0x27C6D00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000479")]
		public static v128 vbicq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C78D0", Offset = "0x27C6CD0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000483")]
		public static v128 vbicq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C78D0", Offset = "0x27C6CD0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000485")]
		public static v128 vbicq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C78D0", Offset = "0x27C6CD0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000487")]
		public static v128 vbicq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C78D0", Offset = "0x27C6CD0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000481")]
		public static v128 vbicq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7940", Offset = "0x27C6D40", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004A8")]
		public static v64 vbsl_f32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C7940", Offset = "0x27C6D40", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000858")]
		public static v64 vbsl_f64(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C7940", Offset = "0x27C6D40", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600049A")]
		public static v64 vbsl_s16(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C7940", Offset = "0x27C6D40", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600049C")]
		public static v64 vbsl_s32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C7940", Offset = "0x27C6D40", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600049E")]
		public static v64 vbsl_s64(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C7950", Offset = "0x27C6D50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000498")]
		public static v64 vbsl_s8(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C7940", Offset = "0x27C6D40", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004A2")]
		public static v64 vbsl_u16(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C7940", Offset = "0x27C6D40", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004A4")]
		public static v64 vbsl_u32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C7940", Offset = "0x27C6D40", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004A6")]
		public static v64 vbsl_u64(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C7940", Offset = "0x27C6D40", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004A0")]
		public static v64 vbsl_u8(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27C7990", Offset = "0x27C6D90", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004A9")]
		public static v128 vbslq_f32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C7990", Offset = "0x27C6D90", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000859")]
		public static v128 vbslq_f64(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C7990", Offset = "0x27C6D90", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x600049B")]
		public static v128 vbslq_s16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C7990", Offset = "0x27C6D90", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x600049D")]
		public static v128 vbslq_s32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C7990", Offset = "0x27C6D90", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x600049F")]
		public static v128 vbslq_s64(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C79D0", Offset = "0x27C6DD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000499")]
		public static v128 vbslq_s8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C7990", Offset = "0x27C6D90", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004A3")]
		public static v128 vbslq_u16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C7990", Offset = "0x27C6D90", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004A5")]
		public static v128 vbslq_u32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C7990", Offset = "0x27C6D90", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004A7")]
		public static v128 vbslq_u64(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C7990", Offset = "0x27C6D90", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004A1")]
		public static v128 vbslq_u8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27C7A10", Offset = "0x27C6E10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000221")]
		public static v64 vcage_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7A50", Offset = "0x27C6E50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000680")]
		public static v64 vcage_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7A90", Offset = "0x27C6E90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000683")]
		public static ulong vcaged_f64(double a0, double a1) { }

		[Address(RVA = "0x27C7AD0", Offset = "0x27C6ED0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000222")]
		public static v128 vcageq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7B10", Offset = "0x27C6F10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000681")]
		public static v128 vcageq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7B50", Offset = "0x27C6F50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000682")]
		public static uint vcages_f32(float a0, float a1) { }

		[Address(RVA = "0x27C7B90", Offset = "0x27C6F90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000225")]
		public static v64 vcagt_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7BD0", Offset = "0x27C6FD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000688")]
		public static v64 vcagt_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7C10", Offset = "0x27C7010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600068B")]
		public static ulong vcagtd_f64(double a0, double a1) { }

		[Address(RVA = "0x27C7C50", Offset = "0x27C7050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000226")]
		public static v128 vcagtq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7C90", Offset = "0x27C7090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000689")]
		public static v128 vcagtq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7CD0", Offset = "0x27C70D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600068A")]
		public static uint vcagts_f32(float a0, float a1) { }

		[Address(RVA = "0x27C7D10", Offset = "0x27C7110", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000223")]
		public static v64 vcale_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7D50", Offset = "0x27C7150", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000684")]
		public static v64 vcale_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7D90", Offset = "0x27C7190", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000687")]
		public static ulong vcaled_f64(double a0, double a1) { }

		[Address(RVA = "0x27C7DD0", Offset = "0x27C71D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000224")]
		public static v128 vcaleq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7E10", Offset = "0x27C7210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000685")]
		public static v128 vcaleq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7E50", Offset = "0x27C7250", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000686")]
		public static uint vcales_f32(float a0, float a1) { }

		[Address(RVA = "0x27C7E90", Offset = "0x27C7290", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000227")]
		public static v64 vcalt_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7ED0", Offset = "0x27C72D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600068C")]
		public static v64 vcalt_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C7F10", Offset = "0x27C7310", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600068F")]
		public static ulong vcaltd_f64(double a0, double a1) { }

		[Address(RVA = "0x27C7F50", Offset = "0x27C7350", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000228")]
		public static v128 vcaltq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7F90", Offset = "0x27C7390", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600068D")]
		public static v128 vcaltq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C7FD0", Offset = "0x27C73D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600068E")]
		public static uint vcalts_f32(float a0, float a1) { }

		[Address(RVA = "0x27C8010", Offset = "0x27C7410", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001E7")]
		public static v64 vceq_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8050", Offset = "0x27C7450", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005FE")]
		public static v64 vceq_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8090", Offset = "0x27C7490", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001DD")]
		public static v64 vceq_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C80D0", Offset = "0x27C74D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001DF")]
		public static v64 vceq_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8110", Offset = "0x27C7510", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005FA")]
		public static v64 vceq_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8150", Offset = "0x27C7550", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001DB")]
		public static v64 vceq_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8190", Offset = "0x27C7590", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001E3")]
		public static v64 vceq_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C81A0", Offset = "0x27C75A0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001E5")]
		public static v64 vceq_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C81B0", Offset = "0x27C75B0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005FC")]
		public static v64 vceq_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C81C0", Offset = "0x27C75C0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001E1")]
		public static v64 vceq_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C81D0", Offset = "0x27C75D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000603")]
		public static ulong vceqd_f64(double a0, double a1) { }

		[Address(RVA = "0x27C8210", Offset = "0x27C7610", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000600")]
		public static ulong vceqd_s64(long a0, long a1) { }

		[Address(RVA = "0x27C8250", Offset = "0x27C7650", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000601")]
		public static ulong vceqd_u64(ulong a0, ulong a1) { }

		[Address(RVA = "0x27C8290", Offset = "0x27C7690", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001E8")]
		public static v128 vceqq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C82D0", Offset = "0x27C76D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005FF")]
		public static v128 vceqq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8310", Offset = "0x27C7710", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001DE")]
		public static v128 vceqq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8350", Offset = "0x27C7750", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001E0")]
		public static v128 vceqq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8390", Offset = "0x27C7790", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005FB")]
		public static v128 vceqq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C83D0", Offset = "0x27C77D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001DC")]
		public static v128 vceqq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8410", Offset = "0x27C7810", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001E4")]
		public static v128 vceqq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8440", Offset = "0x27C7840", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001E6")]
		public static v128 vceqq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8470", Offset = "0x27C7870", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005FD")]
		public static v128 vceqq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C84A0", Offset = "0x27C78A0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001E2")]
		public static v128 vceqq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C84D0", Offset = "0x27C78D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000602")]
		public static uint vceqs_f32(float a0, float a1) { }

		[Address(RVA = "0x27C8510", Offset = "0x27C7910", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000610")]
		public static v64 vceqz_f32(v64 a0) { }

		[Address(RVA = "0x27C8550", Offset = "0x27C7950", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000616")]
		public static v64 vceqz_f64(v64 a0) { }

		[Address(RVA = "0x27C8590", Offset = "0x27C7990", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000606")]
		public static v64 vceqz_s16(v64 a0) { }

		[Address(RVA = "0x27C85D0", Offset = "0x27C79D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000608")]
		public static v64 vceqz_s32(v64 a0) { }

		[Address(RVA = "0x27C8610", Offset = "0x27C7A10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000612")]
		public static v64 vceqz_s64(v64 a0) { }

		[Address(RVA = "0x27C8650", Offset = "0x27C7A50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000604")]
		public static v64 vceqz_s8(v64 a0) { }

		[Address(RVA = "0x27C8690", Offset = "0x27C7A90", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x600060C")]
		public static v64 vceqz_u16(v64 a0) { }

		[Address(RVA = "0x27C86A0", Offset = "0x27C7AA0", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x600060E")]
		public static v64 vceqz_u32(v64 a0) { }

		[Address(RVA = "0x27C86B0", Offset = "0x27C7AB0", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000614")]
		public static v64 vceqz_u64(v64 a0) { }

		[Address(RVA = "0x27C86C0", Offset = "0x27C7AC0", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x600060A")]
		public static v64 vceqz_u8(v64 a0) { }

		[Address(RVA = "0x27C86D0", Offset = "0x27C7AD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600061B")]
		public static ulong vceqzd_f64(double a0) { }

		[Address(RVA = "0x27C8710", Offset = "0x27C7B10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000618")]
		public static ulong vceqzd_s64(long a0) { }

		[Address(RVA = "0x27C8750", Offset = "0x27C7B50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000619")]
		public static ulong vceqzd_u64(ulong a0) { }

		[Address(RVA = "0x27C8790", Offset = "0x27C7B90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000611")]
		public static v128 vceqzq_f32(v128 a0) { }

		[Address(RVA = "0x27C87D0", Offset = "0x27C7BD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000617")]
		public static v128 vceqzq_f64(v128 a0) { }

		[Address(RVA = "0x27C8810", Offset = "0x27C7C10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000607")]
		public static v128 vceqzq_s16(v128 a0) { }

		[Address(RVA = "0x27C8850", Offset = "0x27C7C50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000609")]
		public static v128 vceqzq_s32(v128 a0) { }

		[Address(RVA = "0x27C8890", Offset = "0x27C7C90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000613")]
		public static v128 vceqzq_s64(v128 a0) { }

		[Address(RVA = "0x27C88D0", Offset = "0x27C7CD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000605")]
		public static v128 vceqzq_s8(v128 a0) { }

		[Address(RVA = "0x27C8910", Offset = "0x27C7D10", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600060D")]
		public static v128 vceqzq_u16(v128 a0) { }

		[Address(RVA = "0x27C8930", Offset = "0x27C7D30", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600060F")]
		public static v128 vceqzq_u32(v128 a0) { }

		[Address(RVA = "0x27C8950", Offset = "0x27C7D50", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000615")]
		public static v128 vceqzq_u64(v128 a0) { }

		[Address(RVA = "0x27C8970", Offset = "0x27C7D70", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600060B")]
		public static v128 vceqzq_u8(v128 a0) { }

		[Address(RVA = "0x27C8990", Offset = "0x27C7D90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600061A")]
		public static uint vceqzs_f32(float a0) { }

		[Address(RVA = "0x27C89D0", Offset = "0x27C7DD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001F5")]
		public static v64 vcge_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8A10", Offset = "0x27C7E10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000620")]
		public static v64 vcge_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8A50", Offset = "0x27C7E50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001EB")]
		public static v64 vcge_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8A90", Offset = "0x27C7E90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001ED")]
		public static v64 vcge_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8AD0", Offset = "0x27C7ED0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600061C")]
		public static v64 vcge_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8B10", Offset = "0x27C7F10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001E9")]
		public static v64 vcge_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8B50", Offset = "0x27C7F50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001F1")]
		public static v64 vcge_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8B90", Offset = "0x27C7F90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001F3")]
		public static v64 vcge_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8BD0", Offset = "0x27C7FD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600061E")]
		public static v64 vcge_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8C10", Offset = "0x27C8010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001EF")]
		public static v64 vcge_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C8C50", Offset = "0x27C8050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000625")]
		public static ulong vcged_f64(double a0, double a1) { }

		[Address(RVA = "0x27C8C90", Offset = "0x27C8090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000622")]
		public static ulong vcged_s64(long a0, long a1) { }

		[Address(RVA = "0x27C8CD0", Offset = "0x27C80D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000623")]
		public static ulong vcged_u64(ulong a0, ulong a1) { }

		[Address(RVA = "0x27C8D10", Offset = "0x27C8110", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001F6")]
		public static v128 vcgeq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8D50", Offset = "0x27C8150", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000621")]
		public static v128 vcgeq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8D90", Offset = "0x27C8190", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001EC")]
		public static v128 vcgeq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8DD0", Offset = "0x27C81D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001EE")]
		public static v128 vcgeq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8E10", Offset = "0x27C8210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600061D")]
		public static v128 vcgeq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8E50", Offset = "0x27C8250", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001EA")]
		public static v128 vcgeq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8E90", Offset = "0x27C8290", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001F2")]
		public static v128 vcgeq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8ED0", Offset = "0x27C82D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001F4")]
		public static v128 vcgeq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8F10", Offset = "0x27C8310", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600061F")]
		public static v128 vcgeq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8F50", Offset = "0x27C8350", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001F0")]
		public static v128 vcgeq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C8F90", Offset = "0x27C8390", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000624")]
		public static uint vcges_f32(float a0, float a1) { }

		[Address(RVA = "0x27C8FD0", Offset = "0x27C83D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600062E")]
		public static v64 vcgez_f32(v64 a0) { }

		[Address(RVA = "0x27C9010", Offset = "0x27C8410", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000630")]
		public static v64 vcgez_f64(v64 a0) { }

		[Address(RVA = "0x27C9050", Offset = "0x27C8450", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000628")]
		public static v64 vcgez_s16(v64 a0) { }

		[Address(RVA = "0x27C9090", Offset = "0x27C8490", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600062A")]
		public static v64 vcgez_s32(v64 a0) { }

		[Address(RVA = "0x27C90D0", Offset = "0x27C84D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600062C")]
		public static v64 vcgez_s64(v64 a0) { }

		[Address(RVA = "0x27C9110", Offset = "0x27C8510", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000626")]
		public static v64 vcgez_s8(v64 a0) { }

		[Address(RVA = "0x27C9150", Offset = "0x27C8550", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000634")]
		public static ulong vcgezd_f64(double a0) { }

		[Address(RVA = "0x27C9190", Offset = "0x27C8590", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000632")]
		public static ulong vcgezd_s64(long a0) { }

		[Address(RVA = "0x27C91D0", Offset = "0x27C85D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600062F")]
		public static v128 vcgezq_f32(v128 a0) { }

		[Address(RVA = "0x27C9210", Offset = "0x27C8610", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000631")]
		public static v128 vcgezq_f64(v128 a0) { }

		[Address(RVA = "0x27C9250", Offset = "0x27C8650", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000629")]
		public static v128 vcgezq_s16(v128 a0) { }

		[Address(RVA = "0x27C9290", Offset = "0x27C8690", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600062B")]
		public static v128 vcgezq_s32(v128 a0) { }

		[Address(RVA = "0x27C92D0", Offset = "0x27C86D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600062D")]
		public static v128 vcgezq_s64(v128 a0) { }

		[Address(RVA = "0x27C9310", Offset = "0x27C8710", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000627")]
		public static v128 vcgezq_s8(v128 a0) { }

		[Address(RVA = "0x27C9350", Offset = "0x27C8750", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000633")]
		public static uint vcgezs_f32(float a0) { }

		[Address(RVA = "0x27C9390", Offset = "0x27C8790", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000211")]
		public static v64 vcgt_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C93D0", Offset = "0x27C87D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000652")]
		public static v64 vcgt_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9410", Offset = "0x27C8810", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000207")]
		public static v64 vcgt_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9450", Offset = "0x27C8850", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000209")]
		public static v64 vcgt_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9490", Offset = "0x27C8890", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600064E")]
		public static v64 vcgt_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C94D0", Offset = "0x27C88D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000205")]
		public static v64 vcgt_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9510", Offset = "0x27C8910", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600020D")]
		public static v64 vcgt_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9550", Offset = "0x27C8950", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600020F")]
		public static v64 vcgt_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9590", Offset = "0x27C8990", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000650")]
		public static v64 vcgt_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C95D0", Offset = "0x27C89D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600020B")]
		public static v64 vcgt_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9610", Offset = "0x27C8A10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000657")]
		public static ulong vcgtd_f64(double a0, double a1) { }

		[Address(RVA = "0x27C9650", Offset = "0x27C8A50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000654")]
		public static ulong vcgtd_s64(long a0, long a1) { }

		[Address(RVA = "0x27C9690", Offset = "0x27C8A90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000655")]
		public static ulong vcgtd_u64(ulong a0, ulong a1) { }

		[Address(RVA = "0x27C96D0", Offset = "0x27C8AD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000212")]
		public static v128 vcgtq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C9710", Offset = "0x27C8B10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000653")]
		public static v128 vcgtq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C9750", Offset = "0x27C8B50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000208")]
		public static v128 vcgtq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C9790", Offset = "0x27C8B90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600020A")]
		public static v128 vcgtq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C97D0", Offset = "0x27C8BD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600064F")]
		public static v128 vcgtq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C9810", Offset = "0x27C8C10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000206")]
		public static v128 vcgtq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C9850", Offset = "0x27C8C50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600020E")]
		public static v128 vcgtq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C9890", Offset = "0x27C8C90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000210")]
		public static v128 vcgtq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C98D0", Offset = "0x27C8CD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000651")]
		public static v128 vcgtq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C9910", Offset = "0x27C8D10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600020C")]
		public static v128 vcgtq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27C9950", Offset = "0x27C8D50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000656")]
		public static uint vcgts_f32(float a0, float a1) { }

		[Address(RVA = "0x27C9990", Offset = "0x27C8D90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000660")]
		public static v64 vcgtz_f32(v64 a0) { }

		[Address(RVA = "0x27C99D0", Offset = "0x27C8DD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000662")]
		public static v64 vcgtz_f64(v64 a0) { }

		[Address(RVA = "0x27C9A10", Offset = "0x27C8E10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600065A")]
		public static v64 vcgtz_s16(v64 a0) { }

		[Address(RVA = "0x27C9A50", Offset = "0x27C8E50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600065C")]
		public static v64 vcgtz_s32(v64 a0) { }

		[Address(RVA = "0x27C9A90", Offset = "0x27C8E90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600065E")]
		public static v64 vcgtz_s64(v64 a0) { }

		[Address(RVA = "0x27C9AD0", Offset = "0x27C8ED0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000658")]
		public static v64 vcgtz_s8(v64 a0) { }

		[Address(RVA = "0x27C9B10", Offset = "0x27C8F10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000666")]
		public static ulong vcgtzd_f64(double a0) { }

		[Address(RVA = "0x27C9B50", Offset = "0x27C8F50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000664")]
		public static ulong vcgtzd_s64(long a0) { }

		[Address(RVA = "0x27C9B90", Offset = "0x27C8F90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000661")]
		public static v128 vcgtzq_f32(v128 a0) { }

		[Address(RVA = "0x27C9BD0", Offset = "0x27C8FD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000663")]
		public static v128 vcgtzq_f64(v128 a0) { }

		[Address(RVA = "0x27C9C10", Offset = "0x27C9010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600065B")]
		public static v128 vcgtzq_s16(v128 a0) { }

		[Address(RVA = "0x27C9C50", Offset = "0x27C9050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600065D")]
		public static v128 vcgtzq_s32(v128 a0) { }

		[Address(RVA = "0x27C9C90", Offset = "0x27C9090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600065F")]
		public static v128 vcgtzq_s64(v128 a0) { }

		[Address(RVA = "0x27C9CD0", Offset = "0x27C90D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000659")]
		public static v128 vcgtzq_s8(v128 a0) { }

		[Address(RVA = "0x27C9D10", Offset = "0x27C9110", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000665")]
		public static uint vcgtzs_f32(float a0) { }

		[Address(RVA = "0x27C9D50", Offset = "0x27C9150", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000203")]
		public static v64 vcle_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9D90", Offset = "0x27C9190", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000639")]
		public static v64 vcle_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9DD0", Offset = "0x27C91D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001F9")]
		public static v64 vcle_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9E10", Offset = "0x27C9210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001FB")]
		public static v64 vcle_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9E50", Offset = "0x27C9250", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000635")]
		public static v64 vcle_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9E90", Offset = "0x27C9290", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001F7")]
		public static v64 vcle_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9ED0", Offset = "0x27C92D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001FF")]
		public static v64 vcle_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9F10", Offset = "0x27C9310", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000201")]
		public static v64 vcle_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9F50", Offset = "0x27C9350", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000637")]
		public static v64 vcle_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9F90", Offset = "0x27C9390", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001FD")]
		public static v64 vcle_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27C9FD0", Offset = "0x27C93D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600063E")]
		public static ulong vcled_f64(double a0, double a1) { }

		[Address(RVA = "0x27CA010", Offset = "0x27C9410", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600063B")]
		public static ulong vcled_s64(long a0, long a1) { }

		[Address(RVA = "0x27CA050", Offset = "0x27C9450", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600063C")]
		public static ulong vcled_u64(ulong a0, ulong a1) { }

		[Address(RVA = "0x27CA090", Offset = "0x27C9490", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000204")]
		public static v128 vcleq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CA0D0", Offset = "0x27C94D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600063A")]
		public static v128 vcleq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CA110", Offset = "0x27C9510", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001FA")]
		public static v128 vcleq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CA150", Offset = "0x27C9550", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001FC")]
		public static v128 vcleq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CA190", Offset = "0x27C9590", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000636")]
		public static v128 vcleq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CA1D0", Offset = "0x27C95D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001F8")]
		public static v128 vcleq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CA210", Offset = "0x27C9610", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000200")]
		public static v128 vcleq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CA250", Offset = "0x27C9650", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000202")]
		public static v128 vcleq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CA290", Offset = "0x27C9690", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000638")]
		public static v128 vcleq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CA2D0", Offset = "0x27C96D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001FE")]
		public static v128 vcleq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CA310", Offset = "0x27C9710", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600063D")]
		public static uint vcles_f32(float a0, float a1) { }

		[Address(RVA = "0x27CA350", Offset = "0x27C9750", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000647")]
		public static v64 vclez_f32(v64 a0) { }

		[Address(RVA = "0x27CA390", Offset = "0x27C9790", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000649")]
		public static v64 vclez_f64(v64 a0) { }

		[Address(RVA = "0x27CA3D0", Offset = "0x27C97D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000641")]
		public static v64 vclez_s16(v64 a0) { }

		[Address(RVA = "0x27CA410", Offset = "0x27C9810", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000643")]
		public static v64 vclez_s32(v64 a0) { }

		[Address(RVA = "0x27CA450", Offset = "0x27C9850", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000645")]
		public static v64 vclez_s64(v64 a0) { }

		[Address(RVA = "0x27CA490", Offset = "0x27C9890", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600063F")]
		public static v64 vclez_s8(v64 a0) { }

		[Address(RVA = "0x27CA4D0", Offset = "0x27C98D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600064D")]
		public static ulong vclezd_f64(double a0) { }

		[Address(RVA = "0x27CA510", Offset = "0x27C9910", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600064B")]
		public static ulong vclezd_s64(long a0) { }

		[Address(RVA = "0x27CA550", Offset = "0x27C9950", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000648")]
		public static v128 vclezq_f32(v128 a0) { }

		[Address(RVA = "0x27CA590", Offset = "0x27C9990", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600064A")]
		public static v128 vclezq_f64(v128 a0) { }

		[Address(RVA = "0x27CA5D0", Offset = "0x27C99D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000642")]
		public static v128 vclezq_s16(v128 a0) { }

		[Address(RVA = "0x27CA610", Offset = "0x27C9A10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000644")]
		public static v128 vclezq_s32(v128 a0) { }

		[Address(RVA = "0x27CA650", Offset = "0x27C9A50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000646")]
		public static v128 vclezq_s64(v128 a0) { }

		[Address(RVA = "0x27CA690", Offset = "0x27C9A90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000640")]
		public static v128 vclezq_s8(v128 a0) { }

		[Address(RVA = "0x27CA6D0", Offset = "0x27C9AD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600064C")]
		public static uint vclezs_f32(float a0) { }

		[Address(RVA = "0x27CA710", Offset = "0x27C9B10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600041C")]
		public static v64 vcls_s16(v64 a0) { }

		[Address(RVA = "0x27CA750", Offset = "0x27C9B50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600041E")]
		public static v64 vcls_s32(v64 a0) { }

		[Address(RVA = "0x27CA790", Offset = "0x27C9B90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600041A")]
		public static v64 vcls_s8(v64 a0) { }

		[Address(RVA = "0x27CA7D0", Offset = "0x27C9BD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600041D")]
		public static v128 vclsq_s16(v128 a0) { }

		[Address(RVA = "0x27CA810", Offset = "0x27C9C10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600041F")]
		public static v128 vclsq_s32(v128 a0) { }

		[Address(RVA = "0x27CA850", Offset = "0x27C9C50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600041B")]
		public static v128 vclsq_s8(v128 a0) { }

		[Address(RVA = "0x27CA890", Offset = "0x27C9C90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600021F")]
		public static v64 vclt_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CA8D0", Offset = "0x27C9CD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600066B")]
		public static v64 vclt_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CA910", Offset = "0x27C9D10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000215")]
		public static v64 vclt_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CA950", Offset = "0x27C9D50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000217")]
		public static v64 vclt_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CA990", Offset = "0x27C9D90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000667")]
		public static v64 vclt_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CA9D0", Offset = "0x27C9DD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000213")]
		public static v64 vclt_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CAA10", Offset = "0x27C9E10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600021B")]
		public static v64 vclt_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CAA50", Offset = "0x27C9E50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600021D")]
		public static v64 vclt_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CAA90", Offset = "0x27C9E90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000669")]
		public static v64 vclt_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CAAD0", Offset = "0x27C9ED0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000219")]
		public static v64 vclt_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CAB10", Offset = "0x27C9F10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000670")]
		public static ulong vcltd_f64(double a0, double a1) { }

		[Address(RVA = "0x27CAB50", Offset = "0x27C9F50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600066D")]
		public static ulong vcltd_s64(long a0, long a1) { }

		[Address(RVA = "0x27CAB90", Offset = "0x27C9F90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600066E")]
		public static ulong vcltd_u64(ulong a0, ulong a1) { }

		[Address(RVA = "0x27CABD0", Offset = "0x27C9FD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000220")]
		public static v128 vcltq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CAC10", Offset = "0x27CA010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600066C")]
		public static v128 vcltq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CAC50", Offset = "0x27CA050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000216")]
		public static v128 vcltq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CAC90", Offset = "0x27CA090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000218")]
		public static v128 vcltq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CACD0", Offset = "0x27CA0D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000668")]
		public static v128 vcltq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CAD10", Offset = "0x27CA110", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000214")]
		public static v128 vcltq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CAD50", Offset = "0x27CA150", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600021C")]
		public static v128 vcltq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CAD90", Offset = "0x27CA190", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600021E")]
		public static v128 vcltq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CADD0", Offset = "0x27CA1D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600066A")]
		public static v128 vcltq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CAE10", Offset = "0x27CA210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600021A")]
		public static v128 vcltq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CAE50", Offset = "0x27CA250", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600066F")]
		public static uint vclts_f32(float a0, float a1) { }

		[Address(RVA = "0x27CAE90", Offset = "0x27CA290", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000679")]
		public static v64 vcltz_f32(v64 a0) { }

		[Address(RVA = "0x27CAED0", Offset = "0x27CA2D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600067B")]
		public static v64 vcltz_f64(v64 a0) { }

		[Address(RVA = "0x27CAF10", Offset = "0x27CA310", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000673")]
		public static v64 vcltz_s16(v64 a0) { }

		[Address(RVA = "0x27CAF50", Offset = "0x27CA350", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000675")]
		public static v64 vcltz_s32(v64 a0) { }

		[Address(RVA = "0x27CAF90", Offset = "0x27CA390", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000677")]
		public static v64 vcltz_s64(v64 a0) { }

		[Address(RVA = "0x27CAFD0", Offset = "0x27CA3D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000671")]
		public static v64 vcltz_s8(v64 a0) { }

		[Address(RVA = "0x27CB010", Offset = "0x27CA410", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600067F")]
		public static ulong vcltzd_f64(double a0) { }

		[Address(RVA = "0x27CB050", Offset = "0x27CA450", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600067D")]
		public static ulong vcltzd_s64(long a0) { }

		[Address(RVA = "0x27CB090", Offset = "0x27CA490", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600067A")]
		public static v128 vcltzq_f32(v128 a0) { }

		[Address(RVA = "0x27CB0D0", Offset = "0x27CA4D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600067C")]
		public static v128 vcltzq_f64(v128 a0) { }

		[Address(RVA = "0x27CB110", Offset = "0x27CA510", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000674")]
		public static v128 vcltzq_s16(v128 a0) { }

		[Address(RVA = "0x27CB150", Offset = "0x27CA550", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000676")]
		public static v128 vcltzq_s32(v128 a0) { }

		[Address(RVA = "0x27CB190", Offset = "0x27CA590", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000678")]
		public static v128 vcltzq_s64(v128 a0) { }

		[Address(RVA = "0x27CB1D0", Offset = "0x27CA5D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000672")]
		public static v128 vcltzq_s8(v128 a0) { }

		[Address(RVA = "0x27CB210", Offset = "0x27CA610", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600067E")]
		public static uint vcltzs_f32(float a0) { }

		[Address(RVA = "0x27CB250", Offset = "0x27CA650", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000422")]
		public static v64 vclz_s16(v64 a0) { }

		[Address(RVA = "0x27CB290", Offset = "0x27CA690", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000424")]
		public static v64 vclz_s32(v64 a0) { }

		[Address(RVA = "0x27CB2D0", Offset = "0x27CA6D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000420")]
		public static v64 vclz_s8(v64 a0) { }

		[Address(RVA = "0x27CB310", Offset = "0x27CA710", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000428")]
		public static v64 vclz_u16(v64 a0) { }

		[Address(RVA = "0x27CB320", Offset = "0x27CA720", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x600042A")]
		public static v64 vclz_u32(v64 a0) { }

		[Address(RVA = "0x27CB330", Offset = "0x27CA730", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000426")]
		public static v64 vclz_u8(v64 a0) { }

		[Address(RVA = "0x27CB340", Offset = "0x27CA740", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000423")]
		public static v128 vclzq_s16(v128 a0) { }

		[Address(RVA = "0x27CB380", Offset = "0x27CA780", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000425")]
		public static v128 vclzq_s32(v128 a0) { }

		[Address(RVA = "0x27CB3C0", Offset = "0x27CA7C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000421")]
		public static v128 vclzq_s8(v128 a0) { }

		[Address(RVA = "0x27CB400", Offset = "0x27CA800", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000429")]
		public static v128 vclzq_u16(v128 a0) { }

		[Address(RVA = "0x27CB420", Offset = "0x27CA820", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600042B")]
		public static v128 vclzq_u32(v128 a0) { }

		[Address(RVA = "0x27CB440", Offset = "0x27CA840", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000427")]
		public static v128 vclzq_u8(v128 a0) { }

		[Address(RVA = "0x27CB460", Offset = "0x27CA860", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600042C")]
		public static v64 vcnt_s8(v64 a0) { }

		[Address(RVA = "0x27CB4A0", Offset = "0x27CA8A0", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x600042E")]
		public static v64 vcnt_u8(v64 a0) { }

		[Address(RVA = "0x27CB4B0", Offset = "0x27CA8B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600042D")]
		public static v128 vcntq_s8(v128 a0) { }

		[Address(RVA = "0x27CB4F0", Offset = "0x27CA8F0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600042F")]
		public static v128 vcntq_u8(v128 a0) { }

		[Address(RVA = "0x27CB510", Offset = "0x27CA910", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A1B")]
		public static v128 vcombine_f16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CB510", Offset = "0x27CA910", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A1C")]
		public static v128 vcombine_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CB510", Offset = "0x27CA910", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A1D")]
		public static v128 vcombine_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CB510", Offset = "0x27CA910", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A14")]
		public static v128 vcombine_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CB510", Offset = "0x27CA910", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A15")]
		public static v128 vcombine_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CB510", Offset = "0x27CA910", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A16")]
		public static v128 vcombine_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CB510", Offset = "0x27CA910", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A13")]
		public static v128 vcombine_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CB510", Offset = "0x27CA910", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A18")]
		public static v128 vcombine_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CB510", Offset = "0x27CA910", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A19")]
		public static v128 vcombine_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CB510", Offset = "0x27CA910", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A1A")]
		public static v128 vcombine_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CB510", Offset = "0x27CA910", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A17")]
		public static v128 vcombine_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CB530", Offset = "0x27CA930", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600086A")]
		public static v64 vcopy_lane_f32(v64 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x647940", Offset = "0x646D40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x600086C")]
		public static v64 vcopy_lane_f64(v64 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CB570", Offset = "0x27CA970", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600085C")]
		public static v64 vcopy_lane_s16(v64 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CB5B0", Offset = "0x27CA9B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600085E")]
		public static v64 vcopy_lane_s32(v64 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x647940", Offset = "0x646D40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000860")]
		public static v64 vcopy_lane_s64(v64 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CB5F0", Offset = "0x27CA9F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600085A")]
		public static v64 vcopy_lane_s8(v64 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CB630", Offset = "0x27CAA30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000864")]
		public static v64 vcopy_lane_u16(v64 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CB670", Offset = "0x27CAA70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000866")]
		public static v64 vcopy_lane_u32(v64 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x647940", Offset = "0x646D40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000868")]
		public static v64 vcopy_lane_u64(v64 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CB6B0", Offset = "0x27CAAB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000862")]
		public static v64 vcopy_lane_u8(v64 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CB6F0", Offset = "0x27CAAF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600087E")]
		public static v64 vcopy_laneq_f32(v64 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CB730", Offset = "0x27CAB30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000880")]
		public static v64 vcopy_laneq_f64(v64 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CB770", Offset = "0x27CAB70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000870")]
		public static v64 vcopy_laneq_s16(v64 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CB7B0", Offset = "0x27CABB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000872")]
		public static v64 vcopy_laneq_s32(v64 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CB7F0", Offset = "0x27CABF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000874")]
		public static v64 vcopy_laneq_s64(v64 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CB830", Offset = "0x27CAC30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600086E")]
		public static v64 vcopy_laneq_s8(v64 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CB870", Offset = "0x27CAC70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000878")]
		public static v64 vcopy_laneq_u16(v64 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CB8B0", Offset = "0x27CACB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600087A")]
		public static v64 vcopy_laneq_u32(v64 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CB8F0", Offset = "0x27CACF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600087C")]
		public static v64 vcopy_laneq_u64(v64 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CB930", Offset = "0x27CAD30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000876")]
		public static v64 vcopy_laneq_u8(v64 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CB970", Offset = "0x27CAD70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600086B")]
		public static v128 vcopyq_lane_f32(v128 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CB9B0", Offset = "0x27CADB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600086D")]
		public static v128 vcopyq_lane_f64(v128 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CB9F0", Offset = "0x27CADF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600085D")]
		public static v128 vcopyq_lane_s16(v128 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CBA30", Offset = "0x27CAE30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600085F")]
		public static v128 vcopyq_lane_s32(v128 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CBA70", Offset = "0x27CAE70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000861")]
		public static v128 vcopyq_lane_s64(v128 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CBAB0", Offset = "0x27CAEB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600085B")]
		public static v128 vcopyq_lane_s8(v128 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CBAF0", Offset = "0x27CAEF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000865")]
		public static v128 vcopyq_lane_u16(v128 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CBB30", Offset = "0x27CAF30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000867")]
		public static v128 vcopyq_lane_u32(v128 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CBB70", Offset = "0x27CAF70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000869")]
		public static v128 vcopyq_lane_u64(v128 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CBBB0", Offset = "0x27CAFB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000863")]
		public static v128 vcopyq_lane_u8(v128 a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CBBF0", Offset = "0x27CAFF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600087F")]
		public static v128 vcopyq_laneq_f32(v128 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CBC30", Offset = "0x27CB030", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000881")]
		public static v128 vcopyq_laneq_f64(v128 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CBC70", Offset = "0x27CB070", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000871")]
		public static v128 vcopyq_laneq_s16(v128 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CBCB0", Offset = "0x27CB0B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000873")]
		public static v128 vcopyq_laneq_s32(v128 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CBCF0", Offset = "0x27CB0F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000875")]
		public static v128 vcopyq_laneq_s64(v128 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CBD30", Offset = "0x27CB130", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600086F")]
		public static v128 vcopyq_laneq_s8(v128 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CBD70", Offset = "0x27CB170", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000879")]
		public static v128 vcopyq_laneq_u16(v128 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CBDB0", Offset = "0x27CB1B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600087B")]
		public static v128 vcopyq_laneq_u32(v128 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CBDF0", Offset = "0x27CB1F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600087D")]
		public static v128 vcopyq_laneq_u64(v128 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CBE30", Offset = "0x27CB230", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000877")]
		public static v128 vcopyq_laneq_u8(v128 a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009E8")]
		public static v64 vcreate_f16(ulong a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009E9")]
		public static v64 vcreate_f32(ulong a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009EA")]
		public static v64 vcreate_f64(ulong a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009E1")]
		public static v64 vcreate_s16(ulong a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009E2")]
		public static v64 vcreate_s32(ulong a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009E3")]
		public static v64 vcreate_s64(ulong a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009E0")]
		public static v64 vcreate_s8(ulong a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009E5")]
		public static v64 vcreate_u16(ulong a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009E6")]
		public static v64 vcreate_u32(ulong a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009E7")]
		public static v64 vcreate_u64(ulong a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009E4")]
		public static v64 vcreate_u8(ulong a0) { }

		[Address(RVA = "0x27CBEA0", Offset = "0x27CB2A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000766")]
		public static v64 vcvt_f32_f64(v128 a0) { }

		[Address(RVA = "0x27CBEE0", Offset = "0x27CB2E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600036B")]
		public static v64 vcvt_f32_s32(v64 a0) { }

		[Address(RVA = "0x27CBF20", Offset = "0x27CB320", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600036D")]
		public static v64 vcvt_f32_u32(v64 a0) { }

		[Address(RVA = "0x27CBF60", Offset = "0x27CB360", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000768")]
		public static v128 vcvt_f64_f32(v64 a0) { }

		[Address(RVA = "0x27CBFA0", Offset = "0x27CB3A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000758")]
		public static v64 vcvt_f64_s64(v64 a0) { }

		[Address(RVA = "0x27CBFE0", Offset = "0x27CB3E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600075A")]
		public static v64 vcvt_f64_u64(v64 a0) { }

		[Address(RVA = "0x27CC020", Offset = "0x27CB420", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000767")]
		public static v128 vcvt_high_f32_f64(v64 a0, v128 a1) { }

		[Address(RVA = "0x27CC060", Offset = "0x27CB460", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000769")]
		public static v128 vcvt_high_f64_f32(v128 a0) { }

		[Address(RVA = "0x27CC0A0", Offset = "0x27CB4A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600036F")]
		public static v64 vcvt_n_f32_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27CC0E0", Offset = "0x27CB4E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000371")]
		public static v64 vcvt_n_f32_u32(v64 a0, int a1) { }

		[Address(RVA = "0x27CC120", Offset = "0x27CB520", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000760")]
		public static v64 vcvt_n_f64_s64(v64 a0, int a1) { }

		[Address(RVA = "0x27CC160", Offset = "0x27CB560", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000762")]
		public static v64 vcvt_n_f64_u64(v64 a0, int a1) { }

		[Address(RVA = "0x27CC1A0", Offset = "0x27CB5A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000367")]
		public static v64 vcvt_n_s32_f32(v64 a0, int a1) { }

		[Address(RVA = "0x27CC1E0", Offset = "0x27CB5E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000750")]
		public static v64 vcvt_n_s64_f64(v64 a0, int a1) { }

		[Address(RVA = "0x27CC220", Offset = "0x27CB620", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000369")]
		public static v64 vcvt_n_u32_f32(v64 a0, int a1) { }

		[Address(RVA = "0x27CC260", Offset = "0x27CB660", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000752")]
		public static v64 vcvt_n_u64_f64(v64 a0, int a1) { }

		[Address(RVA = "0x27CC2A0", Offset = "0x27CB6A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000363")]
		public static v64 vcvt_s32_f32(v64 a0) { }

		[Address(RVA = "0x27CC2E0", Offset = "0x27CB6E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000730")]
		public static v64 vcvt_s64_f64(v64 a0) { }

		[Address(RVA = "0x27CC320", Offset = "0x27CB720", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000365")]
		public static v64 vcvt_u32_f32(v64 a0) { }

		[Address(RVA = "0x27CC360", Offset = "0x27CB760", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000732")]
		public static v64 vcvt_u64_f64(v64 a0) { }

		[Address(RVA = "0x27CC3A0", Offset = "0x27CB7A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000722")]
		public static v64 vcvta_s32_f32(v64 a0) { }

		[Address(RVA = "0x27CC3E0", Offset = "0x27CB7E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000740")]
		public static v64 vcvta_s64_f64(v64 a0) { }

		[Address(RVA = "0x27CC420", Offset = "0x27CB820", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000724")]
		public static v64 vcvta_u32_f32(v64 a0) { }

		[Address(RVA = "0x27CC460", Offset = "0x27CB860", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000742")]
		public static v64 vcvta_u64_f64(v64 a0) { }

		[Address(RVA = "0x27CC4A0", Offset = "0x27CB8A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600074C")]
		public static long vcvtad_s64_f64(double a0) { }

		[Address(RVA = "0x27CC4E0", Offset = "0x27CB8E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600074D")]
		public static ulong vcvtad_u64_f64(double a0) { }

		[Address(RVA = "0x27CC520", Offset = "0x27CB920", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000723")]
		public static v128 vcvtaq_s32_f32(v128 a0) { }

		[Address(RVA = "0x27CC560", Offset = "0x27CB960", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000741")]
		public static v128 vcvtaq_s64_f64(v128 a0) { }

		[Address(RVA = "0x27CC5A0", Offset = "0x27CB9A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000725")]
		public static v128 vcvtaq_u32_f32(v128 a0) { }

		[Address(RVA = "0x27CC5E0", Offset = "0x27CB9E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000743")]
		public static v128 vcvtaq_u64_f64(v128 a0) { }

		[Address(RVA = "0x27CC620", Offset = "0x27CBA20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600072E")]
		public static int vcvtas_s32_f32(float a0) { }

		[Address(RVA = "0x27CC660", Offset = "0x27CBA60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600072F")]
		public static uint vcvtas_u32_f32(float a0) { }

		[Address(RVA = "0x27CC6A0", Offset = "0x27CBAA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600075C")]
		public static double vcvtd_f64_s64(long a0) { }

		[Address(RVA = "0x27CC6E0", Offset = "0x27CBAE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600075D")]
		public static double vcvtd_f64_u64(ulong a0) { }

		[Address(RVA = "0x27CC720", Offset = "0x27CBB20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000764")]
		public static double vcvtd_n_f64_s64(long a0, int a1) { }

		[Address(RVA = "0x27CC760", Offset = "0x27CBB60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000765")]
		public static double vcvtd_n_f64_u64(ulong a0, int a1) { }

		[Address(RVA = "0x27CC7A0", Offset = "0x27CBBA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000754")]
		public static long vcvtd_n_s64_f64(double a0, int a1) { }

		[Address(RVA = "0x27CC7E0", Offset = "0x27CBBE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000755")]
		public static ulong vcvtd_n_u64_f64(double a0, int a1) { }

		[Address(RVA = "0x27CC820", Offset = "0x27CBC20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000744")]
		public static long vcvtd_s64_f64(double a0) { }

		[Address(RVA = "0x27CC860", Offset = "0x27CBC60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000745")]
		public static ulong vcvtd_u64_f64(double a0) { }

		[Address(RVA = "0x27CC8A0", Offset = "0x27CBCA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600071A")]
		public static v64 vcvtm_s32_f32(v64 a0) { }

		[Address(RVA = "0x27CC8E0", Offset = "0x27CBCE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000738")]
		public static v64 vcvtm_s64_f64(v64 a0) { }

		[Address(RVA = "0x27CC920", Offset = "0x27CBD20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600071C")]
		public static v64 vcvtm_u32_f32(v64 a0) { }

		[Address(RVA = "0x27CC960", Offset = "0x27CBD60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600073A")]
		public static v64 vcvtm_u64_f64(v64 a0) { }

		[Address(RVA = "0x27CC9A0", Offset = "0x27CBDA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000748")]
		public static long vcvtmd_s64_f64(double a0) { }

		[Address(RVA = "0x27CC9E0", Offset = "0x27CBDE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000749")]
		public static ulong vcvtmd_u64_f64(double a0) { }

		[Address(RVA = "0x27CCA20", Offset = "0x27CBE20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600071B")]
		public static v128 vcvtmq_s32_f32(v128 a0) { }

		[Address(RVA = "0x27CCA60", Offset = "0x27CBE60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000739")]
		public static v128 vcvtmq_s64_f64(v128 a0) { }

		[Address(RVA = "0x27CCAA0", Offset = "0x27CBEA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600071D")]
		public static v128 vcvtmq_u32_f32(v128 a0) { }

		[Address(RVA = "0x27CCAE0", Offset = "0x27CBEE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600073B")]
		public static v128 vcvtmq_u64_f64(v128 a0) { }

		[Address(RVA = "0x27CCB20", Offset = "0x27CBF20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600072A")]
		public static int vcvtms_s32_f32(float a0) { }

		[Address(RVA = "0x27CCB60", Offset = "0x27CBF60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600072B")]
		public static uint vcvtms_u32_f32(float a0) { }

		[Address(RVA = "0x27CCBA0", Offset = "0x27CBFA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000716")]
		public static v64 vcvtn_s32_f32(v64 a0) { }

		[Address(RVA = "0x27CCBE0", Offset = "0x27CBFE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000734")]
		public static v64 vcvtn_s64_f64(v64 a0) { }

		[Address(RVA = "0x27CCC20", Offset = "0x27CC020", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000718")]
		public static v64 vcvtn_u32_f32(v64 a0) { }

		[Address(RVA = "0x27CCC60", Offset = "0x27CC060", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000736")]
		public static v64 vcvtn_u64_f64(v64 a0) { }

		[Address(RVA = "0x27CCCA0", Offset = "0x27CC0A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000746")]
		public static long vcvtnd_s64_f64(double a0) { }

		[Address(RVA = "0x27CCCE0", Offset = "0x27CC0E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000747")]
		public static ulong vcvtnd_u64_f64(double a0) { }

		[Address(RVA = "0x27CCD20", Offset = "0x27CC120", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000717")]
		public static v128 vcvtnq_s32_f32(v128 a0) { }

		[Address(RVA = "0x27CCD60", Offset = "0x27CC160", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000735")]
		public static v128 vcvtnq_s64_f64(v128 a0) { }

		[Address(RVA = "0x27CCDA0", Offset = "0x27CC1A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000719")]
		public static v128 vcvtnq_u32_f32(v128 a0) { }

		[Address(RVA = "0x27CCDE0", Offset = "0x27CC1E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000737")]
		public static v128 vcvtnq_u64_f64(v128 a0) { }

		[Address(RVA = "0x27CCE20", Offset = "0x27CC220", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000728")]
		public static int vcvtns_s32_f32(float a0) { }

		[Address(RVA = "0x27CCE60", Offset = "0x27CC260", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000729")]
		public static uint vcvtns_u32_f32(float a0) { }

		[Address(RVA = "0x27CCEA0", Offset = "0x27CC2A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600071E")]
		public static v64 vcvtp_s32_f32(v64 a0) { }

		[Address(RVA = "0x27CCEE0", Offset = "0x27CC2E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600073C")]
		public static v64 vcvtp_s64_f64(v64 a0) { }

		[Address(RVA = "0x27CCF20", Offset = "0x27CC320", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000720")]
		public static v64 vcvtp_u32_f32(v64 a0) { }

		[Address(RVA = "0x27CCF60", Offset = "0x27CC360", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600073E")]
		public static v64 vcvtp_u64_f64(v64 a0) { }

		[Address(RVA = "0x27CCFA0", Offset = "0x27CC3A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600074A")]
		public static long vcvtpd_s64_f64(double a0) { }

		[Address(RVA = "0x27CCFE0", Offset = "0x27CC3E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600074B")]
		public static ulong vcvtpd_u64_f64(double a0) { }

		[Address(RVA = "0x27CD020", Offset = "0x27CC420", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600071F")]
		public static v128 vcvtpq_s32_f32(v128 a0) { }

		[Address(RVA = "0x27CD060", Offset = "0x27CC460", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600073D")]
		public static v128 vcvtpq_s64_f64(v128 a0) { }

		[Address(RVA = "0x27CD0A0", Offset = "0x27CC4A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000721")]
		public static v128 vcvtpq_u32_f32(v128 a0) { }

		[Address(RVA = "0x27CD0E0", Offset = "0x27CC4E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600073F")]
		public static v128 vcvtpq_u64_f64(v128 a0) { }

		[Address(RVA = "0x27CD120", Offset = "0x27CC520", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600072C")]
		public static int vcvtps_s32_f32(float a0) { }

		[Address(RVA = "0x27CD160", Offset = "0x27CC560", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600072D")]
		public static uint vcvtps_u32_f32(float a0) { }

		[Address(RVA = "0x27CD1A0", Offset = "0x27CC5A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600036C")]
		public static v128 vcvtq_f32_s32(v128 a0) { }

		[Address(RVA = "0x27CD1E0", Offset = "0x27CC5E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600036E")]
		public static v128 vcvtq_f32_u32(v128 a0) { }

		[Address(RVA = "0x27CD220", Offset = "0x27CC620", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000759")]
		public static v128 vcvtq_f64_s64(v128 a0) { }

		[Address(RVA = "0x27CD260", Offset = "0x27CC660", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600075B")]
		public static v128 vcvtq_f64_u64(v128 a0) { }

		[Address(RVA = "0x27CD2A0", Offset = "0x27CC6A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000370")]
		public static v128 vcvtq_n_f32_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27CD2E0", Offset = "0x27CC6E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000372")]
		public static v128 vcvtq_n_f32_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27CD320", Offset = "0x27CC720", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000761")]
		public static v128 vcvtq_n_f64_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27CD360", Offset = "0x27CC760", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000763")]
		public static v128 vcvtq_n_f64_u64(v128 a0, int a1) { }

		[Address(RVA = "0x27CD3A0", Offset = "0x27CC7A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000368")]
		public static v128 vcvtq_n_s32_f32(v128 a0, int a1) { }

		[Address(RVA = "0x27CD3E0", Offset = "0x27CC7E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000751")]
		public static v128 vcvtq_n_s64_f64(v128 a0, int a1) { }

		[Address(RVA = "0x27CD420", Offset = "0x27CC820", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600036A")]
		public static v128 vcvtq_n_u32_f32(v128 a0, int a1) { }

		[Address(RVA = "0x27CD460", Offset = "0x27CC860", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000753")]
		public static v128 vcvtq_n_u64_f64(v128 a0, int a1) { }

		[Address(RVA = "0x27CD4A0", Offset = "0x27CC8A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000364")]
		public static v128 vcvtq_s32_f32(v128 a0) { }

		[Address(RVA = "0x27CD4E0", Offset = "0x27CC8E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000731")]
		public static v128 vcvtq_s64_f64(v128 a0) { }

		[Address(RVA = "0x27CD520", Offset = "0x27CC920", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000366")]
		public static v128 vcvtq_u32_f32(v128 a0) { }

		[Address(RVA = "0x27CD560", Offset = "0x27CC960", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000733")]
		public static v128 vcvtq_u64_f64(v128 a0) { }

		[Address(RVA = "0x27CD5A0", Offset = "0x27CC9A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000756")]
		public static float vcvts_f32_s32(int a0) { }

		[Address(RVA = "0x27CD5E0", Offset = "0x27CC9E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000757")]
		public static float vcvts_f32_u32(uint a0) { }

		[Address(RVA = "0x27CD620", Offset = "0x27CCA20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600075E")]
		public static float vcvts_n_f32_s32(int a0, int a1) { }

		[Address(RVA = "0x27CD660", Offset = "0x27CCA60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600075F")]
		public static float vcvts_n_f32_u32(uint a0, int a1) { }

		[Address(RVA = "0x27CD6A0", Offset = "0x27CCAA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600074E")]
		public static int vcvts_n_s32_f32(float a0, int a1) { }

		[Address(RVA = "0x27CD6E0", Offset = "0x27CCAE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600074F")]
		public static uint vcvts_n_u32_f32(float a0, int a1) { }

		[Address(RVA = "0x27CD720", Offset = "0x27CCB20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000726")]
		public static int vcvts_s32_f32(float a0) { }

		[Address(RVA = "0x27CD760", Offset = "0x27CCB60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000727")]
		public static uint vcvts_u32_f32(float a0) { }

		[Address(RVA = "0x27CD7A0", Offset = "0x27CCBA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600076A")]
		public static v64 vcvtx_f32_f64(v128 a0) { }

		[Address(RVA = "0x27CD7E0", Offset = "0x27CCBE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600076C")]
		public static v128 vcvtx_high_f32_f64(v64 a0, v128 a1) { }

		[Address(RVA = "0x27CD820", Offset = "0x27CCC20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600076B")]
		public static float vcvtxd_f32_f64(double a0) { }

		[Address(RVA = "0x27CD860", Offset = "0x27CCC60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000590")]
		public static v64 vdiv_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CD8A0", Offset = "0x27CCCA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000592")]
		public static v64 vdiv_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CD8E0", Offset = "0x27CCCE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000591")]
		public static v128 vdivq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CD920", Offset = "0x27CCD20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000593")]
		public static v128 vdivq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CD960", Offset = "0x27CCD60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009B6")]
		public static v64 vdot_lane_s32(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CD9A0", Offset = "0x27CCDA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009B5")]
		public static v64 vdot_lane_u32(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CD9E0", Offset = "0x27CCDE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009BA")]
		public static v64 vdot_laneq_s32(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CDA20", Offset = "0x27CCE20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009B9")]
		public static v64 vdot_laneq_u32(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CDA60", Offset = "0x27CCE60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009B2")]
		public static v64 vdot_s32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27CDAA0", Offset = "0x27CCEA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009B1")]
		public static v64 vdot_u32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27CDAE0", Offset = "0x27CCEE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009BC")]
		public static v128 vdotq_lane_s32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CDB20", Offset = "0x27CCF20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009BB")]
		public static v128 vdotq_lane_u32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CDB60", Offset = "0x27CCF60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009B8")]
		public static v128 vdotq_laneq_s32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CDBA0", Offset = "0x27CCFA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009B7")]
		public static v128 vdotq_laneq_u32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CDBE0", Offset = "0x27CCFE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009B4")]
		public static v128 vdotq_s32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27CDC20", Offset = "0x27CD020", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009B3")]
		public static v128 vdotq_u32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27CDC60", Offset = "0x27CD060", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004BA")]
		public static v64 vdup_lane_f32(v64 a0, int a1) { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000886")]
		public static v64 vdup_lane_f64(v64 a0, int a1) { }

		[Address(RVA = "0x27CDCA0", Offset = "0x27CD0A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004AC")]
		public static v64 vdup_lane_s16(v64 a0, int a1) { }

		[Address(RVA = "0x27CDCE0", Offset = "0x27CD0E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004AE")]
		public static v64 vdup_lane_s32(v64 a0, int a1) { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004B0")]
		public static v64 vdup_lane_s64(v64 a0, int a1) { }

		[Address(RVA = "0x27CDD20", Offset = "0x27CD120", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004AA")]
		public static v64 vdup_lane_s8(v64 a0, int a1) { }

		[Address(RVA = "0x27CDD60", Offset = "0x27CD160", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004B4")]
		public static v64 vdup_lane_u16(v64 a0, int a1) { }

		[Address(RVA = "0x27CDDA0", Offset = "0x27CD1A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004B6")]
		public static v64 vdup_lane_u32(v64 a0, int a1) { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004B8")]
		public static v64 vdup_lane_u64(v64 a0, int a1) { }

		[Address(RVA = "0x27CDDE0", Offset = "0x27CD1E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004B2")]
		public static v64 vdup_lane_u8(v64 a0, int a1) { }

		[Address(RVA = "0x27CDE20", Offset = "0x27CD220", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000898")]
		public static v64 vdup_laneq_f32(v128 a0, int a1) { }

		[Address(RVA = "0x27CDE60", Offset = "0x27CD260", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600089A")]
		public static v64 vdup_laneq_f64(v128 a0, int a1) { }

		[Address(RVA = "0x27CDEA0", Offset = "0x27CD2A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600088A")]
		public static v64 vdup_laneq_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27CDEE0", Offset = "0x27CD2E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600088C")]
		public static v64 vdup_laneq_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27CDF20", Offset = "0x27CD320", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600088E")]
		public static v64 vdup_laneq_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27CDF60", Offset = "0x27CD360", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000888")]
		public static v64 vdup_laneq_s8(v128 a0, int a1) { }

		[Address(RVA = "0x27CDFA0", Offset = "0x27CD3A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000892")]
		public static v64 vdup_laneq_u16(v128 a0, int a1) { }

		[Address(RVA = "0x27CDFE0", Offset = "0x27CD3E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000894")]
		public static v64 vdup_laneq_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27CE020", Offset = "0x27CD420", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000896")]
		public static v64 vdup_laneq_u64(v128 a0, int a1) { }

		[Address(RVA = "0x27CE060", Offset = "0x27CD460", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000890")]
		public static v64 vdup_laneq_u8(v128 a0, int a1) { }

		[Address(RVA = "0x27CE0A0", Offset = "0x27CD4A0", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009FB")]
		public static v64 vdup_n_f32(float a0) { }

		[Address(RVA = "0x27CE0D0", Offset = "0x27CD4D0", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009FD")]
		public static v64 vdup_n_f64(double a0) { }

		[Address(RVA = "0x27CE100", Offset = "0x27CD500", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009ED")]
		public static v64 vdup_n_s16(short a0) { }

		[Address(RVA = "0x27CE130", Offset = "0x27CD530", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009EF")]
		public static v64 vdup_n_s32(int a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009F1")]
		public static v64 vdup_n_s64(long a0) { }

		[Address(RVA = "0x27CE160", Offset = "0x27CD560", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009EB")]
		public static v64 vdup_n_s8(sbyte a0) { }

		[Address(RVA = "0x27CE100", Offset = "0x27CD500", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009F5")]
		public static v64 vdup_n_u16(ushort a0) { }

		[Address(RVA = "0x27CE130", Offset = "0x27CD530", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009F7")]
		public static v64 vdup_n_u32(uint a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009F9")]
		public static v64 vdup_n_u64(ulong a0) { }

		[Address(RVA = "0x27CE160", Offset = "0x27CD560", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009F3")]
		public static v64 vdup_n_u8(byte a0) { }

		[Address(RVA = "0x27CE190", Offset = "0x27CD590", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600089C")]
		public static sbyte vdupb_lane_s8(v64 a0, int a1) { }

		[Address(RVA = "0x27CE1D0", Offset = "0x27CD5D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008A0")]
		public static byte vdupb_lane_u8(v64 a0, int a1) { }

		[Address(RVA = "0x27CE210", Offset = "0x27CD610", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008A6")]
		public static sbyte vdupb_laneq_s8(v128 a0, int a1) { }

		[Address(RVA = "0x27CE250", Offset = "0x27CD650", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008AA")]
		public static byte vdupb_laneq_u8(v128 a0, int a1) { }

		[Address(RVA = "0x27CE290", Offset = "0x27CD690", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008A5")]
		public static double vdupd_lane_f64(v64 a0, int a1) { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x600089F")]
		public static long vdupd_lane_s64(v64 a0, int a1) { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008A3")]
		public static ulong vdupd_lane_u64(v64 a0, int a1) { }

		[Address(RVA = "0x27CE2A0", Offset = "0x27CD6A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008AF")]
		public static double vdupd_laneq_f64(v128 a0, int a1) { }

		[Address(RVA = "0x27CE2E0", Offset = "0x27CD6E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008A9")]
		public static long vdupd_laneq_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27CE320", Offset = "0x27CD720", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008AD")]
		public static ulong vdupd_laneq_u64(v128 a0, int a1) { }

		[Address(RVA = "0x27CE360", Offset = "0x27CD760", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600089D")]
		public static short vduph_lane_s16(v64 a0, int a1) { }

		[Address(RVA = "0x27CE3A0", Offset = "0x27CD7A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008A1")]
		public static ushort vduph_lane_u16(v64 a0, int a1) { }

		[Address(RVA = "0x27CE3E0", Offset = "0x27CD7E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008A7")]
		public static short vduph_laneq_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27CE420", Offset = "0x27CD820", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008AB")]
		public static ushort vduph_laneq_u16(v128 a0, int a1) { }

		[Address(RVA = "0x27CE460", Offset = "0x27CD860", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004BB")]
		public static v128 vdupq_lane_f32(v64 a0, int a1) { }

		[Address(RVA = "0x27CE4A0", Offset = "0x27CD8A0", Length = "0x23")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000887")]
		public static v128 vdupq_lane_f64(v64 a0, int a1) { }

		[Address(RVA = "0x27CE4D0", Offset = "0x27CD8D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004AD")]
		public static v128 vdupq_lane_s16(v64 a0, int a1) { }

		[Address(RVA = "0x27CE510", Offset = "0x27CD910", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004AF")]
		public static v128 vdupq_lane_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27CE4A0", Offset = "0x27CD8A0", Length = "0x23")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004B1")]
		public static v128 vdupq_lane_s64(v64 a0, int a1) { }

		[Address(RVA = "0x27CE550", Offset = "0x27CD950", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004AB")]
		public static v128 vdupq_lane_s8(v64 a0, int a1) { }

		[Address(RVA = "0x27CE590", Offset = "0x27CD990", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004B5")]
		public static v128 vdupq_lane_u16(v64 a0, int a1) { }

		[Address(RVA = "0x27CE5D0", Offset = "0x27CD9D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004B7")]
		public static v128 vdupq_lane_u32(v64 a0, int a1) { }

		[Address(RVA = "0x27CE4A0", Offset = "0x27CD8A0", Length = "0x23")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004B9")]
		public static v128 vdupq_lane_u64(v64 a0, int a1) { }

		[Address(RVA = "0x27CE610", Offset = "0x27CDA10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004B3")]
		public static v128 vdupq_lane_u8(v64 a0, int a1) { }

		[Address(RVA = "0x27CE650", Offset = "0x27CDA50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000899")]
		public static v128 vdupq_laneq_f32(v128 a0, int a1) { }

		[Address(RVA = "0x27CE690", Offset = "0x27CDA90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600089B")]
		public static v128 vdupq_laneq_f64(v128 a0, int a1) { }

		[Address(RVA = "0x27CE6D0", Offset = "0x27CDAD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600088B")]
		public static v128 vdupq_laneq_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27CE710", Offset = "0x27CDB10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600088D")]
		public static v128 vdupq_laneq_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27CE750", Offset = "0x27CDB50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600088F")]
		public static v128 vdupq_laneq_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27CE790", Offset = "0x27CDB90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000889")]
		public static v128 vdupq_laneq_s8(v128 a0, int a1) { }

		[Address(RVA = "0x27CE7D0", Offset = "0x27CDBD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000893")]
		public static v128 vdupq_laneq_u16(v128 a0, int a1) { }

		[Address(RVA = "0x27CE810", Offset = "0x27CDC10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000895")]
		public static v128 vdupq_laneq_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27CE850", Offset = "0x27CDC50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000897")]
		public static v128 vdupq_laneq_u64(v128 a0, int a1) { }

		[Address(RVA = "0x27CE890", Offset = "0x27CDC90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000891")]
		public static v128 vdupq_laneq_u8(v128 a0, int a1) { }

		[Address(RVA = "0x27CE8D0", Offset = "0x27CDCD0", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009FC")]
		public static v128 vdupq_n_f32(float a0) { }

		[Address(RVA = "0x27CE8F0", Offset = "0x27CDCF0", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009FE")]
		public static v128 vdupq_n_f64(double a0) { }

		[Address(RVA = "0x27CE910", Offset = "0x27CDD10", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009EE")]
		public static v128 vdupq_n_s16(short a0) { }

		[Address(RVA = "0x27CE930", Offset = "0x27CDD30", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009F0")]
		public static v128 vdupq_n_s32(int a0) { }

		[Address(RVA = "0x27CE950", Offset = "0x27CDD50", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009F2")]
		public static v128 vdupq_n_s64(long a0) { }

		[Address(RVA = "0x27CE970", Offset = "0x27CDD70", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009EC")]
		public static v128 vdupq_n_s8(sbyte a0) { }

		[Address(RVA = "0x27CE910", Offset = "0x27CDD10", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009F6")]
		public static v128 vdupq_n_u16(ushort a0) { }

		[Address(RVA = "0x27CE930", Offset = "0x27CDD30", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009F8")]
		public static v128 vdupq_n_u32(uint a0) { }

		[Address(RVA = "0x27CE950", Offset = "0x27CDD50", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009FA")]
		public static v128 vdupq_n_u64(ulong a0) { }

		[Address(RVA = "0x27CE970", Offset = "0x27CDD70", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009F4")]
		public static v128 vdupq_n_u8(byte a0) { }

		[Address(RVA = "0x27CE990", Offset = "0x27CDD90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008A4")]
		public static float vdups_lane_f32(v64 a0, int a1) { }

		[Address(RVA = "0x27CE9D0", Offset = "0x27CDDD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600089E")]
		public static int vdups_lane_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27CEA10", Offset = "0x27CDE10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008A2")]
		public static uint vdups_lane_u32(v64 a0, int a1) { }

		[Address(RVA = "0x27CEA50", Offset = "0x27CDE50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008AE")]
		public static float vdups_laneq_f32(v128 a0, int a1) { }

		[Address(RVA = "0x27CEA90", Offset = "0x27CDE90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008A8")]
		public static int vdups_laneq_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27CEAD0", Offset = "0x27CDED0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008AC")]
		public static uint vdups_laneq_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27CEB10", Offset = "0x27CDF10", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600046A")]
		public static v64 veor_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CEB10", Offset = "0x27CDF10", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600046C")]
		public static v64 veor_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CEB10", Offset = "0x27CDF10", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600046E")]
		public static v64 veor_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CEB20", Offset = "0x27CDF20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000468")]
		public static v64 veor_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CEB10", Offset = "0x27CDF10", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000472")]
		public static v64 veor_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CEB10", Offset = "0x27CDF10", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000474")]
		public static v64 veor_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CEB10", Offset = "0x27CDF10", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000476")]
		public static v64 veor_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CEB10", Offset = "0x27CDF10", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000470")]
		public static v64 veor_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CEB60", Offset = "0x27CDF60", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600046B")]
		public static v128 veorq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CEB60", Offset = "0x27CDF60", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600046D")]
		public static v128 veorq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CEB60", Offset = "0x27CDF60", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600046F")]
		public static v128 veorq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CEB90", Offset = "0x27CDF90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000469")]
		public static v128 veorq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CEB60", Offset = "0x27CDF60", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000473")]
		public static v128 veorq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CEB60", Offset = "0x27CDF60", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000475")]
		public static v128 veorq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CEB60", Offset = "0x27CDF60", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000477")]
		public static v128 veorq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CEB60", Offset = "0x27CDF60", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000471")]
		public static v128 veorq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CEBD0", Offset = "0x27CDFD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004F9")]
		public static v64 vext_f32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x600091D")]
		public static v64 vext_f64(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27CEC10", Offset = "0x27CE010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004EB")]
		public static v64 vext_s16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27CEC50", Offset = "0x27CE050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004ED")]
		public static v64 vext_s32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004EF")]
		public static v64 vext_s64(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27CEC90", Offset = "0x27CE090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004E9")]
		public static v64 vext_s8(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27CECD0", Offset = "0x27CE0D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004F3")]
		public static v64 vext_u16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27CED10", Offset = "0x27CE110", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004F5")]
		public static v64 vext_u32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004F7")]
		public static v64 vext_u64(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27CED50", Offset = "0x27CE150", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004F1")]
		public static v64 vext_u8(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27CED90", Offset = "0x27CE190", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004FA")]
		public static v128 vextq_f32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27CEDD0", Offset = "0x27CE1D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600091E")]
		public static v128 vextq_f64(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27CEE10", Offset = "0x27CE210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004EC")]
		public static v128 vextq_s16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27CEE50", Offset = "0x27CE250", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004EE")]
		public static v128 vextq_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27CEE90", Offset = "0x27CE290", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004F0")]
		public static v128 vextq_s64(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27CEED0", Offset = "0x27CE2D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004EA")]
		public static v128 vextq_s8(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27CEF10", Offset = "0x27CE310", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004F4")]
		public static v128 vextq_u16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27CEF50", Offset = "0x27CE350", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004F6")]
		public static v128 vextq_u32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27CEF90", Offset = "0x27CE390", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004F8")]
		public static v128 vextq_u64(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27CEFD0", Offset = "0x27CE3D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004F2")]
		public static v128 vextq_u8(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27CF010", Offset = "0x27CE410", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600017D")]
		public static v64 vfma_f32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27CF050", Offset = "0x27CE450", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005A4")]
		public static v64 vfma_f64(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27CF090", Offset = "0x27CE490", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005A6")]
		public static v64 vfma_lane_f32(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CF0D0", Offset = "0x27CE4D0", Length = "0xC")]
		[BurstTargetCpu(BurstTargetCpu::ARMV8A_AARCH64 (9))]
		[DebuggerStepThrough]
		[Token(Token = "0x60005A8")]
		public static v64 vfma_lane_f64(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CF0E0", Offset = "0x27CE4E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005AC")]
		public static v64 vfma_laneq_f32(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CF120", Offset = "0x27CE520", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005AE")]
		public static v64 vfma_laneq_f64(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CF160", Offset = "0x27CE560", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600053D")]
		public static v64 vfma_n_f32(v64 a0, v64 a1, float a2) { }

		[Address(RVA = "0x27CF1A0", Offset = "0x27CE5A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000995")]
		public static v64 vfma_n_f64(v64 a0, v64 a1, double a2) { }

		[Address(RVA = "0x27CF1E0", Offset = "0x27CE5E0", Length = "0x58")]
		[BurstTargetCpu(BurstTargetCpu::ARMV8A_AARCH64 (9))]
		[DebuggerStepThrough]
		[Token(Token = "0x60005AB")]
		public static double vfmad_lane_f64(double a0, double a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CF240", Offset = "0x27CE640", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005B1")]
		public static double vfmad_laneq_f64(double a0, double a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CF280", Offset = "0x27CE680", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600017E")]
		public static v128 vfmaq_f32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27CF2C0", Offset = "0x27CE6C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005A5")]
		public static v128 vfmaq_f64(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27CF300", Offset = "0x27CE700", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005A7")]
		public static v128 vfmaq_lane_f32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CF340", Offset = "0x27CE740", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005A9")]
		public static v128 vfmaq_lane_f64(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CF380", Offset = "0x27CE780", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005AD")]
		public static v128 vfmaq_laneq_f32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CF3C0", Offset = "0x27CE7C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005AF")]
		public static v128 vfmaq_laneq_f64(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CF400", Offset = "0x27CE800", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600053E")]
		public static v128 vfmaq_n_f32(v128 a0, v128 a1, float a2) { }

		[Address(RVA = "0x27CF440", Offset = "0x27CE840", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000996")]
		public static v128 vfmaq_n_f64(v128 a0, v128 a1, double a2) { }

		[Address(RVA = "0x27CF480", Offset = "0x27CE880", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005AA")]
		public static float vfmas_lane_f32(float a0, float a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CF4C0", Offset = "0x27CE8C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005B0")]
		public static float vfmas_laneq_f32(float a0, float a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CF500", Offset = "0x27CE900", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600017F")]
		public static v64 vfms_f32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27CF540", Offset = "0x27CE940", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005B2")]
		public static v64 vfms_f64(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27CF580", Offset = "0x27CE980", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005B4")]
		public static v64 vfms_lane_f32(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CF5C0", Offset = "0x27CE9C0", Length = "0xC")]
		[BurstTargetCpu(BurstTargetCpu::ARMV8A_AARCH64 (9))]
		[DebuggerStepThrough]
		[Token(Token = "0x60005B6")]
		public static v64 vfms_lane_f64(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CF5D0", Offset = "0x27CE9D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005BA")]
		public static v64 vfms_laneq_f32(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CF610", Offset = "0x27CEA10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005BC")]
		public static v64 vfms_laneq_f64(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CF650", Offset = "0x27CEA50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000993")]
		public static v64 vfms_n_f32(v64 a0, v64 a1, float a2) { }

		[Address(RVA = "0x27CF690", Offset = "0x27CEA90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000997")]
		public static v64 vfms_n_f64(v64 a0, v64 a1, double a2) { }

		[Address(RVA = "0x27CF6D0", Offset = "0x27CEAD0", Length = "0x58")]
		[BurstTargetCpu(BurstTargetCpu::ARMV8A_AARCH64 (9))]
		[DebuggerStepThrough]
		[Token(Token = "0x60005B9")]
		public static double vfmsd_lane_f64(double a0, double a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CF730", Offset = "0x27CEB30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005BF")]
		public static double vfmsd_laneq_f64(double a0, double a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CF770", Offset = "0x27CEB70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000180")]
		public static v128 vfmsq_f32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27CF7B0", Offset = "0x27CEBB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005B3")]
		public static v128 vfmsq_f64(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27CF7F0", Offset = "0x27CEBF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005B5")]
		public static v128 vfmsq_lane_f32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CF830", Offset = "0x27CEC30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005B7")]
		public static v128 vfmsq_lane_f64(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CF870", Offset = "0x27CEC70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005BB")]
		public static v128 vfmsq_laneq_f32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CF8B0", Offset = "0x27CECB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005BD")]
		public static v128 vfmsq_laneq_f64(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27CF8F0", Offset = "0x27CECF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000994")]
		public static v128 vfmsq_n_f32(v128 a0, v128 a1, float a2) { }

		[Address(RVA = "0x27CF930", Offset = "0x27CED30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000998")]
		public static v128 vfmsq_n_f64(v128 a0, v128 a1, double a2) { }

		[Address(RVA = "0x27CF970", Offset = "0x27CED70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005B8")]
		public static float vfmss_lane_f32(float a0, float a1, v64 a2, int a3) { }

		[Address(RVA = "0x27CF9B0", Offset = "0x27CEDB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005BE")]
		public static float vfmss_laneq_f32(float a0, float a1, v128 a2, int a3) { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A26")]
		public static v64 vget_high_f32(v128 a0) { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A27")]
		public static v64 vget_high_f64(v128 a0) { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A1F")]
		public static v64 vget_high_s16(v128 a0) { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A20")]
		public static v64 vget_high_s32(v128 a0) { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A21")]
		public static v64 vget_high_s64(v128 a0) { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A1E")]
		public static v64 vget_high_s8(v128 a0) { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A23")]
		public static v64 vget_high_u16(v128 a0) { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A24")]
		public static v64 vget_high_u32(v128 a0) { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A25")]
		public static v64 vget_high_u64(v128 a0) { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A22")]
		public static v64 vget_high_u8(v128 a0) { }

		[Address(RVA = "0x27CF9F0", Offset = "0x27CEDF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000521")]
		public static float vget_lane_f32(v64 a0, int a1) { }

		[Address(RVA = "0x27CE290", Offset = "0x27CD690", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600098D")]
		public static double vget_lane_f64(v64 a0, int a1) { }

		[Address(RVA = "0x27CFA30", Offset = "0x27CEE30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600051E")]
		public static short vget_lane_s16(v64 a0, int a1) { }

		[Address(RVA = "0x27CFA70", Offset = "0x27CEE70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600051F")]
		public static int vget_lane_s32(v64 a0, int a1) { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000520")]
		public static long vget_lane_s64(v64 a0, int a1) { }

		[Address(RVA = "0x27CFAB0", Offset = "0x27CEEB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600051D")]
		public static sbyte vget_lane_s8(v64 a0, int a1) { }

		[Address(RVA = "0x27CFAF0", Offset = "0x27CEEF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600051A")]
		public static ushort vget_lane_u16(v64 a0, int a1) { }

		[Address(RVA = "0x27CFB30", Offset = "0x27CEF30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600051B")]
		public static uint vget_lane_u32(v64 a0, int a1) { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x600051C")]
		public static ulong vget_lane_u64(v64 a0, int a1) { }

		[Address(RVA = "0x27CFB70", Offset = "0x27CEF70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000519")]
		public static byte vget_lane_u8(v64 a0, int a1) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A30")]
		public static v64 vget_low_f32(v128 a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A31")]
		public static v64 vget_low_f64(v128 a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A29")]
		public static v64 vget_low_s16(v128 a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A2A")]
		public static v64 vget_low_s32(v128 a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A2B")]
		public static v64 vget_low_s64(v128 a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A28")]
		public static v64 vget_low_s8(v128 a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A2D")]
		public static v64 vget_low_u16(v128 a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A2E")]
		public static v64 vget_low_u32(v128 a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A2F")]
		public static v64 vget_low_u64(v128 a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A2C")]
		public static v64 vget_low_u8(v128 a0) { }

		[Address(RVA = "0x27CFBB0", Offset = "0x27CEFB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600052A")]
		public static float vgetq_lane_f32(v128 a0, int a1) { }

		[Address(RVA = "0x27CFBF0", Offset = "0x27CEFF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600098E")]
		public static double vgetq_lane_f64(v128 a0, int a1) { }

		[Address(RVA = "0x27CFC30", Offset = "0x27CF030", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000527")]
		public static short vgetq_lane_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27CFC70", Offset = "0x27CF070", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000528")]
		public static int vgetq_lane_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27CFCB0", Offset = "0x27CF0B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000529")]
		public static long vgetq_lane_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27CFCF0", Offset = "0x27CF0F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000526")]
		public static sbyte vgetq_lane_s8(v128 a0, int a1) { }

		[Address(RVA = "0x27CFD30", Offset = "0x27CF130", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000523")]
		public static ushort vgetq_lane_u16(v128 a0, int a1) { }

		[Address(RVA = "0x27CFD70", Offset = "0x27CF170", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000524")]
		public static uint vgetq_lane_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27CFDB0", Offset = "0x27CF1B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000525")]
		public static ulong vgetq_lane_u64(v128 a0, int a1) { }

		[Address(RVA = "0x27CFDF0", Offset = "0x27CF1F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000522")]
		public static byte vgetq_lane_u8(v128 a0, int a1) { }

		[Address(RVA = "0x27CFE30", Offset = "0x27CF230", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000115")]
		public static v64 vhadd_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CFE70", Offset = "0x27CF270", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000117")]
		public static v64 vhadd_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CFEB0", Offset = "0x27CF2B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000113")]
		public static v64 vhadd_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CFEF0", Offset = "0x27CF2F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600011B")]
		public static v64 vhadd_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CFF30", Offset = "0x27CF330", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600011D")]
		public static v64 vhadd_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CFF70", Offset = "0x27CF370", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000119")]
		public static v64 vhadd_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27CFFB0", Offset = "0x27CF3B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000116")]
		public static v128 vhaddq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27CFFF0", Offset = "0x27CF3F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000118")]
		public static v128 vhaddq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D0030", Offset = "0x27CF430", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000114")]
		public static v128 vhaddq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D0070", Offset = "0x27CF470", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600011C")]
		public static v128 vhaddq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D00B0", Offset = "0x27CF4B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600011E")]
		public static v128 vhaddq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D00F0", Offset = "0x27CF4F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600011A")]
		public static v128 vhaddq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D0130", Offset = "0x27CF530", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001B5")]
		public static v64 vhsub_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0170", Offset = "0x27CF570", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001B7")]
		public static v64 vhsub_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D01B0", Offset = "0x27CF5B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001B3")]
		public static v64 vhsub_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D01F0", Offset = "0x27CF5F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001BB")]
		public static v64 vhsub_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0230", Offset = "0x27CF630", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001BD")]
		public static v64 vhsub_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0270", Offset = "0x27CF670", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001B9")]
		public static v64 vhsub_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D02B0", Offset = "0x27CF6B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001B6")]
		public static v128 vhsubq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D02F0", Offset = "0x27CF6F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001B8")]
		public static v128 vhsubq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D0330", Offset = "0x27CF730", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001B4")]
		public static v128 vhsubq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D0370", Offset = "0x27CF770", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001BC")]
		public static v128 vhsubq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D03B0", Offset = "0x27CF7B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001BE")]
		public static v128 vhsubq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D03F0", Offset = "0x27CF7F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001BA")]
		public static v128 vhsubq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A42")]
		public static v64 vld1_f32(Single* a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A44")]
		public static v64 vld1_f64(Double* a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A34")]
		public static v64 vld1_s16(Int16* a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A36")]
		public static v64 vld1_s32(Int32* a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A38")]
		public static v64 vld1_s64(Int64* a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A32")]
		public static v64 vld1_s8(SByte* a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A3C")]
		public static v64 vld1_u16(UInt16* a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A3E")]
		public static v64 vld1_u32(UInt32* a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A40")]
		public static v64 vld1_u64(UInt64* a0) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A3A")]
		public static v64 vld1_u8(Byte* a0) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A43")]
		public static v128 vld1q_f32(Single* a0) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A45")]
		public static v128 vld1q_f64(Double* a0) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A35")]
		public static v128 vld1q_s16(Int16* a0) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A37")]
		public static v128 vld1q_s32(Int32* a0) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A39")]
		public static v128 vld1q_s64(Int64* a0) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A33")]
		public static v128 vld1q_s8(SByte* a0) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A3D")]
		public static v128 vld1q_u16(UInt16* a0) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A3F")]
		public static v128 vld1q_u32(UInt32* a0) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A41")]
		public static v128 vld1q_u64(UInt64* a0) { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A3B")]
		public static v128 vld1q_u8(Byte* a0) { }

		[Address(RVA = "0x27D0430", Offset = "0x27CF830", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000267")]
		public static v64 vmax_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0470", Offset = "0x27CF870", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006A6")]
		public static v64 vmax_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D04B0", Offset = "0x27CF8B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600025D")]
		public static v64 vmax_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D04F0", Offset = "0x27CF8F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600025F")]
		public static v64 vmax_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0530", Offset = "0x27CF930", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600025B")]
		public static v64 vmax_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0570", Offset = "0x27CF970", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000263")]
		public static v64 vmax_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D05B0", Offset = "0x27CF9B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000265")]
		public static v64 vmax_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D05F0", Offset = "0x27CF9F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000261")]
		public static v64 vmax_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0630", Offset = "0x27CFA30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006AA")]
		public static v64 vmaxnm_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0670", Offset = "0x27CFA70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006AC")]
		public static v64 vmaxnm_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D06B0", Offset = "0x27CFAB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006AB")]
		public static v128 vmaxnmq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D06F0", Offset = "0x27CFAF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006AD")]
		public static v128 vmaxnmq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D0730", Offset = "0x27CFB30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000917")]
		public static float vmaxnmv_f32(v64 a0) { }

		[Address(RVA = "0x27D0770", Offset = "0x27CFB70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000918")]
		public static float vmaxnmvq_f32(v128 a0) { }

		[Address(RVA = "0x27D07B0", Offset = "0x27CFBB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000919")]
		public static double vmaxnmvq_f64(v128 a0) { }

		[Address(RVA = "0x27D07F0", Offset = "0x27CFBF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000268")]
		public static v128 vmaxq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D0830", Offset = "0x27CFC30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006A7")]
		public static v128 vmaxq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D0870", Offset = "0x27CFC70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600025E")]
		public static v128 vmaxq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D08B0", Offset = "0x27CFCB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000260")]
		public static v128 vmaxq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D08F0", Offset = "0x27CFCF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600025C")]
		public static v128 vmaxq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D0930", Offset = "0x27CFD30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000264")]
		public static v128 vmaxq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D0970", Offset = "0x27CFD70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000266")]
		public static v128 vmaxq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D09B0", Offset = "0x27CFDB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000262")]
		public static v128 vmaxq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D09F0", Offset = "0x27CFDF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000905")]
		public static float vmaxv_f32(v64 a0) { }

		[Address(RVA = "0x27D0A30", Offset = "0x27CFE30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008FB")]
		public static short vmaxv_s16(v64 a0) { }

		[Address(RVA = "0x27D0A70", Offset = "0x27CFE70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008FD")]
		public static int vmaxv_s32(v64 a0) { }

		[Address(RVA = "0x27D0AB0", Offset = "0x27CFEB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008F9")]
		public static sbyte vmaxv_s8(v64 a0) { }

		[Address(RVA = "0x27D0AF0", Offset = "0x27CFEF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000901")]
		public static ushort vmaxv_u16(v64 a0) { }

		[Address(RVA = "0x27D0B30", Offset = "0x27CFF30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000903")]
		public static uint vmaxv_u32(v64 a0) { }

		[Address(RVA = "0x27D0B70", Offset = "0x27CFF70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008FF")]
		public static byte vmaxv_u8(v64 a0) { }

		[Address(RVA = "0x27D0BB0", Offset = "0x27CFFB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000906")]
		public static float vmaxvq_f32(v128 a0) { }

		[Address(RVA = "0x27D0BF0", Offset = "0x27CFFF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000907")]
		public static double vmaxvq_f64(v128 a0) { }

		[Address(RVA = "0x27D0C30", Offset = "0x27D0030", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008FC")]
		public static short vmaxvq_s16(v128 a0) { }

		[Address(RVA = "0x27D0C70", Offset = "0x27D0070", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008FE")]
		public static int vmaxvq_s32(v128 a0) { }

		[Address(RVA = "0x27D0CB0", Offset = "0x27D00B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008FA")]
		public static sbyte vmaxvq_s8(v128 a0) { }

		[Address(RVA = "0x27D0CF0", Offset = "0x27D00F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000902")]
		public static ushort vmaxvq_u16(v128 a0) { }

		[Address(RVA = "0x27D0D30", Offset = "0x27D0130", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000904")]
		public static uint vmaxvq_u32(v128 a0) { }

		[Address(RVA = "0x27D0D70", Offset = "0x27D0170", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000900")]
		public static byte vmaxvq_u8(v128 a0) { }

		[Address(RVA = "0x27D0DB0", Offset = "0x27D01B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000275")]
		public static v64 vmin_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0DF0", Offset = "0x27D01F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006A8")]
		public static v64 vmin_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0E30", Offset = "0x27D0230", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600026B")]
		public static v64 vmin_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0E70", Offset = "0x27D0270", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600026D")]
		public static v64 vmin_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0EB0", Offset = "0x27D02B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000269")]
		public static v64 vmin_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0EF0", Offset = "0x27D02F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000271")]
		public static v64 vmin_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0F30", Offset = "0x27D0330", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000273")]
		public static v64 vmin_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0F70", Offset = "0x27D0370", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600026F")]
		public static v64 vmin_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0FB0", Offset = "0x27D03B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006AE")]
		public static v64 vminnm_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D0FF0", Offset = "0x27D03F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006B0")]
		public static v64 vminnm_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D1030", Offset = "0x27D0430", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006AF")]
		public static v128 vminnmq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D1070", Offset = "0x27D0470", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006B1")]
		public static v128 vminnmq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D10B0", Offset = "0x27D04B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600091A")]
		public static float vminnmv_f32(v64 a0) { }

		[Address(RVA = "0x27D10F0", Offset = "0x27D04F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600091B")]
		public static float vminnmvq_f32(v128 a0) { }

		[Address(RVA = "0x27D1130", Offset = "0x27D0530", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600091C")]
		public static double vminnmvq_f64(v128 a0) { }

		[Address(RVA = "0x27D1170", Offset = "0x27D0570", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000276")]
		public static v128 vminq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D11B0", Offset = "0x27D05B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006A9")]
		public static v128 vminq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D11F0", Offset = "0x27D05F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600026C")]
		public static v128 vminq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D1230", Offset = "0x27D0630", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600026E")]
		public static v128 vminq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D1270", Offset = "0x27D0670", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600026A")]
		public static v128 vminq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D12B0", Offset = "0x27D06B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000272")]
		public static v128 vminq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D12F0", Offset = "0x27D06F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000274")]
		public static v128 vminq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D1330", Offset = "0x27D0730", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000270")]
		public static v128 vminq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D1370", Offset = "0x27D0770", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000914")]
		public static float vminv_f32(v64 a0) { }

		[Address(RVA = "0x27D13B0", Offset = "0x27D07B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600090A")]
		public static short vminv_s16(v64 a0) { }

		[Address(RVA = "0x27D13F0", Offset = "0x27D07F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600090C")]
		public static int vminv_s32(v64 a0) { }

		[Address(RVA = "0x27D1430", Offset = "0x27D0830", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000908")]
		public static sbyte vminv_s8(v64 a0) { }

		[Address(RVA = "0x27D1470", Offset = "0x27D0870", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000910")]
		public static ushort vminv_u16(v64 a0) { }

		[Address(RVA = "0x27D14B0", Offset = "0x27D08B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000912")]
		public static uint vminv_u32(v64 a0) { }

		[Address(RVA = "0x27D14F0", Offset = "0x27D08F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600090E")]
		public static byte vminv_u8(v64 a0) { }

		[Address(RVA = "0x27D1530", Offset = "0x27D0930", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000915")]
		public static float vminvq_f32(v128 a0) { }

		[Address(RVA = "0x27D1570", Offset = "0x27D0970", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000916")]
		public static double vminvq_f64(v128 a0) { }

		[Address(RVA = "0x27D15B0", Offset = "0x27D09B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600090B")]
		public static short vminvq_s16(v128 a0) { }

		[Address(RVA = "0x27D15F0", Offset = "0x27D09F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600090D")]
		public static int vminvq_s32(v128 a0) { }

		[Address(RVA = "0x27D1630", Offset = "0x27D0A30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000909")]
		public static sbyte vminvq_s8(v128 a0) { }

		[Address(RVA = "0x27D1670", Offset = "0x27D0A70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000911")]
		public static ushort vminvq_u16(v128 a0) { }

		[Address(RVA = "0x27D16B0", Offset = "0x27D0AB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000913")]
		public static uint vminvq_u32(v128 a0) { }

		[Address(RVA = "0x27D16F0", Offset = "0x27D0AF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600090F")]
		public static byte vminvq_u8(v128 a0) { }

		[Address(RVA = "0x27D1730", Offset = "0x27D0B30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000161")]
		public static v64 vmla_f32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D1770", Offset = "0x27D0B70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000594")]
		public static v64 vmla_f64(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D17B0", Offset = "0x27D0BB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000396")]
		public static v64 vmla_lane_f32(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D17F0", Offset = "0x27D0BF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600038E")]
		public static v64 vmla_lane_s16(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D1830", Offset = "0x27D0C30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000390")]
		public static v64 vmla_lane_s32(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D1870", Offset = "0x27D0C70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000392")]
		public static v64 vmla_lane_u16(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D18B0", Offset = "0x27D0CB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000394")]
		public static v64 vmla_lane_u32(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D18F0", Offset = "0x27D0CF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007AA")]
		public static v64 vmla_laneq_f32(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D1930", Offset = "0x27D0D30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007A2")]
		public static v64 vmla_laneq_s16(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D1970", Offset = "0x27D0D70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007A4")]
		public static v64 vmla_laneq_s32(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D19B0", Offset = "0x27D0DB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007A6")]
		public static v64 vmla_laneq_u16(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D19F0", Offset = "0x27D0DF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007A8")]
		public static v64 vmla_laneq_u32(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D1A30", Offset = "0x27D0E30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003E6")]
		public static v64 vmla_n_f32(v64 a0, v64 a1, float a2) { }

		[Address(RVA = "0x27D1A70", Offset = "0x27D0E70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003DE")]
		public static v64 vmla_n_s16(v64 a0, v64 a1, short a2) { }

		[Address(RVA = "0x27D1AB0", Offset = "0x27D0EB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003E0")]
		public static v64 vmla_n_s32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D1AF0", Offset = "0x27D0EF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003E2")]
		public static v64 vmla_n_u16(v64 a0, v64 a1, ushort a2) { }

		[Address(RVA = "0x27D1B30", Offset = "0x27D0F30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003E4")]
		public static v64 vmla_n_u32(v64 a0, v64 a1, uint a2) { }

		[Address(RVA = "0x27D1B70", Offset = "0x27D0F70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000157")]
		public static v64 vmla_s16(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D1BB0", Offset = "0x27D0FB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000159")]
		public static v64 vmla_s32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D1BF0", Offset = "0x27D0FF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000155")]
		public static v64 vmla_s8(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D1C30", Offset = "0x27D1030", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600015D")]
		public static v64 vmla_u16(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D1C40", Offset = "0x27D1040", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600015F")]
		public static v64 vmla_u32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D1C50", Offset = "0x27D1050", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600015B")]
		public static v64 vmla_u8(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D1C60", Offset = "0x27D1060", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007AC")]
		public static v128 vmlal_high_lane_s16(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D1CA0", Offset = "0x27D10A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007AD")]
		public static v128 vmlal_high_lane_s32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D1CE0", Offset = "0x27D10E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007AE")]
		public static v128 vmlal_high_lane_u16(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D1D20", Offset = "0x27D1120", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007AF")]
		public static v128 vmlal_high_lane_u32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D1D60", Offset = "0x27D1160", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007B4")]
		public static v128 vmlal_high_laneq_s16(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D1DA0", Offset = "0x27D11A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007B5")]
		public static v128 vmlal_high_laneq_s32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D1DE0", Offset = "0x27D11E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007B6")]
		public static v128 vmlal_high_laneq_u16(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D1E20", Offset = "0x27D1220", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007B7")]
		public static v128 vmlal_high_laneq_u32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D1E60", Offset = "0x27D1260", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000822")]
		public static v128 vmlal_high_n_s16(v128 a0, v128 a1, short a2) { }

		[Address(RVA = "0x27D1EA0", Offset = "0x27D12A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000823")]
		public static v128 vmlal_high_n_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D1EE0", Offset = "0x27D12E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000824")]
		public static v128 vmlal_high_n_u16(v128 a0, v128 a1, ushort a2) { }

		[Address(RVA = "0x27D1F20", Offset = "0x27D1320", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000825")]
		public static v128 vmlal_high_n_u32(v128 a0, v128 a1, uint a2) { }

		[Address(RVA = "0x27D1F60", Offset = "0x27D1360", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000597")]
		public static v128 vmlal_high_s16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D1FA0", Offset = "0x27D13A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000598")]
		public static v128 vmlal_high_s32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D1FE0", Offset = "0x27D13E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000596")]
		public static v128 vmlal_high_s8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D2020", Offset = "0x27D1420", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600059A")]
		public static v128 vmlal_high_u16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D2060", Offset = "0x27D1460", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600059B")]
		public static v128 vmlal_high_u32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D20A0", Offset = "0x27D14A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000599")]
		public static v128 vmlal_high_u8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D20E0", Offset = "0x27D14E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000398")]
		public static v128 vmlal_lane_s16(v128 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D2120", Offset = "0x27D1520", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000399")]
		public static v128 vmlal_lane_s32(v128 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D2160", Offset = "0x27D1560", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600039A")]
		public static v128 vmlal_lane_u16(v128 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D21A0", Offset = "0x27D15A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600039B")]
		public static v128 vmlal_lane_u32(v128 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D21E0", Offset = "0x27D15E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007B0")]
		public static v128 vmlal_laneq_s16(v128 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D2220", Offset = "0x27D1620", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007B1")]
		public static v128 vmlal_laneq_s32(v128 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D2260", Offset = "0x27D1660", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007B2")]
		public static v128 vmlal_laneq_u16(v128 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D22A0", Offset = "0x27D16A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007B3")]
		public static v128 vmlal_laneq_u32(v128 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D22E0", Offset = "0x27D16E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003E8")]
		public static v128 vmlal_n_s16(v128 a0, v64 a1, short a2) { }

		[Address(RVA = "0x27D2320", Offset = "0x27D1720", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003E9")]
		public static v128 vmlal_n_s32(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D2360", Offset = "0x27D1760", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003EA")]
		public static v128 vmlal_n_u16(v128 a0, v64 a1, ushort a2) { }

		[Address(RVA = "0x27D23A0", Offset = "0x27D17A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003EB")]
		public static v128 vmlal_n_u32(v128 a0, v64 a1, uint a2) { }

		[Address(RVA = "0x27D23E0", Offset = "0x27D17E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000164")]
		public static v128 vmlal_s16(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D2420", Offset = "0x27D1820", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000165")]
		public static v128 vmlal_s32(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D2460", Offset = "0x27D1860", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000163")]
		public static v128 vmlal_s8(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D24A0", Offset = "0x27D18A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000167")]
		public static v128 vmlal_u16(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D24E0", Offset = "0x27D18E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000168")]
		public static v128 vmlal_u32(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D2520", Offset = "0x27D1920", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000166")]
		public static v128 vmlal_u8(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D2560", Offset = "0x27D1960", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000162")]
		public static v128 vmlaq_f32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D25A0", Offset = "0x27D19A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000595")]
		public static v128 vmlaq_f64(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D25E0", Offset = "0x27D19E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000397")]
		public static v128 vmlaq_lane_f32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D2620", Offset = "0x27D1A20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600038F")]
		public static v128 vmlaq_lane_s16(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D2660", Offset = "0x27D1A60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000391")]
		public static v128 vmlaq_lane_s32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D26A0", Offset = "0x27D1AA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000393")]
		public static v128 vmlaq_lane_u16(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D26E0", Offset = "0x27D1AE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000395")]
		public static v128 vmlaq_lane_u32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D2720", Offset = "0x27D1B20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007AB")]
		public static v128 vmlaq_laneq_f32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D2760", Offset = "0x27D1B60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007A3")]
		public static v128 vmlaq_laneq_s16(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D27A0", Offset = "0x27D1BA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007A5")]
		public static v128 vmlaq_laneq_s32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D27E0", Offset = "0x27D1BE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007A7")]
		public static v128 vmlaq_laneq_u16(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D2820", Offset = "0x27D1C20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007A9")]
		public static v128 vmlaq_laneq_u32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D2860", Offset = "0x27D1C60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003E7")]
		public static v128 vmlaq_n_f32(v128 a0, v128 a1, float a2) { }

		[Address(RVA = "0x27D28A0", Offset = "0x27D1CA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003DF")]
		public static v128 vmlaq_n_s16(v128 a0, v128 a1, short a2) { }

		[Address(RVA = "0x27D28E0", Offset = "0x27D1CE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003E1")]
		public static v128 vmlaq_n_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D2920", Offset = "0x27D1D20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003E3")]
		public static v128 vmlaq_n_u16(v128 a0, v128 a1, ushort a2) { }

		[Address(RVA = "0x27D2960", Offset = "0x27D1D60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003E5")]
		public static v128 vmlaq_n_u32(v128 a0, v128 a1, uint a2) { }

		[Address(RVA = "0x27D29A0", Offset = "0x27D1DA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000158")]
		public static v128 vmlaq_s16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D29E0", Offset = "0x27D1DE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600015A")]
		public static v128 vmlaq_s32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D2A20", Offset = "0x27D1E20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000156")]
		public static v128 vmlaq_s8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D2A60", Offset = "0x27D1E60", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x600015E")]
		public static v128 vmlaq_u16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D2AA0", Offset = "0x27D1EA0", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000160")]
		public static v128 vmlaq_u32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D2AE0", Offset = "0x27D1EE0", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x600015C")]
		public static v128 vmlaq_u8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D2B20", Offset = "0x27D1F20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000175")]
		public static v64 vmls_f32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D2B60", Offset = "0x27D1F60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600059C")]
		public static v64 vmls_f64(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D2BA0", Offset = "0x27D1FA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003A6")]
		public static v64 vmls_lane_f32(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D2BE0", Offset = "0x27D1FE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600039E")]
		public static v64 vmls_lane_s16(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D2C20", Offset = "0x27D2020", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003A0")]
		public static v64 vmls_lane_s32(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D2C60", Offset = "0x27D2060", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003A2")]
		public static v64 vmls_lane_u16(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D2CA0", Offset = "0x27D20A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003A4")]
		public static v64 vmls_lane_u32(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D2CE0", Offset = "0x27D20E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007CA")]
		public static v64 vmls_laneq_f32(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D2D20", Offset = "0x27D2120", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007C2")]
		public static v64 vmls_laneq_s16(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D2D60", Offset = "0x27D2160", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007C4")]
		public static v64 vmls_laneq_s32(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D2DA0", Offset = "0x27D21A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007C6")]
		public static v64 vmls_laneq_u16(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D2DE0", Offset = "0x27D21E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007C8")]
		public static v64 vmls_laneq_u32(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D2E20", Offset = "0x27D2220", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003F6")]
		public static v64 vmls_n_f32(v64 a0, v64 a1, float a2) { }

		[Address(RVA = "0x27D2E60", Offset = "0x27D2260", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003EE")]
		public static v64 vmls_n_s16(v64 a0, v64 a1, short a2) { }

		[Address(RVA = "0x27D2EA0", Offset = "0x27D22A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003F0")]
		public static v64 vmls_n_s32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D2EE0", Offset = "0x27D22E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003F2")]
		public static v64 vmls_n_u16(v64 a0, v64 a1, ushort a2) { }

		[Address(RVA = "0x27D2F20", Offset = "0x27D2320", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003F4")]
		public static v64 vmls_n_u32(v64 a0, v64 a1, uint a2) { }

		[Address(RVA = "0x27D2F60", Offset = "0x27D2360", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600016B")]
		public static v64 vmls_s16(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D2FA0", Offset = "0x27D23A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600016D")]
		public static v64 vmls_s32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D2FE0", Offset = "0x27D23E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000169")]
		public static v64 vmls_s8(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D3020", Offset = "0x27D2420", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000171")]
		public static v64 vmls_u16(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D3030", Offset = "0x27D2430", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000173")]
		public static v64 vmls_u32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D3040", Offset = "0x27D2440", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600016F")]
		public static v64 vmls_u8(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D3050", Offset = "0x27D2450", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007CC")]
		public static v128 vmlsl_high_lane_s16(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D3090", Offset = "0x27D2490", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007CD")]
		public static v128 vmlsl_high_lane_s32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D30D0", Offset = "0x27D24D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007CE")]
		public static v128 vmlsl_high_lane_u16(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D3110", Offset = "0x27D2510", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007CF")]
		public static v128 vmlsl_high_lane_u32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D3150", Offset = "0x27D2550", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007D4")]
		public static v128 vmlsl_high_laneq_s16(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D3190", Offset = "0x27D2590", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007D5")]
		public static v128 vmlsl_high_laneq_s32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D31D0", Offset = "0x27D25D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007D6")]
		public static v128 vmlsl_high_laneq_u16(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D3210", Offset = "0x27D2610", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007D7")]
		public static v128 vmlsl_high_laneq_u32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D3250", Offset = "0x27D2650", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000828")]
		public static v128 vmlsl_high_n_s16(v128 a0, v128 a1, short a2) { }

		[Address(RVA = "0x27D3290", Offset = "0x27D2690", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000829")]
		public static v128 vmlsl_high_n_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D32D0", Offset = "0x27D26D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600082A")]
		public static v128 vmlsl_high_n_u16(v128 a0, v128 a1, ushort a2) { }

		[Address(RVA = "0x27D3310", Offset = "0x27D2710", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600082B")]
		public static v128 vmlsl_high_n_u32(v128 a0, v128 a1, uint a2) { }

		[Address(RVA = "0x27D3350", Offset = "0x27D2750", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600059F")]
		public static v128 vmlsl_high_s16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D3390", Offset = "0x27D2790", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005A0")]
		public static v128 vmlsl_high_s32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D33D0", Offset = "0x27D27D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600059E")]
		public static v128 vmlsl_high_s8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D3410", Offset = "0x27D2810", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005A2")]
		public static v128 vmlsl_high_u16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D3450", Offset = "0x27D2850", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005A3")]
		public static v128 vmlsl_high_u32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D3490", Offset = "0x27D2890", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005A1")]
		public static v128 vmlsl_high_u8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D34D0", Offset = "0x27D28D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003A8")]
		public static v128 vmlsl_lane_s16(v128 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D3510", Offset = "0x27D2910", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003A9")]
		public static v128 vmlsl_lane_s32(v128 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D3550", Offset = "0x27D2950", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003AA")]
		public static v128 vmlsl_lane_u16(v128 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D3590", Offset = "0x27D2990", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003AB")]
		public static v128 vmlsl_lane_u32(v128 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D35D0", Offset = "0x27D29D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007D0")]
		public static v128 vmlsl_laneq_s16(v128 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D3610", Offset = "0x27D2A10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007D1")]
		public static v128 vmlsl_laneq_s32(v128 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D3650", Offset = "0x27D2A50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007D2")]
		public static v128 vmlsl_laneq_u16(v128 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D3690", Offset = "0x27D2A90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007D3")]
		public static v128 vmlsl_laneq_u32(v128 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D36D0", Offset = "0x27D2AD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003F8")]
		public static v128 vmlsl_n_s16(v128 a0, v64 a1, short a2) { }

		[Address(RVA = "0x27D3710", Offset = "0x27D2B10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003F9")]
		public static v128 vmlsl_n_s32(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D3750", Offset = "0x27D2B50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003FA")]
		public static v128 vmlsl_n_u16(v128 a0, v64 a1, ushort a2) { }

		[Address(RVA = "0x27D3790", Offset = "0x27D2B90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003FB")]
		public static v128 vmlsl_n_u32(v128 a0, v64 a1, uint a2) { }

		[Address(RVA = "0x27D37D0", Offset = "0x27D2BD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000178")]
		public static v128 vmlsl_s16(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D3810", Offset = "0x27D2C10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000179")]
		public static v128 vmlsl_s32(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D3850", Offset = "0x27D2C50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000177")]
		public static v128 vmlsl_s8(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D3890", Offset = "0x27D2C90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600017B")]
		public static v128 vmlsl_u16(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D38D0", Offset = "0x27D2CD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600017C")]
		public static v128 vmlsl_u32(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D3910", Offset = "0x27D2D10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600017A")]
		public static v128 vmlsl_u8(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D3950", Offset = "0x27D2D50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000176")]
		public static v128 vmlsq_f32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D3990", Offset = "0x27D2D90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600059D")]
		public static v128 vmlsq_f64(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D39D0", Offset = "0x27D2DD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003A7")]
		public static v128 vmlsq_lane_f32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D3A10", Offset = "0x27D2E10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600039F")]
		public static v128 vmlsq_lane_s16(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D3A50", Offset = "0x27D2E50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003A1")]
		public static v128 vmlsq_lane_s32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D3A90", Offset = "0x27D2E90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003A3")]
		public static v128 vmlsq_lane_u16(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D3AD0", Offset = "0x27D2ED0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003A5")]
		public static v128 vmlsq_lane_u32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D3B10", Offset = "0x27D2F10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007CB")]
		public static v128 vmlsq_laneq_f32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D3B50", Offset = "0x27D2F50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007C3")]
		public static v128 vmlsq_laneq_s16(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D3B90", Offset = "0x27D2F90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007C5")]
		public static v128 vmlsq_laneq_s32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D3BD0", Offset = "0x27D2FD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007C7")]
		public static v128 vmlsq_laneq_u16(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D3C10", Offset = "0x27D3010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007C9")]
		public static v128 vmlsq_laneq_u32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D3C50", Offset = "0x27D3050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003F7")]
		public static v128 vmlsq_n_f32(v128 a0, v128 a1, float a2) { }

		[Address(RVA = "0x27D3C90", Offset = "0x27D3090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003EF")]
		public static v128 vmlsq_n_s16(v128 a0, v128 a1, short a2) { }

		[Address(RVA = "0x27D3CD0", Offset = "0x27D30D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003F1")]
		public static v128 vmlsq_n_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D3D10", Offset = "0x27D3110", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003F3")]
		public static v128 vmlsq_n_u16(v128 a0, v128 a1, ushort a2) { }

		[Address(RVA = "0x27D3D50", Offset = "0x27D3150", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003F5")]
		public static v128 vmlsq_n_u32(v128 a0, v128 a1, uint a2) { }

		[Address(RVA = "0x27D3D90", Offset = "0x27D3190", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600016C")]
		public static v128 vmlsq_s16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D3DD0", Offset = "0x27D31D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600016E")]
		public static v128 vmlsq_s32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D3E10", Offset = "0x27D3210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600016A")]
		public static v128 vmlsq_s8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D3E50", Offset = "0x27D3250", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000172")]
		public static v128 vmlsq_u16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D3E90", Offset = "0x27D3290", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000174")]
		public static v128 vmlsq_u32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D3ED0", Offset = "0x27D32D0", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000170")]
		public static v128 vmlsq_u8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27CE0A0", Offset = "0x27CD4A0", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A0F")]
		public static v64 vmov_n_f32(float a0) { }

		[Address(RVA = "0x27CE0D0", Offset = "0x27CD4D0", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A11")]
		public static v64 vmov_n_f64(double a0) { }

		[Address(RVA = "0x27CE100", Offset = "0x27CD500", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A01")]
		public static v64 vmov_n_s16(short a0) { }

		[Address(RVA = "0x27CE130", Offset = "0x27CD530", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A03")]
		public static v64 vmov_n_s32(int a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A05")]
		public static v64 vmov_n_s64(long a0) { }

		[Address(RVA = "0x27CE160", Offset = "0x27CD560", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009FF")]
		public static v64 vmov_n_s8(sbyte a0) { }

		[Address(RVA = "0x27CE100", Offset = "0x27CD500", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A09")]
		public static v64 vmov_n_u16(ushort a0) { }

		[Address(RVA = "0x27CE130", Offset = "0x27CD530", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A0B")]
		public static v64 vmov_n_u32(uint a0) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A0D")]
		public static v64 vmov_n_u64(ulong a0) { }

		[Address(RVA = "0x27CE160", Offset = "0x27CD560", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A07")]
		public static v64 vmov_n_u8(byte a0) { }

		[Address(RVA = "0x27D3F10", Offset = "0x27D3310", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600078B")]
		public static v128 vmovl_high_s16(v128 a0) { }

		[Address(RVA = "0x27D3F50", Offset = "0x27D3350", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600078C")]
		public static v128 vmovl_high_s32(v128 a0) { }

		[Address(RVA = "0x27D3F90", Offset = "0x27D3390", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600078A")]
		public static v128 vmovl_high_s8(v128 a0) { }

		[Address(RVA = "0x27D3FD0", Offset = "0x27D33D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600078E")]
		public static v128 vmovl_high_u16(v128 a0) { }

		[Address(RVA = "0x27D4010", Offset = "0x27D3410", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600078F")]
		public static v128 vmovl_high_u32(v128 a0) { }

		[Address(RVA = "0x27D4050", Offset = "0x27D3450", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600078D")]
		public static v128 vmovl_high_u8(v128 a0) { }

		[Address(RVA = "0x27D4090", Offset = "0x27D3490", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000380")]
		public static v128 vmovl_s16(v64 a0) { }

		[Address(RVA = "0x27D40D0", Offset = "0x27D34D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000381")]
		public static v128 vmovl_s32(v64 a0) { }

		[Address(RVA = "0x27D4110", Offset = "0x27D3510", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600037F")]
		public static v128 vmovl_s8(v64 a0) { }

		[Address(RVA = "0x27D4150", Offset = "0x27D3550", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000383")]
		public static v128 vmovl_u16(v64 a0) { }

		[Address(RVA = "0x27D4190", Offset = "0x27D3590", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000384")]
		public static v128 vmovl_u32(v64 a0) { }

		[Address(RVA = "0x27D41D0", Offset = "0x27D35D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000382")]
		public static v128 vmovl_u8(v64 a0) { }

		[Address(RVA = "0x27D4210", Offset = "0x27D3610", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000379")]
		public static v128 vmovn_high_s16(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D4250", Offset = "0x27D3650", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600037A")]
		public static v128 vmovn_high_s32(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D4290", Offset = "0x27D3690", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600037B")]
		public static v128 vmovn_high_s64(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D42D0", Offset = "0x27D36D0", Length = "0x1F")]
		[DebuggerStepThrough]
		[Token(Token = "0x600037C")]
		public static v128 vmovn_high_u16(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D42F0", Offset = "0x27D36F0", Length = "0x1F")]
		[DebuggerStepThrough]
		[Token(Token = "0x600037D")]
		public static v128 vmovn_high_u32(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D4310", Offset = "0x27D3710", Length = "0x1F")]
		[DebuggerStepThrough]
		[Token(Token = "0x600037E")]
		public static v128 vmovn_high_u64(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D4330", Offset = "0x27D3730", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000373")]
		public static v64 vmovn_s16(v128 a0) { }

		[Address(RVA = "0x27D4370", Offset = "0x27D3770", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000374")]
		public static v64 vmovn_s32(v128 a0) { }

		[Address(RVA = "0x27D43B0", Offset = "0x27D37B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000375")]
		public static v64 vmovn_s64(v128 a0) { }

		[Address(RVA = "0x27D43F0", Offset = "0x27D37F0", Length = "0x18")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000376")]
		public static v64 vmovn_u16(v128 a0) { }

		[Address(RVA = "0x27D4410", Offset = "0x27D3810", Length = "0x18")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000377")]
		public static v64 vmovn_u32(v128 a0) { }

		[Address(RVA = "0x27D4430", Offset = "0x27D3830", Length = "0x18")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000378")]
		public static v64 vmovn_u64(v128 a0) { }

		[Address(RVA = "0x27CE8D0", Offset = "0x27CDCD0", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A10")]
		public static v128 vmovq_n_f32(float a0) { }

		[Address(RVA = "0x27CE8F0", Offset = "0x27CDCF0", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A12")]
		public static v128 vmovq_n_f64(double a0) { }

		[Address(RVA = "0x27CE910", Offset = "0x27CDD10", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A02")]
		public static v128 vmovq_n_s16(short a0) { }

		[Address(RVA = "0x27CE930", Offset = "0x27CDD30", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A04")]
		public static v128 vmovq_n_s32(int a0) { }

		[Address(RVA = "0x27CE950", Offset = "0x27CDD50", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A06")]
		public static v128 vmovq_n_s64(long a0) { }

		[Address(RVA = "0x27CE970", Offset = "0x27CDD70", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A00")]
		public static v128 vmovq_n_s8(sbyte a0) { }

		[Address(RVA = "0x27CE910", Offset = "0x27CDD10", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A0A")]
		public static v128 vmovq_n_u16(ushort a0) { }

		[Address(RVA = "0x27CE930", Offset = "0x27CDD30", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A0C")]
		public static v128 vmovq_n_u32(uint a0) { }

		[Address(RVA = "0x27CE950", Offset = "0x27CDD50", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A0E")]
		public static v128 vmovq_n_u64(ulong a0) { }

		[Address(RVA = "0x27CE970", Offset = "0x27CDD70", Length = "0x20")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A08")]
		public static v128 vmovq_n_u8(byte a0) { }

		[Address(RVA = "0x27D4450", Offset = "0x27D3850", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000153")]
		public static v64 vmul_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D4490", Offset = "0x27D3890", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600057C")]
		public static v64 vmul_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D44D0", Offset = "0x27D38D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003C0")]
		public static v64 vmul_lane_f32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D4510", Offset = "0x27D3910", Length = "0xC")]
		[BurstTargetCpu(BurstTargetCpu::ARMV8A_AARCH64 (9))]
		[DebuggerStepThrough]
		[Token(Token = "0x60007E4")]
		public static v64 vmul_lane_f64(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D4520", Offset = "0x27D3920", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003B8")]
		public static v64 vmul_lane_s16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D4560", Offset = "0x27D3960", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003BA")]
		public static v64 vmul_lane_s32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D45A0", Offset = "0x27D39A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003BC")]
		public static v64 vmul_lane_u16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D45E0", Offset = "0x27D39E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003BE")]
		public static v64 vmul_lane_u32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D4620", Offset = "0x27D3A20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007F0")]
		public static v64 vmul_laneq_f32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D4660", Offset = "0x27D3A60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007F2")]
		public static v64 vmul_laneq_f64(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D46A0", Offset = "0x27D3AA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007E8")]
		public static v64 vmul_laneq_s16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D46E0", Offset = "0x27D3AE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007EA")]
		public static v64 vmul_laneq_s32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D4720", Offset = "0x27D3B20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007EC")]
		public static v64 vmul_laneq_u16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D4760", Offset = "0x27D3B60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007EE")]
		public static v64 vmul_laneq_u32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D47A0", Offset = "0x27D3BA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003B6")]
		public static v64 vmul_n_f32(v64 a0, float a1) { }

		[Address(RVA = "0x27D47E0", Offset = "0x27D3BE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007E2")]
		public static v64 vmul_n_f64(v64 a0, double a1) { }

		[Address(RVA = "0x27D4820", Offset = "0x27D3C20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003AE")]
		public static v64 vmul_n_s16(v64 a0, short a1) { }

		[Address(RVA = "0x27D4860", Offset = "0x27D3C60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003B0")]
		public static v64 vmul_n_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27D48A0", Offset = "0x27D3CA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003B2")]
		public static v64 vmul_n_u16(v64 a0, ushort a1) { }

		[Address(RVA = "0x27D48E0", Offset = "0x27D3CE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003B4")]
		public static v64 vmul_n_u32(v64 a0, uint a1) { }

		[Address(RVA = "0x27D4920", Offset = "0x27D3D20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000149")]
		public static v64 vmul_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D4960", Offset = "0x27D3D60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600014B")]
		public static v64 vmul_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D49A0", Offset = "0x27D3DA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000147")]
		public static v64 vmul_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D49E0", Offset = "0x27D3DE0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600014F")]
		public static v64 vmul_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D49F0", Offset = "0x27D3DF0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000151")]
		public static v64 vmul_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D4A00", Offset = "0x27D3E00", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600014D")]
		public static v64 vmul_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D4A10", Offset = "0x27D3E10", Length = "0x13")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007E7")]
		public static double vmuld_lane_f64(double a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D4A30", Offset = "0x27D3E30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007F5")]
		public static double vmuld_laneq_f64(double a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D4A70", Offset = "0x27D3E70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007FA")]
		public static v128 vmull_high_lane_s16(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D4AB0", Offset = "0x27D3EB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007FB")]
		public static v128 vmull_high_lane_s32(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D4AF0", Offset = "0x27D3EF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007FC")]
		public static v128 vmull_high_lane_u16(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D4B30", Offset = "0x27D3F30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007FD")]
		public static v128 vmull_high_lane_u32(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D4B70", Offset = "0x27D3F70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000802")]
		public static v128 vmull_high_laneq_s16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D4BB0", Offset = "0x27D3FB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000803")]
		public static v128 vmull_high_laneq_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D4BF0", Offset = "0x27D3FF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000804")]
		public static v128 vmull_high_laneq_u16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D4C30", Offset = "0x27D4030", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000805")]
		public static v128 vmull_high_laneq_u32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D4C70", Offset = "0x27D4070", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007F6")]
		public static v128 vmull_high_n_s16(v128 a0, short a1) { }

		[Address(RVA = "0x27D4CB0", Offset = "0x27D40B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007F7")]
		public static v128 vmull_high_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27D4CF0", Offset = "0x27D40F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007F8")]
		public static v128 vmull_high_n_u16(v128 a0, ushort a1) { }

		[Address(RVA = "0x27D4D30", Offset = "0x27D4130", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007F9")]
		public static v128 vmull_high_n_u32(v128 a0, uint a1) { }

		[Address(RVA = "0x27D4D70", Offset = "0x27D4170", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005CD")]
		public static v128 vmull_high_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D4DB0", Offset = "0x27D41B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005CE")]
		public static v128 vmull_high_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D4DF0", Offset = "0x27D41F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005CC")]
		public static v128 vmull_high_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D4E30", Offset = "0x27D4230", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005D0")]
		public static v128 vmull_high_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D4E70", Offset = "0x27D4270", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005D1")]
		public static v128 vmull_high_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D4EB0", Offset = "0x27D42B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005CF")]
		public static v128 vmull_high_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D4EF0", Offset = "0x27D42F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003C6")]
		public static v128 vmull_lane_s16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D4F30", Offset = "0x27D4330", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003C7")]
		public static v128 vmull_lane_s32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D4F70", Offset = "0x27D4370", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003C8")]
		public static v128 vmull_lane_u16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D4FB0", Offset = "0x27D43B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003C9")]
		public static v128 vmull_lane_u32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D4FF0", Offset = "0x27D43F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007FE")]
		public static v128 vmull_laneq_s16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D5030", Offset = "0x27D4430", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007FF")]
		public static v128 vmull_laneq_s32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D5070", Offset = "0x27D4470", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000800")]
		public static v128 vmull_laneq_u16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D50B0", Offset = "0x27D44B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000801")]
		public static v128 vmull_laneq_u32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D50F0", Offset = "0x27D44F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003C2")]
		public static v128 vmull_n_s16(v64 a0, short a1) { }

		[Address(RVA = "0x27D5130", Offset = "0x27D4530", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003C3")]
		public static v128 vmull_n_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27D5170", Offset = "0x27D4570", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003C4")]
		public static v128 vmull_n_u16(v64 a0, ushort a1) { }

		[Address(RVA = "0x27D51B0", Offset = "0x27D45B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003C5")]
		public static v128 vmull_n_u32(v64 a0, uint a1) { }

		[Address(RVA = "0x27D51F0", Offset = "0x27D45F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600018E")]
		public static v128 vmull_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D5230", Offset = "0x27D4630", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600018F")]
		public static v128 vmull_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D5270", Offset = "0x27D4670", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600018D")]
		public static v128 vmull_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D52B0", Offset = "0x27D46B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000191")]
		public static v128 vmull_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D52F0", Offset = "0x27D46F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000192")]
		public static v128 vmull_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D5330", Offset = "0x27D4730", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000190")]
		public static v128 vmull_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D5370", Offset = "0x27D4770", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000154")]
		public static v128 vmulq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D53B0", Offset = "0x27D47B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600057D")]
		public static v128 vmulq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D53F0", Offset = "0x27D47F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003C1")]
		public static v128 vmulq_lane_f32(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D5430", Offset = "0x27D4830", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007E5")]
		public static v128 vmulq_lane_f64(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D5470", Offset = "0x27D4870", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003B9")]
		public static v128 vmulq_lane_s16(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D54B0", Offset = "0x27D48B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003BB")]
		public static v128 vmulq_lane_s32(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D54F0", Offset = "0x27D48F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003BD")]
		public static v128 vmulq_lane_u16(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D5530", Offset = "0x27D4930", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003BF")]
		public static v128 vmulq_lane_u32(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D5570", Offset = "0x27D4970", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007F1")]
		public static v128 vmulq_laneq_f32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D55B0", Offset = "0x27D49B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007F3")]
		public static v128 vmulq_laneq_f64(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D55F0", Offset = "0x27D49F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007E9")]
		public static v128 vmulq_laneq_s16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D5630", Offset = "0x27D4A30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007EB")]
		public static v128 vmulq_laneq_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D5670", Offset = "0x27D4A70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007ED")]
		public static v128 vmulq_laneq_u16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D56B0", Offset = "0x27D4AB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007EF")]
		public static v128 vmulq_laneq_u32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D56F0", Offset = "0x27D4AF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003B7")]
		public static v128 vmulq_n_f32(v128 a0, float a1) { }

		[Address(RVA = "0x27D5730", Offset = "0x27D4B30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007E3")]
		public static v128 vmulq_n_f64(v128 a0, double a1) { }

		[Address(RVA = "0x27D5770", Offset = "0x27D4B70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003AF")]
		public static v128 vmulq_n_s16(v128 a0, short a1) { }

		[Address(RVA = "0x27D57B0", Offset = "0x27D4BB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003B1")]
		public static v128 vmulq_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27D57F0", Offset = "0x27D4BF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003B3")]
		public static v128 vmulq_n_u16(v128 a0, ushort a1) { }

		[Address(RVA = "0x27D5830", Offset = "0x27D4C30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003B5")]
		public static v128 vmulq_n_u32(v128 a0, uint a1) { }

		[Address(RVA = "0x27D5870", Offset = "0x27D4C70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600014A")]
		public static v128 vmulq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D58B0", Offset = "0x27D4CB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600014C")]
		public static v128 vmulq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D58F0", Offset = "0x27D4CF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000148")]
		public static v128 vmulq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D5930", Offset = "0x27D4D30", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000150")]
		public static v128 vmulq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D5960", Offset = "0x27D4D60", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000152")]
		public static v128 vmulq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D5990", Offset = "0x27D4D90", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600014E")]
		public static v128 vmulq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D59C0", Offset = "0x27D4DC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007E6")]
		public static float vmuls_lane_f32(float a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D5A00", Offset = "0x27D4E00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007F4")]
		public static float vmuls_laneq_f32(float a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D5A40", Offset = "0x27D4E40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600057E")]
		public static v64 vmulx_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D5A80", Offset = "0x27D4E80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000580")]
		public static v64 vmulx_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D5AC0", Offset = "0x27D4EC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000584")]
		public static v64 vmulx_lane_f32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D5B00", Offset = "0x27D4F00", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000586")]
		public static v64 vmulx_lane_f64(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D5B10", Offset = "0x27D4F10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600058A")]
		public static v64 vmulx_laneq_f32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D5B50", Offset = "0x27D4F50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600058C")]
		public static v64 vmulx_laneq_f64(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D5B90", Offset = "0x27D4F90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000583")]
		public static double vmulxd_f64(double a0, double a1) { }

		[Address(RVA = "0x27D5BD0", Offset = "0x27D4FD0", Length = "0x17")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000589")]
		public static double vmulxd_lane_f64(double a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D5BF0", Offset = "0x27D4FF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600058F")]
		public static double vmulxd_laneq_f64(double a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D5C30", Offset = "0x27D5030", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600057F")]
		public static v128 vmulxq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D5C70", Offset = "0x27D5070", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000581")]
		public static v128 vmulxq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D5CB0", Offset = "0x27D50B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000585")]
		public static v128 vmulxq_lane_f32(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D5CF0", Offset = "0x27D50F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000587")]
		public static v128 vmulxq_lane_f64(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D5D30", Offset = "0x27D5130", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600058B")]
		public static v128 vmulxq_laneq_f32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D5D70", Offset = "0x27D5170", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600058D")]
		public static v128 vmulxq_laneq_f64(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D5DB0", Offset = "0x27D51B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000582")]
		public static float vmulxs_f32(float a0, float a1) { }

		[Address(RVA = "0x27D5DF0", Offset = "0x27D51F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000588")]
		public static float vmulxs_lane_f32(float a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D5E30", Offset = "0x27D5230", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600058E")]
		public static float vmulxs_laneq_f32(float a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D5E70", Offset = "0x27D5270", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x600043E")]
		public static v64 vmvn_s16(v64 a0) { }

		[Address(RVA = "0x27D5E70", Offset = "0x27D5270", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000440")]
		public static v64 vmvn_s32(v64 a0) { }

		[Address(RVA = "0x27D5E80", Offset = "0x27D5280", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600043C")]
		public static v64 vmvn_s8(v64 a0) { }

		[Address(RVA = "0x27D5E70", Offset = "0x27D5270", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000444")]
		public static v64 vmvn_u16(v64 a0) { }

		[Address(RVA = "0x27D5E70", Offset = "0x27D5270", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000446")]
		public static v64 vmvn_u32(v64 a0) { }

		[Address(RVA = "0x27D5E70", Offset = "0x27D5270", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000442")]
		public static v64 vmvn_u8(v64 a0) { }

		[Address(RVA = "0x27D5EC0", Offset = "0x27D52C0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600043F")]
		public static v128 vmvnq_s16(v128 a0) { }

		[Address(RVA = "0x27D5EC0", Offset = "0x27D52C0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000441")]
		public static v128 vmvnq_s32(v128 a0) { }

		[Address(RVA = "0x27D5EE0", Offset = "0x27D52E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600043D")]
		public static v128 vmvnq_s8(v128 a0) { }

		[Address(RVA = "0x27D5EC0", Offset = "0x27D52C0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000445")]
		public static v128 vmvnq_u16(v128 a0) { }

		[Address(RVA = "0x27D5EC0", Offset = "0x27D52C0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000447")]
		public static v128 vmvnq_u32(v128 a0) { }

		[Address(RVA = "0x27D5EC0", Offset = "0x27D52C0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000443")]
		public static v128 vmvnq_u8(v128 a0) { }

		[Address(RVA = "0x27D5F20", Offset = "0x27D5320", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000412")]
		public static v64 vneg_f32(v64 a0) { }

		[Address(RVA = "0x27D5F60", Offset = "0x27D5360", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600083C")]
		public static v64 vneg_f64(v64 a0) { }

		[Address(RVA = "0x27D5FA0", Offset = "0x27D53A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600040E")]
		public static v64 vneg_s16(v64 a0) { }

		[Address(RVA = "0x27D5FE0", Offset = "0x27D53E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000410")]
		public static v64 vneg_s32(v64 a0) { }

		[Address(RVA = "0x27D6020", Offset = "0x27D5420", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000839")]
		public static v64 vneg_s64(v64 a0) { }

		[Address(RVA = "0x27D6060", Offset = "0x27D5460", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600040C")]
		public static v64 vneg_s8(v64 a0) { }

		[Address(RVA = "0x27D60A0", Offset = "0x27D54A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600083A")]
		public static long vnegd_s64(long a0) { }

		[Address(RVA = "0x27D60E0", Offset = "0x27D54E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000413")]
		public static v128 vnegq_f32(v128 a0) { }

		[Address(RVA = "0x27D6120", Offset = "0x27D5520", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600083D")]
		public static v128 vnegq_f64(v128 a0) { }

		[Address(RVA = "0x27D6160", Offset = "0x27D5560", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600040F")]
		public static v128 vnegq_s16(v128 a0) { }

		[Address(RVA = "0x27D61A0", Offset = "0x27D55A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000411")]
		public static v128 vnegq_s32(v128 a0) { }

		[Address(RVA = "0x27D61E0", Offset = "0x27D55E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600083B")]
		public static v128 vnegq_s64(v128 a0) { }

		[Address(RVA = "0x27D6220", Offset = "0x27D5620", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600040D")]
		public static v128 vnegq_s8(v128 a0) { }

		[Address(RVA = "0x27D6260", Offset = "0x27D5660", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600048A")]
		public static v64 vorn_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6260", Offset = "0x27D5660", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600048C")]
		public static v64 vorn_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6260", Offset = "0x27D5660", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600048E")]
		public static v64 vorn_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6270", Offset = "0x27D5670", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000488")]
		public static v64 vorn_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6260", Offset = "0x27D5660", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000492")]
		public static v64 vorn_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6260", Offset = "0x27D5660", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000494")]
		public static v64 vorn_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6260", Offset = "0x27D5660", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000496")]
		public static v64 vorn_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6260", Offset = "0x27D5660", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000490")]
		public static v64 vorn_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D62B0", Offset = "0x27D56B0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600048B")]
		public static v128 vornq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D62B0", Offset = "0x27D56B0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600048D")]
		public static v128 vornq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D62B0", Offset = "0x27D56B0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600048F")]
		public static v128 vornq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D62E0", Offset = "0x27D56E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000489")]
		public static v128 vornq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D62B0", Offset = "0x27D56B0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000493")]
		public static v128 vornq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D62B0", Offset = "0x27D56B0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000495")]
		public static v128 vornq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D62B0", Offset = "0x27D56B0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000497")]
		public static v128 vornq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D62B0", Offset = "0x27D56B0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000491")]
		public static v128 vornq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6320", Offset = "0x27D5720", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600045A")]
		public static v64 vorr_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6320", Offset = "0x27D5720", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600045C")]
		public static v64 vorr_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6320", Offset = "0x27D5720", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600045E")]
		public static v64 vorr_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6330", Offset = "0x27D5730", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000458")]
		public static v64 vorr_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6320", Offset = "0x27D5720", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000462")]
		public static v64 vorr_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6320", Offset = "0x27D5720", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000464")]
		public static v64 vorr_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6320", Offset = "0x27D5720", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000466")]
		public static v64 vorr_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6320", Offset = "0x27D5720", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000460")]
		public static v64 vorr_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6370", Offset = "0x27D5770", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600045B")]
		public static v128 vorrq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6370", Offset = "0x27D5770", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600045D")]
		public static v128 vorrq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6370", Offset = "0x27D5770", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600045F")]
		public static v128 vorrq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D63A0", Offset = "0x27D57A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000459")]
		public static v128 vorrq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6370", Offset = "0x27D5770", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000463")]
		public static v128 vorrq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6370", Offset = "0x27D5770", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000465")]
		public static v128 vorrq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6370", Offset = "0x27D5770", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000467")]
		public static v128 vorrq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6370", Offset = "0x27D5770", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000461")]
		public static v128 vorrq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D63E0", Offset = "0x27D57E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004D1")]
		public static v64 vpadal_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6420", Offset = "0x27D5820", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004D3")]
		public static v64 vpadal_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6460", Offset = "0x27D5860", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004CF")]
		public static v64 vpadal_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D64A0", Offset = "0x27D58A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004D7")]
		public static v64 vpadal_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D64E0", Offset = "0x27D58E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004D9")]
		public static v64 vpadal_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6520", Offset = "0x27D5920", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004D5")]
		public static v64 vpadal_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6560", Offset = "0x27D5960", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004D2")]
		public static v128 vpadalq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D65A0", Offset = "0x27D59A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004D4")]
		public static v128 vpadalq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D65E0", Offset = "0x27D59E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004D0")]
		public static v128 vpadalq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6620", Offset = "0x27D5A20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004D8")]
		public static v128 vpadalq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6660", Offset = "0x27D5A60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004DA")]
		public static v128 vpadalq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D66A0", Offset = "0x27D5AA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004D6")]
		public static v128 vpadalq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D66E0", Offset = "0x27D5AE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004C2")]
		public static v64 vpadd_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6720", Offset = "0x27D5B20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004BD")]
		public static v64 vpadd_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6760", Offset = "0x27D5B60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004BE")]
		public static v64 vpadd_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D67A0", Offset = "0x27D5BA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004BC")]
		public static v64 vpadd_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D67E0", Offset = "0x27D5BE0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004C0")]
		public static v64 vpadd_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D67F0", Offset = "0x27D5BF0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004C1")]
		public static v64 vpadd_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6800", Offset = "0x27D5C00", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004BF")]
		public static v64 vpadd_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6810", Offset = "0x27D5C10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008D3")]
		public static double vpaddd_f64(v128 a0) { }

		[Address(RVA = "0x27D6850", Offset = "0x27D5C50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008D0")]
		public static long vpaddd_s64(v128 a0) { }

		[Address(RVA = "0x27D6890", Offset = "0x27D5C90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008D1")]
		public static ulong vpaddd_u64(v128 a0) { }

		[Address(RVA = "0x27D68D0", Offset = "0x27D5CD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004C5")]
		public static v64 vpaddl_s16(v64 a0) { }

		[Address(RVA = "0x27D6910", Offset = "0x27D5D10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004C7")]
		public static v64 vpaddl_s32(v64 a0) { }

		[Address(RVA = "0x27D6950", Offset = "0x27D5D50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004C3")]
		public static v64 vpaddl_s8(v64 a0) { }

		[Address(RVA = "0x27D6990", Offset = "0x27D5D90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004CB")]
		public static v64 vpaddl_u16(v64 a0) { }

		[Address(RVA = "0x27D69D0", Offset = "0x27D5DD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004CD")]
		public static v64 vpaddl_u32(v64 a0) { }

		[Address(RVA = "0x27D6A10", Offset = "0x27D5E10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004C9")]
		public static v64 vpaddl_u8(v64 a0) { }

		[Address(RVA = "0x27D6A50", Offset = "0x27D5E50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004C6")]
		public static v128 vpaddlq_s16(v128 a0) { }

		[Address(RVA = "0x27D6A90", Offset = "0x27D5E90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004C8")]
		public static v128 vpaddlq_s32(v128 a0) { }

		[Address(RVA = "0x27D6AD0", Offset = "0x27D5ED0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004C4")]
		public static v128 vpaddlq_s8(v128 a0) { }

		[Address(RVA = "0x27D6B10", Offset = "0x27D5F10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004CC")]
		public static v128 vpaddlq_u16(v128 a0) { }

		[Address(RVA = "0x27D6B50", Offset = "0x27D5F50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004CE")]
		public static v128 vpaddlq_u32(v128 a0) { }

		[Address(RVA = "0x27D6B90", Offset = "0x27D5F90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004CA")]
		public static v128 vpaddlq_u8(v128 a0) { }

		[Address(RVA = "0x27D6BD0", Offset = "0x27D5FD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008B8")]
		public static v128 vpaddq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6C10", Offset = "0x27D6010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008B9")]
		public static v128 vpaddq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6C50", Offset = "0x27D6050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008B1")]
		public static v128 vpaddq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6C90", Offset = "0x27D6090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008B2")]
		public static v128 vpaddq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6CD0", Offset = "0x27D60D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008B3")]
		public static v128 vpaddq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6D10", Offset = "0x27D6110", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008B0")]
		public static v128 vpaddq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6D50", Offset = "0x27D6150", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008B5")]
		public static v128 vpaddq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6D80", Offset = "0x27D6180", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008B6")]
		public static v128 vpaddq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6DB0", Offset = "0x27D61B0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008B7")]
		public static v128 vpaddq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6DE0", Offset = "0x27D61E0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008B4")]
		public static v128 vpaddq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D6E10", Offset = "0x27D6210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008D2")]
		public static float vpadds_f32(v64 a0) { }

		[Address(RVA = "0x27D6E50", Offset = "0x27D6250", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004E1")]
		public static v64 vpmax_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6E90", Offset = "0x27D6290", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004DC")]
		public static v64 vpmax_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6ED0", Offset = "0x27D62D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004DD")]
		public static v64 vpmax_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6F10", Offset = "0x27D6310", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004DB")]
		public static v64 vpmax_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6F50", Offset = "0x27D6350", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004DF")]
		public static v64 vpmax_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6F90", Offset = "0x27D6390", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004E0")]
		public static v64 vpmax_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D6FD0", Offset = "0x27D63D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004DE")]
		public static v64 vpmax_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7010", Offset = "0x27D6410", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008CA")]
		public static v64 vpmaxnm_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7050", Offset = "0x27D6450", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008CB")]
		public static v128 vpmaxnmq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7090", Offset = "0x27D6490", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008CC")]
		public static v128 vpmaxnmq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D70D0", Offset = "0x27D64D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008D9")]
		public static double vpmaxnmqd_f64(v128 a0) { }

		[Address(RVA = "0x27D7110", Offset = "0x27D6510", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008D8")]
		public static float vpmaxnms_f32(v64 a0) { }

		[Address(RVA = "0x27D7150", Offset = "0x27D6550", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008C0")]
		public static v128 vpmaxq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7190", Offset = "0x27D6590", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008C1")]
		public static v128 vpmaxq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D71D0", Offset = "0x27D65D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008BB")]
		public static v128 vpmaxq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7210", Offset = "0x27D6610", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008BC")]
		public static v128 vpmaxq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7250", Offset = "0x27D6650", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008BA")]
		public static v128 vpmaxq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7290", Offset = "0x27D6690", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008BE")]
		public static v128 vpmaxq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D72D0", Offset = "0x27D66D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008BF")]
		public static v128 vpmaxq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7310", Offset = "0x27D6710", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008BD")]
		public static v128 vpmaxq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7350", Offset = "0x27D6750", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008D5")]
		public static double vpmaxqd_f64(v128 a0) { }

		[Address(RVA = "0x27D7390", Offset = "0x27D6790", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008D4")]
		public static float vpmaxs_f32(v64 a0) { }

		[Address(RVA = "0x27D73D0", Offset = "0x27D67D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004E8")]
		public static v64 vpmin_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7410", Offset = "0x27D6810", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004E3")]
		public static v64 vpmin_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7450", Offset = "0x27D6850", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004E4")]
		public static v64 vpmin_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7490", Offset = "0x27D6890", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004E2")]
		public static v64 vpmin_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D74D0", Offset = "0x27D68D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004E6")]
		public static v64 vpmin_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7510", Offset = "0x27D6910", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004E7")]
		public static v64 vpmin_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7550", Offset = "0x27D6950", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004E5")]
		public static v64 vpmin_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7590", Offset = "0x27D6990", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008CD")]
		public static v64 vpminnm_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D75D0", Offset = "0x27D69D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008CE")]
		public static v128 vpminnmq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7610", Offset = "0x27D6A10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008CF")]
		public static v128 vpminnmq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7650", Offset = "0x27D6A50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008DB")]
		public static double vpminnmqd_f64(v128 a0) { }

		[Address(RVA = "0x27D7690", Offset = "0x27D6A90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008DA")]
		public static float vpminnms_f32(v64 a0) { }

		[Address(RVA = "0x27D76D0", Offset = "0x27D6AD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008C8")]
		public static v128 vpminq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7710", Offset = "0x27D6B10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008C9")]
		public static v128 vpminq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7750", Offset = "0x27D6B50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008C3")]
		public static v128 vpminq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7790", Offset = "0x27D6B90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008C4")]
		public static v128 vpminq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D77D0", Offset = "0x27D6BD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008C2")]
		public static v128 vpminq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7810", Offset = "0x27D6C10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008C6")]
		public static v128 vpminq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7850", Offset = "0x27D6C50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008C7")]
		public static v128 vpminq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D7890", Offset = "0x27D6C90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008C5")]
		public static v128 vpminq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D78D0", Offset = "0x27D6CD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008D7")]
		public static double vpminqd_f64(v128 a0) { }

		[Address(RVA = "0x27D7910", Offset = "0x27D6D10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60008D6")]
		public static float vpmins_f32(v64 a0) { }

		[Address(RVA = "0x27D7950", Offset = "0x27D6D50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000408")]
		public static v64 vqabs_s16(v64 a0) { }

		[Address(RVA = "0x27D7990", Offset = "0x27D6D90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600040A")]
		public static v64 vqabs_s32(v64 a0) { }

		[Address(RVA = "0x27D79D0", Offset = "0x27D6DD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000833")]
		public static v64 vqabs_s64(v64 a0) { }

		[Address(RVA = "0x27D7A10", Offset = "0x27D6E10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000406")]
		public static v64 vqabs_s8(v64 a0) { }

		[Address(RVA = "0x27D7A50", Offset = "0x27D6E50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000835")]
		public static sbyte vqabsb_s8(sbyte a0) { }

		[Address(RVA = "0x27D7A90", Offset = "0x27D6E90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000838")]
		public static long vqabsd_s64(long a0) { }

		[Address(RVA = "0x27D7AD0", Offset = "0x27D6ED0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000836")]
		public static short vqabsh_s16(short a0) { }

		[Address(RVA = "0x27D7B10", Offset = "0x27D6F10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000409")]
		public static v128 vqabsq_s16(v128 a0) { }

		[Address(RVA = "0x27D7B50", Offset = "0x27D6F50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600040B")]
		public static v128 vqabsq_s32(v128 a0) { }

		[Address(RVA = "0x27D7B90", Offset = "0x27D6F90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000834")]
		public static v128 vqabsq_s64(v128 a0) { }

		[Address(RVA = "0x27D7BD0", Offset = "0x27D6FD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000407")]
		public static v128 vqabsq_s8(v128 a0) { }

		[Address(RVA = "0x27D7C10", Offset = "0x27D7010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000837")]
		public static int vqabss_s32(int a0) { }

		[Address(RVA = "0x27D7C50", Offset = "0x27D7050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600012D")]
		public static v64 vqadd_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7C90", Offset = "0x27D7090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600012F")]
		public static v64 vqadd_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7CD0", Offset = "0x27D70D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000131")]
		public static v64 vqadd_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7D10", Offset = "0x27D7110", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600012B")]
		public static v64 vqadd_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7D50", Offset = "0x27D7150", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000135")]
		public static v64 vqadd_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7D90", Offset = "0x27D7190", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000137")]
		public static v64 vqadd_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7DD0", Offset = "0x27D71D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000139")]
		public static v64 vqadd_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7E10", Offset = "0x27D7210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000133")]
		public static v64 vqadd_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D7E50", Offset = "0x27D7250", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000550")]
		public static sbyte vqaddb_s8(sbyte a0, sbyte a1) { }

		[Address(RVA = "0x27D7E90", Offset = "0x27D7290", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000554")]
		public static byte vqaddb_u8(byte a0, byte a1) { }

		[Address(RVA = "0x27D7ED0", Offset = "0x27D72D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000553")]
		public static long vqaddd_s64(long a0, long a1) { }

		[Address(RVA = "0x27D7F10", Offset = "0x27D7310", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000557")]
		public static ulong vqaddd_u64(ulong a0, ulong a1) { }

		[Address(RVA = "0x27D7F50", Offset = "0x27D7350", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000551")]
		public static short vqaddh_s16(short a0, short a1) { }

		[Address(RVA = "0x27D7F90", Offset = "0x27D7390", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000555")]
		public static ushort vqaddh_u16(ushort a0, ushort a1) { }

		[Address(RVA = "0x27D7FD0", Offset = "0x27D73D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600012E")]
		public static v128 vqaddq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D8010", Offset = "0x27D7410", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000130")]
		public static v128 vqaddq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D8050", Offset = "0x27D7450", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000132")]
		public static v128 vqaddq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D8090", Offset = "0x27D7490", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600012C")]
		public static v128 vqaddq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D80D0", Offset = "0x27D74D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000136")]
		public static v128 vqaddq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D8110", Offset = "0x27D7510", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000138")]
		public static v128 vqaddq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D8150", Offset = "0x27D7550", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600013A")]
		public static v128 vqaddq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D8190", Offset = "0x27D7590", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000134")]
		public static v128 vqaddq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D81D0", Offset = "0x27D75D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000552")]
		public static int vqadds_s32(int a0, int a1) { }

		[Address(RVA = "0x27D8210", Offset = "0x27D7610", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000556")]
		public static uint vqadds_u32(uint a0, uint a1) { }

		[Address(RVA = "0x27D8250", Offset = "0x27D7650", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007BA")]
		public static v128 vqdmlal_high_lane_s16(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D8290", Offset = "0x27D7690", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007BB")]
		public static v128 vqdmlal_high_lane_s32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D82D0", Offset = "0x27D76D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007C0")]
		public static v128 vqdmlal_high_laneq_s16(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D8310", Offset = "0x27D7710", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007C1")]
		public static v128 vqdmlal_high_laneq_s32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D8350", Offset = "0x27D7750", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000826")]
		public static v128 vqdmlal_high_n_s16(v128 a0, v128 a1, short a2) { }

		[Address(RVA = "0x27D8390", Offset = "0x27D7790", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000827")]
		public static v128 vqdmlal_high_n_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D83D0", Offset = "0x27D77D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005C6")]
		public static v128 vqdmlal_high_s16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D8410", Offset = "0x27D7810", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005C7")]
		public static v128 vqdmlal_high_s32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D8450", Offset = "0x27D7850", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600039C")]
		public static v128 vqdmlal_lane_s16(v128 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D8490", Offset = "0x27D7890", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600039D")]
		public static v128 vqdmlal_lane_s32(v128 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D84D0", Offset = "0x27D78D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007BC")]
		public static v128 vqdmlal_laneq_s16(v128 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D8510", Offset = "0x27D7910", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007BD")]
		public static v128 vqdmlal_laneq_s32(v128 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D8550", Offset = "0x27D7950", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003EC")]
		public static v128 vqdmlal_n_s16(v128 a0, v64 a1, short a2) { }

		[Address(RVA = "0x27D8590", Offset = "0x27D7990", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003ED")]
		public static v128 vqdmlal_n_s32(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D85D0", Offset = "0x27D79D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000189")]
		public static v128 vqdmlal_s16(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D8610", Offset = "0x27D7A10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600018A")]
		public static v128 vqdmlal_s32(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D8650", Offset = "0x27D7A50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007B8")]
		public static int vqdmlalh_lane_s16(int a0, short a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D8690", Offset = "0x27D7A90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007BE")]
		public static int vqdmlalh_laneq_s16(int a0, short a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D86D0", Offset = "0x27D7AD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005C4")]
		public static int vqdmlalh_s16(int a0, short a1, short a2) { }

		[Address(RVA = "0x27D8710", Offset = "0x27D7B10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007B9")]
		public static long vqdmlals_lane_s32(long a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D8750", Offset = "0x27D7B50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007BF")]
		public static long vqdmlals_laneq_s32(long a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D8790", Offset = "0x27D7B90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005C5")]
		public static long vqdmlals_s32(long a0, int a1, int a2) { }

		[Address(RVA = "0x27D87D0", Offset = "0x27D7BD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007DA")]
		public static v128 vqdmlsl_high_lane_s16(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D8810", Offset = "0x27D7C10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007DB")]
		public static v128 vqdmlsl_high_lane_s32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D8850", Offset = "0x27D7C50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007E0")]
		public static v128 vqdmlsl_high_laneq_s16(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D8890", Offset = "0x27D7C90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007E1")]
		public static v128 vqdmlsl_high_laneq_s32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D88D0", Offset = "0x27D7CD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600082C")]
		public static v128 vqdmlsl_high_n_s16(v128 a0, v128 a1, short a2) { }

		[Address(RVA = "0x27D8910", Offset = "0x27D7D10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600082D")]
		public static v128 vqdmlsl_high_n_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D8950", Offset = "0x27D7D50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005CA")]
		public static v128 vqdmlsl_high_s16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D8990", Offset = "0x27D7D90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005CB")]
		public static v128 vqdmlsl_high_s32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27D89D0", Offset = "0x27D7DD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003AC")]
		public static v128 vqdmlsl_lane_s16(v128 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D8A10", Offset = "0x27D7E10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003AD")]
		public static v128 vqdmlsl_lane_s32(v128 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D8A50", Offset = "0x27D7E50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007DC")]
		public static v128 vqdmlsl_laneq_s16(v128 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D8A90", Offset = "0x27D7E90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007DD")]
		public static v128 vqdmlsl_laneq_s32(v128 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D8AD0", Offset = "0x27D7ED0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003FC")]
		public static v128 vqdmlsl_n_s16(v128 a0, v64 a1, short a2) { }

		[Address(RVA = "0x27D8B10", Offset = "0x27D7F10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003FD")]
		public static v128 vqdmlsl_n_s32(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D8B50", Offset = "0x27D7F50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600018B")]
		public static v128 vqdmlsl_s16(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D8B90", Offset = "0x27D7F90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600018C")]
		public static v128 vqdmlsl_s32(v128 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27D8BD0", Offset = "0x27D7FD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007D8")]
		public static int vqdmlslh_lane_s16(int a0, short a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D8C10", Offset = "0x27D8010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007DE")]
		public static int vqdmlslh_laneq_s16(int a0, short a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D8C50", Offset = "0x27D8050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005C8")]
		public static int vqdmlslh_s16(int a0, short a1, short a2) { }

		[Address(RVA = "0x27D8C90", Offset = "0x27D8090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007D9")]
		public static long vqdmlsls_lane_s32(long a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27D8CD0", Offset = "0x27D80D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007DF")]
		public static long vqdmlsls_laneq_s32(long a0, int a1, v128 a2, int a3) { }

		[Address(RVA = "0x27D8D10", Offset = "0x27D8110", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005C9")]
		public static long vqdmlsls_s32(long a0, int a1, int a2) { }

		[Address(RVA = "0x27D8D50", Offset = "0x27D8150", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003D2")]
		public static v64 vqdmulh_lane_s16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D8D90", Offset = "0x27D8190", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003D4")]
		public static v64 vqdmulh_lane_s32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D8DD0", Offset = "0x27D81D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000814")]
		public static v64 vqdmulh_laneq_s16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D8E10", Offset = "0x27D8210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000816")]
		public static v64 vqdmulh_laneq_s32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D8E50", Offset = "0x27D8250", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003CE")]
		public static v64 vqdmulh_n_s16(v64 a0, short a1) { }

		[Address(RVA = "0x27D8E90", Offset = "0x27D8290", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003D0")]
		public static v64 vqdmulh_n_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27D8ED0", Offset = "0x27D82D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000181")]
		public static v64 vqdmulh_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D8F10", Offset = "0x27D8310", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000183")]
		public static v64 vqdmulh_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D8F50", Offset = "0x27D8350", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000812")]
		public static short vqdmulhh_lane_s16(short a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D8F90", Offset = "0x27D8390", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000818")]
		public static short vqdmulhh_laneq_s16(short a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D8FD0", Offset = "0x27D83D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005C0")]
		public static short vqdmulhh_s16(short a0, short a1) { }

		[Address(RVA = "0x27D9010", Offset = "0x27D8410", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003D3")]
		public static v128 vqdmulhq_lane_s16(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D9050", Offset = "0x27D8450", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003D5")]
		public static v128 vqdmulhq_lane_s32(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D9090", Offset = "0x27D8490", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000815")]
		public static v128 vqdmulhq_laneq_s16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D90D0", Offset = "0x27D84D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000817")]
		public static v128 vqdmulhq_laneq_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D9110", Offset = "0x27D8510", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003CF")]
		public static v128 vqdmulhq_n_s16(v128 a0, short a1) { }

		[Address(RVA = "0x27D9150", Offset = "0x27D8550", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003D1")]
		public static v128 vqdmulhq_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27D9190", Offset = "0x27D8590", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000182")]
		public static v128 vqdmulhq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D91D0", Offset = "0x27D85D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000184")]
		public static v128 vqdmulhq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D9210", Offset = "0x27D8610", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000813")]
		public static int vqdmulhs_lane_s32(int a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D9250", Offset = "0x27D8650", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000819")]
		public static int vqdmulhs_laneq_s32(int a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D9290", Offset = "0x27D8690", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005C1")]
		public static int vqdmulhs_s32(int a0, int a1) { }

		[Address(RVA = "0x27D92D0", Offset = "0x27D86D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600080A")]
		public static v128 vqdmull_high_lane_s16(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D9310", Offset = "0x27D8710", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600080B")]
		public static v128 vqdmull_high_lane_s32(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D9350", Offset = "0x27D8750", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000810")]
		public static v128 vqdmull_high_laneq_s16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D9390", Offset = "0x27D8790", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000811")]
		public static v128 vqdmull_high_laneq_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D93D0", Offset = "0x27D87D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000806")]
		public static v128 vqdmull_high_n_s16(v128 a0, short a1) { }

		[Address(RVA = "0x27D9410", Offset = "0x27D8810", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000807")]
		public static v128 vqdmull_high_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27D9450", Offset = "0x27D8850", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005D4")]
		public static v128 vqdmull_high_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D9490", Offset = "0x27D8890", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005D5")]
		public static v128 vqdmull_high_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27D94D0", Offset = "0x27D88D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003CC")]
		public static v128 vqdmull_lane_s16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D9510", Offset = "0x27D8910", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003CD")]
		public static v128 vqdmull_lane_s32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D9550", Offset = "0x27D8950", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600080C")]
		public static v128 vqdmull_laneq_s16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D9590", Offset = "0x27D8990", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600080D")]
		public static v128 vqdmull_laneq_s32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D95D0", Offset = "0x27D89D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003CA")]
		public static v128 vqdmull_n_s16(v64 a0, short a1) { }

		[Address(RVA = "0x27D9610", Offset = "0x27D8A10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003CB")]
		public static v128 vqdmull_n_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27D9650", Offset = "0x27D8A50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000193")]
		public static v128 vqdmull_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D9690", Offset = "0x27D8A90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000194")]
		public static v128 vqdmull_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27D96D0", Offset = "0x27D8AD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000808")]
		public static int vqdmullh_lane_s16(short a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D9710", Offset = "0x27D8B10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600080E")]
		public static int vqdmullh_laneq_s16(short a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D9750", Offset = "0x27D8B50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005D2")]
		public static int vqdmullh_s16(short a0, short a1) { }

		[Address(RVA = "0x27D9790", Offset = "0x27D8B90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000809")]
		public static long vqdmulls_lane_s32(int a0, v64 a1, int a2) { }

		[Address(RVA = "0x27D97D0", Offset = "0x27D8BD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600080F")]
		public static long vqdmulls_laneq_s32(int a0, v128 a1, int a2) { }

		[Address(RVA = "0x27D9810", Offset = "0x27D8C10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005D3")]
		public static long vqdmulls_s32(int a0, int a1) { }

		[Address(RVA = "0x27D9850", Offset = "0x27D8C50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000796")]
		public static v128 vqmovn_high_s16(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D9890", Offset = "0x27D8C90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000797")]
		public static v128 vqmovn_high_s32(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D98D0", Offset = "0x27D8CD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000798")]
		public static v128 vqmovn_high_s64(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D9910", Offset = "0x27D8D10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000799")]
		public static v128 vqmovn_high_u16(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D9950", Offset = "0x27D8D50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600079A")]
		public static v128 vqmovn_high_u32(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D9990", Offset = "0x27D8D90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600079B")]
		public static v128 vqmovn_high_u64(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D99D0", Offset = "0x27D8DD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000385")]
		public static v64 vqmovn_s16(v128 a0) { }

		[Address(RVA = "0x27D9A10", Offset = "0x27D8E10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000386")]
		public static v64 vqmovn_s32(v128 a0) { }

		[Address(RVA = "0x27D9A50", Offset = "0x27D8E50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000387")]
		public static v64 vqmovn_s64(v128 a0) { }

		[Address(RVA = "0x27D9A90", Offset = "0x27D8E90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000388")]
		public static v64 vqmovn_u16(v128 a0) { }

		[Address(RVA = "0x27D9AD0", Offset = "0x27D8ED0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000389")]
		public static v64 vqmovn_u32(v128 a0) { }

		[Address(RVA = "0x27D9B10", Offset = "0x27D8F10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600038A")]
		public static v64 vqmovn_u64(v128 a0) { }

		[Address(RVA = "0x27D9B50", Offset = "0x27D8F50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000792")]
		public static int vqmovnd_s64(long a0) { }

		[Address(RVA = "0x27D9B90", Offset = "0x27D8F90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000795")]
		public static uint vqmovnd_u64(ulong a0) { }

		[Address(RVA = "0x27D9BD0", Offset = "0x27D8FD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000790")]
		public static sbyte vqmovnh_s16(short a0) { }

		[Address(RVA = "0x27D9C10", Offset = "0x27D9010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000793")]
		public static byte vqmovnh_u16(ushort a0) { }

		[Address(RVA = "0x27D9C50", Offset = "0x27D9050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000791")]
		public static short vqmovns_s32(int a0) { }

		[Address(RVA = "0x27D9C90", Offset = "0x27D9090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000794")]
		public static ushort vqmovns_u32(uint a0) { }

		[Address(RVA = "0x27D9CD0", Offset = "0x27D90D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600079F")]
		public static v128 vqmovun_high_s16(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D9D10", Offset = "0x27D9110", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007A0")]
		public static v128 vqmovun_high_s32(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D9D50", Offset = "0x27D9150", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60007A1")]
		public static v128 vqmovun_high_s64(v64 a0, v128 a1) { }

		[Address(RVA = "0x27D9D90", Offset = "0x27D9190", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600038B")]
		public static v64 vqmovun_s16(v128 a0) { }

		[Address(RVA = "0x27D9DD0", Offset = "0x27D91D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600038C")]
		public static v64 vqmovun_s32(v128 a0) { }

		[Address(RVA = "0x27D9E10", Offset = "0x27D9210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600038D")]
		public static v64 vqmovun_s64(v128 a0) { }

		[Address(RVA = "0x27D9E50", Offset = "0x27D9250", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600079E")]
		public static uint vqmovund_s64(long a0) { }

		[Address(RVA = "0x27D9E90", Offset = "0x27D9290", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600079C")]
		public static byte vqmovunh_s16(short a0) { }

		[Address(RVA = "0x27D9ED0", Offset = "0x27D92D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600079D")]
		public static ushort vqmovuns_s32(int a0) { }

		[Address(RVA = "0x27D9F10", Offset = "0x27D9310", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000416")]
		public static v64 vqneg_s16(v64 a0) { }

		[Address(RVA = "0x27D9F50", Offset = "0x27D9350", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000418")]
		public static v64 vqneg_s32(v64 a0) { }

		[Address(RVA = "0x27D9F90", Offset = "0x27D9390", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600083E")]
		public static v64 vqneg_s64(v64 a0) { }

		[Address(RVA = "0x27D9FD0", Offset = "0x27D93D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000414")]
		public static v64 vqneg_s8(v64 a0) { }

		[Address(RVA = "0x27DA010", Offset = "0x27D9410", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000840")]
		public static sbyte vqnegb_s8(sbyte a0) { }

		[Address(RVA = "0x27DA050", Offset = "0x27D9450", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000843")]
		public static long vqnegd_s64(long a0) { }

		[Address(RVA = "0x27DA090", Offset = "0x27D9490", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000841")]
		public static short vqnegh_s16(short a0) { }

		[Address(RVA = "0x27DA0D0", Offset = "0x27D94D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000417")]
		public static v128 vqnegq_s16(v128 a0) { }

		[Address(RVA = "0x27DA110", Offset = "0x27D9510", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000419")]
		public static v128 vqnegq_s32(v128 a0) { }

		[Address(RVA = "0x27DA150", Offset = "0x27D9550", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600083F")]
		public static v128 vqnegq_s64(v128 a0) { }

		[Address(RVA = "0x27DA190", Offset = "0x27D9590", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000415")]
		public static v128 vqnegq_s8(v128 a0) { }

		[Address(RVA = "0x27DA1D0", Offset = "0x27D95D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000842")]
		public static int vqnegs_s32(int a0) { }

		[Address(RVA = "0x27DA210", Offset = "0x27D9610", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009C6")]
		public static v64 vqrdmlah_lane_s16(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27DA250", Offset = "0x27D9650", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009CA")]
		public static v64 vqrdmlah_lane_s32(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27DA290", Offset = "0x27D9690", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009C8")]
		public static v64 vqrdmlah_laneq_s16(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27DA2D0", Offset = "0x27D96D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009CC")]
		public static v64 vqrdmlah_laneq_s32(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27DA310", Offset = "0x27D9710", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009BE")]
		public static v64 vqrdmlah_s16(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27DA350", Offset = "0x27D9750", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009BF")]
		public static v64 vqrdmlah_s32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27DA390", Offset = "0x27D9790", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009DA")]
		public static short vqrdmlahh_lane_s16(short a0, short a1, v64 a2, int a3) { }

		[Address(RVA = "0x27DA3D0", Offset = "0x27D97D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009DB")]
		public static short vqrdmlahh_laneq_s16(short a0, short a1, v128 a2, int a3) { }

		[Address(RVA = "0x27DA410", Offset = "0x27D9810", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009D6")]
		public static short vqrdmlahh_s16(short a0, short a1, short a2) { }

		[Address(RVA = "0x27DA450", Offset = "0x27D9850", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009C7")]
		public static v128 vqrdmlahq_lane_s16(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27DA490", Offset = "0x27D9890", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009CB")]
		public static v128 vqrdmlahq_lane_s32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27DA4D0", Offset = "0x27D98D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009C9")]
		public static v128 vqrdmlahq_laneq_s16(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27DA510", Offset = "0x27D9910", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009CD")]
		public static v128 vqrdmlahq_laneq_s32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27DA550", Offset = "0x27D9950", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009C0")]
		public static v128 vqrdmlahq_s16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27DA590", Offset = "0x27D9990", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009C1")]
		public static v128 vqrdmlahq_s32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27DA5D0", Offset = "0x27D99D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009DC")]
		public static int vqrdmlahs_lane_s32(int a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27DA610", Offset = "0x27D9A10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009D7")]
		public static int vqrdmlahs_s32(int a0, int a1, int a2) { }

		[Address(RVA = "0x27DA650", Offset = "0x27D9A50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009CE")]
		public static v64 vqrdmlsh_lane_s16(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27DA690", Offset = "0x27D9A90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009D2")]
		public static v64 vqrdmlsh_lane_s32(v64 a0, v64 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27DA6D0", Offset = "0x27D9AD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009D0")]
		public static v64 vqrdmlsh_laneq_s16(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27DA710", Offset = "0x27D9B10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009D4")]
		public static v64 vqrdmlsh_laneq_s32(v64 a0, v64 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27DA750", Offset = "0x27D9B50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009C2")]
		public static v64 vqrdmlsh_s16(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27DA790", Offset = "0x27D9B90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009C3")]
		public static v64 vqrdmlsh_s32(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27DA7D0", Offset = "0x27D9BD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009DD")]
		public static short vqrdmlshh_lane_s16(short a0, short a1, v64 a2, int a3) { }

		[Address(RVA = "0x27DA810", Offset = "0x27D9C10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009DE")]
		public static short vqrdmlshh_laneq_s16(short a0, short a1, v128 a2, int a3) { }

		[Address(RVA = "0x27DA850", Offset = "0x27D9C50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009D8")]
		public static short vqrdmlshh_s16(short a0, short a1, short a2) { }

		[Address(RVA = "0x27DA890", Offset = "0x27D9C90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009CF")]
		public static v128 vqrdmlshq_lane_s16(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27DA8D0", Offset = "0x27D9CD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009D3")]
		public static v128 vqrdmlshq_lane_s32(v128 a0, v128 a1, v64 a2, int a3) { }

		[Address(RVA = "0x27DA910", Offset = "0x27D9D10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009D1")]
		public static v128 vqrdmlshq_laneq_s16(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27DA950", Offset = "0x27D9D50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009D5")]
		public static v128 vqrdmlshq_laneq_s32(v128 a0, v128 a1, v128 a2, int a3) { }

		[Address(RVA = "0x27DA990", Offset = "0x27D9D90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009C4")]
		public static v128 vqrdmlshq_s16(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27DA9D0", Offset = "0x27D9DD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009C5")]
		public static v128 vqrdmlshq_s32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27DAA10", Offset = "0x27D9E10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009DF")]
		public static int vqrdmlshs_lane_s32(int a0, int a1, v64 a2, int a3) { }

		[Address(RVA = "0x27DAA50", Offset = "0x27D9E50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009D9")]
		public static int vqrdmlshs_s32(int a0, int a1, int a2) { }

		[Address(RVA = "0x27DAA90", Offset = "0x27D9E90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003DA")]
		public static v64 vqrdmulh_lane_s16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27DAAD0", Offset = "0x27D9ED0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003DC")]
		public static v64 vqrdmulh_lane_s32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27DAB10", Offset = "0x27D9F10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600081C")]
		public static v64 vqrdmulh_laneq_s16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DAB50", Offset = "0x27D9F50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600081E")]
		public static v64 vqrdmulh_laneq_s32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DAB90", Offset = "0x27D9F90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003D6")]
		public static v64 vqrdmulh_n_s16(v64 a0, short a1) { }

		[Address(RVA = "0x27DABD0", Offset = "0x27D9FD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003D8")]
		public static v64 vqrdmulh_n_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27DAC10", Offset = "0x27DA010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000185")]
		public static v64 vqrdmulh_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DAC50", Offset = "0x27DA050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000187")]
		public static v64 vqrdmulh_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DAC90", Offset = "0x27DA090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600081A")]
		public static short vqrdmulhh_lane_s16(short a0, v64 a1, int a2) { }

		[Address(RVA = "0x27DACD0", Offset = "0x27DA0D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000820")]
		public static short vqrdmulhh_laneq_s16(short a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DAD10", Offset = "0x27DA110", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005C2")]
		public static short vqrdmulhh_s16(short a0, short a1) { }

		[Address(RVA = "0x27DAD50", Offset = "0x27DA150", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003DB")]
		public static v128 vqrdmulhq_lane_s16(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27DAD90", Offset = "0x27DA190", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003DD")]
		public static v128 vqrdmulhq_lane_s32(v128 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27DADD0", Offset = "0x27DA1D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600081D")]
		public static v128 vqrdmulhq_laneq_s16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DAE10", Offset = "0x27DA210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600081F")]
		public static v128 vqrdmulhq_laneq_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DAE50", Offset = "0x27DA250", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003D7")]
		public static v128 vqrdmulhq_n_s16(v128 a0, short a1) { }

		[Address(RVA = "0x27DAE90", Offset = "0x27DA290", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60003D9")]
		public static v128 vqrdmulhq_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27DAED0", Offset = "0x27DA2D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000186")]
		public static v128 vqrdmulhq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DAF10", Offset = "0x27DA310", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000188")]
		public static v128 vqrdmulhq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DAF50", Offset = "0x27DA350", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600081B")]
		public static int vqrdmulhs_lane_s32(int a0, v64 a1, int a2) { }

		[Address(RVA = "0x27DAF90", Offset = "0x27DA390", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000821")]
		public static int vqrdmulhs_laneq_s32(int a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DAFD0", Offset = "0x27DA3D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005C3")]
		public static int vqrdmulhs_s32(int a0, int a1) { }

		[Address(RVA = "0x27DB010", Offset = "0x27DA410", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002A9")]
		public static v64 vqrshl_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DB050", Offset = "0x27DA450", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002AB")]
		public static v64 vqrshl_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DB090", Offset = "0x27DA490", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002AD")]
		public static v64 vqrshl_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DB0D0", Offset = "0x27DA4D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002A7")]
		public static v64 vqrshl_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DB110", Offset = "0x27DA510", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002B1")]
		public static v64 vqrshl_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DB150", Offset = "0x27DA550", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002B3")]
		public static v64 vqrshl_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DB190", Offset = "0x27DA590", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002B5")]
		public static v64 vqrshl_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DB1D0", Offset = "0x27DA5D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002AF")]
		public static v64 vqrshl_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DB210", Offset = "0x27DA610", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006BE")]
		public static sbyte vqrshlb_s8(sbyte a0, sbyte a1) { }

		[Address(RVA = "0x27DB250", Offset = "0x27DA650", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006C2")]
		public static byte vqrshlb_u8(byte a0, sbyte a1) { }

		[Address(RVA = "0x27DB290", Offset = "0x27DA690", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006C1")]
		public static long vqrshld_s64(long a0, long a1) { }

		[Address(RVA = "0x27DB2D0", Offset = "0x27DA6D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006C5")]
		public static ulong vqrshld_u64(ulong a0, long a1) { }

		[Address(RVA = "0x27DB310", Offset = "0x27DA710", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006BF")]
		public static short vqrshlh_s16(short a0, short a1) { }

		[Address(RVA = "0x27DB350", Offset = "0x27DA750", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006C3")]
		public static ushort vqrshlh_u16(ushort a0, short a1) { }

		[Address(RVA = "0x27DB390", Offset = "0x27DA790", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002AA")]
		public static v128 vqrshlq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DB3D0", Offset = "0x27DA7D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002AC")]
		public static v128 vqrshlq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DB410", Offset = "0x27DA810", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002AE")]
		public static v128 vqrshlq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DB450", Offset = "0x27DA850", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002A8")]
		public static v128 vqrshlq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DB490", Offset = "0x27DA890", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002B2")]
		public static v128 vqrshlq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DB4D0", Offset = "0x27DA8D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002B4")]
		public static v128 vqrshlq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DB510", Offset = "0x27DA910", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002B6")]
		public static v128 vqrshlq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DB550", Offset = "0x27DA950", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002B0")]
		public static v128 vqrshlq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DB590", Offset = "0x27DA990", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006C0")]
		public static int vqrshls_s32(int a0, int a1) { }

		[Address(RVA = "0x27DB5D0", Offset = "0x27DA9D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006C4")]
		public static uint vqrshls_u32(uint a0, int a1) { }

		[Address(RVA = "0x27DB610", Offset = "0x27DAA10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000706")]
		public static v128 vqrshrn_high_n_s16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DB650", Offset = "0x27DAA50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000707")]
		public static v128 vqrshrn_high_n_s32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DB690", Offset = "0x27DAA90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000708")]
		public static v128 vqrshrn_high_n_s64(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DB6D0", Offset = "0x27DAAD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000709")]
		public static v128 vqrshrn_high_n_u16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DB710", Offset = "0x27DAB10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600070A")]
		public static v128 vqrshrn_high_n_u32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DB750", Offset = "0x27DAB50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600070B")]
		public static v128 vqrshrn_high_n_u64(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DB790", Offset = "0x27DAB90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000337")]
		public static v64 vqrshrn_n_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27DB7D0", Offset = "0x27DABD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000338")]
		public static v64 vqrshrn_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27DB810", Offset = "0x27DAC10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000339")]
		public static v64 vqrshrn_n_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27DB850", Offset = "0x27DAC50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600033A")]
		public static v64 vqrshrn_n_u16(v128 a0, int a1) { }

		[Address(RVA = "0x27DB890", Offset = "0x27DAC90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600033B")]
		public static v64 vqrshrn_n_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27DB8D0", Offset = "0x27DACD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600033C")]
		public static v64 vqrshrn_n_u64(v128 a0, int a1) { }

		[Address(RVA = "0x27DB910", Offset = "0x27DAD10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000702")]
		public static int vqrshrnd_n_s64(long a0, int a1) { }

		[Address(RVA = "0x27DB950", Offset = "0x27DAD50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000705")]
		public static uint vqrshrnd_n_u64(ulong a0, int a1) { }

		[Address(RVA = "0x27DB990", Offset = "0x27DAD90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000700")]
		public static sbyte vqrshrnh_n_s16(short a0, int a1) { }

		[Address(RVA = "0x27DB9D0", Offset = "0x27DADD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000703")]
		public static byte vqrshrnh_n_u16(ushort a0, int a1) { }

		[Address(RVA = "0x27DBA10", Offset = "0x27DAE10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000701")]
		public static short vqrshrns_n_s32(int a0, int a1) { }

		[Address(RVA = "0x27DBA50", Offset = "0x27DAE50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000704")]
		public static ushort vqrshrns_n_u32(uint a0, int a1) { }

		[Address(RVA = "0x27DBA90", Offset = "0x27DAE90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006EB")]
		public static v128 vqrshrun_high_n_s16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DBAD0", Offset = "0x27DAED0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006EC")]
		public static v128 vqrshrun_high_n_s32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DBB10", Offset = "0x27DAF10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006ED")]
		public static v128 vqrshrun_high_n_s64(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DBB50", Offset = "0x27DAF50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000328")]
		public static v64 vqrshrun_n_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27DBB90", Offset = "0x27DAF90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000329")]
		public static v64 vqrshrun_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27DBBD0", Offset = "0x27DAFD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600032A")]
		public static v64 vqrshrun_n_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27DBC10", Offset = "0x27DB010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006EA")]
		public static uint vqrshrund_n_s64(long a0, int a1) { }

		[Address(RVA = "0x27DBC50", Offset = "0x27DB050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006E8")]
		public static byte vqrshrunh_n_s16(short a0, int a1) { }

		[Address(RVA = "0x27DBC90", Offset = "0x27DB090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006E9")]
		public static ushort vqrshruns_n_s32(int a0, int a1) { }

		[Address(RVA = "0x27DBCD0", Offset = "0x27DB0D0", Length = "0x2F")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000309")]
		public static v64 vqshl_n_s16(v64 a0, int a1) { }

		[Address(RVA = "0x27DBD00", Offset = "0x27DB100", Length = "0x2F")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x600030B")]
		public static v64 vqshl_n_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27DBD30", Offset = "0x27DB130", Length = "0x32")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x600030D")]
		public static v64 vqshl_n_s64(v64 a0, int a1) { }

		[Address(RVA = "0x27DBD70", Offset = "0x27DB170", Length = "0x2F")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000307")]
		public static v64 vqshl_n_s8(v64 a0, int a1) { }

		[Address(RVA = "0x27DBDA0", Offset = "0x27DB1A0", Length = "0x2F")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000311")]
		public static v64 vqshl_n_u16(v64 a0, int a1) { }

		[Address(RVA = "0x27DBDD0", Offset = "0x27DB1D0", Length = "0x2F")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000313")]
		public static v64 vqshl_n_u32(v64 a0, int a1) { }

		[Address(RVA = "0x27DBE00", Offset = "0x27DB200", Length = "0x32")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000315")]
		public static v64 vqshl_n_u64(v64 a0, int a1) { }

		[Address(RVA = "0x27DBE40", Offset = "0x27DB240", Length = "0x2F")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x600030F")]
		public static v64 vqshl_n_u8(v64 a0, int a1) { }

		[Address(RVA = "0x27DBE70", Offset = "0x27DB270", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000289")]
		public static v64 vqshl_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DBEB0", Offset = "0x27DB2B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600028B")]
		public static v64 vqshl_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DBEF0", Offset = "0x27DB2F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600028D")]
		public static v64 vqshl_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DBF30", Offset = "0x27DB330", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000287")]
		public static v64 vqshl_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DBF70", Offset = "0x27DB370", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000291")]
		public static v64 vqshl_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DBFB0", Offset = "0x27DB3B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000293")]
		public static v64 vqshl_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DBFF0", Offset = "0x27DB3F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000295")]
		public static v64 vqshl_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DC030", Offset = "0x27DB430", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600028F")]
		public static v64 vqshl_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DC070", Offset = "0x27DB470", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006D0")]
		public static sbyte vqshlb_n_s8(sbyte a0, int a1) { }

		[Address(RVA = "0x27DC0B0", Offset = "0x27DB4B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006D4")]
		public static byte vqshlb_n_u8(byte a0, int a1) { }

		[Address(RVA = "0x27DC0F0", Offset = "0x27DB4F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006B4")]
		public static sbyte vqshlb_s8(sbyte a0, sbyte a1) { }

		[Address(RVA = "0x27DC130", Offset = "0x27DB530", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006B8")]
		public static byte vqshlb_u8(byte a0, sbyte a1) { }

		[Address(RVA = "0x27DC170", Offset = "0x27DB570", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006D3")]
		public static long vqshld_n_s64(long a0, int a1) { }

		[Address(RVA = "0x27DC1B0", Offset = "0x27DB5B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006D7")]
		public static ulong vqshld_n_u64(ulong a0, int a1) { }

		[Address(RVA = "0x27DC1F0", Offset = "0x27DB5F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006B7")]
		public static long vqshld_s64(long a0, long a1) { }

		[Address(RVA = "0x27DC230", Offset = "0x27DB630", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006BB")]
		public static ulong vqshld_u64(ulong a0, long a1) { }

		[Address(RVA = "0x27DC270", Offset = "0x27DB670", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006D1")]
		public static short vqshlh_n_s16(short a0, int a1) { }

		[Address(RVA = "0x27DC2B0", Offset = "0x27DB6B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006D5")]
		public static ushort vqshlh_n_u16(ushort a0, int a1) { }

		[Address(RVA = "0x27DC2F0", Offset = "0x27DB6F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006B5")]
		public static short vqshlh_s16(short a0, short a1) { }

		[Address(RVA = "0x27DC330", Offset = "0x27DB730", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006B9")]
		public static ushort vqshlh_u16(ushort a0, short a1) { }

		[Address(RVA = "0x27DC370", Offset = "0x27DB770", Length = "0x4E")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x600030A")]
		public static v128 vqshlq_n_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27DC3C0", Offset = "0x27DB7C0", Length = "0x4D")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x600030C")]
		public static v128 vqshlq_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27DC410", Offset = "0x27DB810", Length = "0x4B")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x600030E")]
		public static v128 vqshlq_n_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27DC460", Offset = "0x27DB860", Length = "0x4E")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000308")]
		public static v128 vqshlq_n_s8(v128 a0, int a1) { }

		[Address(RVA = "0x27DC4B0", Offset = "0x27DB8B0", Length = "0x4E")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000312")]
		public static v128 vqshlq_n_u16(v128 a0, int a1) { }

		[Address(RVA = "0x27DC500", Offset = "0x27DB900", Length = "0x4D")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000314")]
		public static v128 vqshlq_n_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27DC550", Offset = "0x27DB950", Length = "0x4B")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000316")]
		public static v128 vqshlq_n_u64(v128 a0, int a1) { }

		[Address(RVA = "0x27DC5A0", Offset = "0x27DB9A0", Length = "0x4E")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000310")]
		public static v128 vqshlq_n_u8(v128 a0, int a1) { }

		[Address(RVA = "0x27DC5F0", Offset = "0x27DB9F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600028A")]
		public static v128 vqshlq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DC630", Offset = "0x27DBA30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600028C")]
		public static v128 vqshlq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DC670", Offset = "0x27DBA70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600028E")]
		public static v128 vqshlq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DC6B0", Offset = "0x27DBAB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000288")]
		public static v128 vqshlq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DC6F0", Offset = "0x27DBAF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000292")]
		public static v128 vqshlq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DC730", Offset = "0x27DBB30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000294")]
		public static v128 vqshlq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DC770", Offset = "0x27DBB70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000296")]
		public static v128 vqshlq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DC7B0", Offset = "0x27DBBB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000290")]
		public static v128 vqshlq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DC7F0", Offset = "0x27DBBF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006D2")]
		public static int vqshls_n_s32(int a0, int a1) { }

		[Address(RVA = "0x27DC830", Offset = "0x27DBC30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006D6")]
		public static uint vqshls_n_u32(uint a0, int a1) { }

		[Address(RVA = "0x27DC870", Offset = "0x27DBC70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006B6")]
		public static int vqshls_s32(int a0, int a1) { }

		[Address(RVA = "0x27DC8B0", Offset = "0x27DBCB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006BA")]
		public static uint vqshls_u32(uint a0, int a1) { }

		[Address(RVA = "0x27DC8F0", Offset = "0x27DBCF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000319")]
		public static v64 vqshlu_n_s16(v64 a0, int a1) { }

		[Address(RVA = "0x27DC930", Offset = "0x27DBD30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600031B")]
		public static v64 vqshlu_n_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27DC970", Offset = "0x27DBD70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600031D")]
		public static v64 vqshlu_n_s64(v64 a0, int a1) { }

		[Address(RVA = "0x27DC9B0", Offset = "0x27DBDB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000317")]
		public static v64 vqshlu_n_s8(v64 a0, int a1) { }

		[Address(RVA = "0x27DC9F0", Offset = "0x27DBDF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006D8")]
		public static byte vqshlub_n_s8(sbyte a0, int a1) { }

		[Address(RVA = "0x27DCA30", Offset = "0x27DBE30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006DB")]
		public static ulong vqshlud_n_s64(long a0, int a1) { }

		[Address(RVA = "0x27DCA70", Offset = "0x27DBE70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006D9")]
		public static ushort vqshluh_n_s16(short a0, int a1) { }

		[Address(RVA = "0x27DCAB0", Offset = "0x27DBEB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600031A")]
		public static v128 vqshluq_n_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27DCAF0", Offset = "0x27DBEF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600031C")]
		public static v128 vqshluq_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27DCB30", Offset = "0x27DBF30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600031E")]
		public static v128 vqshluq_n_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27DCB70", Offset = "0x27DBF70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000318")]
		public static v128 vqshluq_n_s8(v128 a0, int a1) { }

		[Address(RVA = "0x27DCBB0", Offset = "0x27DBFB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006DA")]
		public static uint vqshlus_n_s32(int a0, int a1) { }

		[Address(RVA = "0x27DCBF0", Offset = "0x27DBFF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006F4")]
		public static v128 vqshrn_high_n_s16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DCC30", Offset = "0x27DC030", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006F5")]
		public static v128 vqshrn_high_n_s32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DCC70", Offset = "0x27DC070", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006F6")]
		public static v128 vqshrn_high_n_s64(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DCCB0", Offset = "0x27DC0B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006F7")]
		public static v128 vqshrn_high_n_u16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DCCF0", Offset = "0x27DC0F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006F8")]
		public static v128 vqshrn_high_n_u32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DCD30", Offset = "0x27DC130", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006F9")]
		public static v128 vqshrn_high_n_u64(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DCD70", Offset = "0x27DC170", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600032B")]
		public static v64 vqshrn_n_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27DCDB0", Offset = "0x27DC1B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600032C")]
		public static v64 vqshrn_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27DCDF0", Offset = "0x27DC1F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600032D")]
		public static v64 vqshrn_n_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27DCE30", Offset = "0x27DC230", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600032E")]
		public static v64 vqshrn_n_u16(v128 a0, int a1) { }

		[Address(RVA = "0x27DCE70", Offset = "0x27DC270", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600032F")]
		public static v64 vqshrn_n_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27DCEB0", Offset = "0x27DC2B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000330")]
		public static v64 vqshrn_n_u64(v128 a0, int a1) { }

		[Address(RVA = "0x27DCEF0", Offset = "0x27DC2F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006F0")]
		public static int vqshrnd_n_s64(long a0, int a1) { }

		[Address(RVA = "0x27DCF30", Offset = "0x27DC330", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006F3")]
		public static uint vqshrnd_n_u64(ulong a0, int a1) { }

		[Address(RVA = "0x27DCF70", Offset = "0x27DC370", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006EE")]
		public static sbyte vqshrnh_n_s16(short a0, int a1) { }

		[Address(RVA = "0x27DCFB0", Offset = "0x27DC3B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006F1")]
		public static byte vqshrnh_n_u16(ushort a0, int a1) { }

		[Address(RVA = "0x27DCFF0", Offset = "0x27DC3F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006EF")]
		public static short vqshrns_n_s32(int a0, int a1) { }

		[Address(RVA = "0x27DD030", Offset = "0x27DC430", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006F2")]
		public static ushort vqshrns_n_u32(uint a0, int a1) { }

		[Address(RVA = "0x27DD070", Offset = "0x27DC470", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006E5")]
		public static v128 vqshrun_high_n_s16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DD0B0", Offset = "0x27DC4B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006E6")]
		public static v128 vqshrun_high_n_s32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DD0F0", Offset = "0x27DC4F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006E7")]
		public static v128 vqshrun_high_n_s64(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DD130", Offset = "0x27DC530", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000325")]
		public static v64 vqshrun_n_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27DD170", Offset = "0x27DC570", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000326")]
		public static v64 vqshrun_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27DD1B0", Offset = "0x27DC5B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000327")]
		public static v64 vqshrun_n_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27DD1F0", Offset = "0x27DC5F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006E4")]
		public static uint vqshrund_n_s64(long a0, int a1) { }

		[Address(RVA = "0x27DD230", Offset = "0x27DC630", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006E2")]
		public static byte vqshrunh_n_s16(short a0, int a1) { }

		[Address(RVA = "0x27DD270", Offset = "0x27DC670", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006E3")]
		public static ushort vqshruns_n_s32(int a0, int a1) { }

		[Address(RVA = "0x27DD2B0", Offset = "0x27DC6B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001C1")]
		public static v64 vqsub_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DD2F0", Offset = "0x27DC6F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001C3")]
		public static v64 vqsub_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DD330", Offset = "0x27DC730", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001C5")]
		public static v64 vqsub_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DD370", Offset = "0x27DC770", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001BF")]
		public static v64 vqsub_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DD3B0", Offset = "0x27DC7B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001C9")]
		public static v64 vqsub_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DD3F0", Offset = "0x27DC7F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001CB")]
		public static v64 vqsub_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DD430", Offset = "0x27DC830", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001CD")]
		public static v64 vqsub_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DD470", Offset = "0x27DC870", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001C7")]
		public static v64 vqsub_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DD4B0", Offset = "0x27DC8B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005E6")]
		public static sbyte vqsubb_s8(sbyte a0, sbyte a1) { }

		[Address(RVA = "0x27DD4F0", Offset = "0x27DC8F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005EA")]
		public static byte vqsubb_u8(byte a0, byte a1) { }

		[Address(RVA = "0x27DD530", Offset = "0x27DC930", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005E9")]
		public static long vqsubd_s64(long a0, long a1) { }

		[Address(RVA = "0x27DD570", Offset = "0x27DC970", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005ED")]
		public static ulong vqsubd_u64(ulong a0, ulong a1) { }

		[Address(RVA = "0x27DD5B0", Offset = "0x27DC9B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005E7")]
		public static short vqsubh_s16(short a0, short a1) { }

		[Address(RVA = "0x27DD5F0", Offset = "0x27DC9F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005EB")]
		public static ushort vqsubh_u16(ushort a0, ushort a1) { }

		[Address(RVA = "0x27DD630", Offset = "0x27DCA30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001C2")]
		public static v128 vqsubq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DD670", Offset = "0x27DCA70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001C4")]
		public static v128 vqsubq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DD6B0", Offset = "0x27DCAB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001C6")]
		public static v128 vqsubq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DD6F0", Offset = "0x27DCAF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001C0")]
		public static v128 vqsubq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DD730", Offset = "0x27DCB30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001CA")]
		public static v128 vqsubq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DD770", Offset = "0x27DCB70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001CC")]
		public static v128 vqsubq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DD7B0", Offset = "0x27DCBB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001CE")]
		public static v128 vqsubq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DD7F0", Offset = "0x27DCBF0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001C8")]
		public static v128 vqsubq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DD830", Offset = "0x27DCC30", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005E8")]
		public static int vqsubs_s32(int a0, int a1) { }

		[Address(RVA = "0x27DD870", Offset = "0x27DCC70", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005EC")]
		public static uint vqsubs_u32(uint a0, uint a1) { }

		[Address(RVA = "0x27DD8B0", Offset = "0x27DCCB0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000985")]
		public static v64 vqtbl1_s8(v128 a0, v64 a1) { }

		[Address(RVA = "0x27DD8F0", Offset = "0x27DCCF0", Length = "0x19")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000987")]
		public static v64 vqtbl1_u8(v128 a0, v64 a1) { }

		[Address(RVA = "0x27DD910", Offset = "0x27DCD10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000986")]
		public static v128 vqtbl1q_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DD950", Offset = "0x27DCD50", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000988")]
		public static v128 vqtbl1q_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DD980", Offset = "0x27DCD80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000989")]
		public static v64 vqtbx1_s8(v64 a0, v128 a1, v64 a2) { }

		[Address(RVA = "0x27DD9C0", Offset = "0x27DCDC0", Length = "0x19")]
		[DebuggerStepThrough]
		[Token(Token = "0x600098B")]
		public static v64 vqtbx1_u8(v64 a0, v128 a1, v64 a2) { }

		[Address(RVA = "0x27DD9E0", Offset = "0x27DCDE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600098A")]
		public static v128 vqtbx1q_s8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27DDA20", Offset = "0x27DCE20", Length = "0x3B")]
		[DebuggerStepThrough]
		[Token(Token = "0x600098C")]
		public static v128 vqtbx1q_u8(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27DDA60", Offset = "0x27DCE60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000576")]
		public static v128 vraddhn_high_s16(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27DDAA0", Offset = "0x27DCEA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000577")]
		public static v128 vraddhn_high_s32(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27DDAE0", Offset = "0x27DCEE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000578")]
		public static v128 vraddhn_high_s64(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27DDB20", Offset = "0x27DCF20", Length = "0x33")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000579")]
		public static v128 vraddhn_high_u16(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27DDB60", Offset = "0x27DCF60", Length = "0x33")]
		[DebuggerStepThrough]
		[Token(Token = "0x600057A")]
		public static v128 vraddhn_high_u32(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27DDBA0", Offset = "0x27DCFA0", Length = "0x33")]
		[DebuggerStepThrough]
		[Token(Token = "0x600057B")]
		public static v128 vraddhn_high_u64(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27DDBE0", Offset = "0x27DCFE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000141")]
		public static v64 vraddhn_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DDC20", Offset = "0x27DD020", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000142")]
		public static v64 vraddhn_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DDC60", Offset = "0x27DD060", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000143")]
		public static v64 vraddhn_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DDCA0", Offset = "0x27DD0A0", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000144")]
		public static v64 vraddhn_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DDCD0", Offset = "0x27DD0D0", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000145")]
		public static v64 vraddhn_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DDD00", Offset = "0x27DD100", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000146")]
		public static v64 vraddhn_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DDD30", Offset = "0x27DD130", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000882")]
		public static v64 vrbit_s8(v64 a0) { }

		[Address(RVA = "0x27DDD70", Offset = "0x27DD170", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000884")]
		public static v64 vrbit_u8(v64 a0) { }

		[Address(RVA = "0x27DDD80", Offset = "0x27DD180", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000883")]
		public static v128 vrbitq_s8(v128 a0) { }

		[Address(RVA = "0x27DDDC0", Offset = "0x27DD1C0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000885")]
		public static v128 vrbitq_u8(v128 a0) { }

		[Address(RVA = "0x27DDDE0", Offset = "0x27DD1E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000432")]
		public static v64 vrecpe_f32(v64 a0) { }

		[Address(RVA = "0x27DDE20", Offset = "0x27DD220", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000844")]
		public static v64 vrecpe_f64(v64 a0) { }

		[Address(RVA = "0x27DDE60", Offset = "0x27DD260", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000430")]
		public static v64 vrecpe_u32(v64 a0) { }

		[Address(RVA = "0x27DDEA0", Offset = "0x27DD2A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000847")]
		public static double vrecped_f64(double a0) { }

		[Address(RVA = "0x27DDEE0", Offset = "0x27DD2E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000433")]
		public static v128 vrecpeq_f32(v128 a0) { }

		[Address(RVA = "0x27DDF20", Offset = "0x27DD320", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000845")]
		public static v128 vrecpeq_f64(v128 a0) { }

		[Address(RVA = "0x27DDF60", Offset = "0x27DD360", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000431")]
		public static v128 vrecpeq_u32(v128 a0) { }

		[Address(RVA = "0x27DDFA0", Offset = "0x27DD3A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000846")]
		public static float vrecpes_f32(float a0) { }

		[Address(RVA = "0x27DDFE0", Offset = "0x27DD3E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000434")]
		public static v64 vrecps_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DE020", Offset = "0x27DD420", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000848")]
		public static v64 vrecps_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DE060", Offset = "0x27DD460", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600084B")]
		public static double vrecpsd_f64(double a0, double a1) { }

		[Address(RVA = "0x27DE0A0", Offset = "0x27DD4A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000435")]
		public static v128 vrecpsq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DE0E0", Offset = "0x27DD4E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000849")]
		public static v128 vrecpsq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DE120", Offset = "0x27DD520", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600084A")]
		public static float vrecpss_f32(float a0, float a1) { }

		[Address(RVA = "0x27DE160", Offset = "0x27DD560", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000992")]
		public static double vrecpxd_f64(double a0) { }

		[Address(RVA = "0x27DE1A0", Offset = "0x27DD5A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000991")]
		public static float vrecpxs_f32(float a0) { }

		[Address(RVA = "0x27DE1E0", Offset = "0x27DD5E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000511")]
		public static v64 vrev16_s8(v64 a0) { }

		[Address(RVA = "0x27DE220", Offset = "0x27DD620", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000513")]
		public static v64 vrev16_u8(v64 a0) { }

		[Address(RVA = "0x27DE230", Offset = "0x27DD630", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000512")]
		public static v128 vrev16q_s8(v128 a0) { }

		[Address(RVA = "0x27DE270", Offset = "0x27DD670", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000514")]
		public static v128 vrev16q_u8(v128 a0) { }

		[Address(RVA = "0x27DE290", Offset = "0x27DD690", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600050B")]
		public static v64 vrev32_s16(v64 a0) { }

		[Address(RVA = "0x27DE2D0", Offset = "0x27DD6D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000509")]
		public static v64 vrev32_s8(v64 a0) { }

		[Address(RVA = "0x27DE310", Offset = "0x27DD710", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x600050F")]
		public static v64 vrev32_u16(v64 a0) { }

		[Address(RVA = "0x27DE320", Offset = "0x27DD720", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x600050D")]
		public static v64 vrev32_u8(v64 a0) { }

		[Address(RVA = "0x27DE330", Offset = "0x27DD730", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600050C")]
		public static v128 vrev32q_s16(v128 a0) { }

		[Address(RVA = "0x27DE370", Offset = "0x27DD770", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600050A")]
		public static v128 vrev32q_s8(v128 a0) { }

		[Address(RVA = "0x27DE3B0", Offset = "0x27DD7B0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000510")]
		public static v128 vrev32q_u16(v128 a0) { }

		[Address(RVA = "0x27DE3D0", Offset = "0x27DD7D0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600050E")]
		public static v128 vrev32q_u8(v128 a0) { }

		[Address(RVA = "0x27DE3F0", Offset = "0x27DD7F0", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000507")]
		public static v64 vrev64_f32(v64 a0) { }

		[Address(RVA = "0x27DE400", Offset = "0x27DD800", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004FD")]
		public static v64 vrev64_s16(v64 a0) { }

		[Address(RVA = "0x27DE440", Offset = "0x27DD840", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004FF")]
		public static v64 vrev64_s32(v64 a0) { }

		[Address(RVA = "0x27DE480", Offset = "0x27DD880", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004FB")]
		public static v64 vrev64_s8(v64 a0) { }

		[Address(RVA = "0x27DE4C0", Offset = "0x27DD8C0", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000503")]
		public static v64 vrev64_u16(v64 a0) { }

		[Address(RVA = "0x27DE3F0", Offset = "0x27DD7F0", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000505")]
		public static v64 vrev64_u32(v64 a0) { }

		[Address(RVA = "0x27DE4D0", Offset = "0x27DD8D0", Length = "0xB")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000501")]
		public static v64 vrev64_u8(v64 a0) { }

		[Address(RVA = "0x27DE4E0", Offset = "0x27DD8E0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000508")]
		public static v128 vrev64q_f32(v128 a0) { }

		[Address(RVA = "0x27DE500", Offset = "0x27DD900", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004FE")]
		public static v128 vrev64q_s16(v128 a0) { }

		[Address(RVA = "0x27DE540", Offset = "0x27DD940", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000500")]
		public static v128 vrev64q_s32(v128 a0) { }

		[Address(RVA = "0x27DE580", Offset = "0x27DD980", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60004FC")]
		public static v128 vrev64q_s8(v128 a0) { }

		[Address(RVA = "0x27DE5C0", Offset = "0x27DD9C0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000504")]
		public static v128 vrev64q_u16(v128 a0) { }

		[Address(RVA = "0x27DE4E0", Offset = "0x27DD8E0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000506")]
		public static v128 vrev64q_u32(v128 a0) { }

		[Address(RVA = "0x27DE5E0", Offset = "0x27DD9E0", Length = "0x1E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000502")]
		public static v128 vrev64q_u8(v128 a0) { }

		[Address(RVA = "0x27DE600", Offset = "0x27DDA00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000121")]
		public static v64 vrhadd_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DE640", Offset = "0x27DDA40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000123")]
		public static v64 vrhadd_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DE680", Offset = "0x27DDA80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600011F")]
		public static v64 vrhadd_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DE6C0", Offset = "0x27DDAC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000127")]
		public static v64 vrhadd_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DE700", Offset = "0x27DDB00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000129")]
		public static v64 vrhadd_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DE740", Offset = "0x27DDB40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000125")]
		public static v64 vrhadd_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DE780", Offset = "0x27DDB80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000122")]
		public static v128 vrhaddq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DE7C0", Offset = "0x27DDBC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000124")]
		public static v128 vrhaddq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DE800", Offset = "0x27DDC00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000120")]
		public static v128 vrhaddq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DE840", Offset = "0x27DDC40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000128")]
		public static v128 vrhaddq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DE880", Offset = "0x27DDC80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600012A")]
		public static v128 vrhaddq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DE8C0", Offset = "0x27DDCC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000126")]
		public static v128 vrhaddq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DE900", Offset = "0x27DDD00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600076D")]
		public static v64 vrnd_f32(v64 a0) { }

		[Address(RVA = "0x27DE940", Offset = "0x27DDD40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600076F")]
		public static v64 vrnd_f64(v64 a0) { }

		[Address(RVA = "0x27DE980", Offset = "0x27DDD80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600077E")]
		public static v64 vrnda_f32(v64 a0) { }

		[Address(RVA = "0x27DE9C0", Offset = "0x27DDDC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000780")]
		public static v64 vrnda_f64(v64 a0) { }

		[Address(RVA = "0x27DEA00", Offset = "0x27DDE00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600077F")]
		public static v128 vrndaq_f32(v128 a0) { }

		[Address(RVA = "0x27DEA40", Offset = "0x27DDE40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000781")]
		public static v128 vrndaq_f64(v128 a0) { }

		[Address(RVA = "0x27DEA80", Offset = "0x27DDE80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000782")]
		public static v64 vrndi_f32(v64 a0) { }

		[Address(RVA = "0x27DEAC0", Offset = "0x27DDEC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000784")]
		public static v64 vrndi_f64(v64 a0) { }

		[Address(RVA = "0x27DEB00", Offset = "0x27DDF00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000783")]
		public static v128 vrndiq_f32(v128 a0) { }

		[Address(RVA = "0x27DEB40", Offset = "0x27DDF40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000785")]
		public static v128 vrndiq_f64(v128 a0) { }

		[Address(RVA = "0x27DEB80", Offset = "0x27DDF80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000776")]
		public static v64 vrndm_f32(v64 a0) { }

		[Address(RVA = "0x27DEBC0", Offset = "0x27DDFC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000778")]
		public static v64 vrndm_f64(v64 a0) { }

		[Address(RVA = "0x27DEC00", Offset = "0x27DE000", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000777")]
		public static v128 vrndmq_f32(v128 a0) { }

		[Address(RVA = "0x27DEC40", Offset = "0x27DE040", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000779")]
		public static v128 vrndmq_f64(v128 a0) { }

		[Address(RVA = "0x27DEC80", Offset = "0x27DE080", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000771")]
		public static v64 vrndn_f32(v64 a0) { }

		[Address(RVA = "0x27DECC0", Offset = "0x27DE0C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000773")]
		public static v64 vrndn_f64(v64 a0) { }

		[Address(RVA = "0x27DED00", Offset = "0x27DE100", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000772")]
		public static v128 vrndnq_f32(v128 a0) { }

		[Address(RVA = "0x27DED40", Offset = "0x27DE140", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000774")]
		public static v128 vrndnq_f64(v128 a0) { }

		[Address(RVA = "0x27DED80", Offset = "0x27DE180", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000775")]
		public static float vrndns_f32(float a0) { }

		[Address(RVA = "0x27DEDC0", Offset = "0x27DE1C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600077A")]
		public static v64 vrndp_f32(v64 a0) { }

		[Address(RVA = "0x27DEE00", Offset = "0x27DE200", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600077C")]
		public static v64 vrndp_f64(v64 a0) { }

		[Address(RVA = "0x27DEE40", Offset = "0x27DE240", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600077B")]
		public static v128 vrndpq_f32(v128 a0) { }

		[Address(RVA = "0x27DEE80", Offset = "0x27DE280", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600077D")]
		public static v128 vrndpq_f64(v128 a0) { }

		[Address(RVA = "0x27DEEC0", Offset = "0x27DE2C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600076E")]
		public static v128 vrndq_f32(v128 a0) { }

		[Address(RVA = "0x27DEF00", Offset = "0x27DE300", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000770")]
		public static v128 vrndq_f64(v128 a0) { }

		[Address(RVA = "0x27DEF40", Offset = "0x27DE340", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000786")]
		public static v64 vrndx_f32(v64 a0) { }

		[Address(RVA = "0x27DEF80", Offset = "0x27DE380", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000788")]
		public static v64 vrndx_f64(v64 a0) { }

		[Address(RVA = "0x27DEFC0", Offset = "0x27DE3C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000787")]
		public static v128 vrndxq_f32(v128 a0) { }

		[Address(RVA = "0x27DF000", Offset = "0x27DE400", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000789")]
		public static v128 vrndxq_f64(v128 a0) { }

		[Address(RVA = "0x27DF040", Offset = "0x27DE440", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000299")]
		public static v64 vrshl_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DF080", Offset = "0x27DE480", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600029B")]
		public static v64 vrshl_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DF0C0", Offset = "0x27DE4C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600029D")]
		public static v64 vrshl_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DF100", Offset = "0x27DE500", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000297")]
		public static v64 vrshl_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DF140", Offset = "0x27DE540", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002A1")]
		public static v64 vrshl_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DF180", Offset = "0x27DE580", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002A3")]
		public static v64 vrshl_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DF1C0", Offset = "0x27DE5C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002A5")]
		public static v64 vrshl_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DF200", Offset = "0x27DE600", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600029F")]
		public static v64 vrshl_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DF240", Offset = "0x27DE640", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006BC")]
		public static long vrshld_s64(long a0, long a1) { }

		[Address(RVA = "0x27DF280", Offset = "0x27DE680", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006BD")]
		public static ulong vrshld_u64(ulong a0, long a1) { }

		[Address(RVA = "0x27DF2C0", Offset = "0x27DE6C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600029A")]
		public static v128 vrshlq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DF300", Offset = "0x27DE700", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600029C")]
		public static v128 vrshlq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DF340", Offset = "0x27DE740", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600029E")]
		public static v128 vrshlq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DF380", Offset = "0x27DE780", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000298")]
		public static v128 vrshlq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DF3C0", Offset = "0x27DE7C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002A2")]
		public static v128 vrshlq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DF400", Offset = "0x27DE800", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002A4")]
		public static v128 vrshlq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DF440", Offset = "0x27DE840", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002A6")]
		public static v128 vrshlq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DF480", Offset = "0x27DE880", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002A0")]
		public static v128 vrshlq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27DF4C0", Offset = "0x27DE8C0", Length = "0x32")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002D9")]
		public static v64 vrshr_n_s16(v64 a0, int a1) { }

		[Address(RVA = "0x27DF500", Offset = "0x27DE900", Length = "0x31")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002DB")]
		public static v64 vrshr_n_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27DF540", Offset = "0x27DE940", Length = "0x34")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002DD")]
		public static v64 vrshr_n_s64(v64 a0, int a1) { }

		[Address(RVA = "0x27DF580", Offset = "0x27DE980", Length = "0x31")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002D7")]
		public static v64 vrshr_n_s8(v64 a0, int a1) { }

		[Address(RVA = "0x27DF5C0", Offset = "0x27DE9C0", Length = "0x32")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002E1")]
		public static v64 vrshr_n_u16(v64 a0, int a1) { }

		[Address(RVA = "0x27DF600", Offset = "0x27DEA00", Length = "0x31")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002E3")]
		public static v64 vrshr_n_u32(v64 a0, int a1) { }

		[Address(RVA = "0x27DF640", Offset = "0x27DEA40", Length = "0x34")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002E5")]
		public static v64 vrshr_n_u64(v64 a0, int a1) { }

		[Address(RVA = "0x27DF680", Offset = "0x27DEA80", Length = "0x31")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002DF")]
		public static v64 vrshr_n_u8(v64 a0, int a1) { }

		[Address(RVA = "0x27DF6C0", Offset = "0x27DEAC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006CA")]
		public static long vrshrd_n_s64(long a0, int a1) { }

		[Address(RVA = "0x27DF700", Offset = "0x27DEB00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006CB")]
		public static ulong vrshrd_n_u64(ulong a0, int a1) { }

		[Address(RVA = "0x27DF740", Offset = "0x27DEB40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006FA")]
		public static v128 vrshrn_high_n_s16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DF780", Offset = "0x27DEB80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006FB")]
		public static v128 vrshrn_high_n_s32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DF7C0", Offset = "0x27DEBC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006FC")]
		public static v128 vrshrn_high_n_s64(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DF800", Offset = "0x27DEC00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006FD")]
		public static v128 vrshrn_high_n_u16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DF840", Offset = "0x27DEC40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006FE")]
		public static v128 vrshrn_high_n_u32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DF880", Offset = "0x27DEC80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006FF")]
		public static v128 vrshrn_high_n_u64(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27DF8C0", Offset = "0x27DECC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000331")]
		public static v64 vrshrn_n_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27DF900", Offset = "0x27DED00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000332")]
		public static v64 vrshrn_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27DF940", Offset = "0x27DED40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000333")]
		public static v64 vrshrn_n_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27DF980", Offset = "0x27DED80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000334")]
		public static v64 vrshrn_n_u16(v128 a0, int a1) { }

		[Address(RVA = "0x27DF9C0", Offset = "0x27DEDC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000335")]
		public static v64 vrshrn_n_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27DFA00", Offset = "0x27DEE00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000336")]
		public static v64 vrshrn_n_u64(v128 a0, int a1) { }

		[Address(RVA = "0x27DFA40", Offset = "0x27DEE40", Length = "0x51")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002DA")]
		public static v128 vrshrq_n_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27DFAA0", Offset = "0x27DEEA0", Length = "0x4F")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002DC")]
		public static v128 vrshrq_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27DFAF0", Offset = "0x27DEEF0", Length = "0x4E")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002DE")]
		public static v128 vrshrq_n_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27DFB40", Offset = "0x27DEF40", Length = "0x50")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002D8")]
		public static v128 vrshrq_n_s8(v128 a0, int a1) { }

		[Address(RVA = "0x27DFBA0", Offset = "0x27DEFA0", Length = "0x51")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002E2")]
		public static v128 vrshrq_n_u16(v128 a0, int a1) { }

		[Address(RVA = "0x27DFC00", Offset = "0x27DF000", Length = "0x4F")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002E4")]
		public static v128 vrshrq_n_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27DFC50", Offset = "0x27DF050", Length = "0x4E")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002E6")]
		public static v128 vrshrq_n_u64(v128 a0, int a1) { }

		[Address(RVA = "0x27DFCA0", Offset = "0x27DF0A0", Length = "0x50")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002E0")]
		public static v128 vrshrq_n_u8(v128 a0, int a1) { }

		[Address(RVA = "0x27DFD00", Offset = "0x27DF100", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000438")]
		public static v64 vrsqrte_f32(v64 a0) { }

		[Address(RVA = "0x27DFD40", Offset = "0x27DF140", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000850")]
		public static v64 vrsqrte_f64(v64 a0) { }

		[Address(RVA = "0x27DFD80", Offset = "0x27DF180", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000436")]
		public static v64 vrsqrte_u32(v64 a0) { }

		[Address(RVA = "0x27DFDC0", Offset = "0x27DF1C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000853")]
		public static double vrsqrted_f64(double a0) { }

		[Address(RVA = "0x27DFE00", Offset = "0x27DF200", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000439")]
		public static v128 vrsqrteq_f32(v128 a0) { }

		[Address(RVA = "0x27DFE40", Offset = "0x27DF240", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000851")]
		public static v128 vrsqrteq_f64(v128 a0) { }

		[Address(RVA = "0x27DFE80", Offset = "0x27DF280", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000437")]
		public static v128 vrsqrteq_u32(v128 a0) { }

		[Address(RVA = "0x27DFEC0", Offset = "0x27DF2C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000852")]
		public static float vrsqrtes_f32(float a0) { }

		[Address(RVA = "0x27DFF00", Offset = "0x27DF300", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600043A")]
		public static v64 vrsqrts_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DFF40", Offset = "0x27DF340", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000854")]
		public static v64 vrsqrts_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27DFF80", Offset = "0x27DF380", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000857")]
		public static double vrsqrtsd_f64(double a0, double a1) { }

		[Address(RVA = "0x27DFFC0", Offset = "0x27DF3C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600043B")]
		public static v128 vrsqrtsq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E0000", Offset = "0x27DF400", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000855")]
		public static v128 vrsqrtsq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E0040", Offset = "0x27DF440", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000856")]
		public static float vrsqrtss_f32(float a0, float a1) { }

		[Address(RVA = "0x27E0080", Offset = "0x27DF480", Length = "0x15")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002F9")]
		public static v64 vrsra_n_s16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E00A0", Offset = "0x27DF4A0", Length = "0x15")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002FB")]
		public static v64 vrsra_n_s32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E00C0", Offset = "0x27DF4C0", Length = "0x15")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002FD")]
		public static v64 vrsra_n_s64(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E00E0", Offset = "0x27DF4E0", Length = "0x15")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002F7")]
		public static v64 vrsra_n_s8(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E0100", Offset = "0x27DF500", Length = "0x15")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000301")]
		public static v64 vrsra_n_u16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E0120", Offset = "0x27DF520", Length = "0x15")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000303")]
		public static v64 vrsra_n_u32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E0140", Offset = "0x27DF540", Length = "0x15")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000305")]
		public static v64 vrsra_n_u64(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E0160", Offset = "0x27DF560", Length = "0x15")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002FF")]
		public static v64 vrsra_n_u8(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E0180", Offset = "0x27DF580", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006CE")]
		public static long vrsrad_n_s64(long a0, long a1, int a2) { }

		[Address(RVA = "0x27E01C0", Offset = "0x27DF5C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006CF")]
		public static ulong vrsrad_n_u64(ulong a0, ulong a1, int a2) { }

		[Address(RVA = "0x27E0200", Offset = "0x27DF600", Length = "0x25")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002FA")]
		public static v128 vrsraq_n_s16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0230", Offset = "0x27DF630", Length = "0x25")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002FC")]
		public static v128 vrsraq_n_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0260", Offset = "0x27DF660", Length = "0x25")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002FE")]
		public static v128 vrsraq_n_s64(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0290", Offset = "0x27DF690", Length = "0x25")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x60002F8")]
		public static v128 vrsraq_n_s8(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E02C0", Offset = "0x27DF6C0", Length = "0x25")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000302")]
		public static v128 vrsraq_n_u16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E02F0", Offset = "0x27DF6F0", Length = "0x25")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000304")]
		public static v128 vrsraq_n_u32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0320", Offset = "0x27DF720", Length = "0x25")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000306")]
		public static v128 vrsraq_n_u64(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0350", Offset = "0x27DF750", Length = "0x25")]
		[BurstTargetCpu(BurstTargetCpu::ARMV7A_NEON32 (8))]
		[DebuggerStepThrough]
		[Token(Token = "0x6000300")]
		public static v128 vrsraq_n_u8(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0380", Offset = "0x27DF780", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005F4")]
		public static v128 vrsubhn_high_s16(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E03C0", Offset = "0x27DF7C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005F5")]
		public static v128 vrsubhn_high_s32(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E0400", Offset = "0x27DF800", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005F6")]
		public static v128 vrsubhn_high_s64(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E0440", Offset = "0x27DF840", Length = "0x33")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005F7")]
		public static v128 vrsubhn_high_u16(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E0480", Offset = "0x27DF880", Length = "0x33")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005F8")]
		public static v128 vrsubhn_high_u32(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E04C0", Offset = "0x27DF8C0", Length = "0x33")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005F9")]
		public static v128 vrsubhn_high_u64(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E0500", Offset = "0x27DF900", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001D5")]
		public static v64 vrsubhn_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E0540", Offset = "0x27DF940", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001D6")]
		public static v64 vrsubhn_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E0580", Offset = "0x27DF980", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001D7")]
		public static v64 vrsubhn_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E05C0", Offset = "0x27DF9C0", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001D8")]
		public static v64 vrsubhn_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E05F0", Offset = "0x27DF9F0", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001D9")]
		public static v64 vrsubhn_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E0620", Offset = "0x27DFA20", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001DA")]
		public static v64 vrsubhn_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E0650", Offset = "0x27DFA50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000533")]
		public static v64 vset_lane_f32(float a0, v64 a1, int a2) { }

		[Address(RVA = "0x27CE0D0", Offset = "0x27CD4D0", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x600098F")]
		public static v64 vset_lane_f64(double a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E0690", Offset = "0x27DFA90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000530")]
		public static v64 vset_lane_s16(short a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E06D0", Offset = "0x27DFAD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000531")]
		public static v64 vset_lane_s32(int a0, v64 a1, int a2) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000532")]
		public static v64 vset_lane_s64(long a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E0710", Offset = "0x27DFB10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600052F")]
		public static v64 vset_lane_s8(sbyte a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E0750", Offset = "0x27DFB50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600052C")]
		public static v64 vset_lane_u16(ushort a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E0790", Offset = "0x27DFB90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600052D")]
		public static v64 vset_lane_u32(uint a0, v64 a1, int a2) { }

		[Address(RVA = "0x27CBE70", Offset = "0x27CB270", Length = "0x27")]
		[DebuggerStepThrough]
		[Token(Token = "0x600052E")]
		public static v64 vset_lane_u64(ulong a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E07D0", Offset = "0x27DFBD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600052B")]
		public static v64 vset_lane_u8(byte a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E0810", Offset = "0x27DFC10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600053C")]
		public static v128 vsetq_lane_f32(float a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0850", Offset = "0x27DFC50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000990")]
		public static v128 vsetq_lane_f64(double a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0890", Offset = "0x27DFC90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000539")]
		public static v128 vsetq_lane_s16(short a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E08D0", Offset = "0x27DFCD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600053A")]
		public static v128 vsetq_lane_s32(int a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0910", Offset = "0x27DFD10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600053B")]
		public static v128 vsetq_lane_s64(long a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0950", Offset = "0x27DFD50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000538")]
		public static v128 vsetq_lane_s8(sbyte a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0990", Offset = "0x27DFD90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000535")]
		public static v128 vsetq_lane_u16(ushort a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E09D0", Offset = "0x27DFDD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000536")]
		public static v128 vsetq_lane_u32(uint a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0A10", Offset = "0x27DFE10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000537")]
		public static v128 vsetq_lane_u64(ulong a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0A50", Offset = "0x27DFE50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000534")]
		public static v128 vsetq_lane_u8(byte a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E0A90", Offset = "0x27DFE90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600099A")]
		public static v128 vsha1cq_u32(v128 a0, uint a1, v128 a2) { }

		[Address(RVA = "0x27E0AD0", Offset = "0x27DFED0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600099D")]
		public static uint vsha1h_u32(uint a0) { }

		[Address(RVA = "0x27E0B10", Offset = "0x27DFF10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600099C")]
		public static v128 vsha1mq_u32(v128 a0, uint a1, v128 a2) { }

		[Address(RVA = "0x27E0B50", Offset = "0x27DFF50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600099B")]
		public static v128 vsha1pq_u32(v128 a0, uint a1, v128 a2) { }

		[Address(RVA = "0x27E0B90", Offset = "0x27DFF90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600099E")]
		public static v128 vsha1su0q_u32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E0BD0", Offset = "0x27DFFD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600099F")]
		public static v128 vsha1su1q_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E0C10", Offset = "0x27E0010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009A1")]
		public static v128 vsha256h2q_u32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E0C50", Offset = "0x27E0050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009A0")]
		public static v128 vsha256hq_u32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E0C90", Offset = "0x27E0090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009A2")]
		public static v128 vsha256su0q_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E0CD0", Offset = "0x27E00D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60009A3")]
		public static v128 vsha256su1q_u32(v128 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E0D10", Offset = "0x27E0110", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002C9")]
		public static v64 vshl_n_s16(v64 a0, int a1) { }

		[Address(RVA = "0x27E0D50", Offset = "0x27E0150", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002CB")]
		public static v64 vshl_n_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27E0D90", Offset = "0x27E0190", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002CD")]
		public static v64 vshl_n_s64(v64 a0, int a1) { }

		[Address(RVA = "0x27E0DD0", Offset = "0x27E01D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002C7")]
		public static v64 vshl_n_s8(v64 a0, int a1) { }

		[Address(RVA = "0x27E0E10", Offset = "0x27E0210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002D1")]
		public static v64 vshl_n_u16(v64 a0, int a1) { }

		[Address(RVA = "0x27E0E50", Offset = "0x27E0250", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002D3")]
		public static v64 vshl_n_u32(v64 a0, int a1) { }

		[Address(RVA = "0x27E0E90", Offset = "0x27E0290", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002D5")]
		public static v64 vshl_n_u64(v64 a0, int a1) { }

		[Address(RVA = "0x27E0ED0", Offset = "0x27E02D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002CF")]
		public static v64 vshl_n_u8(v64 a0, int a1) { }

		[Address(RVA = "0x27E0F10", Offset = "0x27E0310", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000279")]
		public static v64 vshl_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E0F50", Offset = "0x27E0350", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600027B")]
		public static v64 vshl_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E0F90", Offset = "0x27E0390", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600027D")]
		public static v64 vshl_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E0FD0", Offset = "0x27E03D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000277")]
		public static v64 vshl_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E1010", Offset = "0x27E0410", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000281")]
		public static v64 vshl_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E1050", Offset = "0x27E0450", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000283")]
		public static v64 vshl_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E1090", Offset = "0x27E0490", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000285")]
		public static v64 vshl_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E10D0", Offset = "0x27E04D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600027F")]
		public static v64 vshl_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E1110", Offset = "0x27E0510", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006C8")]
		public static long vshld_n_s64(long a0, int a1) { }

		[Address(RVA = "0x27E1110", Offset = "0x27E0510", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006C9")]
		public static ulong vshld_n_u64(ulong a0, int a1) { }

		[Address(RVA = "0x27E1120", Offset = "0x27E0520", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006B2")]
		public static long vshld_s64(long a0, long a1) { }

		[Address(RVA = "0x27E1160", Offset = "0x27E0560", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006B3")]
		public static ulong vshld_u64(ulong a0, long a1) { }

		[Address(RVA = "0x27E11A0", Offset = "0x27E05A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600070D")]
		public static v128 vshll_high_n_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27E11E0", Offset = "0x27E05E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600070E")]
		public static v128 vshll_high_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27E1220", Offset = "0x27E0620", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600070C")]
		public static v128 vshll_high_n_s8(v128 a0, int a1) { }

		[Address(RVA = "0x27E1260", Offset = "0x27E0660", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000710")]
		public static v128 vshll_high_n_u16(v128 a0, int a1) { }

		[Address(RVA = "0x27E12A0", Offset = "0x27E06A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000711")]
		public static v128 vshll_high_n_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27E12E0", Offset = "0x27E06E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600070F")]
		public static v128 vshll_high_n_u8(v128 a0, int a1) { }

		[Address(RVA = "0x27E1320", Offset = "0x27E0720", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600033E")]
		public static v128 vshll_n_s16(v64 a0, int a1) { }

		[Address(RVA = "0x27E1360", Offset = "0x27E0760", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600033F")]
		public static v128 vshll_n_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27E13A0", Offset = "0x27E07A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600033D")]
		public static v128 vshll_n_s8(v64 a0, int a1) { }

		[Address(RVA = "0x27E13E0", Offset = "0x27E07E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000341")]
		public static v128 vshll_n_u16(v64 a0, int a1) { }

		[Address(RVA = "0x27E1420", Offset = "0x27E0820", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000342")]
		public static v128 vshll_n_u32(v64 a0, int a1) { }

		[Address(RVA = "0x27E1460", Offset = "0x27E0860", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000340")]
		public static v128 vshll_n_u8(v64 a0, int a1) { }

		[Address(RVA = "0x27E14A0", Offset = "0x27E08A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002CA")]
		public static v128 vshlq_n_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27E14E0", Offset = "0x27E08E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002CC")]
		public static v128 vshlq_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27E1520", Offset = "0x27E0920", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002CE")]
		public static v128 vshlq_n_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27E1560", Offset = "0x27E0960", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002C8")]
		public static v128 vshlq_n_s8(v128 a0, int a1) { }

		[Address(RVA = "0x27E15A0", Offset = "0x27E09A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002D2")]
		public static v128 vshlq_n_u16(v128 a0, int a1) { }

		[Address(RVA = "0x27E15E0", Offset = "0x27E09E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002D4")]
		public static v128 vshlq_n_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27E1620", Offset = "0x27E0A20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002D6")]
		public static v128 vshlq_n_u64(v128 a0, int a1) { }

		[Address(RVA = "0x27E1660", Offset = "0x27E0A60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002D0")]
		public static v128 vshlq_n_u8(v128 a0, int a1) { }

		[Address(RVA = "0x27E16A0", Offset = "0x27E0AA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600027A")]
		public static v128 vshlq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E16E0", Offset = "0x27E0AE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600027C")]
		public static v128 vshlq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E1720", Offset = "0x27E0B20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600027E")]
		public static v128 vshlq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E1760", Offset = "0x27E0B60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000278")]
		public static v128 vshlq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E17A0", Offset = "0x27E0BA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000282")]
		public static v128 vshlq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E17E0", Offset = "0x27E0BE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000284")]
		public static v128 vshlq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E1820", Offset = "0x27E0C20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000286")]
		public static v128 vshlq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E1860", Offset = "0x27E0C60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000280")]
		public static v128 vshlq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E18A0", Offset = "0x27E0CA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002B9")]
		public static v64 vshr_n_s16(v64 a0, int a1) { }

		[Address(RVA = "0x27E18E0", Offset = "0x27E0CE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002BB")]
		public static v64 vshr_n_s32(v64 a0, int a1) { }

		[Address(RVA = "0x27E1920", Offset = "0x27E0D20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002BD")]
		public static v64 vshr_n_s64(v64 a0, int a1) { }

		[Address(RVA = "0x27E1960", Offset = "0x27E0D60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002B7")]
		public static v64 vshr_n_s8(v64 a0, int a1) { }

		[Address(RVA = "0x27E19A0", Offset = "0x27E0DA0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002C1")]
		public static v64 vshr_n_u16(v64 a0, int a1) { }

		[Address(RVA = "0x27E19E0", Offset = "0x27E0DE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002C3")]
		public static v64 vshr_n_u32(v64 a0, int a1) { }

		[Address(RVA = "0x27E1A20", Offset = "0x27E0E20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002C5")]
		public static v64 vshr_n_u64(v64 a0, int a1) { }

		[Address(RVA = "0x27E1A60", Offset = "0x27E0E60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002BF")]
		public static v64 vshr_n_u8(v64 a0, int a1) { }

		[Address(RVA = "0x27E1AA0", Offset = "0x27E0EA0", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006C6")]
		public static long vshrd_n_s64(long a0, int a1) { }

		[Address(RVA = "0x27E1AB0", Offset = "0x27E0EB0", Length = "0xD")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006C7")]
		public static ulong vshrd_n_u64(ulong a0, int a1) { }

		[Address(RVA = "0x27E1AC0", Offset = "0x27E0EC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006DC")]
		public static v128 vshrn_high_n_s16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E1B00", Offset = "0x27E0F00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006DD")]
		public static v128 vshrn_high_n_s32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E1B40", Offset = "0x27E0F40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006DE")]
		public static v128 vshrn_high_n_s64(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E1B80", Offset = "0x27E0F80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006DF")]
		public static v128 vshrn_high_n_u16(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E1BC0", Offset = "0x27E0FC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006E0")]
		public static v128 vshrn_high_n_u32(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E1C00", Offset = "0x27E1000", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006E1")]
		public static v128 vshrn_high_n_u64(v64 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E1C40", Offset = "0x27E1040", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600031F")]
		public static v64 vshrn_n_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27E1C80", Offset = "0x27E1080", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000320")]
		public static v64 vshrn_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27E1CC0", Offset = "0x27E10C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000321")]
		public static v64 vshrn_n_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27E1D00", Offset = "0x27E1100", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000322")]
		public static v64 vshrn_n_u16(v128 a0, int a1) { }

		[Address(RVA = "0x27E1D40", Offset = "0x27E1140", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000323")]
		public static v64 vshrn_n_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27E1D80", Offset = "0x27E1180", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000324")]
		public static v64 vshrn_n_u64(v128 a0, int a1) { }

		[Address(RVA = "0x27E1DC0", Offset = "0x27E11C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002BA")]
		public static v128 vshrq_n_s16(v128 a0, int a1) { }

		[Address(RVA = "0x27E1E00", Offset = "0x27E1200", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002BC")]
		public static v128 vshrq_n_s32(v128 a0, int a1) { }

		[Address(RVA = "0x27E1E40", Offset = "0x27E1240", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002BE")]
		public static v128 vshrq_n_s64(v128 a0, int a1) { }

		[Address(RVA = "0x27E1E80", Offset = "0x27E1280", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002B8")]
		public static v128 vshrq_n_s8(v128 a0, int a1) { }

		[Address(RVA = "0x27E1EC0", Offset = "0x27E12C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002C2")]
		public static v128 vshrq_n_u16(v128 a0, int a1) { }

		[Address(RVA = "0x27E1F00", Offset = "0x27E1300", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002C4")]
		public static v128 vshrq_n_u32(v128 a0, int a1) { }

		[Address(RVA = "0x27E1F40", Offset = "0x27E1340", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002C6")]
		public static v128 vshrq_n_u64(v128 a0, int a1) { }

		[Address(RVA = "0x27E1F80", Offset = "0x27E1380", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002C0")]
		public static v128 vshrq_n_u8(v128 a0, int a1) { }

		[Address(RVA = "0x27E1FC0", Offset = "0x27E13C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000355")]
		public static v64 vsli_n_s16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2000", Offset = "0x27E1400", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000357")]
		public static v64 vsli_n_s32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2040", Offset = "0x27E1440", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000359")]
		public static v64 vsli_n_s64(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2080", Offset = "0x27E1480", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000353")]
		public static v64 vsli_n_s8(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E20C0", Offset = "0x27E14C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600035D")]
		public static v64 vsli_n_u16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2100", Offset = "0x27E1500", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600035F")]
		public static v64 vsli_n_u32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2140", Offset = "0x27E1540", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000361")]
		public static v64 vsli_n_u64(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2180", Offset = "0x27E1580", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600035B")]
		public static v64 vsli_n_u8(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E21C0", Offset = "0x27E15C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000714")]
		public static long vslid_n_s64(long a0, long a1, int a2) { }

		[Address(RVA = "0x27E2200", Offset = "0x27E1600", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000715")]
		public static ulong vslid_n_u64(ulong a0, ulong a1, int a2) { }

		[Address(RVA = "0x27E2240", Offset = "0x27E1640", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000356")]
		public static v128 vsliq_n_s16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2280", Offset = "0x27E1680", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000358")]
		public static v128 vsliq_n_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E22C0", Offset = "0x27E16C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600035A")]
		public static v128 vsliq_n_s64(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2300", Offset = "0x27E1700", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000354")]
		public static v128 vsliq_n_s8(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2340", Offset = "0x27E1740", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600035E")]
		public static v128 vsliq_n_u16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2380", Offset = "0x27E1780", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000360")]
		public static v128 vsliq_n_u32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E23C0", Offset = "0x27E17C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000362")]
		public static v128 vsliq_n_u64(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2400", Offset = "0x27E1800", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600035C")]
		public static v128 vsliq_n_u8(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2440", Offset = "0x27E1840", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000566")]
		public static v64 vsqadd_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E2480", Offset = "0x27E1880", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000568")]
		public static v64 vsqadd_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E24C0", Offset = "0x27E18C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600056A")]
		public static v64 vsqadd_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E2500", Offset = "0x27E1900", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000564")]
		public static v64 vsqadd_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E2540", Offset = "0x27E1940", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600056C")]
		public static byte vsqaddb_u8(byte a0, sbyte a1) { }

		[Address(RVA = "0x27E2580", Offset = "0x27E1980", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600056F")]
		public static ulong vsqaddd_u64(ulong a0, long a1) { }

		[Address(RVA = "0x27E25C0", Offset = "0x27E19C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600056D")]
		public static ushort vsqaddh_u16(ushort a0, short a1) { }

		[Address(RVA = "0x27E2600", Offset = "0x27E1A00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000567")]
		public static v128 vsqaddq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E2640", Offset = "0x27E1A40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000569")]
		public static v128 vsqaddq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E2680", Offset = "0x27E1A80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600056B")]
		public static v128 vsqaddq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E26C0", Offset = "0x27E1AC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000565")]
		public static v128 vsqaddq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E2700", Offset = "0x27E1B00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600056E")]
		public static uint vsqadds_u32(uint a0, int a1) { }

		[Address(RVA = "0x27E2740", Offset = "0x27E1B40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600084C")]
		public static v64 vsqrt_f32(v64 a0) { }

		[Address(RVA = "0x27E2780", Offset = "0x27E1B80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600084E")]
		public static v64 vsqrt_f64(v64 a0) { }

		[Address(RVA = "0x27E27C0", Offset = "0x27E1BC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600084D")]
		public static v128 vsqrtq_f32(v128 a0) { }

		[Address(RVA = "0x27E2800", Offset = "0x27E1C00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600084F")]
		public static v128 vsqrtq_f64(v128 a0) { }

		[Address(RVA = "0x27E2840", Offset = "0x27E1C40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002E9")]
		public static v64 vsra_n_s16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2880", Offset = "0x27E1C80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002EB")]
		public static v64 vsra_n_s32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E28C0", Offset = "0x27E1CC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002ED")]
		public static v64 vsra_n_s64(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2900", Offset = "0x27E1D00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002E7")]
		public static v64 vsra_n_s8(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2940", Offset = "0x27E1D40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002F1")]
		public static v64 vsra_n_u16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2980", Offset = "0x27E1D80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002F3")]
		public static v64 vsra_n_u32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E29C0", Offset = "0x27E1DC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002F5")]
		public static v64 vsra_n_u64(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2A00", Offset = "0x27E1E00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002EF")]
		public static v64 vsra_n_u8(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2A40", Offset = "0x27E1E40", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006CC")]
		public static long vsrad_n_s64(long a0, long a1, int a2) { }

		[Address(RVA = "0x27E2A60", Offset = "0x27E1E60", Length = "0x12")]
		[DebuggerStepThrough]
		[Token(Token = "0x60006CD")]
		public static ulong vsrad_n_u64(ulong a0, ulong a1, int a2) { }

		[Address(RVA = "0x27E2A80", Offset = "0x27E1E80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002EA")]
		public static v128 vsraq_n_s16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2AC0", Offset = "0x27E1EC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002EC")]
		public static v128 vsraq_n_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2B00", Offset = "0x27E1F00", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002EE")]
		public static v128 vsraq_n_s64(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2B40", Offset = "0x27E1F40", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002E8")]
		public static v128 vsraq_n_s8(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2B80", Offset = "0x27E1F80", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002F2")]
		public static v128 vsraq_n_u16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2BC0", Offset = "0x27E1FC0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002F4")]
		public static v128 vsraq_n_u32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2C00", Offset = "0x27E2000", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002F6")]
		public static v128 vsraq_n_u64(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2C40", Offset = "0x27E2040", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60002F0")]
		public static v128 vsraq_n_u8(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2C80", Offset = "0x27E2080", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000345")]
		public static v64 vsri_n_s16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2CC0", Offset = "0x27E20C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000347")]
		public static v64 vsri_n_s32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2D00", Offset = "0x27E2100", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000349")]
		public static v64 vsri_n_s64(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2D40", Offset = "0x27E2140", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000343")]
		public static v64 vsri_n_s8(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2D80", Offset = "0x27E2180", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600034D")]
		public static v64 vsri_n_u16(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2DC0", Offset = "0x27E21C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600034F")]
		public static v64 vsri_n_u32(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2E00", Offset = "0x27E2200", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000351")]
		public static v64 vsri_n_u64(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2E40", Offset = "0x27E2240", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600034B")]
		public static v64 vsri_n_u8(v64 a0, v64 a1, int a2) { }

		[Address(RVA = "0x27E2E80", Offset = "0x27E2280", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000712")]
		public static long vsrid_n_s64(long a0, long a1, int a2) { }

		[Address(RVA = "0x27E2EC0", Offset = "0x27E22C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000713")]
		public static ulong vsrid_n_u64(ulong a0, ulong a1, int a2) { }

		[Address(RVA = "0x27E2F00", Offset = "0x27E2300", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000346")]
		public static v128 vsriq_n_s16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2F40", Offset = "0x27E2340", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000348")]
		public static v128 vsriq_n_s32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2F80", Offset = "0x27E2380", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600034A")]
		public static v128 vsriq_n_s64(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E2FC0", Offset = "0x27E23C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000344")]
		public static v128 vsriq_n_s8(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E3000", Offset = "0x27E2400", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600034E")]
		public static v128 vsriq_n_u16(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E3040", Offset = "0x27E2440", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000350")]
		public static v128 vsriq_n_u32(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E3080", Offset = "0x27E2480", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000352")]
		public static v128 vsriq_n_u64(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x27E30C0", Offset = "0x27E24C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600034C")]
		public static v128 vsriq_n_u8(v128 a0, v128 a1, int a2) { }

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A56")]
		public static void vst1_f32(Single* a0, v64 a1) { }

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A58")]
		public static void vst1_f64(Double* a0, v64 a1) { }

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A48")]
		public static void vst1_s16(Int16* a0, v64 a1) { }

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A4A")]
		public static void vst1_s32(Int32* a0, v64 a1) { }

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A4C")]
		public static void vst1_s64(Int64* a0, v64 a1) { }

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A46")]
		public static void vst1_s8(SByte* a0, v64 a1) { }

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A50")]
		public static void vst1_u16(UInt16* a0, v64 a1) { }

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A52")]
		public static void vst1_u32(UInt32* a0, v64 a1) { }

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A54")]
		public static void vst1_u64(UInt64* a0, v64 a1) { }

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A4E")]
		public static void vst1_u8(Byte* a0, v64 a1) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A57")]
		public static void vst1q_f32(Single* a0, v128 a1) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A59")]
		public static void vst1q_f64(Double* a0, v128 a1) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A49")]
		public static void vst1q_s16(Int16* a0, v128 a1) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A4B")]
		public static void vst1q_s32(Int32* a0, v128 a1) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A4D")]
		public static void vst1q_s64(Int64* a0, v128 a1) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A47")]
		public static void vst1q_s8(SByte* a0, v128 a1) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A51")]
		public static void vst1q_u16(UInt16* a0, v128 a1) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A53")]
		public static void vst1q_u32(UInt32* a0, v128 a1) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A55")]
		public static void vst1q_u64(UInt64* a0, v128 a1) { }

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000A4F")]
		public static void vst1q_u8(Byte* a0, v128 a1) { }

		[Address(RVA = "0x27E3100", Offset = "0x27E2500", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001A5")]
		public static v64 vsub_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3140", Offset = "0x27E2540", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005D6")]
		public static v64 vsub_f64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3180", Offset = "0x27E2580", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000197")]
		public static v64 vsub_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E31C0", Offset = "0x27E25C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000199")]
		public static v64 vsub_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3200", Offset = "0x27E2600", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600019B")]
		public static v64 vsub_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3240", Offset = "0x27E2640", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000195")]
		public static v64 vsub_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3280", Offset = "0x27E2680", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600019F")]
		public static v64 vsub_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3290", Offset = "0x27E2690", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001A1")]
		public static v64 vsub_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E32A0", Offset = "0x27E26A0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001A3")]
		public static v64 vsub_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E32B0", Offset = "0x27E26B0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600019D")]
		public static v64 vsub_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E32C0", Offset = "0x27E26C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005D8")]
		public static long vsubd_s64(long a0, long a1) { }

		[Address(RVA = "0x27E3300", Offset = "0x27E2700", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005D9")]
		public static ulong vsubd_u64(ulong a0, ulong a1) { }

		[Address(RVA = "0x27E3340", Offset = "0x27E2740", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005EE")]
		public static v128 vsubhn_high_s16(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E3380", Offset = "0x27E2780", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005EF")]
		public static v128 vsubhn_high_s32(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E33C0", Offset = "0x27E27C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005F0")]
		public static v128 vsubhn_high_s64(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E3400", Offset = "0x27E2800", Length = "0x33")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005F1")]
		public static v128 vsubhn_high_u16(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E3440", Offset = "0x27E2840", Length = "0x33")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005F2")]
		public static v128 vsubhn_high_u32(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E3480", Offset = "0x27E2880", Length = "0x33")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005F3")]
		public static v128 vsubhn_high_u64(v64 a0, v128 a1, v128 a2) { }

		[Address(RVA = "0x27E34C0", Offset = "0x27E28C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001CF")]
		public static v64 vsubhn_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3500", Offset = "0x27E2900", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001D0")]
		public static v64 vsubhn_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3540", Offset = "0x27E2940", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001D1")]
		public static v64 vsubhn_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3580", Offset = "0x27E2980", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001D2")]
		public static v64 vsubhn_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E35B0", Offset = "0x27E29B0", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001D3")]
		public static v64 vsubhn_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E35E0", Offset = "0x27E29E0", Length = "0x26")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001D4")]
		public static v64 vsubhn_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3610", Offset = "0x27E2A10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005DB")]
		public static v128 vsubl_high_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3650", Offset = "0x27E2A50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005DC")]
		public static v128 vsubl_high_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3690", Offset = "0x27E2A90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005DA")]
		public static v128 vsubl_high_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E36D0", Offset = "0x27E2AD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005DE")]
		public static v128 vsubl_high_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3710", Offset = "0x27E2B10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005DF")]
		public static v128 vsubl_high_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3750", Offset = "0x27E2B50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005DD")]
		public static v128 vsubl_high_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3790", Offset = "0x27E2B90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001A8")]
		public static v128 vsubl_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E37D0", Offset = "0x27E2BD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001A9")]
		public static v128 vsubl_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3810", Offset = "0x27E2C10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001A7")]
		public static v128 vsubl_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3850", Offset = "0x27E2C50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001AB")]
		public static v128 vsubl_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3890", Offset = "0x27E2C90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001AC")]
		public static v128 vsubl_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E38D0", Offset = "0x27E2CD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001AA")]
		public static v128 vsubl_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3910", Offset = "0x27E2D10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001A6")]
		public static v128 vsubq_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3950", Offset = "0x27E2D50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005D7")]
		public static v128 vsubq_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3990", Offset = "0x27E2D90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000198")]
		public static v128 vsubq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E39D0", Offset = "0x27E2DD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600019A")]
		public static v128 vsubq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3A10", Offset = "0x27E2E10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600019C")]
		public static v128 vsubq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3A50", Offset = "0x27E2E50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000196")]
		public static v128 vsubq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3A90", Offset = "0x27E2E90", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001A0")]
		public static v128 vsubq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3AC0", Offset = "0x27E2EC0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001A2")]
		public static v128 vsubq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3AF0", Offset = "0x27E2EF0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001A4")]
		public static v128 vsubq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3B20", Offset = "0x27E2F20", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600019E")]
		public static v128 vsubq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3B50", Offset = "0x27E2F50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005E1")]
		public static v128 vsubw_high_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3B90", Offset = "0x27E2F90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005E2")]
		public static v128 vsubw_high_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3BD0", Offset = "0x27E2FD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005E0")]
		public static v128 vsubw_high_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3C10", Offset = "0x27E3010", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005E4")]
		public static v128 vsubw_high_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3C50", Offset = "0x27E3050", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005E5")]
		public static v128 vsubw_high_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3C90", Offset = "0x27E3090", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60005E3")]
		public static v128 vsubw_high_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3CD0", Offset = "0x27E30D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001AE")]
		public static v128 vsubw_s16(v128 a0, v64 a1) { }

		[Address(RVA = "0x27E3D10", Offset = "0x27E3110", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001AF")]
		public static v128 vsubw_s32(v128 a0, v64 a1) { }

		[Address(RVA = "0x27E3D50", Offset = "0x27E3150", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001AD")]
		public static v128 vsubw_s8(v128 a0, v64 a1) { }

		[Address(RVA = "0x27E3D90", Offset = "0x27E3190", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001B1")]
		public static v128 vsubw_u16(v128 a0, v64 a1) { }

		[Address(RVA = "0x27E3DD0", Offset = "0x27E31D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001B2")]
		public static v128 vsubw_u32(v128 a0, v64 a1) { }

		[Address(RVA = "0x27E3E10", Offset = "0x27E3210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x60001B0")]
		public static v128 vsubw_u8(v128 a0, v64 a1) { }

		[Address(RVA = "0x27E3E50", Offset = "0x27E3250", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000515")]
		public static v64 vtbl1_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3E90", Offset = "0x27E3290", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000516")]
		public static v64 vtbl1_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3EA0", Offset = "0x27E32A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000517")]
		public static v64 vtbx1_s8(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27E3EE0", Offset = "0x27E32E0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000518")]
		public static v64 vtbx1_u8(v64 a0, v64 a1, v64 a2) { }

		[Address(RVA = "0x27E3EF0", Offset = "0x27E32F0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000971")]
		public static v64 vtrn1_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3F00", Offset = "0x27E3300", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000965")]
		public static v64 vtrn1_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3F40", Offset = "0x27E3340", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000967")]
		public static v64 vtrn1_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3F80", Offset = "0x27E3380", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000963")]
		public static v64 vtrn1_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3FC0", Offset = "0x27E33C0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600096C")]
		public static v64 vtrn1_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3EF0", Offset = "0x27E32F0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600096E")]
		public static v64 vtrn1_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3FD0", Offset = "0x27E33D0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600096A")]
		public static v64 vtrn1_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E3FE0", Offset = "0x27E33E0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000972")]
		public static v128 vtrn1q_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4010", Offset = "0x27E3410", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000973")]
		public static v128 vtrn1q_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4040", Offset = "0x27E3440", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000966")]
		public static v128 vtrn1q_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4080", Offset = "0x27E3480", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000968")]
		public static v128 vtrn1q_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E40C0", Offset = "0x27E34C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000969")]
		public static v128 vtrn1q_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4100", Offset = "0x27E3500", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000964")]
		public static v128 vtrn1q_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4140", Offset = "0x27E3540", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600096D")]
		public static v128 vtrn1q_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E3FE0", Offset = "0x27E33E0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600096F")]
		public static v128 vtrn1q_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4010", Offset = "0x27E3410", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000970")]
		public static v128 vtrn1q_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4170", Offset = "0x27E3570", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600096B")]
		public static v128 vtrn1q_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E41A0", Offset = "0x27E35A0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000982")]
		public static v64 vtrn2_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E41B0", Offset = "0x27E35B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000976")]
		public static v64 vtrn2_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E41F0", Offset = "0x27E35F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000978")]
		public static v64 vtrn2_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4230", Offset = "0x27E3630", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000974")]
		public static v64 vtrn2_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4270", Offset = "0x27E3670", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600097D")]
		public static v64 vtrn2_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E41A0", Offset = "0x27E35A0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600097F")]
		public static v64 vtrn2_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4280", Offset = "0x27E3680", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600097B")]
		public static v64 vtrn2_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4290", Offset = "0x27E3690", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000983")]
		public static v128 vtrn2q_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E42C0", Offset = "0x27E36C0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000984")]
		public static v128 vtrn2q_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E42F0", Offset = "0x27E36F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000977")]
		public static v128 vtrn2q_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4330", Offset = "0x27E3730", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000979")]
		public static v128 vtrn2q_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4370", Offset = "0x27E3770", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600097A")]
		public static v128 vtrn2q_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E43B0", Offset = "0x27E37B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000975")]
		public static v128 vtrn2q_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E43F0", Offset = "0x27E37F0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600097E")]
		public static v128 vtrn2q_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4290", Offset = "0x27E3690", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000980")]
		public static v128 vtrn2q_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E42C0", Offset = "0x27E36C0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000981")]
		public static v128 vtrn2q_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4420", Offset = "0x27E3820", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600097C")]
		public static v128 vtrn2q_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4450", Offset = "0x27E3850", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600022B")]
		public static v64 vtst_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4490", Offset = "0x27E3890", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600022D")]
		public static v64 vtst_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E44D0", Offset = "0x27E38D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000690")]
		public static v64 vtst_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4510", Offset = "0x27E3910", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000229")]
		public static v64 vtst_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4550", Offset = "0x27E3950", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000231")]
		public static v64 vtst_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4560", Offset = "0x27E3960", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000233")]
		public static v64 vtst_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4570", Offset = "0x27E3970", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000692")]
		public static v64 vtst_u64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4580", Offset = "0x27E3980", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600022F")]
		public static v64 vtst_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4590", Offset = "0x27E3990", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000694")]
		public static ulong vtstd_s64(long a0, long a1) { }

		[Address(RVA = "0x27E45D0", Offset = "0x27E39D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000695")]
		public static ulong vtstd_u64(ulong a0, ulong a1) { }

		[Address(RVA = "0x27E4610", Offset = "0x27E3A10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600022C")]
		public static v128 vtstq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4650", Offset = "0x27E3A50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600022E")]
		public static v128 vtstq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4690", Offset = "0x27E3A90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000691")]
		public static v128 vtstq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E46D0", Offset = "0x27E3AD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600022A")]
		public static v128 vtstq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4710", Offset = "0x27E3B10", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000232")]
		public static v128 vtstq_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4740", Offset = "0x27E3B40", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000234")]
		public static v128 vtstq_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4770", Offset = "0x27E3B70", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000693")]
		public static v128 vtstq_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E47A0", Offset = "0x27E3BA0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000230")]
		public static v128 vtstq_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E47D0", Offset = "0x27E3BD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600055A")]
		public static v64 vuqadd_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4810", Offset = "0x27E3C10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600055C")]
		public static v64 vuqadd_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4850", Offset = "0x27E3C50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600055E")]
		public static v64 vuqadd_s64(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4890", Offset = "0x27E3C90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000558")]
		public static v64 vuqadd_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E48D0", Offset = "0x27E3CD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000560")]
		public static sbyte vuqaddb_s8(sbyte a0, byte a1) { }

		[Address(RVA = "0x27E4910", Offset = "0x27E3D10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000563")]
		public static long vuqaddd_s64(long a0, ulong a1) { }

		[Address(RVA = "0x27E4950", Offset = "0x27E3D50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000561")]
		public static short vuqaddh_s16(short a0, ushort a1) { }

		[Address(RVA = "0x27E4990", Offset = "0x27E3D90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600055B")]
		public static v128 vuqaddq_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E49D0", Offset = "0x27E3DD0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600055D")]
		public static v128 vuqaddq_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4A10", Offset = "0x27E3E10", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600055F")]
		public static v128 vuqaddq_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4A50", Offset = "0x27E3E50", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000559")]
		public static v128 vuqaddq_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4A90", Offset = "0x27E3E90", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000562")]
		public static int vuqadds_s32(int a0, uint a1) { }

		[Address(RVA = "0x27E4AD0", Offset = "0x27E3ED0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600094F")]
		public static v64 vuzp1_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4AE0", Offset = "0x27E3EE0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000943")]
		public static v64 vuzp1_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4B20", Offset = "0x27E3F20", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000945")]
		public static v64 vuzp1_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4B60", Offset = "0x27E3F60", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000941")]
		public static v64 vuzp1_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4BA0", Offset = "0x27E3FA0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600094A")]
		public static v64 vuzp1_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4AD0", Offset = "0x27E3ED0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600094C")]
		public static v64 vuzp1_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4BB0", Offset = "0x27E3FB0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000948")]
		public static v64 vuzp1_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4BC0", Offset = "0x27E3FC0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000950")]
		public static v128 vuzp1q_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4BF0", Offset = "0x27E3FF0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000951")]
		public static v128 vuzp1q_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4C20", Offset = "0x27E4020", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000944")]
		public static v128 vuzp1q_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4C60", Offset = "0x27E4060", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000946")]
		public static v128 vuzp1q_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4CA0", Offset = "0x27E40A0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000947")]
		public static v128 vuzp1q_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4CE0", Offset = "0x27E40E0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000942")]
		public static v128 vuzp1q_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4D20", Offset = "0x27E4120", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600094B")]
		public static v128 vuzp1q_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4BC0", Offset = "0x27E3FC0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600094D")]
		public static v128 vuzp1q_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4BF0", Offset = "0x27E3FF0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600094E")]
		public static v128 vuzp1q_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4D50", Offset = "0x27E4150", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000949")]
		public static v128 vuzp1q_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4D80", Offset = "0x27E4180", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000960")]
		public static v64 vuzp2_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4D90", Offset = "0x27E4190", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000954")]
		public static v64 vuzp2_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4DD0", Offset = "0x27E41D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000956")]
		public static v64 vuzp2_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4E10", Offset = "0x27E4210", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000952")]
		public static v64 vuzp2_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4E50", Offset = "0x27E4250", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600095B")]
		public static v64 vuzp2_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4D80", Offset = "0x27E4180", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600095D")]
		public static v64 vuzp2_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4E60", Offset = "0x27E4260", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000959")]
		public static v64 vuzp2_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E4E70", Offset = "0x27E4270", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000961")]
		public static v128 vuzp2q_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4EA0", Offset = "0x27E42A0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000962")]
		public static v128 vuzp2q_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4ED0", Offset = "0x27E42D0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000955")]
		public static v128 vuzp2q_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4F10", Offset = "0x27E4310", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000957")]
		public static v128 vuzp2q_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4F50", Offset = "0x27E4350", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000958")]
		public static v128 vuzp2q_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4F90", Offset = "0x27E4390", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000953")]
		public static v128 vuzp2q_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4FD0", Offset = "0x27E43D0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600095C")]
		public static v128 vuzp2q_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4E70", Offset = "0x27E4270", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600095E")]
		public static v128 vuzp2q_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E4EA0", Offset = "0x27E42A0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600095F")]
		public static v128 vuzp2q_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5000", Offset = "0x27E4400", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600095A")]
		public static v128 vuzp2q_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5030", Offset = "0x27E4430", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600092D")]
		public static v64 vzip1_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E5040", Offset = "0x27E4440", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000921")]
		public static v64 vzip1_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E5080", Offset = "0x27E4480", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000923")]
		public static v64 vzip1_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E50C0", Offset = "0x27E44C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x600091F")]
		public static v64 vzip1_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E5100", Offset = "0x27E4500", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000928")]
		public static v64 vzip1_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E5030", Offset = "0x27E4430", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600092A")]
		public static v64 vzip1_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E5110", Offset = "0x27E4510", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000926")]
		public static v64 vzip1_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E5120", Offset = "0x27E4520", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600092E")]
		public static v128 vzip1q_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5150", Offset = "0x27E4550", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600092F")]
		public static v128 vzip1q_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5180", Offset = "0x27E4580", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000922")]
		public static v128 vzip1q_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E51C0", Offset = "0x27E45C0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000924")]
		public static v128 vzip1q_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5200", Offset = "0x27E4600", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000925")]
		public static v128 vzip1q_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5240", Offset = "0x27E4640", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000920")]
		public static v128 vzip1q_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5280", Offset = "0x27E4680", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000929")]
		public static v128 vzip1q_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5120", Offset = "0x27E4520", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600092B")]
		public static v128 vzip1q_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5150", Offset = "0x27E4550", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600092C")]
		public static v128 vzip1q_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E52B0", Offset = "0x27E46B0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000927")]
		public static v128 vzip1q_u8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E52E0", Offset = "0x27E46E0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600093E")]
		public static v64 vzip2_f32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E52F0", Offset = "0x27E46F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000932")]
		public static v64 vzip2_s16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E5330", Offset = "0x27E4730", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000934")]
		public static v64 vzip2_s32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E5370", Offset = "0x27E4770", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000930")]
		public static v64 vzip2_s8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E53B0", Offset = "0x27E47B0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000939")]
		public static v64 vzip2_u16(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E52E0", Offset = "0x27E46E0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x600093B")]
		public static v64 vzip2_u32(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E53C0", Offset = "0x27E47C0", Length = "0xC")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000937")]
		public static v64 vzip2_u8(v64 a0, v64 a1) { }

		[Address(RVA = "0x27E53D0", Offset = "0x27E47D0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600093F")]
		public static v128 vzip2q_f32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5400", Offset = "0x27E4800", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000940")]
		public static v128 vzip2q_f64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5430", Offset = "0x27E4830", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000933")]
		public static v128 vzip2q_s16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5470", Offset = "0x27E4870", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000935")]
		public static v128 vzip2q_s32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E54B0", Offset = "0x27E48B0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000936")]
		public static v128 vzip2q_s64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E54F0", Offset = "0x27E48F0", Length = "0x3E")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000931")]
		public static v128 vzip2q_s8(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5530", Offset = "0x27E4930", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600093A")]
		public static v128 vzip2q_u16(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E53D0", Offset = "0x27E47D0", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600093C")]
		public static v128 vzip2q_u32(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5400", Offset = "0x27E4800", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x600093D")]
		public static v128 vzip2q_u64(v128 a0, v128 a1) { }

		[Address(RVA = "0x27E5560", Offset = "0x27E4960", Length = "0x2C")]
		[DebuggerStepThrough]
		[Token(Token = "0x6000938")]
		public static v128 vzip2q_u8(v128 a0, v128 a1) { }

	}


}

