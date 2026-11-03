namespace Newtonsoft.Json.Bson;

[Token(Token = "0x20001DC")]
internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000856")]
	private readonly List<BsonToken> _children; //Field offset: 0x20

	[Token(Token = "0x170002B5")]
	public virtual BsonType Type
	{
		[Address(RVA = "0x21A91B0", Offset = "0x21A85B0", Length = "0x3")]
		[Token(Token = "0x600100C")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x21A9130", Offset = "0x21A8530", Length = "0x77")]
	[Token(Token = "0x600100F")]
	public BsonArray() { }

	[Address(RVA = "0x21A8FE0", Offset = "0x21A83E0", Length = "0xB6")]
	[Token(Token = "0x600100B")]
	public void Add(BsonToken token) { }

	[Address(RVA = "0x21A91B0", Offset = "0x21A85B0", Length = "0x3")]
	[Token(Token = "0x600100C")]
	public virtual BsonType get_Type() { }

	[Address(RVA = "0x21A90A0", Offset = "0x21A84A0", Length = "0x7D")]
	[Token(Token = "0x600100D")]
	public override IEnumerator<BsonToken> GetEnumerator() { }

	[Address(RVA = "0x21A9120", Offset = "0x21A8520", Length = "0x7")]
	[Token(Token = "0x600100E")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

