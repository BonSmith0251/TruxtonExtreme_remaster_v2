namespace UnityEngine;

[AttributeUsage(AttributeTargets::Enum (16))]
[Token(Token = "0x20001B0")]
public sealed class InspectorOrderAttribute : PropertyAttribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000676")]
	private InspectorSort <m_inspectorSort>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000677")]
	private InspectorSortDirection <m_sortDirection>k__BackingField; //Field offset: 0x1C

	[Token(Token = "0x170002EB")]
	internal InspectorSort m_inspectorSort
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60013A9")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170002EC")]
	internal InspectorSortDirection m_sortDirection
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60013AA")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60013A9")]
	internal InspectorSort get_m_inspectorSort() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60013AA")]
	internal InspectorSortDirection get_m_sortDirection() { }

}

