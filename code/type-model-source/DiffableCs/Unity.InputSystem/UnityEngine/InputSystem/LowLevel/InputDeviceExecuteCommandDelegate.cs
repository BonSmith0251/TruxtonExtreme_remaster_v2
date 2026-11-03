namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x200017E")]
public sealed class InputDeviceExecuteCommandDelegate : MulticastDelegate
{

	[Address(RVA = "0x10DE7E0", Offset = "0x10DDBE0", Length = "0xB4")]
	[Token(Token = "0x6000FC0")]
	public InputDeviceExecuteCommandDelegate(object object, IntPtr method) { }

	[Address(RVA = "0x29F6800", Offset = "0x29F5C00", Length = "0x80")]
	[Token(Token = "0x6000FC2")]
	public override IAsyncResult BeginInvoke(ref InputDeviceCommand command, AsyncCallback callback, object object) { }

	[Address(RVA = "0x29F6880", Offset = "0x29F5C80", Length = "0x30")]
	[Token(Token = "0x6000FC3")]
	public override long EndInvoke(ref InputDeviceCommand command, IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6000FC1")]
	public override long Invoke(ref InputDeviceCommand command) { }

}

