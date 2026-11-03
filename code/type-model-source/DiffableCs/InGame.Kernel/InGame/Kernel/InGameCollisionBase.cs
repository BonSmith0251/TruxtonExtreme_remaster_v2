namespace InGame.Kernel;

[Token(Token = "0x200001C")]
public abstract class InGameCollisionBase : TXEKernelHybridCollisions
{
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40000CC")]
	protected InGameObject _objectInfo; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000CD")]
	private int _priority; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40000CE")]
	private int _indexValue; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000CF")]
	private float _invincibleTime; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40000D0")]
	private float _nodamagedTime; //Field offset: 0x9C

	[Token(Token = "0x17000029")]
	public int IndexValue
	{
		[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
		[Token(Token = "0x600011F")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700002A")]
	public bool IsInvincibleTime
	{
		[Address(RVA = "0x1CCF5A0", Offset = "0x1CCE9A0", Length = "0x12")]
		[Token(Token = "0x6000120")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000028")]
	public int Priority
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[Token(Token = "0x600011E")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1CCEFC0", Offset = "0x1CCE3C0", Length = "0x11")]
	[Token(Token = "0x6000121")]
	protected InGameCollisionBase() { }

	[Address(RVA = "0x1CCEFE0", Offset = "0x1CCE3E0", Length = "0x94")]
	[Token(Token = "0x6000113")]
	public virtual bool AddDamageOwner(float n) { }

	[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
	[Token(Token = "0x600011F")]
	public int get_IndexValue() { }

	[Address(RVA = "0x1CCF5A0", Offset = "0x1CCE9A0", Length = "0x12")]
	[Token(Token = "0x6000120")]
	public bool get_IsInvincibleTime() { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[Token(Token = "0x600011E")]
	public int get_Priority() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x600011D")]
	protected override string GetDebugString() { }

	[Address(RVA = "0x1CCF080", Offset = "0x1CCE480", Length = "0x38")]
	[Token(Token = "0x600011C")]
	public override Vector3 GetHormingTarget(int nindex) { }

	[Address(RVA = "0x1CCF0C0", Offset = "0x1CCE4C0", Length = "0x88")]
	[Token(Token = "0x6000108")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1CCF1A0", Offset = "0x1CCE5A0", Length = "0x89")]
	[Token(Token = "0x6000117")]
	public override bool IsBombered() { }

	[Address(RVA = "0x1CCF150", Offset = "0x1CCE550", Length = "0x42")]
	[Token(Token = "0x600010E")]
	public virtual bool IsBomberRange() { }

	[Address(RVA = "0x1CCF230", Offset = "0x1CCE630", Length = "0x41")]
	[Token(Token = "0x600010A")]
	public virtual bool IsHitEnable() { }

	[Address(RVA = "0x1CCF280", Offset = "0x1CCE680", Length = "0x31")]
	[Token(Token = "0x600010D")]
	public virtual bool IsLaserBlock() { }

	[Address(RVA = "0x1CCF2C0", Offset = "0x1CCE6C0", Length = "0x31")]
	[Token(Token = "0x600010C")]
	public virtual bool IsLockOnTarget() { }

	[Address(RVA = "0x1CCF300", Offset = "0x1CCE700", Length = "0x41")]
	[Token(Token = "0x600010B")]
	public virtual bool IsNoDamaged() { }

	[Address(RVA = "0x1CCF350", Offset = "0x1CCE750", Length = "0x97")]
	[Token(Token = "0x6000116")]
	public bool IsObjectFlag(InGameObjectFlag f) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000110")]
	protected override bool IsSimpleCalc() { }

	[Address(RVA = "0x1CCF3F0", Offset = "0x1CCE7F0", Length = "0xCC")]
	[Token(Token = "0x6000112")]
	public override void LateUpdater(float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000111")]
	protected override void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1CCF4C0", Offset = "0x1CCE8C0", Length = "0x36")]
	[Token(Token = "0x600010F")]
	public override void ProgressMove(float dt) { }

	[Address(RVA = "0x1CCF500", Offset = "0x1CCE900", Length = "0x15")]
	[Token(Token = "0x6000115")]
	public void ResetObjectFlag(InGameObjectFlag f) { }

	[Address(RVA = "0x1CCF520", Offset = "0x1CCE920", Length = "0x1A")]
	[Token(Token = "0x6000118")]
	public override void SetBombered() { }

	[Address(RVA = "0x1CCF540", Offset = "0x1CCE940", Length = "0x1B")]
	[Token(Token = "0x6000109")]
	public void SetData(float _hpv, int _pv, bool isLockOn, bool isNoBlock) { }

	[Address(RVA = "0xE26C10", Offset = "0xE26010", Length = "0x7")]
	[Token(Token = "0x600011A")]
	public void SetIndexValue(int tindex) { }

	[Address(RVA = "0x1CCF560", Offset = "0x1CCE960", Length = "0x9")]
	[Token(Token = "0x6000119")]
	public void SetInvincibleTime(float v) { }

	[Address(RVA = "0x1CCF570", Offset = "0x1CCE970", Length = "0x9")]
	[Token(Token = "0x600011B")]
	public void SetNodamagedTime(float v) { }

	[Address(RVA = "0x1CCF580", Offset = "0x1CCE980", Length = "0x15")]
	[Token(Token = "0x6000114")]
	public void SetObjectFlag(InGameObjectFlag f) { }

}

