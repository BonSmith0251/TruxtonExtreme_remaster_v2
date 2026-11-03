namespace System.Threading;

[Token(Token = "0x20001F1")]
internal interface IAsyncLocal
{

	[Token(Token = "0x6001178")]
	public void OnValueChanged(object previousValue, object currentValue, bool contextChanged) { }

}

