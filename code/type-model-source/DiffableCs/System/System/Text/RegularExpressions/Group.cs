namespace System.Text.RegularExpressions;

[Token(Token = "0x20000D9")]
public class Group : Capture
{
	[Token(Token = "0x400034E")]
	internal static readonly Group s_emptyGroup; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400034F")]
	internal readonly Int32[] _caps; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000350")]
	internal int _capcount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000351")]
	internal CaptureCollection _capcoll; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000352")]
	private readonly string <Name>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x170000C1")]
	public bool Success
	{
		[Address(RVA = "0x2617D60", Offset = "0x2617160", Length = "0x8")]
		[Token(Token = "0x600047C")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2617B10", Offset = "0x2616F10", Length = "0x14E")]
	[Token(Token = "0x600047D")]
	private static Group() { }

	[Address(RVA = "0x2617C90", Offset = "0x2617090", Length = "0xCA")]
	[Token(Token = "0x600047B")]
	internal Group(string text, Int32[] caps, int capcount, string name) { }

	[Address(RVA = "0x2617C60", Offset = "0x2617060", Length = "0x2C")]
	[Token(Token = "0x600047E")]
	internal Group() { }

	[Address(RVA = "0x2617D60", Offset = "0x2617160", Length = "0x8")]
	[Token(Token = "0x600047C")]
	public bool get_Success() { }

}

