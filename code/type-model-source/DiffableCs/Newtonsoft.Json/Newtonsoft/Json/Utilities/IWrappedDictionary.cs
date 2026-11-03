namespace Newtonsoft.Json.Utilities;

[Token(Token = "0x20000A7")]
internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
{

	[Nullable(1)]
	[Token(Token = "0x170000B6")]
	public object UnderlyingDictionary
	{
		[NullableContext(1)]
		[Token(Token = "0x6000577")]
		 get { } //Length: 0
	}

	[NullableContext(1)]
	[Token(Token = "0x6000577")]
	public object get_UnderlyingDictionary() { }

}

