namespace UnityEngine.Rendering;

[Token(Token = "0x20003AB")]
public struct BatchCullingOutput
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B65")]
	public NativeArray<BatchCullingOutputDrawCommands> drawCommands; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B66")]
	public NativeArray<IntPtr> customCullingResult; //Field offset: 0x10

}

