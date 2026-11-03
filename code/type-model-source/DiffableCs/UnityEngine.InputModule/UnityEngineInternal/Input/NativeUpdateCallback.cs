namespace UnityEngineInternal.Input;

[Token(Token = "0x2000002")]
internal sealed class NativeUpdateCallback : MulticastDelegate
{

	[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
	[Token(Token = "0x6000001")]
	public NativeUpdateCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000002")]
	public override void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

}

