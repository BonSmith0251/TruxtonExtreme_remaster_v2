namespace InGame.Kernel.Shader;

[RequireComponent(typeof(Renderer))]
[Token(Token = "0x2000106")]
public class ShaderFunction_UVAnime : MonoBehaviour
{
	[Flags]
	[Token(Token = "0x2000107")]
	private enum AnimeAttribute : int
	{
		None = 0,
		Once = 1,
		Reverse = 256,
		RandomReverse = 65536,
	}

	[Token(Token = "0x4000726")]
	private static readonly int _PropertyID_MainTex; //Field offset: 0x0
	[Token(Token = "0x4000727")]
	private static readonly int _PropertyID_AIndex; //Field offset: 0x4
	[Token(Token = "0x4000728")]
	private static readonly int _PropertyID_DividedH; //Field offset: 0x8
	[Token(Token = "0x4000729")]
	private static readonly int _PropertyID_DividedV; //Field offset: 0xC
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400072A")]
	private Material _material; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400072B")]
	private LineRenderer _lineRenderer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400072C")]
	private Renderer _Renderer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400072D")]
	private int _animationIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400072E")]
	private int _animationIndexBefo; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400072F")]
	private int _animationIndexMax; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Range(1, 32)]
	[SerializeField]
	[Token(Token = "0x4000730")]
	private int _animationDivide; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Range(1, 32)]
	[SerializeField]
	[Token(Token = "0x4000731")]
	private int _animationDivideV; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000732")]
	private float _DisplaySecondMax; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000733")]
	private float _DisplaySecond; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x4000734")]
	private bool _isOffset; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000735")]
	private Vector2 _texOffset; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000736")]
	private Vector2 _currentOffset; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000737")]
	private AnimeAttribute _attribute; //Field offset: 0x68

	[Address(RVA = "0x1D51260", Offset = "0x1D50660", Length = "0xE1")]
	[Token(Token = "0x600081C")]
	private void _updateMaterial() { }

	[Address(RVA = "0x1D510E0", Offset = "0x1D504E0", Length = "0xD0")]
	[Token(Token = "0x600081E")]
	private static ShaderFunction_UVAnime() { }

	[Address(RVA = "0x1D511B0", Offset = "0x1D505B0", Length = "0xAD")]
	[Token(Token = "0x600081D")]
	public ShaderFunction_UVAnime() { }

	[Address(RVA = "0x1D50C50", Offset = "0x1D50050", Length = "0x6B")]
	[Token(Token = "0x6000817")]
	public void Initialize() { }

	[Address(RVA = "0x1D50CC0", Offset = "0x1D500C0", Length = "0x1E4")]
	[Token(Token = "0x600081B")]
	public void Progress(float dt) { }

	[Address(RVA = "0x1D50EB0", Offset = "0x1D502B0", Length = "0x1B0")]
	[Token(Token = "0x6000818")]
	public void SetMaterial(Material tmaterial) { }

	[Address(RVA = "0x1D51070", Offset = "0x1D50470", Length = "0x46")]
	[Token(Token = "0x600081A")]
	public void Setup() { }

	[Address(RVA = "0x1D510C0", Offset = "0x1D504C0", Length = "0x13")]
	[Token(Token = "0x6000819")]
	public void Terminate() { }

}

