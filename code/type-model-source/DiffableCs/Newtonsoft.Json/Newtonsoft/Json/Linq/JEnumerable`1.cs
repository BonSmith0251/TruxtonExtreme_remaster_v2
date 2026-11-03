namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200016B")]
public struct JEnumerable : IJEnumerable<T>, IEnumerable<T>, IEnumerable, IEquatable<JEnumerable`1<T>>
{
	[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
	[Token(Token = "0x40006BD")]
	public static readonly JEnumerable<T> Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006BE")]
	private readonly IEnumerable<T> _enumerable; //Field offset: 0x0

	[Token(Token = "0x170001F0")]
	public override IJEnumerable<JToken> Item
	{
		[Address(RVA = "0xABFE00", Offset = "0xABF200", Length = "0x128")]
		[Token(Token = "0x6000BD3")]
		 get { } //Length: 296
	}

	[Address(RVA = "0xABFC30", Offset = "0xABF030", Length = "0x16E")]
	[Token(Token = "0x6000BD7")]
	private static JEnumerable`1() { }

	[Address(RVA = "0xABFDA0", Offset = "0xABF1A0", Length = "0x56")]
	[Token(Token = "0x6000BD0")]
	public JEnumerable`1(IEnumerable<T> enumerable) { }

	[Address(RVA = "0xABFA50", Offset = "0xABEE50", Length = "0xB")]
	[Token(Token = "0x6000BD4")]
	public override bool Equals(JEnumerable<T> other) { }

	[Address(RVA = "0xABF910", Offset = "0xABED10", Length = "0x13C")]
	[NullableContext(2)]
	[Token(Token = "0x6000BD5")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xABFE00", Offset = "0xABF200", Length = "0x128")]
	[Token(Token = "0x6000BD3")]
	public override IJEnumerable<JToken> get_Item(object key) { }

	[Address(RVA = "0xABFA60", Offset = "0xABEE60", Length = "0x11A")]
	[Token(Token = "0x6000BD1")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0xABFB80", Offset = "0xABEF80", Length = "0x20")]
	[Token(Token = "0x6000BD6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xABFBA0", Offset = "0xABEFA0", Length = "0x84")]
	[Token(Token = "0x6000BD2")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

