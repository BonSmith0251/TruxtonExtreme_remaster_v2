namespace UnityEngine.UIElements;

[Token(Token = "0x2000029")]
public class ConverterGroup
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000061")]
	private readonly string <id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000062")]
	private readonly string <displayName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000063")]
	private readonly string <description>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000064")]
	private readonly TypeConverterRegistry <registry>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000031")]
	internal TypeConverterRegistry registry
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000CE")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x31F2490", Offset = "0x31F1890", Length = "0x140")]
	[Token(Token = "0x60000CF")]
	public ConverterGroup(string id, string displayName = null, string description = null) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000CE")]
	internal TypeConverterRegistry get_registry() { }

	[Address(RVA = "0x7AB800", Offset = "0x7AAC00", Length = "0x1B5")]
	[Token(Token = "0x60000D0")]
	public bool TryConvert(ref TSource source, out TDestination destination) { }

	[Address(RVA = "0x7ABCE0", Offset = "0x7AB0E0", Length = "0x286")]
	[Token(Token = "0x60000D1")]
	public bool TrySetValue(ref TContainer container, in PropertyPath path, TValue value, out VisitReturnCode returnCode) { }

}

