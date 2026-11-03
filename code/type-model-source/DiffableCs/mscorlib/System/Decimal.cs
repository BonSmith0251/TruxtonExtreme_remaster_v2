namespace System;

[IsReadOnly]
[Token(Token = "0x20001E8")]
public struct decimal : IFormattable, IComparable, IConvertible, IComparable<Decimal>, IEquatable<Decimal>, IDeserializationCallback, ISpanFormattable
{
	[Token(Token = "0x20001E9")]
	private struct DecCalc
	{
		[Token(Token = "0x20001EC")]
		private struct Buf12
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400096E")]
			public uint U0; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000971")]
			private ulong ulo64LE; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x400096F")]
			public uint U1; //Field offset: 0x4
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000972")]
			private ulong uhigh64LE; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000970")]
			public uint U2; //Field offset: 0x8

			[Token(Token = "0x17000186")]
			public ulong High64
			{
				[Address(RVA = "0x20939C0", Offset = "0x2092DC0", Length = "0x7")]
				[Token(Token = "0x600116A")]
				 get { } //Length: 7
				[Address(RVA = "0x20939D0", Offset = "0x2092DD0", Length = "0x5")]
				[Token(Token = "0x600116B")]
				 set { } //Length: 5
			}

			[Token(Token = "0x17000185")]
			public ulong Low64
			{
				[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
				[Token(Token = "0x6001168")]
				 get { } //Length: 6
				[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
				[Token(Token = "0x6001169")]
				 set { } //Length: 4
			}

			[Address(RVA = "0x20939C0", Offset = "0x2092DC0", Length = "0x7")]
			[Token(Token = "0x600116A")]
			public ulong get_High64() { }

			[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
			[Token(Token = "0x6001168")]
			public ulong get_Low64() { }

			[Address(RVA = "0x20939D0", Offset = "0x2092DD0", Length = "0x5")]
			[Token(Token = "0x600116B")]
			public void set_High64(ulong value) { }

			[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
			[Token(Token = "0x6001169")]
			public void set_Low64(ulong value) { }

		}

		[Token(Token = "0x20001ED")]
		private struct Buf16
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000973")]
			public uint U0; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000977")]
			private ulong ulo64LE; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000974")]
			public uint U1; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000975")]
			public uint U2; //Field offset: 0x8
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000978")]
			private ulong uhigh64LE; //Field offset: 0x8
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000976")]
			public uint U3; //Field offset: 0xC

			[Token(Token = "0x17000188")]
			public ulong High64
			{
				[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
				[Token(Token = "0x600116E")]
				 get { } //Length: 7
				[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
				[Token(Token = "0x600116F")]
				 set { } //Length: 5
			}

			[Token(Token = "0x17000187")]
			public ulong Low64
			{
				[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
				[Token(Token = "0x600116C")]
				 get { } //Length: 6
				[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
				[Token(Token = "0x600116D")]
				 set { } //Length: 4
			}

			[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
			[Token(Token = "0x600116E")]
			public ulong get_High64() { }

			[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
			[Token(Token = "0x600116C")]
			public ulong get_Low64() { }

			[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
			[Token(Token = "0x600116F")]
			public void set_High64(ulong value) { }

			[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
			[Token(Token = "0x600116D")]
			public void set_Low64(ulong value) { }

		}

		[Token(Token = "0x20001EE")]
		private struct Buf24
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000979")]
			public uint U0; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400097F")]
			private ulong ulo64LE; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x400097A")]
			public uint U1; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400097B")]
			public uint U2; //Field offset: 0x8
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000980")]
			private ulong umid64LE; //Field offset: 0x8
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x400097C")]
			public uint U3; //Field offset: 0xC
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400097D")]
			public uint U4; //Field offset: 0x10
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000981")]
			private ulong uhigh64LE; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x400097E")]
			public uint U5; //Field offset: 0x14

			[Token(Token = "0x1700018B")]
			public ulong High64
			{
				[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
				[Token(Token = "0x6001173")]
				 set { } //Length: 5
			}

			[Token(Token = "0x17000189")]
			public ulong Low64
			{
				[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
				[Token(Token = "0x6001170")]
				 get { } //Length: 6
				[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
				[Token(Token = "0x6001171")]
				 set { } //Length: 4
			}

			[Token(Token = "0x1700018A")]
			public ulong Mid64
			{
				[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
				[Token(Token = "0x6001172")]
				 set { } //Length: 5
			}

			[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
			[Token(Token = "0x6001170")]
			public ulong get_Low64() { }

			[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
			[Token(Token = "0x6001173")]
			public void set_High64(ulong value) { }

			[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
			[Token(Token = "0x6001171")]
			public void set_Low64(ulong value) { }

			[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
			[Token(Token = "0x6001172")]
			public void set_Mid64(ulong value) { }

		}

		[Token(Token = "0x20001EB")]
		private struct PowerOvfl
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400096C")]
			public readonly uint Hi; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400096D")]
			public readonly ulong MidLo; //Field offset: 0x8

			[Address(RVA = "0x20A2AB0", Offset = "0x20A1EB0", Length = "0x14")]
			[Token(Token = "0x6001167")]
			public PowerOvfl(uint hi, uint mid, uint lo) { }

		}

		[Token(Token = "0x20001EA")]
		public enum RoundingMode : int
		{
			ToEven = 0,
			AwayFromZero = 1,
			Truncate = 2,
			Floor = 3,
			Ceiling = 4,
		}

		[Token(Token = "0x4000962")]
		private static readonly UInt32[] s_powers10; //Field offset: 0x0
		[Token(Token = "0x4000963")]
		private static readonly UInt64[] s_ulongPowers10; //Field offset: 0x8
		[Token(Token = "0x4000964")]
		private static readonly Double[] s_doublePowers10; //Field offset: 0x10
		[Token(Token = "0x4000965")]
		private static readonly PowerOvfl[] PowerOvflValues; //Field offset: 0x18
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400095D")]
		private uint uflags; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400095E")]
		private uint uhi; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400095F")]
		private uint ulo; //Field offset: 0x8
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000961")]
		private ulong ulomidLE; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000960")]
		private uint umid; //Field offset: 0xC

		[Token(Token = "0x17000180")]
		private uint High
		{
			[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
			[Token(Token = "0x6001140")]
			private get { } //Length: 4
			[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
			[Token(Token = "0x6001141")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000183")]
		private bool IsNegative
		{
			[Address(RVA = "0x209A540", Offset = "0x2099940", Length = "0x6")]
			[Token(Token = "0x6001146")]
			private get { } //Length: 6
		}

		[Token(Token = "0x17000181")]
		private uint Low
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[Token(Token = "0x6001142")]
			private get { } //Length: 4
			[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
			[Token(Token = "0x6001143")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000184")]
		private ulong Low64
		{
			[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
			[Token(Token = "0x6001147")]
			private get { } //Length: 7
			[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
			[Token(Token = "0x6001148")]
			private set { } //Length: 5
		}

		[Token(Token = "0x17000182")]
		private uint Mid
		{
			[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
			[Token(Token = "0x6001144")]
			private get { } //Length: 4
			[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
			[Token(Token = "0x6001145")]
			private set { } //Length: 4
		}

		[Address(RVA = "0x209A230", Offset = "0x2099630", Length = "0x307")]
		[Token(Token = "0x6001166")]
		private static DecCalc() { }

		[Address(RVA = "0x2096540", Offset = "0x2095940", Length = "0x19")]
		[Token(Token = "0x6001159")]
		private static bool Add32To96(ref Buf12 bufNum, uint value) { }

		[Address(RVA = "0x2096560", Offset = "0x2095960", Length = "0x72E")]
		[Token(Token = "0x600115A")]
		internal static void DecAddSub(ref DecCalc d1, ref DecCalc d2, bool sign) { }

		[Address(RVA = "0x2096C90", Offset = "0x2096090", Length = "0x7C")]
		[Token(Token = "0x6001165")]
		internal static uint DecDivMod1E9(ref DecCalc value) { }

		[Address(RVA = "0x2096D10", Offset = "0x2096110", Length = "0x116")]
		[Token(Token = "0x6001151")]
		private static uint Div128By96(ref Buf16 bufNum, ref Buf12 bufDen) { }

		[Address(RVA = "0x2096E30", Offset = "0x2096230", Length = "0x6A")]
		[Token(Token = "0x600114D")]
		private static uint Div96By32(ref Buf12 bufNum, uint den) { }

		[Address(RVA = "0x2096EA0", Offset = "0x20962A0", Length = "0x142")]
		[Token(Token = "0x6001150")]
		private static uint Div96By64(ref Buf12 bufNum, ulong den) { }

		[Address(RVA = "0x2096FF0", Offset = "0x20963F0", Length = "0x59")]
		[Token(Token = "0x600114E")]
		private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow) { }

		[Address(RVA = "0x2097050", Offset = "0x2096450", Length = "0x72")]
		[Token(Token = "0x6001155")]
		private static uint DivByConst(UInt32* result, uint hiRes, out uint quotient, out uint remainder, uint power) { }

		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x6001140")]
		private uint get_High() { }

		[Address(RVA = "0x209A540", Offset = "0x2099940", Length = "0x6")]
		[Token(Token = "0x6001146")]
		private bool get_IsNegative() { }

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6001142")]
		private uint get_Low() { }

		[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
		[Token(Token = "0x6001147")]
		private ulong get_Low64() { }

		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x6001144")]
		private uint get_Mid() { }

		[Address(RVA = "0x20970D0", Offset = "0x20964D0", Length = "0xF")]
		[Token(Token = "0x600114A")]
		private static uint GetExponent(double d) { }

		[Address(RVA = "0x20970E0", Offset = "0x20964E0", Length = "0xB")]
		[Token(Token = "0x6001149")]
		private static uint GetExponent(float f) { }

		[Address(RVA = "0x20970F0", Offset = "0x20964F0", Length = "0x147")]
		[Token(Token = "0x6001162")]
		internal static int GetHashCode(in decimal d) { }

		[Address(RVA = "0x20972C0", Offset = "0x20966C0", Length = "0x86")]
		[Token(Token = "0x6001152")]
		private static uint IncreaseScale(ref Buf12 bufNum, uint power) { }

		[Address(RVA = "0x2097240", Offset = "0x2096640", Length = "0x72")]
		[Token(Token = "0x6001153")]
		private static void IncreaseScale64(ref Buf12 bufNum, uint power) { }

		[Address(RVA = "0x2097350", Offset = "0x2096750", Length = "0x309")]
		[Token(Token = "0x6001164")]
		internal static void InternalRound(ref DecCalc d, uint scale, RoundingMode mode) { }

		[Address(RVA = "0x2097660", Offset = "0x2096A60", Length = "0x60")]
		[Token(Token = "0x6001156")]
		private static int LeadingZeroCount(uint value) { }

		[Address(RVA = "0x20976C0", Offset = "0x2096AC0", Length = "0x11D")]
		[Token(Token = "0x6001157")]
		private static int OverflowUnscale(ref Buf12 bufQuo, int scale, bool sticky) { }

		[Address(RVA = "0x20977E0", Offset = "0x2096BE0", Length = "0x7B8")]
		[Token(Token = "0x6001154")]
		private static int ScaleResult(Buf24* bufRes, uint hiRes, int scale) { }

		[Address(RVA = "0x2097FC0", Offset = "0x20973C0", Length = "0x1D2")]
		[Token(Token = "0x6001158")]
		private static int SearchScale(ref Buf12 bufQuo, int scale) { }

		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x6001141")]
		private void set_High(uint value) { }

		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x6001143")]
		private void set_Low(uint value) { }

		[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
		[Token(Token = "0x6001148")]
		private void set_Low64(ulong value) { }

		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[Token(Token = "0x6001145")]
		private void set_Mid(uint value) { }

		[Address(RVA = "0x20304D0", Offset = "0x202F8D0", Length = "0x9")]
		[Token(Token = "0x600114B")]
		private static ulong UInt32x32To64(uint a, uint b) { }

		[Address(RVA = "0x20981A0", Offset = "0x20975A0", Length = "0x161")]
		[Token(Token = "0x600114C")]
		private static void UInt64x64To128(ulong a, ulong b, ref DecCalc result) { }

		[Address(RVA = "0x2098310", Offset = "0x2097710", Length = "0x1FF")]
		[Token(Token = "0x600114F")]
		private static void Unscale(ref uint low, ref ulong high64, ref int scale) { }

		[Address(RVA = "0x2098710", Offset = "0x2097B10", Length = "0x10C")]
		[Token(Token = "0x600115B")]
		internal static int VarDecCmp(in decimal d1, in decimal d2) { }

		[Address(RVA = "0x2098510", Offset = "0x2097910", Length = "0x1F6")]
		[Token(Token = "0x600115C")]
		private static int VarDecCmpSub(in decimal d1, in decimal d2) { }

		[Address(RVA = "0x2098820", Offset = "0x2097C20", Length = "0xB8B")]
		[Token(Token = "0x6001163")]
		internal static void VarDecDiv(ref DecCalc d1, ref DecCalc d2) { }

		[Address(RVA = "0x20993B0", Offset = "0x20987B0", Length = "0x3FA")]
		[Token(Token = "0x600115E")]
		internal static void VarDecFromR4(float input, out DecCalc result) { }

		[Address(RVA = "0x20997B0", Offset = "0x2098BB0", Length = "0x3E8")]
		[Token(Token = "0x600115F")]
		internal static void VarDecFromR8(double input, out DecCalc result) { }

		[Address(RVA = "0x2099BA0", Offset = "0x2098FA0", Length = "0x523")]
		[Token(Token = "0x600115D")]
		internal static void VarDecMul(ref DecCalc d1, ref DecCalc d2) { }

		[Address(RVA = "0x209A0D0", Offset = "0x20994D0", Length = "0x4E")]
		[Token(Token = "0x6001160")]
		internal static float VarR4FromDec(in decimal value) { }

		[Address(RVA = "0x209A120", Offset = "0x2099520", Length = "0x10F")]
		[Token(Token = "0x6001161")]
		internal static double VarR8FromDec(in decimal value) { }

	}

	[DecimalConstant(0, 0, 0, 0, 0)]
	[Token(Token = "0x4000953")]
	public static readonly decimal Zero; //Field offset: 0x0
	[DecimalConstant(0, 0, 0, 0, 1)]
	[Token(Token = "0x4000954")]
	public static readonly decimal One; //Field offset: 0x10
	[DecimalConstant(0, 128, 0, 0, 1)]
	[Token(Token = "0x4000955")]
	public static readonly decimal MinusOne; //Field offset: 0x20
	[DecimalConstant(0, 0, 4294967295, 4294967295, 4294967295)]
	[Token(Token = "0x4000956")]
	public static readonly decimal MaxValue; //Field offset: 0x30
	[DecimalConstant(0, 128, 4294967295, 4294967295, 4294967295)]
	[Token(Token = "0x4000957")]
	public static readonly decimal MinValue; //Field offset: 0x40
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000958")]
	private readonly int flags; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000959")]
	private readonly int hi; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400095A")]
	private readonly int lo; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400095C")]
	private readonly ulong ulomidLE; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400095B")]
	private readonly int mid; //Field offset: 0xC

	[Token(Token = "0x1700017A")]
	internal uint High
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x60010DD")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700017D")]
	internal bool IsNegative
	{
		[Address(RVA = "0x209A540", Offset = "0x2099940", Length = "0x6")]
		[Token(Token = "0x60010E0")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700017B")]
	internal uint Low
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60010DE")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700017F")]
	private ulong Low64
	{
		[Address(RVA = "0x209CBD0", Offset = "0x209BFD0", Length = "0x39")]
		[Token(Token = "0x60010E2")]
		private get { } //Length: 57
	}

	[Token(Token = "0x1700017C")]
	internal uint Mid
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x60010DF")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700017E")]
	internal int Scale
	{
		[Address(RVA = "0x1E1AD50", Offset = "0x1E1A150", Length = "0x5")]
		[Token(Token = "0x60010E1")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x209C760", Offset = "0x209BB60", Length = "0xE2")]
	[Token(Token = "0x600113F")]
	private static Decimal() { }

	[Address(RVA = "0x209C930", Offset = "0x209BD30", Length = "0x9E")]
	[Token(Token = "0x60010ED")]
	public Decimal(int lo, int mid, int hi, bool isNegative, byte scale) { }

	[Address(RVA = "0x209CA00", Offset = "0x209BE00", Length = "0x143")]
	[Token(Token = "0x60010EC")]
	public Decimal(Int32[] bits) { }

	[Address(RVA = "0x209C860", Offset = "0x209BC60", Length = "0x7B")]
	[Token(Token = "0x60010EA")]
	public Decimal(double value) { }

	[Address(RVA = "0x209CB50", Offset = "0x209BF50", Length = "0x7B")]
	[Token(Token = "0x60010E9")]
	public Decimal(float value) { }

	[Address(RVA = "0x209C910", Offset = "0x209BD10", Length = "0x10")]
	[CLSCompliant(False)]
	[Token(Token = "0x60010E8")]
	public Decimal(ulong value) { }

	[Address(RVA = "0x209C9D0", Offset = "0x209BDD0", Length = "0x2E")]
	[Token(Token = "0x60010E7")]
	public Decimal(long value) { }

	[Address(RVA = "0x209C920", Offset = "0x209BD20", Length = "0xA")]
	[Token(Token = "0x60010EF")]
	private Decimal(in decimal d, int flags) { }

	[Address(RVA = "0x209C850", Offset = "0x209BC50", Length = "0xC")]
	[CLSCompliant(False)]
	[Token(Token = "0x60010E6")]
	public Decimal(uint value) { }

	[Address(RVA = "0x209C8E0", Offset = "0x209BCE0", Length = "0x21")]
	[Token(Token = "0x60010E5")]
	public Decimal(int value) { }

	[Address(RVA = "0x209A550", Offset = "0x2099950", Length = "0x12")]
	[Token(Token = "0x60010F0")]
	internal static decimal Abs(ref decimal d) { }

	[Address(RVA = "0x209A570", Offset = "0x2099970", Length = "0x94")]
	[Token(Token = "0x60010F1")]
	public static decimal Add(decimal d1, decimal d2) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60010E3")]
	private static DecCalc AsMutable(ref decimal d) { }

	[Address(RVA = "0x209A770", Offset = "0x2099B70", Length = "0x5A")]
	[Token(Token = "0x60010F2")]
	public static int Compare(decimal d1, decimal d2) { }

	[Address(RVA = "0x209A610", Offset = "0x2099A10", Length = "0xFD")]
	[Token(Token = "0x60010F3")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x209A710", Offset = "0x2099B10", Length = "0x5A")]
	[Token(Token = "0x60010F4")]
	public override int CompareTo(decimal value) { }

	[Address(RVA = "0x209A7D0", Offset = "0x2099BD0", Length = "0xD7")]
	[Token(Token = "0x60010E4")]
	internal static uint DecDivMod1E9(ref decimal value) { }

	[Address(RVA = "0x209A8B0", Offset = "0x2099CB0", Length = "0x91")]
	[Token(Token = "0x60010F5")]
	public static decimal Divide(decimal d1, decimal d2) { }

	[Address(RVA = "0x209A9B0", Offset = "0x2099DB0", Length = "0xB6")]
	[Token(Token = "0x60010F6")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x209A950", Offset = "0x2099D50", Length = "0x5F")]
	[Token(Token = "0x60010F7")]
	public override bool Equals(decimal value) { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x60010DD")]
	internal uint get_High() { }

	[Address(RVA = "0x209A540", Offset = "0x2099940", Length = "0x6")]
	[Token(Token = "0x60010E0")]
	internal bool get_IsNegative() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60010DE")]
	internal uint get_Low() { }

	[Address(RVA = "0x209CBD0", Offset = "0x209BFD0", Length = "0x39")]
	[Token(Token = "0x60010E2")]
	private ulong get_Low64() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[Token(Token = "0x60010DF")]
	internal uint get_Mid() { }

	[Address(RVA = "0x1E1AD50", Offset = "0x1E1A150", Length = "0x5")]
	[Token(Token = "0x60010E1")]
	internal int get_Scale() { }

	[Address(RVA = "0x209AA70", Offset = "0x2099E70", Length = "0x81")]
	[Token(Token = "0x6001100")]
	public static Int32[] GetBits(decimal d) { }

	[Address(RVA = "0x209AB00", Offset = "0x2099F00", Length = "0x178")]
	[Token(Token = "0x60010F8")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x209AC80", Offset = "0x209A080", Length = "0x6")]
	[Token(Token = "0x600112F")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x209AC90", Offset = "0x209A090", Length = "0x1B")]
	[Token(Token = "0x60010EB")]
	private static bool IsValid(int flags) { }

	[Address(RVA = "0x209ACB0", Offset = "0x209A0B0", Length = "0x63")]
	[Token(Token = "0x6001101")]
	internal static decimal Max(ref decimal d1, ref decimal d2) { }

	[Address(RVA = "0x209AD20", Offset = "0x209A120", Length = "0x63")]
	[Token(Token = "0x6001102")]
	internal static decimal Min(ref decimal d1, ref decimal d2) { }

	[Address(RVA = "0x209AD90", Offset = "0x209A190", Length = "0x91")]
	[Token(Token = "0x6001103")]
	public static decimal Multiply(decimal d1, decimal d2) { }

	[Address(RVA = "0x209AE30", Offset = "0x209A230", Length = "0x13")]
	[Token(Token = "0x6001104")]
	public static decimal Negate(decimal d) { }

	[Address(RVA = "0x209CC10", Offset = "0x209C010", Length = "0x94")]
	[Token(Token = "0x6001125")]
	public static decimal op_Addition(decimal d1, decimal d2) { }

	[Address(RVA = "0x209CCB0", Offset = "0x209C0B0", Length = "0x91")]
	[Token(Token = "0x6001128")]
	public static decimal op_Division(decimal d1, decimal d2) { }

	[Address(RVA = "0x209CD50", Offset = "0x209C150", Length = "0x5F")]
	[Token(Token = "0x6001129")]
	public static bool op_Equality(decimal d1, decimal d2) { }

	[Address(RVA = "0x209CF40", Offset = "0x209C340", Length = "0x20")]
	[Token(Token = "0x600111C")]
	public static decimal op_Explicit(float value) { }

	[Address(RVA = "0x209D180", Offset = "0x209C580", Length = "0x20")]
	[Token(Token = "0x600111D")]
	public static decimal op_Explicit(double value) { }

	[Address(RVA = "0x209D1A0", Offset = "0x209C5A0", Length = "0x54")]
	[Token(Token = "0x600111E")]
	public static int op_Explicit(decimal value) { }

	[Address(RVA = "0x209CF60", Offset = "0x209C360", Length = "0x185")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001120")]
	public static ulong op_Explicit(decimal value) { }

	[Address(RVA = "0x209CDB0", Offset = "0x209C1B0", Length = "0x18D")]
	[Token(Token = "0x600111F")]
	public static long op_Explicit(decimal value) { }

	[Address(RVA = "0x209D0F0", Offset = "0x209C4F0", Length = "0x85")]
	[Token(Token = "0x6001122")]
	public static double op_Explicit(decimal value) { }

	[Address(RVA = "0x209D200", Offset = "0x209C600", Length = "0xBA")]
	[Token(Token = "0x6001121")]
	public static float op_Explicit(decimal value) { }

	[Address(RVA = "0x209D320", Offset = "0x209C720", Length = "0x5F")]
	[Token(Token = "0x600112D")]
	public static bool op_GreaterThan(decimal d1, decimal d2) { }

	[Address(RVA = "0x209D2C0", Offset = "0x209C6C0", Length = "0x5F")]
	[Token(Token = "0x600112E")]
	public static bool op_GreaterThanOrEqual(decimal d1, decimal d2) { }

	[Address(RVA = "0x209D410", Offset = "0x209C810", Length = "0x2C")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001114")]
	public static decimal op_Implicit(sbyte value) { }

	[Address(RVA = "0x209D3E0", Offset = "0x209C7E0", Length = "0x13")]
	[CLSCompliant(False)]
	[Token(Token = "0x600111B")]
	public static decimal op_Implicit(ulong value) { }

	[Address(RVA = "0x209D3A0", Offset = "0x209C7A0", Length = "0x31")]
	[Token(Token = "0x600111A")]
	public static decimal op_Implicit(long value) { }

	[Address(RVA = "0x209D400", Offset = "0x209C800", Length = "0xF")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001119")]
	public static decimal op_Implicit(uint value) { }

	[Address(RVA = "0x209D380", Offset = "0x209C780", Length = "0x14")]
	[Token(Token = "0x6001117")]
	public static decimal op_Implicit(char value) { }

	[Address(RVA = "0x209D380", Offset = "0x209C780", Length = "0x14")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001116")]
	public static decimal op_Implicit(ushort value) { }

	[Address(RVA = "0x209D470", Offset = "0x209C870", Length = "0x2D")]
	[Token(Token = "0x6001115")]
	public static decimal op_Implicit(short value) { }

	[Address(RVA = "0x209D4A0", Offset = "0x209C8A0", Length = "0x14")]
	[Token(Token = "0x6001113")]
	public static decimal op_Implicit(byte value) { }

	[Address(RVA = "0x209D440", Offset = "0x209C840", Length = "0x24")]
	[Token(Token = "0x6001118")]
	public static decimal op_Implicit(int value) { }

	[Address(RVA = "0x209D4C0", Offset = "0x209C8C0", Length = "0xDD")]
	[Token(Token = "0x6001124")]
	public static decimal op_Increment(decimal d) { }

	[Address(RVA = "0x209D5A0", Offset = "0x209C9A0", Length = "0x5F")]
	[Token(Token = "0x600112A")]
	public static bool op_Inequality(decimal d1, decimal d2) { }

	[Address(RVA = "0x209D660", Offset = "0x209CA60", Length = "0x5D")]
	[Token(Token = "0x600112B")]
	public static bool op_LessThan(decimal d1, decimal d2) { }

	[Address(RVA = "0x209D600", Offset = "0x209CA00", Length = "0x5F")]
	[Token(Token = "0x600112C")]
	public static bool op_LessThanOrEqual(decimal d1, decimal d2) { }

	[Address(RVA = "0x209D6C0", Offset = "0x209CAC0", Length = "0x91")]
	[Token(Token = "0x6001127")]
	public static decimal op_Multiply(decimal d1, decimal d2) { }

	[Address(RVA = "0x209D760", Offset = "0x209CB60", Length = "0x94")]
	[Token(Token = "0x6001126")]
	public static decimal op_Subtraction(decimal d1, decimal d2) { }

	[Address(RVA = "0x209AE30", Offset = "0x209A230", Length = "0x13")]
	[Token(Token = "0x6001123")]
	public static decimal op_UnaryNegation(decimal d) { }

	[Address(RVA = "0x209AF70", Offset = "0x209A370", Length = "0xFA")]
	[Token(Token = "0x60010FD")]
	public static decimal Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x209AE50", Offset = "0x209A250", Length = "0x111")]
	[Token(Token = "0x60010FE")]
	public static decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x209B1C0", Offset = "0x209A5C0", Length = "0x1BF")]
	[Token(Token = "0x6001106")]
	private static decimal Round(ref decimal d, int decimals, MidpointRounding mode) { }

	[Address(RVA = "0x209B070", Offset = "0x209A470", Length = "0x14D")]
	[Token(Token = "0x6001105")]
	public static decimal Round(decimal d, int decimals) { }

	[Address(RVA = "0x209B380", Offset = "0x209A780", Length = "0x5F")]
	[Token(Token = "0x6001130")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x209B3E0", Offset = "0x209A7E0", Length = "0x5F")]
	[Token(Token = "0x6001133")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x209B440", Offset = "0x209A840", Length = "0x84")]
	[Token(Token = "0x6001131")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x209B4D0", Offset = "0x209A8D0", Length = "0x84")]
	[Token(Token = "0x600113D")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x600113C")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x209B560", Offset = "0x209A960", Length = "0x5F")]
	[Token(Token = "0x600113B")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x209B5C0", Offset = "0x209A9C0", Length = "0x5F")]
	[Token(Token = "0x6001134")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x209B620", Offset = "0x209AA20", Length = "0x5F")]
	[Token(Token = "0x6001136")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x209B680", Offset = "0x209AA80", Length = "0x5F")]
	[Token(Token = "0x6001138")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x209B6E0", Offset = "0x209AAE0", Length = "0x5F")]
	[Token(Token = "0x6001132")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x209B740", Offset = "0x209AB40", Length = "0x5F")]
	[Token(Token = "0x600113A")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x209B7A0", Offset = "0x209ABA0", Length = "0x92")]
	[Token(Token = "0x600113E")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x209B840", Offset = "0x209AC40", Length = "0x5F")]
	[Token(Token = "0x6001135")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x209B8A0", Offset = "0x209ACA0", Length = "0x5F")]
	[Token(Token = "0x6001137")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x209B900", Offset = "0x209AD00", Length = "0x5F")]
	[Token(Token = "0x6001139")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x209B960", Offset = "0x209AD60", Length = "0xA0")]
	[Token(Token = "0x60010EE")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0x209BA10", Offset = "0x209AE10", Length = "0x10E")]
	[Token(Token = "0x6001107")]
	public static byte ToByte(decimal value) { }

	[Address(RVA = "0x209BB20", Offset = "0x209AF20", Length = "0x4A")]
	[Token(Token = "0x600110A")]
	public static double ToDouble(decimal d) { }

	[Address(RVA = "0x209BB70", Offset = "0x209AF70", Length = "0x10E")]
	[Token(Token = "0x6001109")]
	public static short ToInt16(decimal value) { }

	[Address(RVA = "0x209BC80", Offset = "0x209B080", Length = "0xCC")]
	[Token(Token = "0x600110B")]
	public static int ToInt32(decimal d) { }

	[Address(RVA = "0x209BD50", Offset = "0x209B150", Length = "0xDF")]
	[Token(Token = "0x600110C")]
	public static long ToInt64(decimal d) { }

	[Address(RVA = "0x209BE30", Offset = "0x209B230", Length = "0x10E")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001108")]
	public static sbyte ToSByte(decimal value) { }

	[Address(RVA = "0x209BF40", Offset = "0x209B340", Length = "0x7F")]
	[Token(Token = "0x6001110")]
	public static float ToSingle(decimal d) { }

	[Address(RVA = "0x209C160", Offset = "0x209B560", Length = "0x9C")]
	[Token(Token = "0x60010F9")]
	public virtual string ToString() { }

	[Address(RVA = "0x209BFC0", Offset = "0x209B3C0", Length = "0xAB")]
	[Token(Token = "0x60010FA")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x209C070", Offset = "0x209B470", Length = "0xE7")]
	[Token(Token = "0x60010FB")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x209C200", Offset = "0x209B600", Length = "0x10E")]
	[CLSCompliant(False)]
	[Token(Token = "0x600110D")]
	public static ushort ToUInt16(decimal value) { }

	[Address(RVA = "0x209C310", Offset = "0x209B710", Length = "0xBA")]
	[CLSCompliant(False)]
	[Token(Token = "0x600110E")]
	public static uint ToUInt32(decimal d) { }

	[Address(RVA = "0x209C3D0", Offset = "0x209B7D0", Length = "0xD7")]
	[CLSCompliant(False)]
	[Token(Token = "0x600110F")]
	public static ulong ToUInt64(decimal d) { }

	[Address(RVA = "0x209C540", Offset = "0x209B940", Length = "0x5F")]
	[Token(Token = "0x6001111")]
	public static decimal Truncate(decimal d) { }

	[Address(RVA = "0x209C4B0", Offset = "0x209B8B0", Length = "0x8B")]
	[Token(Token = "0x6001112")]
	private static void Truncate(ref decimal d) { }

	[Address(RVA = "0x209C5A0", Offset = "0x209B9A0", Length = "0xC2")]
	[Token(Token = "0x60010FC")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x209C670", Offset = "0x209BA70", Length = "0xEE")]
	[Token(Token = "0x60010FF")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out decimal result) { }

}

