namespace UnityEngine.UI;

[AddComponentMenu("Layout/Grid Layout Group", 152)]
[Token(Token = "0x2000042")]
public class GridLayoutGroup : LayoutGroup
{
	[Token(Token = "0x2000044")]
	internal enum Axis : int
	{
		Horizontal = 0,
		Vertical = 1,
	}

	[Token(Token = "0x2000045")]
	internal enum Constraint : int
	{
		Flexible = 0,
		FixedColumnCount = 1,
		FixedRowCount = 2,
	}

	[Token(Token = "0x2000043")]
	internal enum Corner : int
	{
		UpperLeft = 0,
		UpperRight = 1,
		LowerLeft = 2,
		LowerRight = 3,
	}

	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000159")]
	protected Corner m_StartCorner; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x400015A")]
	protected Axis m_StartAxis; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400015B")]
	protected Vector2 m_CellSize; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x400015C")]
	protected Vector2 m_Spacing; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400015D")]
	protected Constraint m_Constraint; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x400015E")]
	protected int m_ConstraintCount; //Field offset: 0x7C

	[Token(Token = "0x170000AB")]
	public Vector2 cellSize
	{
		[Address(RVA = "0x16D0A20", Offset = "0x16CFE20", Length = "0x13")]
		[Token(Token = "0x600028F")]
		 get { } //Length: 19
		[Address(RVA = "0x3436010", Offset = "0x3435410", Length = "0x51")]
		[Token(Token = "0x6000290")]
		 set { } //Length: 81
	}

	[Token(Token = "0x170000AD")]
	public Constraint constraint
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x6000293")]
		 get { } //Length: 4
		[Address(RVA = "0x34360D0", Offset = "0x34354D0", Length = "0x4B")]
		[Token(Token = "0x6000294")]
		 set { } //Length: 75
	}

	[Token(Token = "0x170000AE")]
	public int constraintCount
	{
		[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
		[Token(Token = "0x6000295")]
		 get { } //Length: 4
		[Address(RVA = "0x3436070", Offset = "0x3435470", Length = "0x55")]
		[Token(Token = "0x6000296")]
		 set { } //Length: 85
	}

	[Token(Token = "0x170000AC")]
	public Vector2 spacing
	{
		[Address(RVA = "0x16D0900", Offset = "0x16CFD00", Length = "0x13")]
		[Token(Token = "0x6000291")]
		 get { } //Length: 19
		[Address(RVA = "0x3436120", Offset = "0x3435520", Length = "0x51")]
		[Token(Token = "0x6000292")]
		 set { } //Length: 81
	}

	[Token(Token = "0x170000AA")]
	public Axis startAxis
	{
		[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
		[Token(Token = "0x600028D")]
		 get { } //Length: 4
		[Address(RVA = "0x3436180", Offset = "0x3435580", Length = "0x4B")]
		[Token(Token = "0x600028E")]
		 set { } //Length: 75
	}

	[Token(Token = "0x170000A9")]
	public Corner startCorner
	{
		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[Token(Token = "0x600028B")]
		 get { } //Length: 4
		[Address(RVA = "0x34361D0", Offset = "0x34355D0", Length = "0x4B")]
		[Token(Token = "0x600028C")]
		 set { } //Length: 75
	}

	[Address(RVA = "0x3435FA0", Offset = "0x34353A0", Length = "0x66")]
	[Token(Token = "0x6000297")]
	protected GridLayoutGroup() { }

	[Address(RVA = "0x34353D0", Offset = "0x34347D0", Length = "0x1F7")]
	[Token(Token = "0x6000298")]
	public virtual void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x34355D0", Offset = "0x34349D0", Length = "0x1FB")]
	[Token(Token = "0x6000299")]
	public virtual void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x16D0A20", Offset = "0x16CFE20", Length = "0x13")]
	[Token(Token = "0x600028F")]
	public Vector2 get_cellSize() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x6000293")]
	public Constraint get_constraint() { }

	[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
	[Token(Token = "0x6000295")]
	public int get_constraintCount() { }

	[Address(RVA = "0x16D0900", Offset = "0x16CFD00", Length = "0x13")]
	[Token(Token = "0x6000291")]
	public Vector2 get_spacing() { }

	[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
	[Token(Token = "0x600028D")]
	public Axis get_startAxis() { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[Token(Token = "0x600028B")]
	public Corner get_startCorner() { }

	[Address(RVA = "0x3436010", Offset = "0x3435410", Length = "0x51")]
	[Token(Token = "0x6000290")]
	public void set_cellSize(Vector2 value) { }

	[Address(RVA = "0x34360D0", Offset = "0x34354D0", Length = "0x4B")]
	[Token(Token = "0x6000294")]
	public void set_constraint(Constraint value) { }

	[Address(RVA = "0x3436070", Offset = "0x3435470", Length = "0x55")]
	[Token(Token = "0x6000296")]
	public void set_constraintCount(int value) { }

	[Address(RVA = "0x3436120", Offset = "0x3435520", Length = "0x51")]
	[Token(Token = "0x6000292")]
	public void set_spacing(Vector2 value) { }

	[Address(RVA = "0x3436180", Offset = "0x3435580", Length = "0x4B")]
	[Token(Token = "0x600028E")]
	public void set_startAxis(Axis value) { }

	[Address(RVA = "0x34361D0", Offset = "0x34355D0", Length = "0x4B")]
	[Token(Token = "0x600028C")]
	public void set_startCorner(Corner value) { }

	[Address(RVA = "0x34357D0", Offset = "0x3434BD0", Length = "0x7A0")]
	[Token(Token = "0x600029C")]
	private void SetCellsAlongAxis(int axis) { }

	[Address(RVA = "0x3435F80", Offset = "0x3435380", Length = "0xA")]
	[Token(Token = "0x600029A")]
	public virtual void SetLayoutHorizontal() { }

	[Address(RVA = "0x3435F90", Offset = "0x3435390", Length = "0xD")]
	[Token(Token = "0x600029B")]
	public virtual void SetLayoutVertical() { }

}

