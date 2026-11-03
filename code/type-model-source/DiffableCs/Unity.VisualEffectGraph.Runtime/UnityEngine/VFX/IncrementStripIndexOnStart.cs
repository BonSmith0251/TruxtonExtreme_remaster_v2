namespace UnityEngine.VFX;

[Token(Token = "0x2000008")]
internal class IncrementStripIndexOnStart : VFXSpawnerCallbacks
{
	[Token(Token = "0x2000009")]
	internal class InputProperties
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000019")]
		[Tooltip("Maximum Strip Count (Used to cycle indices)")]
		public uint StripMaxCount; //Field offset: 0x10

		[Address(RVA = "0x2E74A60", Offset = "0x2E73E60", Length = "0xE")]
		[Token(Token = "0x600000C")]
		public InputProperties() { }

	}

	[Token(Token = "0x4000016")]
	private static readonly int stripMaxCountID; //Field offset: 0x0
	[Token(Token = "0x4000017")]
	private static readonly int stripIndexID; //Field offset: 0x4
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000018")]
	private uint m_Index; //Field offset: 0x18

	[Address(RVA = "0x2F65D20", Offset = "0x2F65120", Length = "0x7A")]
	[Token(Token = "0x600000B")]
	private static IncrementStripIndexOnStart() { }

	[Address(RVA = "0x1D308B0", Offset = "0x1D2FCB0", Length = "0x7")]
	[Token(Token = "0x600000A")]
	public IncrementStripIndexOnStart() { }

	[Address(RVA = "0x2F65C10", Offset = "0x2F65010", Length = "0x103")]
	[Token(Token = "0x6000007")]
	public virtual void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	[Address(RVA = "0x5C4B80", Offset = "0x5C3F80", Length = "0x8")]
	[Token(Token = "0x6000008")]
	public virtual void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000009")]
	public virtual void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

}

