namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Helpers/Cinemachine Spline Cart")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineSplineCart.html")]
[Token(Token = "0x2000043")]
public class CinemachineSplineCart : MonoBehaviour, ISplineReferencer
{
	[Token(Token = "0x2000044")]
	internal enum UpdateMethods : int
	{
		Update = 0,
		FixedUpdate = 1,
		LateUpdate = 2,
	}

	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("SplineSettings")]
	[SerializeField]
	[Token(Token = "0x4000101")]
	private SplineSettings m_SplineSettings; //Field offset: 0x20
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000102")]
	[Tooltip("When to move the cart, if Speed is non-zero")]
	public UpdateMethods UpdateMethod; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x4000103")]
	[Tooltip("Controls how automatic dollying occurs.  A tracking target may be necessary to use this feature.")]
	public SplineAutoDolly AutomaticDolly; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000104")]
	[Tooltip("Used only by Automatic Dolly settings that require it")]
	public Transform TrackingTarget; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000105")]
	private RollCache m_RollCache; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[FormerlySerializedAs("SplinePosition")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x4000106")]
	private float m_LegacyPosition; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[FormerlySerializedAs("PositionUnits")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x4000107")]
	private PathIndexUnit m_LegacyUnits; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("Spline")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x4000108")]
	private SplineContainer m_LegacySpline; //Field offset: 0x70

	[Token(Token = "0x17000029")]
	public PathIndexUnit PositionUnits
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6000127")]
		 get { } //Length: 4
		[Address(RVA = "0x2815D70", Offset = "0x2815170", Length = "0xC")]
		[Token(Token = "0x6000128")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000027")]
	public SplineContainer Spline
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000123")]
		 get { } //Length: 5
		[Address(RVA = "0x2815D80", Offset = "0x2815180", Length = "0xC")]
		[Token(Token = "0x6000124")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000028")]
	public float SplinePosition
	{
		[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
		[Token(Token = "0x6000125")]
		 get { } //Length: 6
		[Address(RVA = "0x1D3E540", Offset = "0x1D3D940", Length = "0x6")]
		[Token(Token = "0x6000126")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000026")]
	public override SplineSettings SplineSettings
	{
		[Address(RVA = "0x2815D60", Offset = "0x2815160", Length = "0x5")]
		[Token(Token = "0x6000122")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2815D10", Offset = "0x2815110", Length = "0x47")]
	[Token(Token = "0x6000133")]
	public CinemachineSplineCart() { }

	[Address(RVA = "0x2815610", Offset = "0x2814A10", Length = "0xE")]
	[Token(Token = "0x600012E")]
	private void FixedUpdate() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000127")]
	public PathIndexUnit get_PositionUnits() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000123")]
	public SplineContainer get_Spline() { }

	[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
	[Token(Token = "0x6000125")]
	public float get_SplinePosition() { }

	[Address(RVA = "0x2815D60", Offset = "0x2815160", Length = "0x5")]
	[Token(Token = "0x6000122")]
	public override SplineSettings get_SplineSettings() { }

	[Address(RVA = "0x2815620", Offset = "0x2814A20", Length = "0x75")]
	[Token(Token = "0x6000130")]
	private void LateUpdate() { }

	[Address(RVA = "0x28156A0", Offset = "0x2814AA0", Length = "0xB")]
	[Token(Token = "0x600012D")]
	private void OnDisable() { }

	[Address(RVA = "0x28156B0", Offset = "0x2814AB0", Length = "0x59")]
	[Token(Token = "0x600012C")]
	private void OnEnable() { }

	[Address(RVA = "0x2815710", Offset = "0x2814B10", Length = "0xDE")]
	[Token(Token = "0x600012A")]
	private void OnValidate() { }

	[Address(RVA = "0x28157F0", Offset = "0x2814BF0", Length = "0xAB")]
	[Token(Token = "0x6000129")]
	private void PerformLegacyUpgrade() { }

	[Address(RVA = "0x28158A0", Offset = "0x2814CA0", Length = "0x63")]
	[Token(Token = "0x600012B")]
	private void Reset() { }

	[Address(RVA = "0x2815D70", Offset = "0x2815170", Length = "0xC")]
	[Token(Token = "0x6000128")]
	public void set_PositionUnits(PathIndexUnit value) { }

	[Address(RVA = "0x2815D80", Offset = "0x2815180", Length = "0xC")]
	[Token(Token = "0x6000124")]
	public void set_Spline(SplineContainer value) { }

	[Address(RVA = "0x1D3E540", Offset = "0x1D3D940", Length = "0x6")]
	[Token(Token = "0x6000126")]
	public void set_SplinePosition(float value) { }

	[Address(RVA = "0x2815910", Offset = "0x2814D10", Length = "0x215")]
	[Token(Token = "0x6000132")]
	private void SetCartPosition(float distanceAlongPath) { }

	[Address(RVA = "0x2815C90", Offset = "0x2815090", Length = "0x75")]
	[Token(Token = "0x600012F")]
	private void Update() { }

	[Address(RVA = "0x2815B30", Offset = "0x2814F30", Length = "0x153")]
	[Token(Token = "0x6000131")]
	private void UpdateCartPosition() { }

}

