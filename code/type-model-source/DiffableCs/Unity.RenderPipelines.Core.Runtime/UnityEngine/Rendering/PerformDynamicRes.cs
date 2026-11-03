namespace UnityEngine.Rendering;

[Token(Token = "0x2000044")]
public sealed class PerformDynamicRes : MulticastDelegate
{

	[Address(RVA = "0x17CA030", Offset = "0x17C9430", Length = "0xA5")]
	[Token(Token = "0x60004DE")]
	public PerformDynamicRes(object object, IntPtr method) { }

	[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
	[Token(Token = "0x60004E0")]
	public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	[Address(RVA = "0x64F590", Offset = "0x64E990", Length = "0x29")]
	[Token(Token = "0x60004E1")]
	public override float EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
	[Token(Token = "0x60004DF")]
	public override float Invoke() { }

}

