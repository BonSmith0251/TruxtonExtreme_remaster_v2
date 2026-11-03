namespace InGame.Kernel;

[Token(Token = "0x200000D")]
public class InGameBulletAnime
{
	[Token(Token = "0x400004A")]
	private static readonly int _divideH; //Field offset: 0x0
	[Token(Token = "0x400004B")]
	private static readonly int _divideV; //Field offset: 0x4
	[Token(Token = "0x4000055")]
	private static readonly int _PropertyID_AIndex; //Field offset: 0x8
	[Token(Token = "0x4000056")]
	private static readonly int _PropertyID_DividedH; //Field offset: 0xC
	[Token(Token = "0x4000057")]
	private static readonly int _PropertyID_DividedV; //Field offset: 0x10
	[Token(Token = "0x4000058")]
	private static readonly int TintColorPropertyId; //Field offset: 0x14
	[Token(Token = "0x4000059")]
	private static readonly Color DefaultColor; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004C")]
	private BulletKind _bkind; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004D")]
	private Material _bmat; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004E")]
	private int _pat; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400004F")]
	private int _patMax; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000050")]
	private float _psec; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000051")]
	private float _secMax; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000052")]
	private float _Alhpa; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000053")]
	private bool _isAlpha; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000054")]
	private Color _color; //Field offset: 0x38

	[Token(Token = "0x1700001A")]
	public Material BMat
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600008F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1CC9650", Offset = "0x1CC8A50", Length = "0xE1")]
	[Token(Token = "0x600008C")]
	private void _setupMaterial() { }

	[Address(RVA = "0x1CC9740", Offset = "0x1CC8B40", Length = "0x7D")]
	[Token(Token = "0x600008D")]
	private void _updateMaterial() { }

	[Address(RVA = "0x1CC9350", Offset = "0x1CC8750", Length = "0x114")]
	[Token(Token = "0x6000090")]
	private static InGameBulletAnime() { }

	[Address(RVA = "0x1CC9470", Offset = "0x1CC8870", Length = "0x1DD")]
	[Token(Token = "0x600008A")]
	public InGameBulletAnime(BulletKind bkind, Material tmat, int npat) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600008F")]
	public Material get_BMat() { }

	[Address(RVA = "0x1CC9160", Offset = "0x1CC8560", Length = "0x2F")]
	[Token(Token = "0x600008E")]
	private float GetBulletAnimeSecond(BulletKind bkind) { }

	[Address(RVA = "0x1CC9190", Offset = "0x1CC8590", Length = "0x1BC")]
	[Token(Token = "0x600008B")]
	public void ProgressAnime(float dt) { }

}

