namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200005B")]
public struct uint3x2 : IEquatable<uint3x2>, IFormattable
{
	[Token(Token = "0x400015A")]
	public static readonly uint3x2 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000158")]
	public uint3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000159")]
	public uint3 c1; //Field offset: 0xC

	[Token(Token = "0x17000A33")]
	public uint3 Item
	{
		[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
		[Token(Token = "0x6002152")]
		 get { } //Length: 12
	}

	[Address(RVA = "0x665C80", Offset = "0x665080", Length = "0x20")]
	[Token(Token = "0x600210D")]
	public uint3x2(uint3 c0, uint3 c1) { }

	[Address(RVA = "0x2B00470", Offset = "0x2AFF870", Length = "0x3E")]
	[Token(Token = "0x600210E")]
	public uint3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21) { }

	[Address(RVA = "0x2B00580", Offset = "0x2AFF980", Length = "0x30")]
	[Token(Token = "0x600210F")]
	public uint3x2(uint v) { }

	[Address(RVA = "0x2A1AF90", Offset = "0x2A1A390", Length = "0x6A")]
	[Token(Token = "0x6002110")]
	public uint3x2(bool v) { }

	[Address(RVA = "0x2B003D0", Offset = "0x2AFF7D0", Length = "0x91")]
	[Token(Token = "0x6002111")]
	public uint3x2(bool3x2 v) { }

	[Address(RVA = "0x2B00580", Offset = "0x2AFF980", Length = "0x30")]
	[Token(Token = "0x6002112")]
	public uint3x2(int v) { }

	[Address(RVA = "0x2B00500", Offset = "0x2AFF900", Length = "0x74")]
	[Token(Token = "0x6002113")]
	public uint3x2(int3x2 v) { }

	[Address(RVA = "0x2A217E0", Offset = "0x2A20BE0", Length = "0x94")]
	[Token(Token = "0x6002114")]
	public uint3x2(float v) { }

	[Address(RVA = "0x2A21880", Offset = "0x2A20C80", Length = "0xCE")]
	[Token(Token = "0x6002115")]
	public uint3x2(float3x2 v) { }

	[Address(RVA = "0x2A21950", Offset = "0x2A20D50", Length = "0x95")]
	[Token(Token = "0x6002116")]
	public uint3x2(double v) { }

	[Address(RVA = "0x2A219F0", Offset = "0x2A20DF0", Length = "0xDA")]
	[Token(Token = "0x6002117")]
	public uint3x2(double3x2 v) { }

	[Address(RVA = "0x2AFFBC0", Offset = "0x2AFEFC0", Length = "0x72")]
	[Token(Token = "0x6002153")]
	public override bool Equals(uint3x2 rhs) { }

	[Address(RVA = "0x2B312A0", Offset = "0x2B306A0", Length = "0xED")]
	[Token(Token = "0x6002154")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
	[Token(Token = "0x6002152")]
	public uint3 get_Item(int index) { }

	[Address(RVA = "0x2B31390", Offset = "0x2B30790", Length = "0x7B")]
	[Token(Token = "0x6002155")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2B00700", Offset = "0x2AFFB00", Length = "0xEA")]
	[Token(Token = "0x6002124")]
	public static uint3x2 op_Addition(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B00670", Offset = "0x2AFFA70", Length = "0x8F")]
	[Token(Token = "0x6002125")]
	public static uint3x2 op_Addition(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B007F0", Offset = "0x2AFFBF0", Length = "0x96")]
	[Token(Token = "0x6002126")]
	public static uint3x2 op_Addition(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B00890", Offset = "0x2AFFC90", Length = "0xE7")]
	[Token(Token = "0x6002149")]
	public static uint3x2 op_BitwiseAnd(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B00A20", Offset = "0x2AFFE20", Length = "0x91")]
	[Token(Token = "0x600214A")]
	public static uint3x2 op_BitwiseAnd(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B00980", Offset = "0x2AFFD80", Length = "0x94")]
	[Token(Token = "0x600214B")]
	public static uint3x2 op_BitwiseAnd(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B00C50", Offset = "0x2B00050", Length = "0x94")]
	[Token(Token = "0x600214E")]
	public static uint3x2 op_BitwiseOr(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B00B60", Offset = "0x2AFFF60", Length = "0xE7")]
	[Token(Token = "0x600214C")]
	public static uint3x2 op_BitwiseOr(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B00AC0", Offset = "0x2AFFEC0", Length = "0x91")]
	[Token(Token = "0x600214D")]
	public static uint3x2 op_BitwiseOr(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B00CF0", Offset = "0x2B000F0", Length = "0x84")]
	[Token(Token = "0x6002131")]
	public static uint3x2 op_Decrement(uint3x2 val) { }

	[Address(RVA = "0x2B319B0", Offset = "0x2B30DB0", Length = "0xB0")]
	[Token(Token = "0x600212C")]
	public static uint3x2 op_Division(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B31A60", Offset = "0x2B30E60", Length = "0xA5")]
	[Token(Token = "0x600212B")]
	public static uint3x2 op_Division(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B31B10", Offset = "0x2B30F10", Length = "0xF8")]
	[Token(Token = "0x600212A")]
	public static uint3x2 op_Division(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B01140", Offset = "0x2B00540", Length = "0x8E")]
	[Token(Token = "0x6002144")]
	public static bool3x2 op_Equality(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B00FD0", Offset = "0x2B003D0", Length = "0xDC")]
	[Token(Token = "0x6002142")]
	public static bool3x2 op_Equality(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B010B0", Offset = "0x2B004B0", Length = "0x8F")]
	[Token(Token = "0x6002143")]
	public static bool3x2 op_Equality(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B01360", Offset = "0x2B00760", Length = "0x94")]
	[Token(Token = "0x6002151")]
	public static uint3x2 op_ExclusiveOr(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B01270", Offset = "0x2B00670", Length = "0xE7")]
	[Token(Token = "0x600214F")]
	public static uint3x2 op_ExclusiveOr(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B011D0", Offset = "0x2B005D0", Length = "0x91")]
	[Token(Token = "0x6002150")]
	public static uint3x2 op_ExclusiveOr(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A43970", Offset = "0x2A42D70", Length = "0x7A")]
	[Token(Token = "0x600211C")]
	public static uint3x2 op_Explicit(int3x2 v) { }

	[Address(RVA = "0x2B31C10", Offset = "0x2B31010", Length = "0x26")]
	[Token(Token = "0x600211D")]
	public static uint3x2 op_Explicit(float v) { }

	[Address(RVA = "0x2B31CC0", Offset = "0x2B310C0", Length = "0x3E")]
	[Token(Token = "0x600211E")]
	public static uint3x2 op_Explicit(float3x2 v) { }

	[Address(RVA = "0x2B31C40", Offset = "0x2B31040", Length = "0x26")]
	[Token(Token = "0x600211F")]
	public static uint3x2 op_Explicit(double v) { }

	[Address(RVA = "0x2A43AC0", Offset = "0x2A42EC0", Length = "0x33")]
	[Token(Token = "0x600211B")]
	public static uint3x2 op_Explicit(int v) { }

	[Address(RVA = "0x2A43B00", Offset = "0x2A42F00", Length = "0x70")]
	[Token(Token = "0x6002119")]
	public static uint3x2 op_Explicit(bool v) { }

	[Address(RVA = "0x2A43B70", Offset = "0x2A42F70", Length = "0x96")]
	[Token(Token = "0x600211A")]
	public static uint3x2 op_Explicit(bool3x2 v) { }

	[Address(RVA = "0x2B31C70", Offset = "0x2B31070", Length = "0x45")]
	[Token(Token = "0x6002120")]
	public static uint3x2 op_Explicit(double3x2 v) { }

	[Address(RVA = "0x2B31F00", Offset = "0x2B31300", Length = "0xDC")]
	[Token(Token = "0x6002138")]
	public static bool3x2 op_GreaterThan(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B31FE0", Offset = "0x2B313E0", Length = "0x8F")]
	[Token(Token = "0x6002139")]
	public static bool3x2 op_GreaterThan(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B32070", Offset = "0x2B31470", Length = "0x8E")]
	[Token(Token = "0x600213A")]
	public static bool3x2 op_GreaterThan(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B31D90", Offset = "0x2B31190", Length = "0xDC")]
	[Token(Token = "0x600213B")]
	public static bool3x2 op_GreaterThanOrEqual(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B31E70", Offset = "0x2B31270", Length = "0x8F")]
	[Token(Token = "0x600213C")]
	public static bool3x2 op_GreaterThanOrEqual(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B31D00", Offset = "0x2B31100", Length = "0x8E")]
	[Token(Token = "0x600213D")]
	public static bool3x2 op_GreaterThanOrEqual(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2A43AC0", Offset = "0x2A42EC0", Length = "0x33")]
	[Token(Token = "0x6002118")]
	public static uint3x2 op_Implicit(uint v) { }

	[Address(RVA = "0x2B01800", Offset = "0x2B00C00", Length = "0x84")]
	[Token(Token = "0x6002130")]
	public static uint3x2 op_Increment(uint3x2 val) { }

	[Address(RVA = "0x2B01970", Offset = "0x2B00D70", Length = "0x8F")]
	[Token(Token = "0x6002146")]
	public static bool3x2 op_Inequality(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B01890", Offset = "0x2B00C90", Length = "0xDC")]
	[Token(Token = "0x6002145")]
	public static bool3x2 op_Inequality(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B01A00", Offset = "0x2B00E00", Length = "0x8E")]
	[Token(Token = "0x6002147")]
	public static bool3x2 op_Inequality(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B01A90", Offset = "0x2B00E90", Length = "0x99")]
	[Token(Token = "0x6002140")]
	public static uint3x2 op_LeftShift(uint3x2 x, int n) { }

	[Address(RVA = "0x2B32390", Offset = "0x2B31790", Length = "0xDC")]
	[Token(Token = "0x6002132")]
	public static bool3x2 op_LessThan(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B32470", Offset = "0x2B31870", Length = "0x8E")]
	[Token(Token = "0x6002134")]
	public static bool3x2 op_LessThan(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B32300", Offset = "0x2B31700", Length = "0x8F")]
	[Token(Token = "0x6002133")]
	public static bool3x2 op_LessThan(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B32100", Offset = "0x2B31500", Length = "0x8E")]
	[Token(Token = "0x6002137")]
	public static bool3x2 op_LessThanOrEqual(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B32190", Offset = "0x2B31590", Length = "0x8F")]
	[Token(Token = "0x6002136")]
	public static bool3x2 op_LessThanOrEqual(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B32220", Offset = "0x2B31620", Length = "0xDC")]
	[Token(Token = "0x6002135")]
	public static bool3x2 op_LessThanOrEqual(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B326B0", Offset = "0x2B31AB0", Length = "0xB0")]
	[Token(Token = "0x600212F")]
	public static uint3x2 op_Modulus(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B32500", Offset = "0x2B31900", Length = "0xF8")]
	[Token(Token = "0x600212D")]
	public static uint3x2 op_Modulus(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B32600", Offset = "0x2B31A00", Length = "0xA7")]
	[Token(Token = "0x600212E")]
	public static uint3x2 op_Modulus(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B02190", Offset = "0x2B01590", Length = "0xED")]
	[Token(Token = "0x6002121")]
	public static uint3x2 op_Multiply(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B02280", Offset = "0x2B01680", Length = "0xA0")]
	[Token(Token = "0x6002123")]
	public static uint3x2 op_Multiply(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B02320", Offset = "0x2B01720", Length = "0x9D")]
	[Token(Token = "0x6002122")]
	public static uint3x2 op_Multiply(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B023C0", Offset = "0x2B017C0", Length = "0x89")]
	[Token(Token = "0x6002148")]
	public static uint3x2 op_OnesComplement(uint3x2 val) { }

	[Address(RVA = "0x2B32760", Offset = "0x2B31B60", Length = "0x9D")]
	[Token(Token = "0x6002141")]
	public static uint3x2 op_RightShift(uint3x2 x, int n) { }

	[Address(RVA = "0x2B024F0", Offset = "0x2B018F0", Length = "0x96")]
	[Token(Token = "0x6002129")]
	public static uint3x2 op_Subtraction(uint lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B02680", Offset = "0x2B01A80", Length = "0x91")]
	[Token(Token = "0x6002128")]
	public static uint3x2 op_Subtraction(uint3x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B02590", Offset = "0x2B01990", Length = "0xE3")]
	[Token(Token = "0x6002127")]
	public static uint3x2 op_Subtraction(uint3x2 lhs, uint3x2 rhs) { }

	[Address(RVA = "0x2B02720", Offset = "0x2B01B20", Length = "0x8F")]
	[Token(Token = "0x600213E")]
	public static uint3x2 op_UnaryNegation(uint3x2 val) { }

	[Address(RVA = "0x2B027B0", Offset = "0x2B01BB0", Length = "0x82")]
	[Token(Token = "0x600213F")]
	public static uint3x2 op_UnaryPlus(uint3x2 val) { }

	[Address(RVA = "0x2B316E0", Offset = "0x2B30AE0", Length = "0x2C0")]
	[Token(Token = "0x6002156")]
	public virtual string ToString() { }

	[Address(RVA = "0x2B31410", Offset = "0x2B30810", Length = "0x2C6")]
	[Token(Token = "0x6002157")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

