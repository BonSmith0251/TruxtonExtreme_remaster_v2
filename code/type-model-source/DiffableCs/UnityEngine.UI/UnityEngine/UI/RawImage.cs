namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Raw Image", 12)]
[RequireComponent(typeof(CanvasRenderer))]
[Token(Token = "0x200005E")]
public class RawImage : MaskableGraphic
{
	[FieldOffset(Offset = "0xE0")]
	[FormerlySerializedAs("m_Tex")]
	[SerializeField]
	[Token(Token = "0x40001B3")]
	private Texture m_Texture; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x40001B4")]
	private Rect m_UVRect; //Field offset: 0xE8

	[Token(Token = "0x170000E4")]
	public virtual Texture mainTexture
	{
		[Address(RVA = "0x344C260", Offset = "0x344B660", Length = "0x1C1")]
		[Token(Token = "0x600037E")]
		 get { } //Length: 449
	}

	[Token(Token = "0x170000E5")]
	public Texture texture
	{
		[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
		[Token(Token = "0x600037F")]
		 get { } //Length: 8
		[Address(RVA = "0x344C440", Offset = "0x344B840", Length = "0xB1")]
		[Token(Token = "0x6000380")]
		 set { } //Length: 177
	}

	[Token(Token = "0x170000E6")]
	public Rect uvRect
	{
		[Address(RVA = "0x344C430", Offset = "0x344B830", Length = "0xE")]
		[Token(Token = "0x6000381")]
		 get { } //Length: 14
		[Address(RVA = "0x344C500", Offset = "0x344B900", Length = "0xCA")]
		[Token(Token = "0x6000382")]
		 set { } //Length: 202
	}

	[Address(RVA = "0x344C230", Offset = "0x344B630", Length = "0x2C")]
	[Token(Token = "0x600037D")]
	protected RawImage() { }

	[Address(RVA = "0x344C260", Offset = "0x344B660", Length = "0x1C1")]
	[Token(Token = "0x600037E")]
	public virtual Texture get_mainTexture() { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[Token(Token = "0x600037F")]
	public Texture get_texture() { }

	[Address(RVA = "0x344C430", Offset = "0x344B830", Length = "0xE")]
	[Token(Token = "0x6000381")]
	public Rect get_uvRect() { }

	[Address(RVA = "0x31E92F0", Offset = "0x31E86F0", Length = "0x41")]
	[Token(Token = "0x6000385")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x344BD00", Offset = "0x344B100", Length = "0x39E")]
	[Token(Token = "0x6000384")]
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	[Address(RVA = "0x344C440", Offset = "0x344B840", Length = "0xB1")]
	[Token(Token = "0x6000380")]
	public void set_texture(Texture value) { }

	[Address(RVA = "0x344C500", Offset = "0x344B900", Length = "0xCA")]
	[Token(Token = "0x6000382")]
	public void set_uvRect(Rect value) { }

	[Address(RVA = "0x344C0A0", Offset = "0x344B4A0", Length = "0x18C")]
	[Token(Token = "0x6000383")]
	public virtual void SetNativeSize() { }

}

