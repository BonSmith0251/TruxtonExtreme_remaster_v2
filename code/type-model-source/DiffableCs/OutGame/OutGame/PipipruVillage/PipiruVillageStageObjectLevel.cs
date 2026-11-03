namespace OutGame.PipipruVillage;

[Token(Token = "0x2000100")]
public class PipiruVillageStageObjectLevel : PipiruVillageStageObjectBase
{
	[Token(Token = "0x4000414")]
	private static readonly string AnimatorParamIsAppear; //Field offset: 0x0
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000415")]
	protected Animator _animator; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000416")]
	private PipiruVillageStageObjectLayer _layer; //Field offset: 0x50

	[Token(Token = "0x17000183")]
	public virtual Vector3 ObjPos
	{
		[Address(RVA = "0x21F1030", Offset = "0x21F0430", Length = "0x53")]
		[Token(Token = "0x600065B")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000184")]
	public virtual Vector3 ObjSize
	{
		[Address(RVA = "0x21F18A0", Offset = "0x21F0CA0", Length = "0x90")]
		[Token(Token = "0x600065C")]
		 get { } //Length: 144
	}

	[Address(RVA = "0x21F1830", Offset = "0x21F0C30", Length = "0x62")]
	[Token(Token = "0x600065E")]
	private static PipiruVillageStageObjectLevel() { }

	[Address(RVA = "0x21F0910", Offset = "0x21EFD10", Length = "0x1C")]
	[Token(Token = "0x600065D")]
	public PipiruVillageStageObjectLevel() { }

	[Address(RVA = "0x21F1030", Offset = "0x21F0430", Length = "0x53")]
	[Token(Token = "0x600065B")]
	public virtual Vector3 get_ObjPos() { }

	[Address(RVA = "0x21F18A0", Offset = "0x21F0CA0", Length = "0x90")]
	[Token(Token = "0x600065C")]
	public virtual Vector3 get_ObjSize() { }

	[Address(RVA = "0x21F10F0", Offset = "0x21F04F0", Length = "0x269")]
	[Token(Token = "0x6000659")]
	public virtual void SetObjectParam(bool isDisplay, GameObject obj, PipiruVillageStageObjectLayer layerObject) { }

	[Address(RVA = "0x21F1360", Offset = "0x21F0760", Length = "0x4CF")]
	[Token(Token = "0x600065A")]
	public virtual void UpdateObject(bool isDisplay, float deltaTime) { }

}

