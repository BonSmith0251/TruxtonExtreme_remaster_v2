namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001DF")]
internal struct InputStateBuffers
{
	[Token(Token = "0x20001E0")]
	public struct DoubleBuffers
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AD8")]
		public Void** deviceToBufferMapping; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AD9")]
		public int deviceCount; //Field offset: 0x8

		[Token(Token = "0x1700051B")]
		public bool valid
		{
			[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
			[Token(Token = "0x60011D8")]
			 get { } //Length: 8
		}

		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[Token(Token = "0x60011D8")]
		public bool get_valid() { }

		[Address(RVA = "0x2A05930", Offset = "0x2A04D30", Length = "0x1A")]
		[Token(Token = "0x60011DC")]
		public Void* GetBackBuffer(int deviceIndex) { }

		[Address(RVA = "0x2A05950", Offset = "0x2A04D50", Length = "0x19")]
		[Token(Token = "0x60011DB")]
		public Void* GetFrontBuffer(int deviceIndex) { }

		[Address(RVA = "0x2A05970", Offset = "0x2A04D70", Length = "0x14")]
		[Token(Token = "0x60011DA")]
		public void SetBackBuffer(int deviceIndex, Void* ptr) { }

		[Address(RVA = "0x2A05990", Offset = "0x2A04D90", Length = "0x13")]
		[Token(Token = "0x60011D9")]
		public void SetFrontBuffer(int deviceIndex, Void* ptr) { }

		[Address(RVA = "0x2A059B0", Offset = "0x2A04DB0", Length = "0x60")]
		[Token(Token = "0x60011DD")]
		public void SwapBuffers(int deviceIndex) { }

	}

	[Token(Token = "0x4000AD4")]
	internal static Void* s_DefaultStateBuffer; //Field offset: 0x0
	[Token(Token = "0x4000AD5")]
	internal static Void* s_NoiseMaskBuffer; //Field offset: 0x8
	[Token(Token = "0x4000AD6")]
	internal static Void* s_ResetMaskBuffer; //Field offset: 0x10
	[Token(Token = "0x4000AD7")]
	internal static DoubleBuffers s_CurrentBuffers; //Field offset: 0x18
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000ACD")]
	public uint sizePerBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000ACE")]
	public uint totalSize; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000ACF")]
	public Void* defaultStateBuffer; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AD0")]
	public Void* noiseMaskBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AD1")]
	public Void* resetMaskBuffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AD2")]
	private Void* m_AllBuffers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000AD3")]
	internal DoubleBuffers m_PlayerStateBuffers; //Field offset: 0x28

	[Address(RVA = "0x2A0DDA0", Offset = "0x2A0D1A0", Length = "0x15B")]
	[Token(Token = "0x60011D0")]
	public void AllocateAll(InputDevice[] devices, int deviceCount) { }

	[Address(RVA = "0x2A0DF00", Offset = "0x2A0D300", Length = "0x17C")]
	[Token(Token = "0x60011D6")]
	private static uint ComputeSizeOfSingleStateBuffer(InputDevice[] devices, int deviceCount) { }

	[Address(RVA = "0x2A0E080", Offset = "0x2A0D480", Length = "0xCB")]
	[Token(Token = "0x60011D2")]
	public void FreeAll() { }

	[Address(RVA = "0x2A0E150", Offset = "0x2A0D550", Length = "0x54")]
	[Token(Token = "0x60011CE")]
	public static Void* GetBackBufferForDevice(int deviceIndex) { }

	[Address(RVA = "0x2A0E1B0", Offset = "0x2A0D5B0", Length = "0xD6")]
	[Token(Token = "0x60011CC")]
	public DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType) { }

	[Address(RVA = "0x2A0E290", Offset = "0x2A0D690", Length = "0x53")]
	[Token(Token = "0x60011CD")]
	public static Void* GetFrontBufferForDevice(int deviceIndex) { }

	[Address(RVA = "0x2A0E2F0", Offset = "0x2A0D6F0", Length = "0x1CE")]
	[Token(Token = "0x60011D3")]
	public void MigrateAll(InputDevice[] devices, int deviceCount, InputStateBuffers oldBuffers) { }

	[Address(RVA = "0x2A0E4C0", Offset = "0x2A0D8C0", Length = "0x1C8")]
	[Token(Token = "0x60011D4")]
	private static void MigrateDoubleBuffer(DoubleBuffers newBuffer, InputDevice[] devices, int deviceCount, DoubleBuffers oldBuffer) { }

	[Address(RVA = "0x2A0E690", Offset = "0x2A0DA90", Length = "0x130")]
	[Token(Token = "0x60011D5")]
	private static void MigrateSingleBuffer(Void* newBuffer, InputDevice[] devices, int deviceCount, Void* oldBuffer) { }

	[Address(RVA = "0x2A0E7D0", Offset = "0x2A0DBD0", Length = "0x10A")]
	[Token(Token = "0x60011D7")]
	private static uint NextDeviceOffset(uint currentOffset, InputDevice device) { }

	[Address(RVA = "0x2A0E8E0", Offset = "0x2A0DCE0", Length = "0x84")]
	[Token(Token = "0x60011D1")]
	private static DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref Byte* bufferPtr, uint sizePerBuffer, uint mappingTableSizePerBuffer) { }

	[Address(RVA = "0x2A0E970", Offset = "0x2A0DD70", Length = "0x5E")]
	[Token(Token = "0x60011CF")]
	public static void SwitchTo(InputStateBuffers buffers, InputUpdateType update) { }

}

