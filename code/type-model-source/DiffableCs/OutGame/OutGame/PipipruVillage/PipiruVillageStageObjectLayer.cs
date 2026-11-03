namespace OutGame.PipipruVillage;

[Token(Token = "0x20000FF")]
public class PipiruVillageStageObjectLayer : PipiruVillageStageObjectBase
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400040F")]
	public Vector3 TargetPos; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000410")]
	private float <DelayTime>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000411")]
	private bool <IsSkyView>k__BackingField; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000412")]
	private List<SpriteRenderer> _spriteRenderers; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000413")]
	private float _targetAlpha; //Field offset: 0x68

	[Token(Token = "0x17000180")]
	public float DelayTime
	{
		[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000653")]
		 get { } //Length: 6
		[Address(RVA = "0x1D1D150", Offset = "0x1D1C550", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000654")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000181")]
	public bool IsSkyView
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000655")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000656")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700017E")]
	public virtual Vector3 ObjPos
	{
		[Address(RVA = "0x21F1030", Offset = "0x21F0430", Length = "0x53")]
		[Token(Token = "0x6000651")]
		 get { } //Length: 83
	}

	[Token(Token = "0x1700017F")]
	public virtual Vector3 ObjSize
	{
		[Address(RVA = "0x21F1090", Offset = "0x21F0490", Length = "0x50")]
		[Token(Token = "0x6000652")]
		 get { } //Length: 80
	}

	[Token(Token = "0x17000182")]
	public float TargetAlpha
	{
		[Address(RVA = "0x16D0A10", Offset = "0x16CFE10", Length = "0x6")]
		[Token(Token = "0x6000657")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x21F0DC0", Offset = "0x21F01C0", Length = "0x19A")]
	[Token(Token = "0x6000650")]
	private void _alphaSprites(float targetAlpha) { }

	[Address(RVA = "0x21F1000", Offset = "0x21F0400", Length = "0x2D")]
	[Token(Token = "0x600064F")]
	private float _normalizeAnimeTime(float animteTime, float delayTime) { }

	[Address(RVA = "0x21F0F60", Offset = "0x21F0360", Length = "0x93")]
	[Token(Token = "0x6000658")]
	public PipiruVillageStageObjectLayer() { }

	[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000653")]
	public float get_DelayTime() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000655")]
	public bool get_IsSkyView() { }

	[Address(RVA = "0x21F1030", Offset = "0x21F0430", Length = "0x53")]
	[Token(Token = "0x6000651")]
	public virtual Vector3 get_ObjPos() { }

	[Address(RVA = "0x21F1090", Offset = "0x21F0490", Length = "0x50")]
	[Token(Token = "0x6000652")]
	public virtual Vector3 get_ObjSize() { }

	[Address(RVA = "0x16D0A10", Offset = "0x16CFE10", Length = "0x6")]
	[Token(Token = "0x6000657")]
	public float get_TargetAlpha() { }

	[Address(RVA = "0x1D1D150", Offset = "0x1D1C550", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000654")]
	public void set_DelayTime(float value) { }

	[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000656")]
	public void set_IsSkyView(bool value) { }

	[Address(RVA = "0x21F0950", Offset = "0x21EFD50", Length = "0x1ED")]
	[Token(Token = "0x600064D")]
	public virtual void SetObjectParam(bool isDisplay, GameObject obj, PipiruVillageStageObjectLayer layerObject = null) { }

	[Address(RVA = "0x21F0B40", Offset = "0x21EFF40", Length = "0x272")]
	[Token(Token = "0x600064E")]
	public virtual void UpdateObject(bool isDisplay, float deltaTime) { }

}

