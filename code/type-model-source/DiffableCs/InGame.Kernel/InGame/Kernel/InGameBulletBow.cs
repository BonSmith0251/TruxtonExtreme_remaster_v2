namespace InGame.Kernel;

[Token(Token = "0x200000E")]
public class InGameBulletBow : InGameBullet
{
	[Token(Token = "0x200000F")]
	private enum BowState : int
	{
		Entry = 0,
		Spawn = 1,
		Ready = 2,
		Delay = 3,
		Go = 4,
	}

	[Token(Token = "0x400005A")]
	public static readonly float _FadeInTimeDefault; //Field offset: 0x0
	[Token(Token = "0x400005D")]
	private const float IdleWaitDefaultSeconds = 10; //Field offset: 0x0
	[Token(Token = "0x400005B")]
	private static readonly int TintColorPropertyId; //Field offset: 0x4
	[Token(Token = "0x400005C")]
	private static readonly Color DefaultColor; //Field offset: 0x8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400005E")]
	private BowState _currentState; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x400005F")]
	private float _fadeInTime; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000060")]
	private float _alpha; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x4000061")]
	private bool _isFire; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000062")]
	private float _delaySeconds; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000063")]
	private Material _fadeMaterial; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000064")]
	private Material _animMaterial; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000065")]
	private Color _currentColor; //Field offset: 0x118
	[FieldOffset(Offset = "0x128")]
	[FormerlySerializedAs("_bornSE")]
	[SerializeField]
	[Token(Token = "0x4000066")]
	private BulletSE _spawnSound; //Field offset: 0x128

	[Token(Token = "0x1700001C")]
	private bool IsDamageable
	{
		[Address(RVA = "0x1CC9E40", Offset = "0x1CC9240", Length = "0x17")]
		[Token(Token = "0x600009C")]
		private get { } //Length: 23
	}

	[Token(Token = "0x1700001B")]
	public bool RequiresFollow
	{
		[Address(RVA = "0x1CC9E60", Offset = "0x1CC9260", Length = "0xB")]
		[Token(Token = "0x6000097")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x1CC9D30", Offset = "0x1CC9130", Length = "0x7E")]
	[Token(Token = "0x600009E")]
	private static InGameBulletBow() { }

	[Address(RVA = "0x1CC9DB0", Offset = "0x1CC91B0", Length = "0x90")]
	[Token(Token = "0x600009D")]
	public InGameBulletBow() { }

	[Address(RVA = "0x1CC97C0", Offset = "0x1CC8BC0", Length = "0x1D")]
	[Token(Token = "0x6000093")]
	public virtual bool AddDamageOwner(float amount) { }

	[Address(RVA = "0x1CC97E0", Offset = "0x1CC8BE0", Length = "0x9F")]
	[Token(Token = "0x600009B")]
	private void ApplyAlpha(float alpha) { }

	[Address(RVA = "0x1CC9880", Offset = "0x1CC8C80", Length = "0x10")]
	[Token(Token = "0x6000095")]
	public void Fire(float delay) { }

	[Address(RVA = "0x1CC9E40", Offset = "0x1CC9240", Length = "0x17")]
	[Token(Token = "0x600009C")]
	private bool get_IsDamageable() { }

	[Address(RVA = "0x1CC9E60", Offset = "0x1CC9260", Length = "0xB")]
	[Token(Token = "0x6000097")]
	public bool get_RequiresFollow() { }

	[Address(RVA = "0x1CC9890", Offset = "0x1CC8C90", Length = "0x96")]
	[Token(Token = "0x6000091")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1CC9930", Offset = "0x1CC8D30", Length = "0x1A3")]
	[Token(Token = "0x6000096")]
	public virtual void ProgressBullet(float deltaTime) { }

	[Address(RVA = "0x1CC9AE0", Offset = "0x1CC8EE0", Length = "0x146")]
	[Token(Token = "0x6000092")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1CC9CB0", Offset = "0x1CC90B0", Length = "0x4A")]
	[Token(Token = "0x6000098")]
	public void SetPosition(Vector3 position) { }

	[Address(RVA = "0x1CC9C30", Offset = "0x1CC9030", Length = "0x7C")]
	[Token(Token = "0x600009A")]
	public void SetPositionAndDirection(Vector3 position, Vector3 direction) { }

	[Address(RVA = "0x1CC9D00", Offset = "0x1CC9100", Length = "0x13")]
	[Token(Token = "0x6000099")]
	public virtual void SetRenderMaterial(Material bmat) { }

	[Address(RVA = "0x1CC9D20", Offset = "0x1CC9120", Length = "0x9")]
	[Token(Token = "0x6000094")]
	public void Setup(float fadeTime) { }

}

