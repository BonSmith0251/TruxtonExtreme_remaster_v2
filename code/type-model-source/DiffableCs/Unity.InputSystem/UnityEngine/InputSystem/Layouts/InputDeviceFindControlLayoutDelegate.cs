namespace UnityEngine.InputSystem.Layouts;

[Token(Token = "0x20001FB")]
public sealed class InputDeviceFindControlLayoutDelegate : MulticastDelegate
{

	[Address(RVA = "0x2A0AF10", Offset = "0x2A0A310", Length = "0xB5")]
	[Token(Token = "0x60012B4")]
	public InputDeviceFindControlLayoutDelegate(object object, IntPtr method) { }

	[Address(RVA = "0x2A0AE70", Offset = "0x2A0A270", Length = "0x93")]
	[Token(Token = "0x60012B6")]
	public override IAsyncResult BeginInvoke(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand, AsyncCallback callback, object object) { }

	[Address(RVA = "0x1116830", Offset = "0x1115C30", Length = "0x1B")]
	[Token(Token = "0x60012B7")]
	public override string EndInvoke(ref InputDeviceDescription description, IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x60012B5")]
	public override string Invoke(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

}

