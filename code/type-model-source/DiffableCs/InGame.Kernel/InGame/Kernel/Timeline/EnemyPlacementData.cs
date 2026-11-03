namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000DF")]
public class EnemyPlacementData
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000602")]
	public string objectName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000603")]
	private float moveSpeed; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000604")]
	public float delayTime; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000605")]
	private float _moveSpeedRange; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000606")]
	private Vector3 offset; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000607")]
	public Vector3 rotate; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000608")]
	private Vector3 _offsetRange; //Field offset: 0x3C
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000609")]
	public EasingType easeType; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x400060A")]
	public LookAtType lookAt; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400060B")]
	public PlacementAttribute attributeFlag; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x400060C")]
	public float PlaneOffsetY; //Field offset: 0x54

	[Token(Token = "0x17000158")]
	public float MoveSpeedWithRange
	{
		[Address(RVA = "0x1D35730", Offset = "0x1D34B30", Length = "0x28")]
		[Token(Token = "0x600074B")]
		 get { } //Length: 40
	}

	[Token(Token = "0x17000159")]
	public Vector3 Offset
	{
		[Address(RVA = "0x1D35760", Offset = "0x1D34B60", Length = "0x83")]
		[Token(Token = "0x600074C")]
		 get { } //Length: 131
	}

	[Address(RVA = "0x1D356F0", Offset = "0x1D34AF0", Length = "0x3D")]
	[Token(Token = "0x600074F")]
	public EnemyPlacementData() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600074E")]
	public void DebugPrint() { }

	[Address(RVA = "0x1D35730", Offset = "0x1D34B30", Length = "0x28")]
	[Token(Token = "0x600074B")]
	public float get_MoveSpeedWithRange() { }

	[Address(RVA = "0x1D35760", Offset = "0x1D34B60", Length = "0x83")]
	[Token(Token = "0x600074C")]
	public Vector3 get_Offset() { }

	[Address(RVA = "0x1D355F0", Offset = "0x1D349F0", Length = "0xF6")]
	[Token(Token = "0x600074D")]
	public void Reset() { }

}

