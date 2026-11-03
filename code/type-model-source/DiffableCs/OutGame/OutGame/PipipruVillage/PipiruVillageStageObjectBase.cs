namespace OutGame.PipipruVillage;

[Token(Token = "0x20000FC")]
public abstract class PipiruVillageStageObjectBase : MonoBehaviour
{
	[Token(Token = "0x20000FE")]
	internal enum ApperanceType : int
	{
		Point = 0,
		Squash = 1,
		Alpha = 2,
		Instant = 3,
		Default = 0,
	}

	[Token(Token = "0x20000FD")]
	internal class ObjParam
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000405")]
		public GameObject Obj; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000406")]
		public Vector3 BasePos; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000407")]
		public Vector3 BaseScale; //Field offset: 0x24
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000408")]
		public SpriteRenderer Sprite; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600064C")]
		public ObjParam() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40003FF")]
	protected ApperanceType _apperanceType; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000400")]
	protected int _leaveLevel; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000401")]
	protected Vector3 _pos; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000402")]
	protected float _animeTime; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000403")]
	protected float _scale; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000404")]
	protected ObjParam _objParam; //Field offset: 0x40

	[Token(Token = "0x17000179")]
	public ApperanceType ApperanceTypeValue
	{
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000646")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700017A")]
	public int LeaveLevel
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000647")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700017C")]
	public abstract Vector3 ObjPos
	{
		[Token(Token = "0x6000649")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700017D")]
	public abstract Vector3 ObjSize
	{
		[Token(Token = "0x600064A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700017B")]
	public float ScrollRate
	{
		[Address(RVA = "0x21F0930", Offset = "0x21EFD30", Length = "0x1C")]
		[Token(Token = "0x6000648")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x21F0910", Offset = "0x21EFD10", Length = "0x1C")]
	[Token(Token = "0x600064B")]
	protected PipiruVillageStageObjectBase() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000647")]
	public int get_LeaveLevel() { }

	[Token(Token = "0x6000649")]
	public abstract Vector3 get_ObjPos() { }

	[Token(Token = "0x600064A")]
	public abstract Vector3 get_ObjSize() { }

	[Address(RVA = "0x21F0930", Offset = "0x21EFD30", Length = "0x1C")]
	[Token(Token = "0x6000648")]
	public float get_ScrollRate() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000646")]
	public void set_ApperanceTypeValue(ApperanceType value) { }

	[Token(Token = "0x6000644")]
	public abstract void SetObjectParam(bool isDisplay, GameObject obj, PipiruVillageStageObjectLayer layerObject = null) { }

	[Token(Token = "0x6000645")]
	public abstract void UpdateObject(bool isDisplay, float deltaTime) { }

}

