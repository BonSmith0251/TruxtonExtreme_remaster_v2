namespace InGame.Kernel.Player;

[Token(Token = "0x2000120")]
public class superFighterCollision : InGameCollisionBase
{
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400081E")]
	private PlayerControll _playerController; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400081F")]
	private PlayerInformation _playerInformation; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000820")]
	private bool _isInvincible; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB1")]
	[Token(Token = "0x4000821")]
	private bool _isFullBoost; //Field offset: 0xB1
	[FieldOffset(Offset = "0xB2")]
	[Token(Token = "0x4000822")]
	private bool _isNoEntryMode; //Field offset: 0xB2
	[FieldOffset(Offset = "0xB3")]
	[Token(Token = "0x4000823")]
	private bool _isRescued; //Field offset: 0xB3

	[Token(Token = "0x170001AC")]
	public bool IsFullBoost
	{
		[Address(RVA = "0x1D605B0", Offset = "0x1D5F9B0", Length = "0x8")]
		[Token(Token = "0x6000916")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001AB")]
	public bool IsInvincible
	{
		[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
		[Token(Token = "0x6000915")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001A8")]
	public virtual bool IsPrgoressMove
	{
		[Address(RVA = "0x1D605C0", Offset = "0x1D5F9C0", Length = "0x13")]
		[Token(Token = "0x6000912")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170001AD")]
	public bool IsRescued
	{
		[Address(RVA = "0x1D605E0", Offset = "0x1D5F9E0", Length = "0xB1")]
		[Token(Token = "0x6000917")]
		 get { } //Length: 177
	}

	[Token(Token = "0x170001AA")]
	public PlayerInformation PInfo
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x6000914")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001A9")]
	public PlayerControll PlayerController
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x6000913")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1D605A0", Offset = "0x1D5F9A0", Length = "0x7")]
	[Token(Token = "0x6000918")]
	public superFighterCollision() { }

	[Address(RVA = "0x1D5FF40", Offset = "0x1D5F340", Length = "0x5D")]
	[Token(Token = "0x6000904")]
	public virtual bool AddDamageOwner(float n) { }

	[Address(RVA = "0x1D5FFA0", Offset = "0x1D5F3A0", Length = "0x2D")]
	[Token(Token = "0x6000905")]
	public virtual void AddEnergyOwner(float n) { }

	[Address(RVA = "0x1D5FFD0", Offset = "0x1D5F3D0", Length = "0xF2")]
	[Token(Token = "0x6000906")]
	public virtual void AddScoreOwner(float n) { }

	[Address(RVA = "0x1D605B0", Offset = "0x1D5F9B0", Length = "0x8")]
	[Token(Token = "0x6000916")]
	public bool get_IsFullBoost() { }

	[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
	[Token(Token = "0x6000915")]
	public bool get_IsInvincible() { }

	[Address(RVA = "0x1D605C0", Offset = "0x1D5F9C0", Length = "0x13")]
	[Token(Token = "0x6000912")]
	public virtual bool get_IsPrgoressMove() { }

	[Address(RVA = "0x1D605E0", Offset = "0x1D5F9E0", Length = "0xB1")]
	[Token(Token = "0x6000917")]
	public bool get_IsRescued() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x6000914")]
	public PlayerInformation get_PInfo() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x6000913")]
	public PlayerControll get_PlayerController() { }

	[Address(RVA = "0x1D600D0", Offset = "0x1D5F4D0", Length = "0x31")]
	[Token(Token = "0x6000902")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D60110", Offset = "0x1D5F510", Length = "0x33")]
	[Token(Token = "0x6000911")]
	public virtual bool IsAlive() { }

	[Address(RVA = "0x1D60150", Offset = "0x1D5F550", Length = "0x1C")]
	[Token(Token = "0x6000908")]
	public virtual bool IsNoDamaged() { }

	[Address(RVA = "0x1D60170", Offset = "0x1D5F570", Length = "0x7")]
	[Token(Token = "0x600090B")]
	public bool IsPipiruCleanup() { }

	[Address(RVA = "0x1D60180", Offset = "0x1D5F580", Length = "0x72")]
	[Token(Token = "0x600090D")]
	private bool IsRescueOK() { }

	[Address(RVA = "0x1D60200", Offset = "0x1D5F600", Length = "0x295")]
	[Token(Token = "0x600090E")]
	protected virtual void OnHitProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x1D604A0", Offset = "0x1D5F8A0", Length = "0xF")]
	[Token(Token = "0x6000903")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D604B0", Offset = "0x1D5F8B0", Length = "0x7")]
	[Token(Token = "0x600090A")]
	public void SetFullBoost(bool v) { }

	[Address(RVA = "0x1D604C0", Offset = "0x1D5F8C0", Length = "0x7")]
	[Token(Token = "0x6000910")]
	public void SetNoEntryMode(bool isNoEntry) { }

	[Address(RVA = "0x1D604D0", Offset = "0x1D5F8D0", Length = "0xBE")]
	[Token(Token = "0x6000907")]
	public void SetOwnerPlayer(PlayerControll p) { }

	[Address(RVA = "0x6617A0", Offset = "0x660BA0", Length = "0x7")]
	[Token(Token = "0x6000909")]
	public void SetPlayerInvincible(bool v) { }

	[Address(RVA = "0x1D60590", Offset = "0x1D5F990", Length = "0x7")]
	[Token(Token = "0x600090F")]
	public void SetRescueFlag(bool isRescue) { }

	[Address(RVA = "0x1CCED80", Offset = "0x1CCE180", Length = "0x14")]
	[Token(Token = "0x600090C")]
	public virtual void ToDestroid() { }

}

