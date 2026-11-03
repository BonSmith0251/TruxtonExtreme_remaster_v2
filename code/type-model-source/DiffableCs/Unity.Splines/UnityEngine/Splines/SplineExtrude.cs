namespace UnityEngine.Splines;

[AddComponentMenu("Splines/Spline Extrude")]
[ExecuteAlways]
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[Token(Token = "0x2000039")]
public class SplineExtrude : MonoBehaviour
{
	[Token(Token = "0x40000DB")]
	internal static readonly string k_EmptyContainerError; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000CA")]
	[Tooltip("The Spline to extrude.")]
	private SplineContainer m_Container; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000CB")]
	[Tooltip("The mesh that should be extruded. If none, a temporary mesh will be created.")]
	private Mesh m_TargetMesh; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000CC")]
	[Tooltip("Enable to regenerate the extruded mesh when the target Spline is modified. Disable this option if the Spline will not be modified at runtime.")]
	private bool m_RebuildOnSplineChange; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40000CD")]
	[Tooltip("The maximum number of times per-second that the mesh will be rebuilt.")]
	private int m_RebuildFrequency; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40000CE")]
	[Tooltip("Automatically update any Mesh, Box, or Sphere collider components when the mesh is extruded.")]
	private bool m_UpdateColliders; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40000CF")]
	[Tooltip("The number of sides that comprise the radius of the mesh.")]
	private int m_Sides; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40000D0")]
	[Tooltip("The number of edge loops that comprise the length of one unit of the mesh. The total number of sections is equal to \"Spline.GetLength() * segmentsPerUnit\".")]
	private float m_SegmentsPerUnit; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x40000D1")]
	[Tooltip("Indicates if the start and end of the mesh are filled. When the target Spline is closed or when the profile of the shape to extrude is concave, this setting is ignored.")]
	private bool m_Capped; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40000D2")]
	[Tooltip("The radius of the extruded mesh.")]
	private float m_Radius; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40000D3")]
	[Tooltip("The section of the Spline to extrude.")]
	private Vector2 m_Range; //Field offset: 0x4C
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x40000D4")]
	[Tooltip("Set true to reverse the winding order of vertices so that the face normals are inverted.")]
	private bool m_FlipNormals; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000D5")]
	private Mesh m_Mesh; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000D6")]
	private float m_NextScheduledRebuild; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40000D7")]
	private float m_AutosmoothAngle; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000D8")]
	private bool m_RebuildRequested; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x40000D9")]
	private bool m_CanCapEnds; //Field offset: 0x69
	[FieldOffset(Offset = "0x70")]
	[SerializeReference]
	[Token(Token = "0x40000DA")]
	private IExtrudeShape m_Shape; //Field offset: 0x70

	[Token(Token = "0x1700005E")]
	internal bool CanCapEnds
	{
		[Address(RVA = "0x16D07D0", Offset = "0x16CFBD0", Length = "0x5")]
		[Token(Token = "0x60001EA")]
		internal get { } //Length: 5
	}

	[Obsolete("Use Capped instead.", False)]
	[Token(Token = "0x1700006A")]
	public bool capped
	{
		[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
		[Token(Token = "0x60001FC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006B")]
	public bool Capped
	{
		[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
		[Token(Token = "0x60001FD")]
		 get { } //Length: 5
		[Address(RVA = "0x22BA530", Offset = "0x22B9930", Length = "0x4")]
		[Token(Token = "0x60001FE")]
		 set { } //Length: 4
	}

	[Obsolete("Use Container instead.", False)]
	[Token(Token = "0x17000060")]
	public SplineContainer container
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60001ED")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000061")]
	public SplineContainer Container
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60001EE")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60001EF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000070")]
	public bool FlipNormals
	{
		[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
		[Token(Token = "0x6000205")]
		 get { } //Length: 5
		[Address(RVA = "0x1CEB110", Offset = "0x1CEA510", Length = "0x4")]
		[Token(Token = "0x6000206")]
		 set { } //Length: 4
	}

	[Obsolete("Use Radius instead.", False)]
	[Token(Token = "0x1700006C")]
	public float radius
	{
		[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
		[Token(Token = "0x60001FF")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700006D")]
	public float Radius
	{
		[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
		[Token(Token = "0x6000200")]
		 get { } //Length: 6
		[Address(RVA = "0x2E63AF0", Offset = "0x2E62EF0", Length = "0x10")]
		[Token(Token = "0x6000201")]
		 set { } //Length: 16
	}

	[Obsolete("Use Range instead.", False)]
	[Token(Token = "0x1700006E")]
	public Vector2 range
	{
		[Address(RVA = "0x2E63A70", Offset = "0x2E62E70", Length = "0x13")]
		[Token(Token = "0x6000202")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700006F")]
	public Vector2 Range
	{
		[Address(RVA = "0x2E63A70", Offset = "0x2E62E70", Length = "0x13")]
		[Token(Token = "0x6000203")]
		 get { } //Length: 19
		[Address(RVA = "0x2E63B00", Offset = "0x2E62F00", Length = "0x25")]
		[Token(Token = "0x6000204")]
		 set { } //Length: 37
	}

	[Obsolete("Use RebuildFrequency instead.", False)]
	[Token(Token = "0x17000064")]
	public int rebuildFrequency
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x60001F3")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000065")]
	public int RebuildFrequency
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x60001F4")]
		 get { } //Length: 4
		[Address(RVA = "0x2E63B30", Offset = "0x2E62F30", Length = "0x10")]
		[Token(Token = "0x60001F5")]
		 set { } //Length: 16
	}

	[Obsolete("Use RebuildOnSplineChange instead.", False)]
	[Token(Token = "0x17000062")]
	public bool rebuildOnSplineChange
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x60001F0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000063")]
	public bool RebuildOnSplineChange
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x60001F1")]
		 get { } //Length: 5
		[Address(RVA = "0x2E63B40", Offset = "0x2E62F40", Length = "0xB")]
		[Token(Token = "0x60001F2")]
		 set { } //Length: 11
	}

	[Obsolete("Use SegmentsPerUnit instead.", False)]
	[Token(Token = "0x17000068")]
	public float segmentsPerUnit
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[Token(Token = "0x60001F9")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000069")]
	public float SegmentsPerUnit
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[Token(Token = "0x60001FA")]
		 get { } //Length: 6
		[Address(RVA = "0x2E63B50", Offset = "0x2E62F50", Length = "0x10")]
		[Token(Token = "0x60001FB")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700005F")]
	internal IExtrudeShape Shape
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x60001EB")]
		internal get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x60001EC")]
		internal set { } //Length: 13
	}

	[Obsolete("Use Sides instead.", False)]
	[Token(Token = "0x17000066")]
	public int sides
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x60001F6")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000067")]
	public int Sides
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x60001F7")]
		 get { } //Length: 4
		[Address(RVA = "0x2E63B60", Offset = "0x2E62F60", Length = "0x83")]
		[Token(Token = "0x60001F8")]
		 set { } //Length: 131
	}

	[Obsolete("Use Spline instead.", False)]
	[Token(Token = "0x17000072")]
	public Spline spline
	{
		[Address(RVA = "0x2E63A90", Offset = "0x2E62E90", Length = "0x3E")]
		[Token(Token = "0x6000209")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000073")]
	public Spline Spline
	{
		[Address(RVA = "0x2E63A90", Offset = "0x2E62E90", Length = "0x3E")]
		[Token(Token = "0x600020A")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000074")]
	public IReadOnlyList<Spline> Splines
	{
		[Address(RVA = "0x2E63AD0", Offset = "0x2E62ED0", Length = "0x13")]
		[Token(Token = "0x600020B")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000071")]
	public Mesh targetMesh
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000207")]
		 get { } //Length: 5
		[Address(RVA = "0x2E63BF0", Offset = "0x2E62FF0", Length = "0x9A")]
		[Token(Token = "0x6000208")]
		 set { } //Length: 154
	}

	[Address(RVA = "0x2E639C0", Offset = "0x2E62DC0", Length = "0x62")]
	[Token(Token = "0x6000219")]
	private static SplineExtrude() { }

	[Address(RVA = "0x2E63A30", Offset = "0x2E62E30", Length = "0x3E")]
	[Token(Token = "0x6000218")]
	public SplineExtrude() { }

	[Address(RVA = "0x2E61F20", Offset = "0x2E61320", Length = "0xBA9")]
	[Token(Token = "0x6000216")]
	private void AutosmoothNormals() { }

	[Address(RVA = "0x2E62AD0", Offset = "0x2E61ED0", Length = "0x106")]
	[Token(Token = "0x6000214")]
	private void CleanupMesh() { }

	[Address(RVA = "0x2E62BE0", Offset = "0x2E61FE0", Length = "0x72")]
	[Token(Token = "0x6000217")]
	internal Mesh CreateMeshAsset() { }

	[Address(RVA = "0x2E62C60", Offset = "0x2E62060", Length = "0x170")]
	[Token(Token = "0x6000213")]
	private void EnsureMeshExists() { }

	[Address(RVA = "0x16D07D0", Offset = "0x16CFBD0", Length = "0x5")]
	[Token(Token = "0x60001EA")]
	internal bool get_CanCapEnds() { }

	[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
	[Token(Token = "0x60001FC")]
	public bool get_capped() { }

	[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
	[Token(Token = "0x60001FD")]
	public bool get_Capped() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60001ED")]
	public SplineContainer get_container() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60001EE")]
	public SplineContainer get_Container() { }

	[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
	[Token(Token = "0x6000205")]
	public bool get_FlipNormals() { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[Token(Token = "0x60001FF")]
	public float get_radius() { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[Token(Token = "0x6000200")]
	public float get_Radius() { }

	[Address(RVA = "0x2E63A70", Offset = "0x2E62E70", Length = "0x13")]
	[Token(Token = "0x6000202")]
	public Vector2 get_range() { }

	[Address(RVA = "0x2E63A70", Offset = "0x2E62E70", Length = "0x13")]
	[Token(Token = "0x6000203")]
	public Vector2 get_Range() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x60001F3")]
	public int get_rebuildFrequency() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x60001F4")]
	public int get_RebuildFrequency() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x60001F0")]
	public bool get_rebuildOnSplineChange() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x60001F1")]
	public bool get_RebuildOnSplineChange() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[Token(Token = "0x60001F9")]
	public float get_segmentsPerUnit() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[Token(Token = "0x60001FA")]
	public float get_SegmentsPerUnit() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x60001EB")]
	internal IExtrudeShape get_Shape() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x60001F6")]
	public int get_sides() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x60001F7")]
	public int get_Sides() { }

	[Address(RVA = "0x2E63A90", Offset = "0x2E62E90", Length = "0x3E")]
	[Token(Token = "0x6000209")]
	public Spline get_spline() { }

	[Address(RVA = "0x2E63A90", Offset = "0x2E62E90", Length = "0x3E")]
	[Token(Token = "0x600020A")]
	public Spline get_Spline() { }

	[Address(RVA = "0x2E63AD0", Offset = "0x2E62ED0", Length = "0x13")]
	[Token(Token = "0x600020B")]
	public IReadOnlyList<Spline> get_Splines() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000207")]
	public Mesh get_targetMesh() { }

	[Address(RVA = "0x2E62DE0", Offset = "0x2E621E0", Length = "0xD2")]
	[Token(Token = "0x600020D")]
	private bool IsNullOrEmptyContainer() { }

	[Address(RVA = "0x2E62EC0", Offset = "0x2E622C0", Length = "0x77")]
	[Token(Token = "0x6000210")]
	private void OnDisable() { }

	[Address(RVA = "0x2E62F40", Offset = "0x2E62340", Length = "0x90")]
	[Token(Token = "0x600020F")]
	private void OnEnable() { }

	[Address(RVA = "0x2E62FD0", Offset = "0x2E623D0", Length = "0x15F")]
	[Token(Token = "0x6000211")]
	private void OnSplineChanged(Spline spline, int knotIndex, SplineModification modificationType) { }

	[Address(RVA = "0x2E63130", Offset = "0x2E62530", Length = "0x603")]
	[Token(Token = "0x6000215")]
	public void Rebuild() { }

	[Address(RVA = "0x2E63740", Offset = "0x2E62B40", Length = "0x151")]
	[Token(Token = "0x600020C")]
	internal void Reset() { }

	[Address(RVA = "0x22BA530", Offset = "0x22B9930", Length = "0x4")]
	[Token(Token = "0x60001FE")]
	public void set_Capped(bool value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60001EF")]
	public void set_Container(SplineContainer value) { }

	[Address(RVA = "0x1CEB110", Offset = "0x1CEA510", Length = "0x4")]
	[Token(Token = "0x6000206")]
	public void set_FlipNormals(bool value) { }

	[Address(RVA = "0x2E63AF0", Offset = "0x2E62EF0", Length = "0x10")]
	[Token(Token = "0x6000201")]
	public void set_Radius(float value) { }

	[Address(RVA = "0x2E63B00", Offset = "0x2E62F00", Length = "0x25")]
	[Token(Token = "0x6000204")]
	public void set_Range(Vector2 value) { }

	[Address(RVA = "0x2E63B30", Offset = "0x2E62F30", Length = "0x10")]
	[Token(Token = "0x60001F5")]
	public void set_RebuildFrequency(int value) { }

	[Address(RVA = "0x2E63B40", Offset = "0x2E62F40", Length = "0xB")]
	[Token(Token = "0x60001F2")]
	public void set_RebuildOnSplineChange(bool value) { }

	[Address(RVA = "0x2E63B50", Offset = "0x2E62F50", Length = "0x10")]
	[Token(Token = "0x60001FB")]
	public void set_SegmentsPerUnit(float value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x60001EC")]
	internal void set_Shape(IExtrudeShape value) { }

	[Address(RVA = "0x2E63B60", Offset = "0x2E62F60", Length = "0x83")]
	[Token(Token = "0x60001F8")]
	public void set_Sides(int value) { }

	[Address(RVA = "0x2E63BF0", Offset = "0x2E62FF0", Length = "0x9A")]
	[Token(Token = "0x6000208")]
	public void set_targetMesh(Mesh value) { }

	[Address(RVA = "0x2E638A0", Offset = "0x2E62CA0", Length = "0xD6")]
	[Token(Token = "0x600020E")]
	internal void SetSplineContainerOnGO() { }

	[Address(RVA = "0x2E63980", Offset = "0x2E62D80", Length = "0x31")]
	[Token(Token = "0x6000212")]
	private void Update() { }

}

