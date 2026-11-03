namespace Unity.Properties;

[DefaultMember("Item")]
[IsReadOnly]
[Token(Token = "0x200001B")]
public struct PropertyPath : IEquatable<PropertyPath>
{
	[CompilerGenerated]
	[Token(Token = "0x200001C")]
	private struct <>c__DisplayClass36_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000033")]
		public int index; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000034")]
		public int length; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000035")]
		public string path; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000036")]
		public int state; //Field offset: 0x10

	}

	[Token(Token = "0x400002C")]
	internal const int k_InlineCount = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002D")]
	private readonly PropertyPathPart m_Part0; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002E")]
	private readonly PropertyPathPart m_Part1; //Field offset: 0x20
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400002F")]
	private readonly PropertyPathPart m_Part2; //Field offset: 0x40
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000030")]
	private readonly PropertyPathPart m_Part3; //Field offset: 0x60
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000031")]
	private readonly PropertyPathPart[] m_AdditionalParts; //Field offset: 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000032")]
	private readonly int <Length>k__BackingField; //Field offset: 0x88

	[Token(Token = "0x17000013")]
	public bool IsEmpty
	{
		[Address(RVA = "0x315F730", Offset = "0x315EB30", Length = "0xB")]
		[Token(Token = "0x6000050")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000014")]
	public PropertyPathPart Item
	{
		[Address(RVA = "0x315F740", Offset = "0x315EB40", Length = "0x1F3")]
		[Token(Token = "0x6000051")]
		 get { } //Length: 499
	}

	[Token(Token = "0x17000012")]
	public int Length
	{
		[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600004F")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x315F250", Offset = "0x315E650", Length = "0x107")]
	[Token(Token = "0x6000052")]
	public PropertyPath(string path) { }

	[Address(RVA = "0x315F150", Offset = "0x315E550", Length = "0x69")]
	[Token(Token = "0x6000053")]
	private PropertyPath(in PropertyPathPart part) { }

	[Address(RVA = "0x315F1C0", Offset = "0x315E5C0", Length = "0x87")]
	[Token(Token = "0x6000054")]
	private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1) { }

	[Address(RVA = "0x315F360", Offset = "0x315E760", Length = "0xA3")]
	[Token(Token = "0x6000055")]
	private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1, in PropertyPathPart part2) { }

	[Address(RVA = "0x315F670", Offset = "0x315EA70", Length = "0xB7")]
	[Token(Token = "0x6000056")]
	private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1, in PropertyPathPart part2, in PropertyPathPart part3) { }

	[Address(RVA = "0x315F410", Offset = "0x315E810", Length = "0x251")]
	[Token(Token = "0x6000057")]
	internal PropertyPath(List<PropertyPathPart> parts) { }

	[Address(RVA = "0x315EFC0", Offset = "0x315E3C0", Length = "0x14A")]
	[CompilerGenerated]
	[Token(Token = "0x6000069")]
	internal static void <ConstructFromPath>g__ReadNext|36_1(ref <>c__DisplayClass36_0 unnamed_param_0) { }

	[Address(RVA = "0x315F110", Offset = "0x315E510", Length = "0x3F")]
	[CompilerGenerated]
	[Token(Token = "0x6000068")]
	internal static void <ConstructFromPath>g__TrimStart|36_0(ref <>c__DisplayClass36_0 unnamed_param_0) { }

	[Address(RVA = "0x315B960", Offset = "0x315AD60", Length = "0xF6")]
	[Token(Token = "0x600005B")]
	public static PropertyPath AppendIndex(in PropertyPath path, int index) { }

	[Address(RVA = "0x315BA60", Offset = "0x315AE60", Length = "0x4DF")]
	[Token(Token = "0x600005A")]
	public static PropertyPath AppendPart(in PropertyPath path, in PropertyPathPart part) { }

	[Address(RVA = "0x315BF40", Offset = "0x315B340", Length = "0x372")]
	[Token(Token = "0x600005C")]
	public static PropertyPath AppendProperty(in PropertyPath path, IProperty property) { }

	[Address(RVA = "0x315C2C0", Offset = "0x315B6C0", Length = "0xB3")]
	[Token(Token = "0x6000060")]
	private static void AppendToBuilder(in PropertyPathPart part, StringBuilder builder) { }

	[Address(RVA = "0x315C380", Offset = "0x315B780", Length = "0x703")]
	[Token(Token = "0x6000059")]
	public static PropertyPath Combine(in PropertyPath path, in PropertyPath pathToAppend) { }

	[Address(RVA = "0x315CA90", Offset = "0x315BE90", Length = "0x117D")]
	[Token(Token = "0x6000062")]
	private static PropertyPath ConstructFromPath(string path) { }

	[Address(RVA = "0x315DC10", Offset = "0x315D010", Length = "0x125")]
	[Token(Token = "0x6000065")]
	public override bool Equals(PropertyPath other) { }

	[Address(RVA = "0x315DD40", Offset = "0x315D140", Length = "0xFF")]
	[Token(Token = "0x6000066")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x315DE40", Offset = "0x315D240", Length = "0xE4")]
	[Token(Token = "0x6000058")]
	public static PropertyPath FromIndex(int index) { }

	[Address(RVA = "0x315F730", Offset = "0x315EB30", Length = "0xB")]
	[Token(Token = "0x6000050")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x315F740", Offset = "0x315EB40", Length = "0x1F3")]
	[Token(Token = "0x6000051")]
	public PropertyPathPart get_Item(int index) { }

	[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600004F")]
	public int get_Length() { }

	[Address(RVA = "0x315DF30", Offset = "0x315D330", Length = "0x1DA")]
	[Token(Token = "0x6000067")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x315E110", Offset = "0x315D510", Length = "0x10F")]
	[Token(Token = "0x6000061")]
	private static void GetParts(in PropertyPath path, List<PropertyPathPart> parts) { }

	[Address(RVA = "0x315F940", Offset = "0x315ED40", Length = "0x6B")]
	[Token(Token = "0x6000063")]
	public static bool op_Equality(PropertyPath lhs, PropertyPath rhs) { }

	[Address(RVA = "0x315F9B0", Offset = "0x315EDB0", Length = "0xD1")]
	[Token(Token = "0x6000064")]
	public static bool op_Inequality(PropertyPath lhs, PropertyPath rhs) { }

	[Address(RVA = "0x315E220", Offset = "0x315D620", Length = "0x84")]
	[Token(Token = "0x600005D")]
	public static PropertyPath Pop(in PropertyPath path) { }

	[Address(RVA = "0x315E2B0", Offset = "0x315D6B0", Length = "0xA3C")]
	[Token(Token = "0x600005E")]
	public static PropertyPath SubPath(in PropertyPath path, int startIndex, int length) { }

	[Address(RVA = "0x315ECF0", Offset = "0x315E0F0", Length = "0x2C0")]
	[Token(Token = "0x600005F")]
	public virtual string ToString() { }

}

