namespace UnityEngine.UI;

[ExecuteAlways]
[Token(Token = "0x2000083")]
public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000270")]
	private Graphic m_Graphic; //Field offset: 0x20

	[Token(Token = "0x17000155")]
	protected Graphic graphic
	{
		[Address(RVA = "0x344AAE0", Offset = "0x3449EE0", Length = "0x8D")]
		[Token(Token = "0x6000535")]
		 get { } //Length: 141
	}

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x600053B")]
	protected BaseMeshEffect() { }

	[Address(RVA = "0x344AAE0", Offset = "0x3449EE0", Length = "0x8D")]
	[Token(Token = "0x6000535")]
	protected Graphic get_graphic() { }

	[Address(RVA = "0x344A6B0", Offset = "0x3449AB0", Length = "0x245")]
	[Token(Token = "0x6000539")]
	public override void ModifyMesh(Mesh mesh) { }

	[Token(Token = "0x600053A")]
	public abstract void ModifyMesh(VertexHelper vh) { }

	[Address(RVA = "0x344A900", Offset = "0x3449D00", Length = "0x9B")]
	[Token(Token = "0x6000538")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x344A9A0", Offset = "0x3449DA0", Length = "0x9B")]
	[Token(Token = "0x6000537")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x344AA40", Offset = "0x3449E40", Length = "0x9C")]
	[Token(Token = "0x6000536")]
	protected virtual void OnEnable() { }

}

