namespace KANAI.UI;

[Token(Token = "0x2000026")]
public sealed class UIInputLocker : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000027")]
	private sealed class <>c
	{
		[Token(Token = "0x40000E7")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000E8")]
		public static Func<UIInputLocker, Boolean> <>9__4_0; //Field offset: 0x8

		[Address(RVA = "0x1E17D10", Offset = "0x1E17110", Length = "0x67")]
		[Token(Token = "0x6000104")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000105")]
		public <>c() { }

		[Address(RVA = "0x1E17B00", Offset = "0x1E16F00", Length = "0x1A")]
		[Token(Token = "0x6000106")]
		internal bool <IsLock>b__4_0(UIInputLocker n) { }

	}

	[CustomLabel("LockCount")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000E6")]
	private int lockCount; //Field offset: 0x20

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000103")]
	public UIInputLocker() { }

	[Address(RVA = "0x1E1FFC0", Offset = "0x1E1F3C0", Length = "0x47")]
	[Token(Token = "0x6000101")]
	public bool IsLock() { }

	[Address(RVA = "0x1E1FE30", Offset = "0x1E1F230", Length = "0x184")]
	[Token(Token = "0x6000102")]
	public static bool IsLock(Transform t) { }

	[Address(RVA = "0x1E20010", Offset = "0x1E1F410", Length = "0x4")]
	[Token(Token = "0x60000FF")]
	public void Lock() { }

	[Address(RVA = "0x1E20020", Offset = "0x1E1F420", Length = "0xA")]
	[Token(Token = "0x6000100")]
	public void Unlock() { }

}

