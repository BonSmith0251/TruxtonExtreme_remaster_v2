namespace TXEKernel;

[Token(Token = "0x200010C")]
public class NowSaving : MonoBehaviourSingleton<NowSaving>
{
	[Token(Token = "0x200010D")]
	internal class NowSavingScope : IDisposable
	{

		[Address(RVA = "0x2720F30", Offset = "0x2720330", Length = "0xB7")]
		[Token(Token = "0x60007A6")]
		public NowSavingScope() { }

		[Address(RVA = "0x2720EB0", Offset = "0x27202B0", Length = "0x75")]
		[Token(Token = "0x60007A7")]
		public override void Dispose() { }

	}

	[Token(Token = "0x4000559")]
	private static readonly float DispTimeMax; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400055A")]
	private UIRotater _rotater; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400055B")]
	private UIImage _timage; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400055C")]
	private bool _isSaving; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400055D")]
	private bool _isBlink; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400055E")]
	private float _canvasAlpha; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400055F")]
	private float _blinkTimer; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000560")]
	private float _dispTime; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000561")]
	private CanvasGroup _canvas; //Field offset: 0x40

	[Token(Token = "0x1700021A")]
	public bool IsSaving
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x60007A3")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x27213A0", Offset = "0x27207A0", Length = "0x39")]
	[Token(Token = "0x60007A5")]
	private static NowSaving() { }

	[Address(RVA = "0x27213E0", Offset = "0x27207E0", Length = "0x39")]
	[Token(Token = "0x60007A4")]
	public NowSaving() { }

	[Address(RVA = "0x2720FF0", Offset = "0x27203F0", Length = "0xA5")]
	[Token(Token = "0x600079E")]
	protected virtual void Awake() { }

	[Address(RVA = "0x27210A0", Offset = "0x27204A0", Length = "0x4A")]
	[Token(Token = "0x60007A1")]
	private void DisplayActive(bool tactive) { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x60007A3")]
	public bool get_IsSaving() { }

	[Address(RVA = "0x27210F0", Offset = "0x27204F0", Length = "0x53")]
	[Token(Token = "0x600079F")]
	public void Saving(bool isLoading) { }

	[Address(RVA = "0x2721340", Offset = "0x2720740", Length = "0x5E")]
	[Token(Token = "0x60007A0")]
	private void Update() { }

	[Address(RVA = "0x2721150", Offset = "0x2720550", Length = "0x1E8")]
	[Token(Token = "0x60007A2")]
	private void UpdateSaveIcon(float dt) { }

}

