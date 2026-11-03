namespace System.Diagnostics;

[Token(Token = "0x20000FA")]
public abstract class Switch
{
	[Token(Token = "0x4000459")]
	private static List<WeakReference> switches; //Field offset: 0x0
	[Token(Token = "0x400045A")]
	private static int s_LastCollectionCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000455")]
	private readonly string description; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000456")]
	private readonly string displayName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000457")]
	private string switchValueString; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000458")]
	private string defaultValue; //Field offset: 0x28

	[Address(RVA = "0x263DA60", Offset = "0x263CE60", Length = "0x495")]
	[Token(Token = "0x600061C")]
	private static void _pruneCachedSwitches() { }

	[Address(RVA = "0x263D700", Offset = "0x263CB00", Length = "0x84")]
	[Token(Token = "0x600061D")]
	private static Switch() { }

	[Address(RVA = "0x263D790", Offset = "0x263CB90", Length = "0x62")]
	[Token(Token = "0x600061A")]
	protected Switch(string displayName, string description) { }

	[Address(RVA = "0x263D800", Offset = "0x263CC00", Length = "0x25E")]
	[Token(Token = "0x600061B")]
	protected Switch(string displayName, string description, string defaultSwitchValue) { }

}

