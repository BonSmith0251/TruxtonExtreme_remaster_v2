namespace Newtonsoft.Json.Linq;

[Token(Token = "0x200017C")]
public class JsonCloneSettings
{
	[Nullable(1)]
	[Token(Token = "0x40006FA")]
	internal static readonly JsonCloneSettings SkipCopyAnnotations; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006FB")]
	private bool <CopyAnnotations>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700020A")]
	public bool CopyAnnotations
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C93")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C94")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2189060", Offset = "0x2188460", Length = "0x6B")]
	[Token(Token = "0x6000C95")]
	private static JsonCloneSettings() { }

	[Address(RVA = "0x21890D0", Offset = "0x21884D0", Length = "0x1A")]
	[Token(Token = "0x6000C92")]
	public JsonCloneSettings() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C93")]
	public bool get_CopyAnnotations() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C94")]
	public void set_CopyAnnotations(bool value) { }

}

