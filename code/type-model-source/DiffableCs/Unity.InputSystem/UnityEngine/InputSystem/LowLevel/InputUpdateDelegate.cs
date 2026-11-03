namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001CC")]
internal sealed class InputUpdateDelegate : MulticastDelegate
{

	[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
	[Token(Token = "0x600112F")]
	public InputUpdateDelegate(object object, IntPtr method) { }

	[Address(RVA = "0x2A115F0", Offset = "0x2A109F0", Length = "0xA2")]
	[Token(Token = "0x6001131")]
	public override IAsyncResult BeginInvoke(InputUpdateType updateType, ref InputEventBuffer eventBuffer, AsyncCallback callback, object object) { }

	[Address(RVA = "0x1116830", Offset = "0x1115C30", Length = "0x1B")]
	[Token(Token = "0x6001132")]
	public override void EndInvoke(ref InputEventBuffer eventBuffer, IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6001130")]
	public override void Invoke(InputUpdateType updateType, ref InputEventBuffer eventBuffer) { }

}

