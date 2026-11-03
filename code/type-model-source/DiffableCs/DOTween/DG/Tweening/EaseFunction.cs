namespace DG.Tweening;

[Token(Token = "0x2000007")]
public sealed class EaseFunction : MulticastDelegate
{

	[Address(RVA = "0x64F5E0", Offset = "0x64E9E0", Length = "0xA6")]
	[Token(Token = "0x600000D")]
	public EaseFunction(object object, IntPtr method) { }

	[Address(RVA = "0x64F4E0", Offset = "0x64E8E0", Length = "0xAC")]
	[Token(Token = "0x600000F")]
	public override IAsyncResult BeginInvoke(float time, float duration, float overshootOrAmplitude, float period, AsyncCallback callback, object object) { }

	[Address(RVA = "0x64F590", Offset = "0x64E990", Length = "0x29")]
	[Token(Token = "0x6000010")]
	public override float EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x64F5C0", Offset = "0x64E9C0", Length = "0x14")]
	[Token(Token = "0x600000E")]
	public override float Invoke(float time, float duration, float overshootOrAmplitude, float period) { }

}

