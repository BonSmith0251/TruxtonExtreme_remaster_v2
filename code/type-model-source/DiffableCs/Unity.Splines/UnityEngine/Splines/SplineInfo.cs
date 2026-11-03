namespace UnityEngine.Splines;

[Token(Token = "0x200003B")]
public struct SplineInfo : IEquatable<SplineInfo>, ISerializationCallbackReceiver
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000DC")]
	private object m_Object; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeReference]
	[Token(Token = "0x40000DD")]
	private ISplineContainer m_Container; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40000DE")]
	private int m_SplineIndex; //Field offset: 0x10

	[Token(Token = "0x17000076")]
	public ISplineContainer Container
	{
		[Address(RVA = "0x2E67530", Offset = "0x2E66930", Length = "0x48")]
		[Token(Token = "0x6000226")]
		 get { } //Length: 72
		[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
		[Token(Token = "0x6000227")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000079")]
	public int Index
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600022A")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x600022B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700007A")]
	public float4x4 LocalToWorld
	{
		[Address(RVA = "0x2E67580", Offset = "0x2E66980", Length = "0x17D")]
		[Token(Token = "0x600022C")]
		 get { } //Length: 381
	}

	[Token(Token = "0x17000075")]
	public object Object
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000225")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000078")]
	public Spline Spline
	{
		[Address(RVA = "0x2E67700", Offset = "0x2E66B00", Length = "0x17B")]
		[Token(Token = "0x6000229")]
		 get { } //Length: 379
	}

	[Token(Token = "0x17000077")]
	public Transform Transform
	{
		[Address(RVA = "0x2E67880", Offset = "0x2E66C80", Length = "0x6D")]
		[Token(Token = "0x6000228")]
		 get { } //Length: 109
	}

	[Address(RVA = "0x2E67440", Offset = "0x2E66840", Length = "0xE4")]
	[Token(Token = "0x600022D")]
	public SplineInfo(ISplineContainer container, int index) { }

	[Address(RVA = "0x2E671C0", Offset = "0x2E665C0", Length = "0xC0")]
	[Token(Token = "0x600022E")]
	public override bool Equals(SplineInfo other) { }

	[Address(RVA = "0x2E67120", Offset = "0x2E66520", Length = "0x9B")]
	[Token(Token = "0x600022F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2E67530", Offset = "0x2E66930", Length = "0x48")]
	[Token(Token = "0x6000226")]
	public ISplineContainer get_Container() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x600022A")]
	public int get_Index() { }

	[Address(RVA = "0x2E67580", Offset = "0x2E66980", Length = "0x17D")]
	[Token(Token = "0x600022C")]
	public float4x4 get_LocalToWorld() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000225")]
	public object get_Object() { }

	[Address(RVA = "0x2E67700", Offset = "0x2E66B00", Length = "0x17B")]
	[Token(Token = "0x6000229")]
	public Spline get_Spline() { }

	[Address(RVA = "0x2E67880", Offset = "0x2E66C80", Length = "0x6D")]
	[Token(Token = "0x6000228")]
	public Transform get_Transform() { }

	[Address(RVA = "0x2E67280", Offset = "0x2E66680", Length = "0xB7")]
	[Token(Token = "0x6000230")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2E67340", Offset = "0x2E66740", Length = "0x6D")]
	[Token(Token = "0x6000232")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x2E673B0", Offset = "0x2E667B0", Length = "0x83")]
	[Token(Token = "0x6000231")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
	[Token(Token = "0x6000227")]
	public void set_Container(ISplineContainer value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x600022B")]
	public void set_Index(int value) { }

}

