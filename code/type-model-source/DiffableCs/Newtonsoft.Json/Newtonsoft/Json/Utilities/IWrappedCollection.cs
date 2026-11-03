namespace Newtonsoft.Json.Utilities;

[Token(Token = "0x200009C")]
internal interface IWrappedCollection : IList, ICollection, IEnumerable
{

	[Nullable(1)]
	[Token(Token = "0x170000AC")]
	public object UnderlyingCollection
	{
		[NullableContext(1)]
		[Token(Token = "0x6000518")]
		 get { } //Length: 0
	}

	[NullableContext(1)]
	[Token(Token = "0x6000518")]
	public object get_UnderlyingCollection() { }

}

