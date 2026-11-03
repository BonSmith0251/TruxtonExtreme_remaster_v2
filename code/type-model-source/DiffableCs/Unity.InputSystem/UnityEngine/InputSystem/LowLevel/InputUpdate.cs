namespace UnityEngine.InputSystem.LowLevel;

[Extension]
[Token(Token = "0x20001D2")]
internal static class InputUpdate
{
	[Token(Token = "0x20001D4")]
	internal struct SerializedState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A92")]
		public InputUpdateType lastUpdateType; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000A93")]
		public UpdateStepCount playerUpdateStepCount; //Field offset: 0x4

	}

	[Token(Token = "0x20001D3")]
	internal struct UpdateStepCount
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A90")]
		private bool m_WasUpdated; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000A91")]
		private uint <value>k__BackingField; //Field offset: 0x4

		[Token(Token = "0x170004FE")]
		public private uint value
		{
			[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6001171")]
			 get { } //Length: 4
			[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001172")]
			private set { } //Length: 4
		}

		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001171")]
		public uint get_value() { }

		[Address(RVA = "0x2A175F0", Offset = "0x2A169F0", Length = "0x7")]
		[Token(Token = "0x6001173")]
		public void OnBeforeUpdate() { }

		[Address(RVA = "0x2A17600", Offset = "0x2A16A00", Length = "0xC")]
		[Token(Token = "0x6001174")]
		public void OnUpdate() { }

		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001172")]
		private void set_value(uint value) { }

	}

	[Token(Token = "0x4000A8D")]
	public static uint s_UpdateStepCount; //Field offset: 0x0
	[Token(Token = "0x4000A8E")]
	public static InputUpdateType s_LatestUpdateType; //Field offset: 0x4
	[Token(Token = "0x4000A8F")]
	public static UpdateStepCount s_PlayerUpdateStepCount; //Field offset: 0x8

	[Address(RVA = "0x2A116A0", Offset = "0x2A10AA0", Length = "0x1C")]
	[Extension]
	[Token(Token = "0x600116F")]
	public static InputUpdateType GetUpdateTypeForPlayer(InputUpdateType mask) { }

	[Address(RVA = "0x2A116C0", Offset = "0x2A10AC0", Length = "0xE")]
	[Extension]
	[Token(Token = "0x6001170")]
	public static bool IsPlayerUpdate(InputUpdateType updateType) { }

	[Address(RVA = "0x2A116D0", Offset = "0x2A10AD0", Length = "0x70")]
	[Token(Token = "0x600116B")]
	internal static void OnBeforeUpdate(InputUpdateType type) { }

	[Address(RVA = "0x2A11740", Offset = "0x2A10B40", Length = "0x76")]
	[Token(Token = "0x600116C")]
	internal static void OnUpdate(InputUpdateType type) { }

	[Address(RVA = "0x2A117C0", Offset = "0x2A10BC0", Length = "0x94")]
	[Token(Token = "0x600116E")]
	public static void Restore(SerializedState state) { }

	[Address(RVA = "0x2A11860", Offset = "0x2A10C60", Length = "0x49")]
	[Token(Token = "0x600116D")]
	public static SerializedState Save() { }

}

