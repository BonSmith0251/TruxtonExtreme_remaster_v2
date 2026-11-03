namespace KANAI.Marquee;

[Token(Token = "0x2000008")]
public class MarqueeManager : MonoBehaviourSingleton<MarqueeManager>
{
	[Token(Token = "0x4000024")]
	private static readonly float GuideBlinkTime; //Field offset: 0x0
	[Token(Token = "0x4000025")]
	private static readonly float GuideBlinkHide; //Field offset: 0x4
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000018")]
	private UITextMeshPro _marqueeTMP; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000019")]
	private CanvasGroup _marqueeGroup; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400001A")]
	private GuideLabel _guideLabel; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400001B")]
	private GuideLabel _guideLabelV; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400001C")]
	private GuideLabel _currentLabel; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400001D")]
	private Stack<List`1<LabelPack>> _guideStack; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400001E")]
	private Stack<String> _marqueeStack; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400001F")]
	private bool _isDisplayMarquee; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000020")]
	private bool _isDisplayGuide; //Field offset: 0x59
	[FieldOffset(Offset = "0x5A")]
	[Token(Token = "0x4000021")]
	private bool _isDisplayH; //Field offset: 0x5A
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000022")]
	private float _marqueeRate; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000023")]
	private float _guideRate; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000026")]
	private float _guideDispSecond; //Field offset: 0x64

	[Token(Token = "0x17000003")]
	public GuideLabel Guide
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600002A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000005")]
	public float GuideAlphaRate
	{
		[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
		[Token(Token = "0x600002C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000004")]
	public bool IsDisplayGuide
	{
		[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
		[Token(Token = "0x600002B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1DFAD90", Offset = "0x1DFA190", Length = "0x45")]
	[Token(Token = "0x6000028")]
	private void _changeGuideRate(float step) { }

	[Address(RVA = "0x1DFADE0", Offset = "0x1DFA1E0", Length = "0x45")]
	[Token(Token = "0x6000026")]
	private void _changeMarqueeRate(float step) { }

	[Address(RVA = "0x1DFAF00", Offset = "0x1DFA300", Length = "0x9A")]
	[Token(Token = "0x6000029")]
	private void _hidden() { }

	[Address(RVA = "0x1DFAFA0", Offset = "0x1DFA3A0", Length = "0x172")]
	[Token(Token = "0x6000027")]
	private void _updateGuide() { }

	[Address(RVA = "0x1DFB120", Offset = "0x1DFA520", Length = "0x84")]
	[Token(Token = "0x6000025")]
	private void _updateMarquee() { }

	[Address(RVA = "0x1DFAD40", Offset = "0x1DFA140", Length = "0x4E")]
	[Token(Token = "0x600002E")]
	private static MarqueeManager() { }

	[Address(RVA = "0x1DFAE30", Offset = "0x1DFA230", Length = "0xCE")]
	[Token(Token = "0x600002D")]
	public MarqueeManager() { }

	[Address(RVA = "0x1DFA300", Offset = "0x1DF9700", Length = "0x1D")]
	[Token(Token = "0x600001D")]
	public override void AdjustGuide() { }

	[Address(RVA = "0x1DFA320", Offset = "0x1DF9720", Length = "0x65")]
	[Token(Token = "0x6000022")]
	public void ClearGuideStack() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600002A")]
	public GuideLabel get_Guide() { }

	[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
	[Token(Token = "0x600002C")]
	public float get_GuideAlphaRate() { }

	[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
	[Token(Token = "0x600002B")]
	public bool get_IsDisplayGuide() { }

	[Address(RVA = "0x1DFA390", Offset = "0x1DF9790", Length = "0xC")]
	[Token(Token = "0x600001E")]
	public override void HiddenGuide() { }

	[Address(RVA = "0x1DFA3A0", Offset = "0x1DF97A0", Length = "0xBB")]
	[Token(Token = "0x6000017")]
	public void Initialize() { }

	[Address(RVA = "0x1DFA460", Offset = "0x1DF9860", Length = "0x265")]
	[Token(Token = "0x6000021")]
	public void PopGuide() { }

	[Address(RVA = "0x1DFA6D0", Offset = "0x1DF9AD0", Length = "0xF9")]
	[Token(Token = "0x6000020")]
	public void PushGuide() { }

	[Address(RVA = "0x1DFA7D0", Offset = "0x1DF9BD0", Length = "0x5B")]
	[Token(Token = "0x6000018")]
	public void Refresh(TMP_FontAsset tfont) { }

	[Address(RVA = "0x1DFA830", Offset = "0x1DF9C30", Length = "0x33")]
	[Token(Token = "0x600001F")]
	public override void ResetGuide() { }

	[Address(RVA = "0x1DFA870", Offset = "0x1DF9C70", Length = "0xCE")]
	[Token(Token = "0x600001C")]
	public override void SetGuide(int no, Sprite _icon, string _text) { }

	[Address(RVA = "0x1DFA940", Offset = "0x1DF9D40", Length = "0x9E")]
	[Token(Token = "0x600001A")]
	public override void SetMarquee(string s) { }

	[Address(RVA = "0x1DFA9E0", Offset = "0x1DF9DE0", Length = "0x8F")]
	[Token(Token = "0x600001B")]
	public void SetString(string s) { }

	[Address(RVA = "0x1DFAA70", Offset = "0x1DF9E70", Length = "0x86")]
	[Token(Token = "0x6000023")]
	public void SwitchGuideH(bool isH) { }

	[Address(RVA = "0x1DFAB00", Offset = "0x1DF9F00", Length = "0x6F")]
	[Token(Token = "0x6000019")]
	public void Terminate() { }

	[Address(RVA = "0x1DFAB70", Offset = "0x1DF9F70", Length = "0x1CA")]
	[Token(Token = "0x6000024")]
	private void Update() { }

}

