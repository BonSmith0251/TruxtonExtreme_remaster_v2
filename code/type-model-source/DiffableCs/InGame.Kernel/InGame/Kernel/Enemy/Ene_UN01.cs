namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000212")]
public class Ene_UN01 : MonoBehaviour, IEnemyUpdater
{
	[Token(Token = "0x40012BF")]
	private static readonly float _DisplayTime; //Field offset: 0x0
	[Token(Token = "0x40012C0")]
	private static readonly float _ScaleTime; //Field offset: 0x4
	[Token(Token = "0x40012C1")]
	private static readonly float _CamoAppearTime; //Field offset: 0x8
	[Token(Token = "0x40012C2")]
	private static readonly float _CamoDisappearTime; //Field offset: 0xC
	[Token(Token = "0x40012C3")]
	private static readonly float _CamoIntensityMin; //Field offset: 0x10
	[Token(Token = "0x40012C4")]
	private static readonly float _CamoIntensityMax; //Field offset: 0x14
	[Token(Token = "0x40012C5")]
	private static readonly float _CamoIntensityRange; //Field offset: 0x18
	[Token(Token = "0x40012C6")]
	private static readonly int _PropertyTransparency; //Field offset: 0x1C
	[Token(Token = "0x40012C7")]
	private static readonly int _PropertyIntensity; //Field offset: 0x20
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40012C8")]
	private Transform _mainModel; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40012C9")]
	private GameObject _camoEffect; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40012CA")]
	private ParticleSystem _warpEffect; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40012CB")]
	private ParticleSystem[] _jetEffects; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40012CC")]
	private Material _camoMaterial; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40012CD")]
	private Transform _warpTransform; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40012CE")]
	private InGameObject _objInfo; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40012CF")]
	private EnePartsGroup _pparts; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40012D0")]
	private float _displayTime; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40012D1")]
	private int _localMode; //Field offset: 0x64

	[Address(RVA = "0x1D020B0", Offset = "0x1D014B0", Length = "0x9A")]
	[Token(Token = "0x6000F99")]
	private void _PlayJetEffect(bool isPlay) { }

	[Address(RVA = "0x1D093B0", Offset = "0x1D087B0", Length = "0x11C")]
	[Token(Token = "0x6000FA0")]
	private static Ene_UN01() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000F9F")]
	public Ene_UN01() { }

	[Address(RVA = "0x1D08D30", Offset = "0x1D08130", Length = "0x40")]
	[Token(Token = "0x6000F9E")]
	private float EaseInOutQuad(float v) { }

	[Address(RVA = "0x1D01A30", Offset = "0x1D00E30", Length = "0x8")]
	[Token(Token = "0x6000F9C")]
	private float EaseInQuad(float v) { }

	[Address(RVA = "0x1D01A40", Offset = "0x1D00E40", Length = "0x18")]
	[Token(Token = "0x6000F9D")]
	private float EaseOutQuad(float v) { }

	[Address(RVA = "0x1D08EF0", Offset = "0x1D082F0", Length = "0x27E")]
	[Token(Token = "0x6000F94")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F97")]
	public override void ProgressDisable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F96")]
	public override void ProgressEnd() { }

	[Address(RVA = "0x1D08D70", Offset = "0x1D08170", Length = "0x120")]
	[Token(Token = "0x6000F91")]
	public override void ProgressInitialize() { }

	[Address(RVA = "0x1CFEBB0", Offset = "0x1CFDFB0", Length = "0x6")]
	[Token(Token = "0x6000F98")]
	public override int ProgressPriority() { }

	[Address(RVA = "0x1D08EA0", Offset = "0x1D082A0", Length = "0x4A")]
	[Token(Token = "0x6000F92")]
	public override void ProgressReset() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F93")]
	public override void ProgressStart() { }

	[Address(RVA = "0x1D01BE0", Offset = "0x1D00FE0", Length = "0x2B")]
	[Token(Token = "0x6000F95")]
	public override void ProgressTerminate() { }

	[Address(RVA = "0x1D09170", Offset = "0x1D08570", Length = "0x199")]
	[Token(Token = "0x6000F9B")]
	private void SetCamoScale(float time) { }

	[Address(RVA = "0x1D09310", Offset = "0x1D08710", Length = "0x90")]
	[Token(Token = "0x6000F9A")]
	private void SetScale(float time) { }

}

