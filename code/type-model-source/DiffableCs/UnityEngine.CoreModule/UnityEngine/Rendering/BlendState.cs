namespace UnityEngine.Rendering;

[Token(Token = "0x20003C7")]
public struct BlendState : IEquatable<BlendState>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C0D")]
	private RenderTargetBlendState m_BlendState0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C0E")]
	private RenderTargetBlendState m_BlendState1; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C0F")]
	private RenderTargetBlendState m_BlendState2; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C10")]
	private RenderTargetBlendState m_BlendState3; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C11")]
	private RenderTargetBlendState m_BlendState4; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C12")]
	private RenderTargetBlendState m_BlendState5; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C13")]
	private RenderTargetBlendState m_BlendState6; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C14")]
	private RenderTargetBlendState m_BlendState7; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C15")]
	private byte m_SeparateMRTBlendStates; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000C16")]
	private byte m_AlphaToMask; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4000C17")]
	private short m_Padding; //Field offset: 0x42

	[Token(Token = "0x1700040F")]
	public RenderTargetBlendState blendState0
	{
		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[Token(Token = "0x6001D5B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700040E")]
	public static BlendState defaultValue
	{
		[Address(RVA = "0x30B9F50", Offset = "0x30B9350", Length = "0x7D")]
		[Token(Token = "0x6001D59")]
		 get { } //Length: 125
	}

	[Address(RVA = "0x30B9E40", Offset = "0x30B9240", Length = "0x10B")]
	[Token(Token = "0x6001D5A")]
	public BlendState(bool separateMRTBlend = false, bool alphaToMask = false) { }

	[Address(RVA = "0x30B96A0", Offset = "0x30B8AA0", Length = "0x2C1")]
	[Token(Token = "0x6001D5C")]
	public override bool Equals(BlendState other) { }

	[Address(RVA = "0x30B9970", Offset = "0x30B8D70", Length = "0xB8")]
	[Token(Token = "0x6001D5D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30B9F50", Offset = "0x30B9350", Length = "0x7D")]
	[Token(Token = "0x6001D59")]
	public static BlendState get_defaultValue() { }

	[Address(RVA = "0x30B9A30", Offset = "0x30B8E30", Length = "0x404")]
	[Token(Token = "0x6001D5E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6001D5B")]
	public void set_blendState0(RenderTargetBlendState value) { }

}

