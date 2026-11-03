namespace System;

[Token(Token = "0x20000B7")]
internal class InvariantComparer : IComparer
{
	[Token(Token = "0x4000238")]
	internal static readonly InvariantComparer Default; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000237")]
	private CompareInfo m_compareInfo; //Field offset: 0x10

	[Address(RVA = "0x25FCA30", Offset = "0x25FBE30", Length = "0xD0")]
	[Token(Token = "0x6000372")]
	private static InvariantComparer() { }

	[Address(RVA = "0x25FCB10", Offset = "0x25FBF10", Length = "0x81")]
	[Token(Token = "0x6000370")]
	internal InvariantComparer() { }

	[Address(RVA = "0x25FC950", Offset = "0x25FBD50", Length = "0xDF")]
	[Token(Token = "0x6000371")]
	public override int Compare(object a, object b) { }

}

