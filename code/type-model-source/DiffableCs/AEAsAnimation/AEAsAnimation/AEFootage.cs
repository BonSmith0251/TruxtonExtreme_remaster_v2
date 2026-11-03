namespace AEAsAnimation;

[Token(Token = "0x2000030")]
public class AEFootage
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400013F")]
	private FootageData _footage; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000140")]
	private IAETextureAccessor _textures; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000141")]
	private string _baseName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000142")]
	private string _extension; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000143")]
	private int _digit; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000144")]
	private int _start; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000145")]
	private int _count; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000146")]
	private List<Sprite> _sprites; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000147")]
	private Sprite _sprite; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000148")]
	private bool _enable; //Field offset: 0x50

	[Address(RVA = "0x5B42C0", Offset = "0x5B36C0", Length = "0x6E")]
	[Token(Token = "0x60000AA")]
	public AEFootage() { }

	[Address(RVA = "0x5B3B00", Offset = "0x5B2F00", Length = "0x12C")]
	[Token(Token = "0x60000A8")]
	private Sprite Create(int frame = 0) { }

	[Address(RVA = "0x5B3C30", Offset = "0x5B3030", Length = "0x1C")]
	[Token(Token = "0x60000A9")]
	public float GetDuration() { }

	[Address(RVA = "0x5B3C50", Offset = "0x5B3050", Length = "0x203")]
	[Token(Token = "0x60000A7")]
	public Sprite GetSprite(float time = 0) { }

	[Address(RVA = "0x5B3E60", Offset = "0x5B3260", Length = "0x451")]
	[Token(Token = "0x60000A6")]
	public void Setup(FootageData footage, IAETextureAccessor textures, bool isFilterEnable) { }

}

