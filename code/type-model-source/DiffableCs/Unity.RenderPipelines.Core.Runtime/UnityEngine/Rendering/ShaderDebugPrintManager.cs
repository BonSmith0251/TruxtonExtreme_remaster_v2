namespace UnityEngine.Rendering;

[Token(Token = "0x20000DB")]
public sealed class ShaderDebugPrintManager
{
	[Token(Token = "0x20000DD")]
	private enum DebugValueType : int
	{
		TypeUint = 1,
		TypeInt = 2,
		TypeFloat = 3,
		TypeUint2 = 4,
		TypeInt2 = 5,
		TypeFloat2 = 6,
		TypeUint3 = 7,
		TypeInt3 = 8,
		TypeFloat3 = 9,
		TypeUint4 = 10,
		TypeInt4 = 11,
		TypeFloat4 = 12,
		TypeBool = 13,
	}

	[Token(Token = "0x20000DC")]
	private static class Profiling
	{
		[Token(Token = "0x40002C1")]
		public static readonly ProfilingSampler BufferReadComplete; //Field offset: 0x0

		[Address(RVA = "0x2C1D160", Offset = "0x2C1C560", Length = "0x87")]
		[Token(Token = "0x60007D7")]
		private static Profiling() { }

	}

	[Token(Token = "0x40002B3")]
	private static readonly ShaderDebugPrintManager s_Instance; //Field offset: 0x0
	[Token(Token = "0x40002B4")]
	private const int k_FramesInFlight = 4; //Field offset: 0x0
	[Token(Token = "0x40002B5")]
	private const int k_MaxBufferElements = 16384; //Field offset: 0x0
	[Token(Token = "0x40002C0")]
	private const uint k_TypeHasTag = 128; //Field offset: 0x0
	[Token(Token = "0x40002BD")]
	private static readonly int m_ShaderPropertyIDInputMouse; //Field offset: 0x8
	[Token(Token = "0x40002BE")]
	private static readonly int m_ShaderPropertyIDInputFrame; //Field offset: 0xC
	[Token(Token = "0x40002BF")]
	private static readonly int m_shaderDebugOutputData; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002B6")]
	private List<GraphicsBuffer> m_OutputBuffers; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002B7")]
	private List<AsyncGPUReadbackRequest> m_ReadbackRequests; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002B8")]
	private Action<AsyncGPUReadbackRequest> m_BufferReadCompleteAction; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002B9")]
	private int m_FrameCounter; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40002BA")]
	private bool m_FrameCleared; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002BB")]
	private string m_OutputLine; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002BC")]
	private Action<String> m_OutputAction; //Field offset: 0x38

	[Token(Token = "0x170000C7")]
	public static ShaderDebugPrintManager instance
	{
		[Address(RVA = "0x2BE9690", Offset = "0x2BE8A90", Length = "0x4E")]
		[Token(Token = "0x60007CC")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170000C9")]
	public Action<String> outputAction
	{
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x60007D4")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000C8")]
	public string outputLine
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60007D3")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2BE92A0", Offset = "0x2BE86A0", Length = "0xE9")]
	[Token(Token = "0x60007D6")]
	private static ShaderDebugPrintManager() { }

	[Address(RVA = "0x2BE9390", Offset = "0x2BE8790", Length = "0x2F3")]
	[Token(Token = "0x60007CB")]
	private ShaderDebugPrintManager() { }

	[Address(RVA = "0x2BE7E70", Offset = "0x2BE7270", Length = "0x3BC")]
	[Token(Token = "0x60007D0")]
	private void BufferReadComplete(AsyncGPUReadbackRequest request) { }

	[Address(RVA = "0x2BE8C20", Offset = "0x2BE8020", Length = "0xF7")]
	[Token(Token = "0x60007CF")]
	private void ClearShaderDebugPrintBuffer() { }

	[Address(RVA = "0x2BE8D20", Offset = "0x2BE8120", Length = "0x18")]
	[Token(Token = "0x60007CA")]
	private int DebugValueTypeToElemSize(DebugValueType type) { }

	[Address(RVA = "0x2BE8D90", Offset = "0x2BE8190", Length = "0x49")]
	[Token(Token = "0x60007D5")]
	public void DefaultOutput(string line) { }

	[Address(RVA = "0x2BE8DE0", Offset = "0x2BE81E0", Length = "0xBA")]
	[Token(Token = "0x60007D1")]
	public void EndFrame() { }

	[Address(RVA = "0x2BE9690", Offset = "0x2BE8A90", Length = "0x4E")]
	[Token(Token = "0x60007CC")]
	public static ShaderDebugPrintManager get_instance() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60007D3")]
	public string get_outputLine() { }

	[Address(RVA = "0x2BE8EA0", Offset = "0x2BE82A0", Length = "0xB4")]
	[Token(Token = "0x60007D2")]
	public void PrintImmediate() { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x60007D4")]
	public void set_outputAction(Action<String> value) { }

	[Address(RVA = "0x2BE8F60", Offset = "0x2BE8360", Length = "0x235")]
	[Token(Token = "0x60007CE")]
	public void SetShaderDebugPrintBindings(CommandBuffer cmd) { }

	[Address(RVA = "0x2BE91A0", Offset = "0x2BE85A0", Length = "0xF0")]
	[Token(Token = "0x60007CD")]
	public void SetShaderDebugPrintInputConstants(CommandBuffer cmd, ShaderDebugPrintInput input) { }

}

