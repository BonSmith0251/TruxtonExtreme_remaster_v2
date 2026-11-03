namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Multiple Position Binder")]
[Token(Token = "0x2000056")]
[VFXBinder("Point Cache/Multiple Position Binder")]
internal class VFXMultiplePositionBinder : VFXBinderBase
{
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("PositionMapParameter")]
	[Token(Token = "0x40001BD")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEngine.Texture2D"})]
	public ExposedProperty PositionMapProperty; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("PositionCountParameter")]
	[Token(Token = "0x40001BE")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Int32"})]
	public ExposedProperty PositionCountProperty; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001BF")]
	public GameObject[] Targets; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001C0")]
	public bool EveryFrame; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001C1")]
	private Texture2D positionMap; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001C2")]
	private int count; //Field offset: 0x50

	[Address(RVA = "0x2F7E470", Offset = "0x2F7D870", Length = "0x7C")]
	[Token(Token = "0x6000182")]
	public VFXMultiplePositionBinder() { }

	[Address(RVA = "0x2F7DDD0", Offset = "0x2F7D1D0", Length = "0x6C")]
	[Token(Token = "0x600017E")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F7DE40", Offset = "0x2F7D240", Length = "0x1F")]
	[Token(Token = "0x600017D")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2F7DE60", Offset = "0x2F7D260", Length = "0x55")]
	[Token(Token = "0x6000181")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F7DEC0", Offset = "0x2F7D2C0", Length = "0xA8")]
	[Token(Token = "0x600017F")]
	public virtual void UpdateBinding(VisualEffect component) { }

	[Address(RVA = "0x2F7DF70", Offset = "0x2F7D370", Length = "0x4F9")]
	[Token(Token = "0x6000180")]
	private void UpdateTexture() { }

}

