namespace UnityEngine.VFX;

[Token(Token = "0x200000D")]
internal class SpawnOverDistance : VFXSpawnerCallbacks
{
	[Token(Token = "0x200000E")]
	internal class InputProperties
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002B")]
		public Vector3 Position; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400002C")]
		public float RatePerUnit; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400002D")]
		public float VelocityThreshold; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400002E")]
		public bool ClampToOne; //Field offset: 0x24

		[Address(RVA = "0x2F65DC0", Offset = "0x2F651C0", Length = "0x5F")]
		[Token(Token = "0x600001D")]
		public InputProperties() { }

	}

	[Token(Token = "0x4000025")]
	private static readonly int positionPropertyId; //Field offset: 0x0
	[Token(Token = "0x4000026")]
	private static readonly int ratePerUnitPropertyId; //Field offset: 0x4
	[Token(Token = "0x4000027")]
	private static readonly int velocityThresholdPropertyId; //Field offset: 0x8
	[Token(Token = "0x4000028")]
	private static readonly int clampToOnePropertyId; //Field offset: 0xC
	[Token(Token = "0x4000029")]
	private static readonly int positionAttributeId; //Field offset: 0x10
	[Token(Token = "0x400002A")]
	private static readonly int oldPositionAttributeId; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000024")]
	private Vector3 m_OldPosition; //Field offset: 0x18

	[Address(RVA = "0x2F70E50", Offset = "0x2F70250", Length = "0x126")]
	[Token(Token = "0x600001C")]
	private static SpawnOverDistance() { }

	[Address(RVA = "0x1D308B0", Offset = "0x1D2FCB0", Length = "0x7")]
	[Token(Token = "0x600001B")]
	public SpawnOverDistance() { }

	[Address(RVA = "0x2F70A90", Offset = "0x2F6FE90", Length = "0x89")]
	[Token(Token = "0x6000018")]
	public virtual void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600001A")]
	public virtual void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	[Address(RVA = "0x2F70B20", Offset = "0x2F6FF20", Length = "0x327")]
	[Token(Token = "0x6000019")]
	public virtual void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

}

