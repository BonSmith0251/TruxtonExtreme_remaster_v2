namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000259")]
internal class Observer : IObserver<TValue>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CB9")]
	private Action<TValue> m_OnNext; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CBA")]
	private Action m_OnCompleted; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60015E7")]
	public Observer`1(Action<TValue> onNext, Action onCompleted = null) { }

	[Address(RVA = "0xE106E0", Offset = "0xE0FAE0", Length = "0x19")]
	[Token(Token = "0x60015E8")]
	public override void OnCompleted() { }

	[Address(RVA = "0xE10700", Offset = "0xE0FB00", Length = "0x49")]
	[Token(Token = "0x60015E9")]
	public override void OnError(Exception error) { }

	[Address(RVA = "0xE10750", Offset = "0xE0FB50", Length = "0xDA")]
	[Token(Token = "0x60015EA")]
	public override void OnNext(TValue evt) { }

}

