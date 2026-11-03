namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x200017D")]
public sealed class InputDeviceCommandDelegate : MulticastDelegate
{

	[Address(RVA = "0x1C153A0", Offset = "0x1C147A0", Length = "0x125")]
	[Token(Token = "0x6000FBC")]
	public InputDeviceCommandDelegate(object object, IntPtr method) { }

	[Address(RVA = "0x639C50", Offset = "0x639050", Length = "0x31")]
	[Token(Token = "0x6000FBE")]
	public override IAsyncResult BeginInvoke(InputDevice device, InputDeviceCommand* command, AsyncCallback callback, object object) { }

	[Address(RVA = "0x17C9A40", Offset = "0x17C8E40", Length = "0x34")]
	[Token(Token = "0x6000FBF")]
	public override Nullable<Int64> EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x1C14C20", Offset = "0x1C14020", Length = "0x31")]
	[Token(Token = "0x6000FBD")]
	public override Nullable<Int64> Invoke(InputDevice device, InputDeviceCommand* command) { }

}

