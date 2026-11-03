namespace UnityEngine.Events;

[Token(Token = "0x2000241")]
public sealed class UnityAction : MulticastDelegate
{

	[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
	[Token(Token = "0x6001804")]
	public UnityAction(object object, IntPtr method) { }

	[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
	[Token(Token = "0x6001805")]
	public override void Invoke() { }

}

