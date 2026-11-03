namespace Newtonsoft.Json.Bson;

[Token(Token = "0x20001DB")]
internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000855")]
	private readonly List<BsonProperty> _children; //Field offset: 0x20

	[Token(Token = "0x170002B4")]
	public virtual BsonType Type
	{
		[Address(RVA = "0x21AB170", Offset = "0x21AA570", Length = "0x3")]
		[Token(Token = "0x6001007")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x21AB0F0", Offset = "0x21AA4F0", Length = "0x77")]
	[Token(Token = "0x600100A")]
	public BsonObject() { }

	[Address(RVA = "0x21AAEF0", Offset = "0x21AA2F0", Length = "0x165")]
	[Token(Token = "0x6001006")]
	public void Add(string name, BsonToken token) { }

	[Address(RVA = "0x21AB170", Offset = "0x21AA570", Length = "0x3")]
	[Token(Token = "0x6001007")]
	public virtual BsonType get_Type() { }

	[Address(RVA = "0x21AB060", Offset = "0x21AA460", Length = "0x7D")]
	[Token(Token = "0x6001008")]
	public override IEnumerator<BsonProperty> GetEnumerator() { }

	[Address(RVA = "0x21AB0E0", Offset = "0x21AA4E0", Length = "0x7")]
	[Token(Token = "0x6001009")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

