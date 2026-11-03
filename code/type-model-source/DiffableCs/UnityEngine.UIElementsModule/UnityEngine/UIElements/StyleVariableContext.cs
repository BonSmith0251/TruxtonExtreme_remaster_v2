namespace UnityEngine.UIElements;

[Token(Token = "0x2000495")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleVariableContext
{
	[CompilerGenerated]
	[Token(Token = "0x2000496")]
	private struct <>c__DisplayClass7_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F2A")]
		public int hash; //Field offset: 0x0

	}

	[Token(Token = "0x4000F25")]
	public static readonly StyleVariableContext none; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F26")]
	private int m_VariableHash; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F27")]
	private List<StyleVariable> m_Variables; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F28")]
	private List<Int32> m_SortedHash; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F29")]
	private List<Int32> m_UnsortedHash; //Field offset: 0x28

	[Address(RVA = "0x3291940", Offset = "0x3290D40", Length = "0x141")]
	[Token(Token = "0x600225A")]
	private static StyleVariableContext() { }

	[Address(RVA = "0x3291BC0", Offset = "0x3290FC0", Length = "0xF2")]
	[Token(Token = "0x6002256")]
	public StyleVariableContext() { }

	[Address(RVA = "0x3291A90", Offset = "0x3290E90", Length = "0x12B")]
	[Token(Token = "0x6002257")]
	public StyleVariableContext(StyleVariableContext other) { }

	[Address(RVA = "0x3291930", Offset = "0x3290D30", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x600225B")]
	internal static int <Add>g__ComputeOrderSensitiveHash|7_0(int index, ref <>c__DisplayClass7_0 unnamed_param_1) { }

	[Address(RVA = "0x32914A0", Offset = "0x32908A0", Length = "0x2DE")]
	[Token(Token = "0x6002253")]
	public void Add(StyleVariable sv) { }

	[Address(RVA = "0x3291390", Offset = "0x3290790", Length = "0x10C")]
	[Token(Token = "0x6002254")]
	public void AddInitialRange(StyleVariableContext other) { }

	[Address(RVA = "0x3291780", Offset = "0x3290B80", Length = "0xA1")]
	[Token(Token = "0x6002255")]
	public void Clear() { }

	[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
	[Token(Token = "0x6002259")]
	public int GetVariableHash() { }

	[Address(RVA = "0x3291830", Offset = "0x3290C30", Length = "0xFE")]
	[Token(Token = "0x6002258")]
	public bool TryFindVariable(string name, out StyleVariable v) { }

}

