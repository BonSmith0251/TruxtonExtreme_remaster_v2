namespace InGame.Kernel.Player;

[Token(Token = "0x2000125")]
public abstract class WeaponBaseShot : MonoBehaviour
{
	[Token(Token = "0x2000128")]
	internal enum Mats : int
	{
		BWeapon = 0,
		Option = 1,
		UPGrade = 2,
	}

	[Token(Token = "0x2000127")]
	internal struct ShotDirectionData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000846")]
		public ShotLevelFlags _level; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000847")]
		public int _muzzleNo; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000848")]
		public int _rotate; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000849")]
		public Vector3 ShotOffset; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400084A")]
		private Vector3 _shotDir; //Field offset: 0x18

		[Token(Token = "0x170001AE")]
		public Vector3 ShotDir
		{
			[Address(RVA = "0x1410A50", Offset = "0x140FE50", Length = "0x13")]
			[Token(Token = "0x600092F")]
			 get { } //Length: 19
		}

		[Address(RVA = "0x1410A50", Offset = "0x140FE50", Length = "0x13")]
		[Token(Token = "0x600092F")]
		public Vector3 get_ShotDir() { }

		[Address(RVA = "0x1D51350", Offset = "0x1D50750", Length = "0x22")]
		[Token(Token = "0x6000931")]
		public int GetUniqueID() { }

		[Address(RVA = "0x1D51380", Offset = "0x1D50780", Length = "0x70")]
		[Token(Token = "0x6000930")]
		public void Initialize() { }

		[Address(RVA = "0x1D513F0", Offset = "0x1D507F0", Length = "0x20")]
		[Token(Token = "0x6000932")]
		public bool IsFire(int nlevel, bool isExboost) { }

	}

	[Flags]
	[Token(Token = "0x2000126")]
	internal enum ShotLevelFlags : int
	{
		lv0 = 1,
		lv1 = 2,
		lv2 = 4,
		lv3 = 8,
		Usually = 536870912,
		Special = 1073741824,
	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000837")]
	private ArmsKind _armKind; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000838")]
	protected Transform _root; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000839")]
	private Transform[] _emitters; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400083A")]
	private PowerLevels _powerLevel; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400083B")]
	protected int _playerNo; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400083C")]
	protected int _emittersCount; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400083D")]
	private Material[] _weaponMaterials; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400083E")]
	private int _numMaterials; //Field offset: 0x50

	[Address(RVA = "0x1D57A40", Offset = "0x1D56E40", Length = "0xE")]
	[Token(Token = "0x600092E")]
	protected WeaponBaseShot() { }

	[Address(RVA = "0x1D57810", Offset = "0x1D56C10", Length = "0x2B")]
	[Token(Token = "0x600092D")]
	protected Transform GetEmitter(int eindex) { }

	[Address(RVA = "0x1D57840", Offset = "0x1D56C40", Length = "0x36")]
	[Token(Token = "0x600092C")]
	public override Material GetMaterial(Mats tmat) { }

	[Address(RVA = "0x1D57880", Offset = "0x1D56C80", Length = "0x1A")]
	[Token(Token = "0x6000924")]
	public override void InitializeMaterails() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000927")]
	public override bool IsFire(bool isExBoost) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x600092B")]
	public override ArmsKind Kind() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600092A")]
	public override void OnUpdate(float dt) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000928")]
	public override int OptionLevel() { }

	[Address(RVA = "0x1D578A0", Offset = "0x1D56CA0", Length = "0xF")]
	[Token(Token = "0x6000926")]
	public override PowerLevels PowerLevel() { }

	[Address(RVA = "0x1D578B0", Offset = "0x1D56CB0", Length = "0x142")]
	[Token(Token = "0x6000925")]
	public override bool SetPower(int n) { }

	[Address(RVA = "0x1D57A00", Offset = "0x1D56E00", Length = "0x30")]
	[Token(Token = "0x6000929")]
	protected void SetupEmitters(Transform[] transforms) { }

}

