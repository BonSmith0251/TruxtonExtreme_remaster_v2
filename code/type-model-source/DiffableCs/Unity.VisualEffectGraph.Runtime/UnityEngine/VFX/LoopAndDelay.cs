namespace UnityEngine.VFX;

[Token(Token = "0x200000A")]
internal class LoopAndDelay : VFXSpawnerCallbacks
{
	[Token(Token = "0x200000B")]
	internal class InputProperties
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000020")]
		[Tooltip("Number of Loops (< 0 for infinite), evaluated when Context Start is hit")]
		public int LoopCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000021")]
		[Tooltip("Duration of one loop, evaluated every loop")]
		public float LoopDuration; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000022")]
		[Tooltip("Duration of in-between delay (after each loop), evaluated every loop")]
		public float Delay; //Field offset: 0x18

		[Address(RVA = "0x2F65DA0", Offset = "0x2F651A0", Length = "0x1C")]
		[Token(Token = "0x6000012")]
		public InputProperties() { }

	}

	[Token(Token = "0x400001D")]
	private static readonly int loopCountPropertyID; //Field offset: 0x0
	[Token(Token = "0x400001E")]
	private static readonly int loopDurationPropertyID; //Field offset: 0x4
	[Token(Token = "0x400001F")]
	private static readonly int delayPropertyID; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001A")]
	private int m_LoopMaxCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400001B")]
	private int m_LoopCurrentIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001C")]
	private float m_WaitingForTotalTime; //Field offset: 0x20

	[Address(RVA = "0x2F663C0", Offset = "0x2F657C0", Length = "0xA5")]
	[Token(Token = "0x6000011")]
	private static LoopAndDelay() { }

	[Address(RVA = "0x1D308B0", Offset = "0x1D2FCB0", Length = "0x7")]
	[Token(Token = "0x6000010")]
	public LoopAndDelay() { }

	[Address(RVA = "0x2F66180", Offset = "0x2F65580", Length = "0xC4")]
	[Token(Token = "0x600000D")]
	public virtual void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	[Address(RVA = "0x2F66250", Offset = "0x2F65650", Length = "0x7")]
	[Token(Token = "0x600000F")]
	public virtual void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	[Address(RVA = "0x2F66260", Offset = "0x2F65660", Length = "0x15F")]
	[Token(Token = "0x600000E")]
	public virtual void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

}

