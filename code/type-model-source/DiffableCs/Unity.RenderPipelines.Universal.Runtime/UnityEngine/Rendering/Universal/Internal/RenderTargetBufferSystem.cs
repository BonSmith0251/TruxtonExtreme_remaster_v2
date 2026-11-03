namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x2000238")]
internal sealed class RenderTargetBufferSystem
{
	[Token(Token = "0x2000239")]
	private struct SwapBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000DCB")]
		public RTHandle rtMSAA; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000DCC")]
		public RTHandle rtResolve; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000DCD")]
		public string name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000DCE")]
		public int msaa; //Field offset: 0x18

	}

	[Token(Token = "0x4000DC7")]
	private static bool m_AisBackBuffer; //Field offset: 0x0
	[Token(Token = "0x4000DC8")]
	private static RenderTextureDescriptor m_Desc; //Field offset: 0x4
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DC5")]
	private SwapBuffer m_A; //Field offset: 0x10
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000DC6")]
	private SwapBuffer m_B; //Field offset: 0x30
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000DC9")]
	private FilterMode m_FilterMode; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000DCA")]
	private bool m_AllowMSAA; //Field offset: 0x54

	[Token(Token = "0x170002CE")]
	private SwapBuffer backBuffer
	{
		[Address(RVA = "0x2E365F0", Offset = "0x2E359F0", Length = "0x63")]
		[Token(Token = "0x6000C21")]
		private get { } //Length: 99
	}

	[Token(Token = "0x170002CF")]
	private SwapBuffer frontBuffer
	{
		[Address(RVA = "0x2E36660", Offset = "0x2E35A60", Length = "0x63")]
		[Token(Token = "0x6000C22")]
		private get { } //Length: 99
	}

	[Address(RVA = "0x2E36510", Offset = "0x2E35910", Length = "0x36")]
	[Token(Token = "0x6000C2E")]
	private static RenderTargetBufferSystem() { }

	[Address(RVA = "0x2E36550", Offset = "0x2E35950", Length = "0x94")]
	[Token(Token = "0x6000C23")]
	public RenderTargetBufferSystem(string name) { }

	[Address(RVA = "0x2E35B10", Offset = "0x2E34F10", Length = "0x6E")]
	[Token(Token = "0x6000C2A")]
	public void Clear() { }

	[Address(RVA = "0x2E35B80", Offset = "0x2E34F80", Length = "0x54")]
	[Token(Token = "0x6000C24")]
	public void Dispose() { }

	[Address(RVA = "0x2E35BE0", Offset = "0x2E34FE0", Length = "0x7E")]
	[Token(Token = "0x6000C2D")]
	public void EnableMSAA(bool enable) { }

	[Address(RVA = "0x2E365F0", Offset = "0x2E359F0", Length = "0x63")]
	[Token(Token = "0x6000C21")]
	private SwapBuffer get_backBuffer() { }

	[Address(RVA = "0x2E36660", Offset = "0x2E35A60", Length = "0x63")]
	[Token(Token = "0x6000C22")]
	private SwapBuffer get_frontBuffer() { }

	[Address(RVA = "0x2E35C60", Offset = "0x2E35060", Length = "0x12B")]
	[Token(Token = "0x6000C26")]
	public RTHandle GetBackBuffer(CommandBuffer cmd) { }

	[Address(RVA = "0x2E35D90", Offset = "0x2E35190", Length = "0x16")]
	[Token(Token = "0x6000C2C")]
	public RTHandle GetBufferA() { }

	[Address(RVA = "0x2E35DB0", Offset = "0x2E351B0", Length = "0x1F9")]
	[Token(Token = "0x6000C27")]
	public RTHandle GetFrontBuffer(CommandBuffer cmd) { }

	[Address(RVA = "0x2E35FB0", Offset = "0x2E353B0", Length = "0x123")]
	[Token(Token = "0x6000C25")]
	public RTHandle PeekBackBuffer() { }

	[Address(RVA = "0x2E360E0", Offset = "0x2E354E0", Length = "0x293")]
	[Token(Token = "0x6000C29")]
	private void ReAllocate(CommandBuffer cmd) { }

	[Address(RVA = "0x2E36380", Offset = "0x2E35780", Length = "0x12A")]
	[Token(Token = "0x6000C2B")]
	public void SetCameraSettings(RenderTextureDescriptor desc, FilterMode filterMode) { }

	[Address(RVA = "0x2E364B0", Offset = "0x2E358B0", Length = "0x53")]
	[Token(Token = "0x6000C28")]
	public void Swap() { }

}

