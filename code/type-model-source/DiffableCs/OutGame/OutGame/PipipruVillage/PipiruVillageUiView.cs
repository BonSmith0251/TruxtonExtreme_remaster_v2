namespace OutGame.PipipruVillage;

[Token(Token = "0x2000102")]
public class PipiruVillageUiView : MonoBehaviour, IDisposable
{
	[Token(Token = "0x400042B")]
	public static readonly float CameraDefaultSize; //Field offset: 0x0
	[Token(Token = "0x400042C")]
	public static readonly float CameraDefaultPosY; //Field offset: 0x4
	[Token(Token = "0x400042D")]
	public static readonly Vector3 CameraDefaultPos; //Field offset: 0x8
	[Token(Token = "0x400042E")]
	public static readonly float CameraZoomRateMax; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400042F")]
	private UITextMeshPro _stageNameFontText; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000430")]
	private UITextMeshPro _aviableLevelFontText; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000431")]
	private TXEBaseWindow _textWindow; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000432")]
	private UITextMeshPro _text; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000433")]
	private ParticleSystem _pipiruEffect; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000434")]
	private float _levelEffectDelaySec; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000435")]
	private float _pipiruEffectDelaySec; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000436")]
	private int _pipiruEffectRepeatTimes; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x4000437")]
	private float _pipiruEffectOffsetX; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000438")]
	private Camera _mainCamera; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000439")]
	private Vector3 _cameraTargetPos; //Field offset: 0x60
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400043A")]
	private Vector3 _cameraCurrentPos; //Field offset: 0x6C
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400043B")]
	private float _cameraTargetSize; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400043C")]
	private float _cameraCurrentSize; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400043D")]
	private Vector3 _pipiruEffectOriginalPos; //Field offset: 0x80

	[Token(Token = "0x17000188")]
	public Vector3 CameraPos
	{
		[Address(RVA = "0x21F4130", Offset = "0x21F3530", Length = "0x10")]
		[Token(Token = "0x6000688")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000185")]
	public float LevelEffectDelaySec
	{
		[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
		[Token(Token = "0x6000685")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000186")]
	public float PipiruEffectDelaySec
	{
		[Address(RVA = "0x21F3FC0", Offset = "0x21F33C0", Length = "0x6")]
		[Token(Token = "0x6000686")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000187")]
	public int PipiruEffectRepeatTimes
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x6000687")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x21F3BE0", Offset = "0x21F2FE0", Length = "0x1DE")]
	[Token(Token = "0x6000681")]
	private void _initializeCamera() { }

	[Address(RVA = "0x21F3DC0", Offset = "0x21F31C0", Length = "0x83")]
	[Token(Token = "0x600067F")]
	private void _setLevelText(int level) { }

	[Address(RVA = "0x21F3E50", Offset = "0x21F3250", Length = "0x15F")]
	[Token(Token = "0x6000682")]
	private void _updateCamera() { }

	[Address(RVA = "0x21F3FB0", Offset = "0x21F33B0", Length = "0x8")]
	[Token(Token = "0x6000680")]
	private void _updateLevelText(int level) { }

	[Address(RVA = "0x21F3B20", Offset = "0x21F2F20", Length = "0x89")]
	[Token(Token = "0x600068A")]
	private static PipiruVillageUiView() { }

	[Address(RVA = "0x21F3BB0", Offset = "0x21F2FB0", Length = "0x23")]
	[Token(Token = "0x6000689")]
	public PipiruVillageUiView() { }

	[Address(RVA = "0x21F3410", Offset = "0x21F2810", Length = "0x28")]
	[Token(Token = "0x6000678")]
	public static void ChangeGuide(int selectLevel, int availableLevel) { }

	[Address(RVA = "0x21F3440", Offset = "0x21F2840", Length = "0x3B")]
	[Token(Token = "0x600067E")]
	public void ClearText(string text) { }

	[Address(RVA = "0x21F3480", Offset = "0x21F2880", Length = "0x31")]
	[Token(Token = "0x600067B")]
	public void CloseWindow() { }

	[Address(RVA = "0x21F34C0", Offset = "0x21F28C0", Length = "0x40")]
	[Token(Token = "0x6000675")]
	public override void Dispose() { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[Token(Token = "0x6000685")]
	public float get_LevelEffectDelaySec() { }

	[Address(RVA = "0x21F3FC0", Offset = "0x21F33C0", Length = "0x6")]
	[Token(Token = "0x6000686")]
	public float get_PipiruEffectDelaySec() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x6000687")]
	public int get_PipiruEffectRepeatTimes() { }

	[Address(RVA = "0x21F3510", Offset = "0x21F2910", Length = "0x20D")]
	[Token(Token = "0x6000672")]
	public void Initialize(int availableLevel) { }

	[Address(RVA = "0x21F3FD0", Offset = "0x21F33D0", Length = "0x15E")]
	[Token(Token = "0x6000683")]
	private void initializeEffect() { }

	[Address(RVA = "0x21F3720", Offset = "0x21F2B20", Length = "0x12")]
	[Token(Token = "0x6000679")]
	public static void MessageWaitGuide(bool display) { }

	[Address(RVA = "0x21F3740", Offset = "0x21F2B40", Length = "0x15")]
	[Token(Token = "0x6000676")]
	public void OnSetCamera(Vector3 pos, float size) { }

	[Address(RVA = "0x21F3760", Offset = "0x21F2B60", Length = "0xDA")]
	[Token(Token = "0x6000677")]
	public void OnSetStageText(int stageNum) { }

	[Address(RVA = "0x21F3840", Offset = "0x21F2C40", Length = "0x4D")]
	[Token(Token = "0x600067A")]
	public void OpenWindow() { }

	[Address(RVA = "0x21F3890", Offset = "0x21F2C90", Length = "0xA5")]
	[Token(Token = "0x6000684")]
	public void PlayEffect(bool isXOffset = false) { }

	[Address(RVA = "0x21F4130", Offset = "0x21F3530", Length = "0x10")]
	[Token(Token = "0x6000688")]
	public void set_CameraPos(Vector3 value) { }

	[Address(RVA = "0x21F3960", Offset = "0x21F2D60", Length = "0x2A")]
	[Token(Token = "0x600067D")]
	public void SetText(string text) { }

	[Address(RVA = "0x21F3940", Offset = "0x21F2D40", Length = "0x1E")]
	[Token(Token = "0x600067C")]
	public void SetTextLabel(string text) { }

	[Address(RVA = "0x21F3990", Offset = "0x21F2D90", Length = "0x7")]
	[Token(Token = "0x6000673")]
	public void StartContent() { }

	[Address(RVA = "0x21F39A0", Offset = "0x21F2DA0", Length = "0x176")]
	[Token(Token = "0x6000674")]
	public void UpdateContent(int level) { }

}

