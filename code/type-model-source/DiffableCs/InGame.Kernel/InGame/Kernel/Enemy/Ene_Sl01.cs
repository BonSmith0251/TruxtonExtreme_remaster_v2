namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000207")]
public class Ene_Sl01 : MonoBehaviour, IEnemyUpdater
{
	[Token(Token = "0x4001249")]
	private const float _AppearPhaseDuration = 1; //Field offset: 0x0
	[Token(Token = "0x400124A")]
	private const float _DisappearPhaseDuration = 1; //Field offset: 0x0
	[Token(Token = "0x400124B")]
	private const float _FadeDuration = 0.8; //Field offset: 0x0
	[Token(Token = "0x400124C")]
	private const float _ScaleDuration = 0.3; //Field offset: 0x0
	[Token(Token = "0x400124D")]
	private const float _LaserDuration = 3; //Field offset: 0x0
	[Token(Token = "0x400124E")]
	private const float _CamoIntensityMin = 0; //Field offset: 0x0
	[Token(Token = "0x400124F")]
	private const float _CamoIntensityMax = 300; //Field offset: 0x0
	[Token(Token = "0x4001250")]
	private const float _CamoIntensityRange = 300; //Field offset: 0x0
	[Token(Token = "0x4001251")]
	private static readonly int _PropertyTransparency; //Field offset: 0x0
	[Token(Token = "0x4001252")]
	private static readonly int _PropertyIntensity; //Field offset: 0x4
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4001253")]
	private Transform _mainModel; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4001254")]
	private GameObject _camoEffect; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4001255")]
	private ParticleSystem _warpEffect; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4001256")]
	private ParticleSystem[] _jetEffects; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001257")]
	private Material _camoMaterial; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001258")]
	private Transform _warpTransform; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001259")]
	private InGameObject _objInfo; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400125A")]
	private EnePartsGroup _pparts; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400125B")]
	private float _phaseTime; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400125C")]
	private int _localMode; //Field offset: 0x64

	[Address(RVA = "0x1D020B0", Offset = "0x1D014B0", Length = "0x9A")]
	[Token(Token = "0x6000F5D")]
	private void _PlayJetEffect(bool isPlay) { }

	[Address(RVA = "0x1D02150", Offset = "0x1D01550", Length = "0x7A")]
	[Token(Token = "0x6000F63")]
	private static Ene_Sl01() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000F62")]
	public Ene_Sl01() { }

	[Address(RVA = "0x1D01A30", Offset = "0x1D00E30", Length = "0x8")]
	[Token(Token = "0x6000F60")]
	private float EaseInQuad(float v) { }

	[Address(RVA = "0x1D01A40", Offset = "0x1D00E40", Length = "0x18")]
	[Token(Token = "0x6000F61")]
	private float EaseOutQuad(float v) { }

	[Address(RVA = "0x1D01C10", Offset = "0x1D01010", Length = "0x2E5")]
	[Token(Token = "0x6000F58")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F5B")]
	public override void ProgressDisable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F5A")]
	public override void ProgressEnd() { }

	[Address(RVA = "0x1D01A60", Offset = "0x1D00E60", Length = "0x120")]
	[Token(Token = "0x6000F55")]
	public override void ProgressInitialize() { }

	[Address(RVA = "0x1CFEBB0", Offset = "0x1CFDFB0", Length = "0x6")]
	[Token(Token = "0x6000F5C")]
	public override int ProgressPriority() { }

	[Address(RVA = "0x1D01B90", Offset = "0x1D00F90", Length = "0x49")]
	[Token(Token = "0x6000F56")]
	public override void ProgressReset() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F57")]
	public override void ProgressStart() { }

	[Address(RVA = "0x1D01BE0", Offset = "0x1D00FE0", Length = "0x2B")]
	[Token(Token = "0x6000F59")]
	public override void ProgressTerminate() { }

	[Address(RVA = "0x1D01F00", Offset = "0x1D01300", Length = "0x144")]
	[Token(Token = "0x6000F5F")]
	private void SetCamoScale(float normalizedScale) { }

	[Address(RVA = "0x1D02050", Offset = "0x1D01450", Length = "0x53")]
	[Token(Token = "0x6000F5E")]
	private void SetScale(float normalizedScale) { }

}

