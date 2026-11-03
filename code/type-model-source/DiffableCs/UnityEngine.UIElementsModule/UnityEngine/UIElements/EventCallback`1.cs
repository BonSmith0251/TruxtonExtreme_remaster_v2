namespace UnityEngine.UIElements;

[Token(Token = "0x20001C9")]
public sealed class EventCallback : MulticastDelegate
{

	[Address(RVA = "0x5BC6F0", Offset = "0x5BBAF0", Length = "0x124")]
	[Token(Token = "0x6000D06")]
	public EventCallback`1(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6000D07")]
	public override void Invoke(TEventType evt) { }

}

