namespace Newtonsoft.Json.Bson;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
[Token(Token = "0x20001D6")]
public class BsonObjectId
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000836")]
	private readonly Byte[] <Value>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170002AD")]
	public Byte[] Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000FDB")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x21AAE20", Offset = "0x21AA220", Length = "0xCD")]
	[Token(Token = "0x6000FDC")]
	public BsonObjectId(Byte[] value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000FDB")]
	public Byte[] get_Value() { }

}

