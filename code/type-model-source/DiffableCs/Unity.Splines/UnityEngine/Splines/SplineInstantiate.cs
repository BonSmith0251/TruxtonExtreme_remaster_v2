namespace UnityEngine.Splines;

[AddComponentMenu("Splines/Spline Instantiate")]
[ExecuteInEditMode]
[Token(Token = "0x200003C")]
public class SplineInstantiate : SplineComponent
{
	[CompilerGenerated]
	[Token(Token = "0x2000043")]
	private sealed class <>c
	{
		[Token(Token = "0x4000111")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000112")]
		public static Func<SplineInstantiate, Int32> <>9__123_0; //Field offset: 0x8

		[Address(RVA = "0x2E7FAC0", Offset = "0x2E7EEC0", Length = "0x67")]
		[Token(Token = "0x6000286")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000287")]
		public <>c() { }

		[Address(RVA = "0x2C507F0", Offset = "0x2C4FBF0", Length = "0x1F")]
		[Token(Token = "0x6000288")]
		internal int <CheckChildrenValidity>b__123_0(SplineInstantiate sInstantiate) { }

	}

	[Token(Token = "0x2000040")]
	internal struct InstantiableItem
	{
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[Obsolete("Use Prefab instead.", False)]
		[Token(Token = "0x4000105")]
		public GameObject prefab; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[FormerlySerializedAs("prefab")]
		[Token(Token = "0x4000106")]
		public GameObject Prefab; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		[Obsolete("Use Probability instead.", False)]
		[Token(Token = "0x4000107")]
		public float probability; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[FormerlySerializedAs("probability")]
		[Token(Token = "0x4000108")]
		public float Probability; //Field offset: 0x14

	}

	[Token(Token = "0x2000041")]
	internal enum Method : int
	{
		InstanceCount = 0,
		SpacingDistance = 1,
		LinearDistance = 2,
	}

	[Token(Token = "0x200003D")]
	internal enum OffsetSpace : int
	{
		Spline = 0,
		Local = 1,
		World = 2,
		Object = 3,
	}

	[Token(Token = "0x2000042")]
	internal enum Space : int
	{
		Spline = 0,
		Local = 1,
		World = 2,
	}

	[Token(Token = "0x200003E")]
	public struct Vector3Offset
	{
		[Flags]
		[Token(Token = "0x200003F")]
		internal enum Setup : int
		{
			None = 0,
			HasOffset = 1,
			HasCustomSpace = 2,
		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FA")]
		public Setup setup; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40000FB")]
		public Vector3 min; //Field offset: 0x4
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000FC")]
		public Vector3 max; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40000FD")]
		public bool randomX; //Field offset: 0x1C
		[FieldOffset(Offset = "0x1D")]
		[Token(Token = "0x40000FE")]
		public bool randomY; //Field offset: 0x1D
		[FieldOffset(Offset = "0x1E")]
		[Token(Token = "0x40000FF")]
		public bool randomZ; //Field offset: 0x1E
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000100")]
		public OffsetSpace space; //Field offset: 0x20

		[Token(Token = "0x170000A0")]
		public bool hasCustomSpace
		{
			[Address(RVA = "0x2E7FCC0", Offset = "0x2E7F0C0", Length = "0x7")]
			[Token(Token = "0x6000281")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700009F")]
		public bool hasOffset
		{
			[Address(RVA = "0x2E7FCD0", Offset = "0x2E7F0D0", Length = "0x6")]
			[Token(Token = "0x6000280")]
			 get { } //Length: 6
		}

		[Address(RVA = "0x2E7FB30", Offset = "0x2E7EF30", Length = "0x18")]
		[Token(Token = "0x6000285")]
		internal void CheckCustomSpace(Space instanceSpace) { }

		[Address(RVA = "0x2E7FB80", Offset = "0x2E7EF80", Length = "0x5C")]
		[Token(Token = "0x6000284")]
		internal void CheckMinMax() { }

		[Address(RVA = "0x2E7FB50", Offset = "0x2E7EF50", Length = "0x30")]
		[Token(Token = "0x6000283")]
		internal void CheckMinMaxValidity() { }

		[Address(RVA = "0x2E7FCC0", Offset = "0x2E7F0C0", Length = "0x7")]
		[Token(Token = "0x6000281")]
		public bool get_hasCustomSpace() { }

		[Address(RVA = "0x2E7FCD0", Offset = "0x2E7F0D0", Length = "0x6")]
		[Token(Token = "0x6000280")]
		public bool get_hasOffset() { }

		[Address(RVA = "0x2E7FBE0", Offset = "0x2E7EFE0", Length = "0xDF")]
		[Token(Token = "0x6000282")]
		internal Vector3 GetNextOffset() { }

	}

	[Token(Token = "0x40000EA")]
	private const string k_InstancesRootName = "root-"; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000DF")]
	private SplineContainer m_Container; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000E0")]
	private List<InstantiableItem> m_ItemsToInstantiate; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40000E1")]
	private Method m_Method; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40000E2")]
	private Space m_Space; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40000E3")]
	private Vector2 m_Spacing; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40000E4")]
	private AlignAxis m_Up; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40000E5")]
	private AlignAxis m_Forward; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40000E6")]
	private Vector3Offset m_PositionOffset; //Field offset: 0x50
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x40000E7")]
	private Vector3Offset m_RotationOffset; //Field offset: 0x74
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x40000E8")]
	private Vector3Offset m_ScaleOffset; //Field offset: 0x98
	[FieldOffset(Offset = "0xC0")]
	[FormerlySerializedAs("m_Instances")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000E9")]
	private List<GameObject> m_DeprecatedInstances; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40000EB")]
	private GameObject m_InstancesRoot; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000EC")]
	private readonly List<GameObject> m_Instances; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40000ED")]
	private bool m_InstancesCacheDirty; //Field offset: 0xD8
	[FieldOffset(Offset = "0xD9")]
	[SerializeField]
	[Token(Token = "0x40000EE")]
	private bool m_AutoRefresh; //Field offset: 0xD9
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40000EF")]
	private InstantiableItem m_CurrentItem; //Field offset: 0xE0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40000F0")]
	private bool m_SplineDirty; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x40000F1")]
	private float m_MaxProbability; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x40000F2")]
	private int m_Seed; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40000F3")]
	private List<Single> m_TimesCache; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40000F4")]
	private List<Single> m_LengthsCache; //Field offset: 0x110

	[Obsolete("Use Container instead.", False)]
	[Token(Token = "0x1700007B")]
	public SplineContainer container
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000233")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700007C")]
	public SplineContainer Container
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000234")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000235")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000081")]
	public Space CoordinateSpace
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x600023C")]
		 get { } //Length: 4
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[Token(Token = "0x600023D")]
		 set { } //Length: 4
	}

	[Obsolete("Use ForwardAxis instead.", False)]
	[Token(Token = "0x17000086")]
	public AlignAxis forwardAxis
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x6000245")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000087")]
	public AlignAxis ForwardAxis
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x6000246")]
		 get { } //Length: 4
		[Address(RVA = "0x2E6C440", Offset = "0x2E6B840", Length = "0x53")]
		[Token(Token = "0x6000247")]
		 set { } //Length: 83
	}

	[Token(Token = "0x1700009C")]
	internal List<GameObject> instances
	{
		[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
		[Token(Token = "0x6000265")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700009A")]
	internal GameObject InstancesRoot
	{
		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[Token(Token = "0x6000263")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700009B")]
	private Transform instancesRootTransform
	{
		[Address(RVA = "0x2E6C1B0", Offset = "0x2E6B5B0", Length = "0x239")]
		[Token(Token = "0x6000264")]
		private get { } //Length: 569
	}

	[Token(Token = "0x1700007F")]
	public Method InstantiateMethod
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000239")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[Token(Token = "0x600023A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700007D")]
	public InstantiableItem[] itemsToInstantiate
	{
		[Address(RVA = "0x2E6C3F0", Offset = "0x2E6B7F0", Length = "0x44")]
		[Token(Token = "0x6000236")]
		 get { } //Length: 68
		[Address(RVA = "0x2E6C700", Offset = "0x2E6BB00", Length = "0xB4")]
		[Token(Token = "0x6000237")]
		 set { } //Length: 180
	}

	[Obsolete("Use MaxPositionOffset instead.", False)]
	[Token(Token = "0x1700008A")]
	public Vector3 maxPositionOffset
	{
		[Address(RVA = "0x1CC6A40", Offset = "0x1CC5E40", Length = "0x13")]
		[Token(Token = "0x600024B")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700008B")]
	public Vector3 MaxPositionOffset
	{
		[Address(RVA = "0x1CC6A40", Offset = "0x1CC5E40", Length = "0x13")]
		[Token(Token = "0x600024C")]
		 get { } //Length: 19
		[Address(RVA = "0x2E6C4A0", Offset = "0x2E6B8A0", Length = "0x1A")]
		[Token(Token = "0x600024D")]
		 set { } //Length: 26
	}

	[Token(Token = "0x1700009D")]
	private float maxProbability
	{
		[Address(RVA = "0x2C2F790", Offset = "0x2C2EB90", Length = "0x9")]
		[Token(Token = "0x6000266")]
		private get { } //Length: 9
		[Address(RVA = "0x2E6C7C0", Offset = "0x2E6BBC0", Length = "0x1F")]
		[Token(Token = "0x6000267")]
		private set { } //Length: 31
	}

	[Obsolete("Use MaxRotationOffset instead.", False)]
	[Token(Token = "0x17000090")]
	public Vector3 maxRotationOffset
	{
		[Address(RVA = "0x2DB5220", Offset = "0x2DB4620", Length = "0x19")]
		[Token(Token = "0x6000254")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000091")]
	public Vector3 MaxRotationOffset
	{
		[Address(RVA = "0x2DB5220", Offset = "0x2DB4620", Length = "0x19")]
		[Token(Token = "0x6000255")]
		 get { } //Length: 25
		[Address(RVA = "0x2E6C4C0", Offset = "0x2E6B8C0", Length = "0x20")]
		[Token(Token = "0x6000256")]
		 set { } //Length: 32
	}

	[Obsolete("Use MaxScaleOffset instead.", False)]
	[Token(Token = "0x17000096")]
	public Vector3 maxScaleOffset
	{
		[Address(RVA = "0xE26960", Offset = "0xE25D60", Length = "0x19")]
		[Token(Token = "0x600025D")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000097")]
	public Vector3 MaxScaleOffset
	{
		[Address(RVA = "0xE26960", Offset = "0xE25D60", Length = "0x19")]
		[Token(Token = "0x600025E")]
		 get { } //Length: 25
		[Address(RVA = "0x2E6C4E0", Offset = "0x2E6B8E0", Length = "0x23")]
		[Token(Token = "0x600025F")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000083")]
	public float MaxSpacing
	{
		[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
		[Token(Token = "0x6000240")]
		 get { } //Length: 6
		[Address(RVA = "0x2E6C510", Offset = "0x2E6B910", Length = "0x82")]
		[Token(Token = "0x6000241")]
		 set { } //Length: 130
	}

	[Obsolete("Use InstantiateMethod instead.", False)]
	[Token(Token = "0x1700007E")]
	public Method method
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000238")]
		 get { } //Length: 4
	}

	[Obsolete("Use MinPositionOffset instead.", False)]
	[Token(Token = "0x17000088")]
	public Vector3 minPositionOffset
	{
		[Address(RVA = "0x2E6C190", Offset = "0x2E6B590", Length = "0x13")]
		[Token(Token = "0x6000248")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000089")]
	public Vector3 MinPositionOffset
	{
		[Address(RVA = "0x2E6C190", Offset = "0x2E6B590", Length = "0x13")]
		[Token(Token = "0x6000249")]
		 get { } //Length: 19
		[Address(RVA = "0x2E6C5A0", Offset = "0x2E6B9A0", Length = "0x1A")]
		[Token(Token = "0x600024A")]
		 set { } //Length: 26
	}

	[Obsolete("Use MinRotationOffset instead.", False)]
	[Token(Token = "0x1700008E")]
	public Vector3 minRotationOffset
	{
		[Address(RVA = "0x1DDF390", Offset = "0x1DDE790", Length = "0x16")]
		[Token(Token = "0x6000251")]
		 get { } //Length: 22
	}

	[Token(Token = "0x1700008F")]
	public Vector3 MinRotationOffset
	{
		[Address(RVA = "0x1DDF390", Offset = "0x1DDE790", Length = "0x16")]
		[Token(Token = "0x6000252")]
		 get { } //Length: 22
		[Address(RVA = "0x2E6C5C0", Offset = "0x2E6B9C0", Length = "0x1D")]
		[Token(Token = "0x6000253")]
		 set { } //Length: 29
	}

	[Obsolete("Use MinScaleOffset instead.", False)]
	[Token(Token = "0x17000094")]
	public Vector3 minScaleOffset
	{
		[Address(RVA = "0xE269B0", Offset = "0xE25DB0", Length = "0x19")]
		[Token(Token = "0x600025A")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000095")]
	public Vector3 MinScaleOffset
	{
		[Address(RVA = "0xE269B0", Offset = "0xE25DB0", Length = "0x19")]
		[Token(Token = "0x600025B")]
		 get { } //Length: 25
		[Address(RVA = "0x2E6C5E0", Offset = "0x2E6B9E0", Length = "0x23")]
		[Token(Token = "0x600025C")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000082")]
	public float MinSpacing
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[Token(Token = "0x600023E")]
		 get { } //Length: 6
		[Address(RVA = "0x2E6C610", Offset = "0x2E6BA10", Length = "0x73")]
		[Token(Token = "0x600023F")]
		 set { } //Length: 115
	}

	[Obsolete("Use PositionSpace instead.", False)]
	[Token(Token = "0x1700008C")]
	public OffsetSpace positionSpace
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[Token(Token = "0x600024E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700008D")]
	public OffsetSpace PositionSpace
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[Token(Token = "0x600024F")]
		 get { } //Length: 4
		[Address(RVA = "0x2E6C690", Offset = "0x2E6BA90", Length = "0x15")]
		[Token(Token = "0x6000250")]
		 set { } //Length: 21
	}

	[Obsolete("Use RotationSpace instead.", False)]
	[Token(Token = "0x17000092")]
	public OffsetSpace rotationSpace
	{
		[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
		[Token(Token = "0x6000257")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000093")]
	public OffsetSpace RotationSpace
	{
		[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
		[Token(Token = "0x6000258")]
		 get { } //Length: 7
		[Address(RVA = "0x2E6C6B0", Offset = "0x2E6BAB0", Length = "0x18")]
		[Token(Token = "0x6000259")]
		 set { } //Length: 24
	}

	[Obsolete("Use ScaleSpace instead.", False)]
	[Token(Token = "0x17000098")]
	public OffsetSpace scaleSpace
	{
		[Address(RVA = "0x1F7B3C0", Offset = "0x1F7A7C0", Length = "0x7")]
		[Token(Token = "0x6000260")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000099")]
	public OffsetSpace ScaleSpace
	{
		[Address(RVA = "0x1F7B3C0", Offset = "0x1F7A7C0", Length = "0x7")]
		[Token(Token = "0x6000261")]
		 get { } //Length: 7
		[Address(RVA = "0x2E6C6D0", Offset = "0x2E6BAD0", Length = "0x1B")]
		[Token(Token = "0x6000262")]
		 set { } //Length: 27
	}

	[Token(Token = "0x1700009E")]
	public int Seed
	{
		[Address(RVA = "0xE7DEE0", Offset = "0xE7D2E0", Length = "0x7")]
		[Token(Token = "0x6000268")]
		 get { } //Length: 7
		[Address(RVA = "0x2E6C6F0", Offset = "0x2E6BAF0", Length = "0xE")]
		[Token(Token = "0x6000269")]
		 set { } //Length: 14
	}

	[Obsolete("Use CoordinateSpace instead.", False)]
	[Token(Token = "0x17000080")]
	public Space space
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x600023B")]
		 get { } //Length: 4
	}

	[Obsolete("Use UpAxis instead.", False)]
	[Token(Token = "0x17000084")]
	public AlignAxis upAxis
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x6000242")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000085")]
	public AlignAxis UpAxis
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x6000243")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[Token(Token = "0x6000244")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2E6BFE0", Offset = "0x2E6B3E0", Length = "0x1AB")]
	[Token(Token = "0x600027F")]
	public SplineInstantiate() { }

	[Address(RVA = "0x2E678F0", Offset = "0x2E66CF0", Length = "0x3BC")]
	[Token(Token = "0x600026F")]
	private void CheckChildrenValidity() { }

	[Address(RVA = "0x2E67E40", Offset = "0x2E67240", Length = "0xE")]
	[Token(Token = "0x6000274")]
	public void Clear() { }

	[Address(RVA = "0x2E67CB0", Offset = "0x2E670B0", Length = "0x187")]
	[Token(Token = "0x6000277")]
	private void ClearDeprecatedInstances() { }

	[Address(RVA = "0x2E67E50", Offset = "0x2E67250", Length = "0x37A")]
	[Token(Token = "0x600026E")]
	private void EnsureItemsValidity() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000233")]
	public SplineContainer get_container() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000234")]
	public SplineContainer get_Container() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x600023C")]
	public Space get_CoordinateSpace() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x6000245")]
	public AlignAxis get_forwardAxis() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x6000246")]
	public AlignAxis get_ForwardAxis() { }

	[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
	[Token(Token = "0x6000265")]
	internal List<GameObject> get_instances() { }

	[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
	[Token(Token = "0x6000263")]
	internal GameObject get_InstancesRoot() { }

	[Address(RVA = "0x2E6C1B0", Offset = "0x2E6B5B0", Length = "0x239")]
	[Token(Token = "0x6000264")]
	private Transform get_instancesRootTransform() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000239")]
	public Method get_InstantiateMethod() { }

	[Address(RVA = "0x2E6C3F0", Offset = "0x2E6B7F0", Length = "0x44")]
	[Token(Token = "0x6000236")]
	public InstantiableItem[] get_itemsToInstantiate() { }

	[Address(RVA = "0x1CC6A40", Offset = "0x1CC5E40", Length = "0x13")]
	[Token(Token = "0x600024B")]
	public Vector3 get_maxPositionOffset() { }

	[Address(RVA = "0x1CC6A40", Offset = "0x1CC5E40", Length = "0x13")]
	[Token(Token = "0x600024C")]
	public Vector3 get_MaxPositionOffset() { }

	[Address(RVA = "0x2C2F790", Offset = "0x2C2EB90", Length = "0x9")]
	[Token(Token = "0x6000266")]
	private float get_maxProbability() { }

	[Address(RVA = "0x2DB5220", Offset = "0x2DB4620", Length = "0x19")]
	[Token(Token = "0x6000254")]
	public Vector3 get_maxRotationOffset() { }

	[Address(RVA = "0x2DB5220", Offset = "0x2DB4620", Length = "0x19")]
	[Token(Token = "0x6000255")]
	public Vector3 get_MaxRotationOffset() { }

	[Address(RVA = "0xE26960", Offset = "0xE25D60", Length = "0x19")]
	[Token(Token = "0x600025D")]
	public Vector3 get_maxScaleOffset() { }

	[Address(RVA = "0xE26960", Offset = "0xE25D60", Length = "0x19")]
	[Token(Token = "0x600025E")]
	public Vector3 get_MaxScaleOffset() { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[Token(Token = "0x6000240")]
	public float get_MaxSpacing() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000238")]
	public Method get_method() { }

	[Address(RVA = "0x2E6C190", Offset = "0x2E6B590", Length = "0x13")]
	[Token(Token = "0x6000248")]
	public Vector3 get_minPositionOffset() { }

	[Address(RVA = "0x2E6C190", Offset = "0x2E6B590", Length = "0x13")]
	[Token(Token = "0x6000249")]
	public Vector3 get_MinPositionOffset() { }

	[Address(RVA = "0x1DDF390", Offset = "0x1DDE790", Length = "0x16")]
	[Token(Token = "0x6000251")]
	public Vector3 get_minRotationOffset() { }

	[Address(RVA = "0x1DDF390", Offset = "0x1DDE790", Length = "0x16")]
	[Token(Token = "0x6000252")]
	public Vector3 get_MinRotationOffset() { }

	[Address(RVA = "0xE269B0", Offset = "0xE25DB0", Length = "0x19")]
	[Token(Token = "0x600025A")]
	public Vector3 get_minScaleOffset() { }

	[Address(RVA = "0xE269B0", Offset = "0xE25DB0", Length = "0x19")]
	[Token(Token = "0x600025B")]
	public Vector3 get_MinScaleOffset() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[Token(Token = "0x600023E")]
	public float get_MinSpacing() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[Token(Token = "0x600024E")]
	public OffsetSpace get_positionSpace() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[Token(Token = "0x600024F")]
	public OffsetSpace get_PositionSpace() { }

	[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
	[Token(Token = "0x6000257")]
	public OffsetSpace get_rotationSpace() { }

	[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
	[Token(Token = "0x6000258")]
	public OffsetSpace get_RotationSpace() { }

	[Address(RVA = "0x1F7B3C0", Offset = "0x1F7A7C0", Length = "0x7")]
	[Token(Token = "0x6000260")]
	public OffsetSpace get_scaleSpace() { }

	[Address(RVA = "0x1F7B3C0", Offset = "0x1F7A7C0", Length = "0x7")]
	[Token(Token = "0x6000261")]
	public OffsetSpace get_ScaleSpace() { }

	[Address(RVA = "0xE7DEE0", Offset = "0xE7D2E0", Length = "0x7")]
	[Token(Token = "0x6000268")]
	public int get_Seed() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x600023B")]
	public Space get_space() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x6000242")]
	public AlignAxis get_upAxis() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x6000243")]
	public AlignAxis get_UpAxis() { }

	[Address(RVA = "0x2E681D0", Offset = "0x2E675D0", Length = "0x317")]
	[Token(Token = "0x600027C")]
	private void GetCustomSpaceAxis(OffsetSpace space, float3 splineUp, float3 direction, Transform instanceTransform, out float3 customUp, out float3 customForward) { }

	[Address(RVA = "0x2E684F0", Offset = "0x2E678F0", Length = "0x12C")]
	[Token(Token = "0x600027D")]
	private int GetPrefabIndex() { }

	[Address(RVA = "0x2E68620", Offset = "0x2E67A20", Length = "0x89")]
	[Token(Token = "0x6000273")]
	private void InitContainer() { }

	[Address(RVA = "0x2E686B0", Offset = "0x2E67AB0", Length = "0x7E")]
	[Token(Token = "0x600026B")]
	private void OnDisable() { }

	[Address(RVA = "0x2E68730", Offset = "0x2E67B30", Length = "0x9A")]
	[Token(Token = "0x600026A")]
	private void OnEnable() { }

	[Address(RVA = "0x2E687D0", Offset = "0x2E67BD0", Length = "0xAF")]
	[Token(Token = "0x600027E")]
	private void OnSplineChanged(Spline spline, int knotIndex, SplineModification modificationType) { }

	[Address(RVA = "0x2E68880", Offset = "0x2E67C80", Length = "0x96")]
	[Token(Token = "0x600026D")]
	private void OnValidate() { }

	[Address(RVA = "0x2E68920", Offset = "0x2E67D20", Length = "0x35")]
	[Token(Token = "0x6000278")]
	public void Randomize() { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000235")]
	public void set_Container(SplineContainer value) { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[Token(Token = "0x600023D")]
	public void set_CoordinateSpace(Space value) { }

	[Address(RVA = "0x2E6C440", Offset = "0x2E6B840", Length = "0x53")]
	[Token(Token = "0x6000247")]
	public void set_ForwardAxis(AlignAxis value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x600023A")]
	public void set_InstantiateMethod(Method value) { }

	[Address(RVA = "0x2E6C700", Offset = "0x2E6BB00", Length = "0xB4")]
	[Token(Token = "0x6000237")]
	public void set_itemsToInstantiate(InstantiableItem[] value) { }

	[Address(RVA = "0x2E6C4A0", Offset = "0x2E6B8A0", Length = "0x1A")]
	[Token(Token = "0x600024D")]
	public void set_MaxPositionOffset(Vector3 value) { }

	[Address(RVA = "0x2E6C7C0", Offset = "0x2E6BBC0", Length = "0x1F")]
	[Token(Token = "0x6000267")]
	private void set_maxProbability(float value) { }

	[Address(RVA = "0x2E6C4C0", Offset = "0x2E6B8C0", Length = "0x20")]
	[Token(Token = "0x6000256")]
	public void set_MaxRotationOffset(Vector3 value) { }

	[Address(RVA = "0x2E6C4E0", Offset = "0x2E6B8E0", Length = "0x23")]
	[Token(Token = "0x600025F")]
	public void set_MaxScaleOffset(Vector3 value) { }

	[Address(RVA = "0x2E6C510", Offset = "0x2E6B910", Length = "0x82")]
	[Token(Token = "0x6000241")]
	public void set_MaxSpacing(float value) { }

	[Address(RVA = "0x2E6C5A0", Offset = "0x2E6B9A0", Length = "0x1A")]
	[Token(Token = "0x600024A")]
	public void set_MinPositionOffset(Vector3 value) { }

	[Address(RVA = "0x2E6C5C0", Offset = "0x2E6B9C0", Length = "0x1D")]
	[Token(Token = "0x6000253")]
	public void set_MinRotationOffset(Vector3 value) { }

	[Address(RVA = "0x2E6C5E0", Offset = "0x2E6B9E0", Length = "0x23")]
	[Token(Token = "0x600025C")]
	public void set_MinScaleOffset(Vector3 value) { }

	[Address(RVA = "0x2E6C610", Offset = "0x2E6BA10", Length = "0x73")]
	[Token(Token = "0x600023F")]
	public void set_MinSpacing(float value) { }

	[Address(RVA = "0x2E6C690", Offset = "0x2E6BA90", Length = "0x15")]
	[Token(Token = "0x6000250")]
	public void set_PositionSpace(OffsetSpace value) { }

	[Address(RVA = "0x2E6C6B0", Offset = "0x2E6BAB0", Length = "0x18")]
	[Token(Token = "0x6000259")]
	public void set_RotationSpace(OffsetSpace value) { }

	[Address(RVA = "0x2E6C6D0", Offset = "0x2E6BAD0", Length = "0x1B")]
	[Token(Token = "0x6000262")]
	public void set_ScaleSpace(OffsetSpace value) { }

	[Address(RVA = "0x2E6C6F0", Offset = "0x2E6BAF0", Length = "0xE")]
	[Token(Token = "0x6000269")]
	public void set_Seed(int value) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[Token(Token = "0x6000244")]
	public void set_UpAxis(AlignAxis value) { }

	[Address(RVA = "0x2E68960", Offset = "0x2E67D60", Length = "0x8")]
	[Token(Token = "0x6000275")]
	public void SetDirty() { }

	[Address(RVA = "0x2E68970", Offset = "0x2E67D70", Length = "0xB5")]
	[Token(Token = "0x6000272")]
	internal void SetSplineDirty(Spline spline) { }

	[Address(RVA = "0x2E68A30", Offset = "0x2E67E30", Length = "0x4C9")]
	[Token(Token = "0x600027B")]
	private bool SpawnPrefab(int index) { }

	[Address(RVA = "0x2E68F00", Offset = "0x2E68300", Length = "0x1C4")]
	[Token(Token = "0x6000276")]
	private void TryClearCache() { }

	[Address(RVA = "0x2E690D0", Offset = "0x2E684D0", Length = "0xF")]
	[Token(Token = "0x600026C")]
	private void UndoRedoPerformed() { }

	[Address(RVA = "0x2E6BF00", Offset = "0x2E6B300", Length = "0x11")]
	[Token(Token = "0x6000279")]
	private void Update() { }

	[Address(RVA = "0x2E690E0", Offset = "0x2E684E0", Length = "0x2E1D")]
	[Token(Token = "0x600027A")]
	public void UpdateInstances() { }

	[Address(RVA = "0x2E6BF20", Offset = "0x2E6B320", Length = "0x4F")]
	[Token(Token = "0x6000271")]
	private void ValidateAxis() { }

	[Address(RVA = "0x2E6BF70", Offset = "0x2E6B370", Length = "0x6A")]
	[Token(Token = "0x6000270")]
	private void ValidateSpacing() { }

}

