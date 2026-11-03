namespace UnityEngine.Rendering;

[DefaultMember("Item")]
[Token(Token = "0x20001EA")]
public class TextureCurve : IDisposable
{
	[Token(Token = "0x4000952")]
	private const int k_Precision = 128; //Field offset: 0x0
	[Token(Token = "0x4000953")]
	private const float k_Step = 0.0078125; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000954")]
	private int <length>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000955")]
	private bool m_Loop; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000956")]
	private float m_ZeroValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000957")]
	private float m_Range; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000958")]
	private AnimationCurve m_Curve; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000959")]
	private AnimationCurve m_LoopingCurve; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400095A")]
	private Texture2D m_Texture; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400095B")]
	private bool m_IsCurveDirty; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x400095C")]
	private bool m_IsTextureDirty; //Field offset: 0x39

	[Token(Token = "0x170001DA")]
	public Keyframe Item
	{
		[Address(RVA = "0x2C66CA0", Offset = "0x2C660A0", Length = "0x43")]
		[Token(Token = "0x6000E95")]
		 get { } //Length: 67
	}

	[Token(Token = "0x170001D9")]
	public private int length
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000E93")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000E94")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2C669E0", Offset = "0x2C65DE0", Length = "0x16A")]
	[Token(Token = "0x6000E96")]
	public TextureCurve(AnimationCurve baseCurve, float zeroValue, bool loop, in Vector2 bounds) { }

	[Address(RVA = "0x2C66B50", Offset = "0x2C65F50", Length = "0x14C")]
	[Token(Token = "0x6000E97")]
	public TextureCurve(Keyframe[] keys, float zeroValue, bool loop, in Vector2 bounds) { }

	[Address(RVA = "0x2C66310", Offset = "0x2C65710", Length = "0x30")]
	[Token(Token = "0x6000E9E")]
	public int AddKey(float time, float value) { }

	[Address(RVA = "0x2C66350", Offset = "0x2C65750", Length = "0x7")]
	[Token(Token = "0x6000E98")]
	public override void Dispose() { }

	[Address(RVA = "0x2C66360", Offset = "0x2C65760", Length = "0x263")]
	[Token(Token = "0x6000E9D")]
	public float Evaluate(float time) { }

	[Address(RVA = "0x2C66CA0", Offset = "0x2C660A0", Length = "0x43")]
	[Token(Token = "0x6000E95")]
	public Keyframe get_Item(int index) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000E93")]
	public int get_length() { }

	[Address(RVA = "0x2C66630", Offset = "0x2C65A30", Length = "0x245")]
	[Token(Token = "0x6000E9C")]
	public Texture2D GetTexture() { }

	[Address(RVA = "0x2C665D0", Offset = "0x2C659D0", Length = "0x53")]
	[Token(Token = "0x6000E9B")]
	private static GraphicsFormat GetTextureFormat() { }

	[Address(RVA = "0x2C66880", Offset = "0x2C65C80", Length = "0x4D")]
	[Token(Token = "0x6000E9F")]
	public int MoveKey(int index, in Keyframe key) { }

	[Address(RVA = "0x2C668D0", Offset = "0x2C65CD0", Length = "0x9F")]
	[Token(Token = "0x6000E99")]
	public void Release() { }

	[Address(RVA = "0x2C66970", Offset = "0x2C65D70", Length = "0x2B")]
	[Token(Token = "0x6000EA0")]
	public void RemoveKey(int index) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000E94")]
	private void set_length(int value) { }

	[Address(RVA = "0x2C669A0", Offset = "0x2C65DA0", Length = "0x7")]
	[Token(Token = "0x6000E9A")]
	public void SetDirty() { }

	[Address(RVA = "0x2C669B0", Offset = "0x2C65DB0", Length = "0x2B")]
	[Token(Token = "0x6000EA1")]
	public void SmoothTangents(int index, float weight) { }

}

