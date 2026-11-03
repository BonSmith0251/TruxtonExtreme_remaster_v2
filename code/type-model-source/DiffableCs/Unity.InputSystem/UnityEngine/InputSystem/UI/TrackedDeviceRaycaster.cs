namespace UnityEngine.InputSystem.UI;

[AddComponentMenu("Event/Tracked Device Raycaster")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/TrackedInputDevices.html#tracked-device-raycaster")]
[RequireComponent(typeof(Canvas))]
[Token(Token = "0x2000124")]
public class TrackedDeviceRaycaster : BaseRaycaster
{
	[CompilerGenerated]
	[Token(Token = "0x2000126")]
	private sealed class <>c
	{
		[Token(Token = "0x40006DB")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40006DC")]
		public static Comparison<RaycastHitData> <>9__25_0; //Field offset: 0x8

		[Address(RVA = "0x29E86F0", Offset = "0x29E7AF0", Length = "0x67")]
		[Token(Token = "0x6000E13")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E14")]
		public <>c() { }

		[Address(RVA = "0x29E86A0", Offset = "0x29E7AA0", Length = "0x4D")]
		[Token(Token = "0x6000E15")]
		internal int <SortedRaycastGraphics>b__25_0(RaycastHitData g1, RaycastHitData g2) { }

	}

	[Token(Token = "0x2000125")]
	private struct RaycastHitData
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D7")]
		private readonly Graphic <graphic>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006D8")]
		private readonly Vector3 <worldHitPosition>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40006D9")]
		private readonly Vector2 <screenPosition>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40006DA")]
		private readonly float <distance>k__BackingField; //Field offset: 0x1C

		[Token(Token = "0x170003BD")]
		public float distance
		{
			[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000E12")]
			 get { } //Length: 6
		}

		[Token(Token = "0x170003BA")]
		public Graphic graphic
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000E0F")]
			 get { } //Length: 4
		}

		[Token(Token = "0x170003BC")]
		public Vector2 screenPosition
		{
			[Address(RVA = "0x1806A80", Offset = "0x1805E80", Length = "0x13")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000E11")]
			 get { } //Length: 19
		}

		[Token(Token = "0x170003BB")]
		public Vector3 worldHitPosition
		{
			[Address(RVA = "0xAEF350", Offset = "0xAEE750", Length = "0x13")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000E10")]
			 get { } //Length: 19
		}

		[Address(RVA = "0x29E4E50", Offset = "0x29E4250", Length = "0x51")]
		[Token(Token = "0x6000E0E")]
		public RaycastHitData(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance) { }

		[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000E12")]
		public float get_distance() { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000E0F")]
		public Graphic get_graphic() { }

		[Address(RVA = "0x1806A80", Offset = "0x1805E80", Length = "0x13")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000E11")]
		public Vector2 get_screenPosition() { }

		[Address(RVA = "0xAEF350", Offset = "0xAEE750", Length = "0x13")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000E10")]
		public Vector3 get_worldHitPosition() { }

	}

	[Token(Token = "0x40006CF")]
	internal static InlinedArray<TrackedDeviceRaycaster> s_Instances; //Field offset: 0x0
	[Token(Token = "0x40006D0")]
	private static readonly List<RaycastHitData> s_SortedGraphics; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006CE")]
	private List<RaycastHitData> m_RaycastResultsCache; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("ignoreReversedGraphics")]
	[SerializeField]
	[Token(Token = "0x40006D1")]
	private bool m_IgnoreReversedGraphics; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[FormerlySerializedAs("checkFor2DOcclusion")]
	[SerializeField]
	[Token(Token = "0x40006D2")]
	private bool m_CheckFor2DOcclusion; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[FormerlySerializedAs("checkFor3DOcclusion")]
	[SerializeField]
	[Token(Token = "0x40006D3")]
	private bool m_CheckFor3DOcclusion; //Field offset: 0x32
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40006D4")]
	[Tooltip("Maximum distance (in 3D world space) that rays are traced to find a hit.")]
	private float m_MaxDistance; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40006D5")]
	private LayerMask m_BlockingMask; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006D6")]
	private Canvas m_Canvas; //Field offset: 0x40

	[Token(Token = "0x170003B4")]
	public LayerMask blockingMask
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000DFB")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[Token(Token = "0x6000DFC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003B9")]
	private Canvas canvas
	{
		[Address(RVA = "0x29E8390", Offset = "0x29E7790", Length = "0x8D")]
		[Token(Token = "0x6000E0B")]
		private get { } //Length: 141
	}

	[Token(Token = "0x170003B6")]
	public bool checkFor2DOcclusion
	{
		[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
		[Token(Token = "0x6000DFF")]
		 get { } //Length: 5
		[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
		[Token(Token = "0x6000E00")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003B5")]
	public bool checkFor3DOcclusion
	{
		[Address(RVA = "0x1E075C0", Offset = "0x1E069C0", Length = "0x5")]
		[Token(Token = "0x6000DFD")]
		 get { } //Length: 5
		[Address(RVA = "0x1E075F0", Offset = "0x1E069F0", Length = "0x4")]
		[Token(Token = "0x6000DFE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003B3")]
	public virtual Camera eventCamera
	{
		[Address(RVA = "0x29E8420", Offset = "0x29E7820", Length = "0x79")]
		[Token(Token = "0x6000DFA")]
		 get { } //Length: 121
	}

	[Token(Token = "0x170003B7")]
	public bool ignoreReversedGraphics
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6000E01")]
		 get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[Token(Token = "0x6000E02")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003B8")]
	public float maxDistance
	{
		[Address(RVA = "0x1BBC130", Offset = "0x1BBB530", Length = "0x6")]
		[Token(Token = "0x6000E03")]
		 get { } //Length: 6
		[Address(RVA = "0x1BBC1D0", Offset = "0x1BBB5D0", Length = "0x6")]
		[Token(Token = "0x6000E04")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x29E8280", Offset = "0x29E7680", Length = "0x89")]
	[Token(Token = "0x6000E0D")]
	private static TrackedDeviceRaycaster() { }

	[Address(RVA = "0x29E8310", Offset = "0x29E7710", Length = "0x7E")]
	[Token(Token = "0x6000E0C")]
	public TrackedDeviceRaycaster() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000DFB")]
	public LayerMask get_blockingMask() { }

	[Address(RVA = "0x29E8390", Offset = "0x29E7790", Length = "0x8D")]
	[Token(Token = "0x6000E0B")]
	private Canvas get_canvas() { }

	[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
	[Token(Token = "0x6000DFF")]
	public bool get_checkFor2DOcclusion() { }

	[Address(RVA = "0x1E075C0", Offset = "0x1E069C0", Length = "0x5")]
	[Token(Token = "0x6000DFD")]
	public bool get_checkFor3DOcclusion() { }

	[Address(RVA = "0x29E8420", Offset = "0x29E7820", Length = "0x79")]
	[Token(Token = "0x6000DFA")]
	public virtual Camera get_eventCamera() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6000E01")]
	public bool get_ignoreReversedGraphics() { }

	[Address(RVA = "0x1BBC130", Offset = "0x1BBB530", Length = "0x6")]
	[Token(Token = "0x6000E03")]
	public float get_maxDistance() { }

	[Address(RVA = "0x29E6EA0", Offset = "0x29E62A0", Length = "0xDA")]
	[Token(Token = "0x6000E06")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x29E6F80", Offset = "0x29E6380", Length = "0x78")]
	[Token(Token = "0x6000E05")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x29E7000", Offset = "0x29E6400", Length = "0x672")]
	[Token(Token = "0x6000E08")]
	internal void PerformRaycast(ExtendedPointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[Address(RVA = "0x29E7C50", Offset = "0x29E7050", Length = "0x8E")]
	[Token(Token = "0x6000E07")]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[Address(RVA = "0x29E7680", Offset = "0x29E6A80", Length = "0x5CF")]
	[Token(Token = "0x6000E0A")]
	private static bool RayIntersectsRectTransform(RectTransform transform, Ray ray, out Vector3 worldPosition, out float distance) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x6000DFC")]
	public void set_blockingMask(LayerMask value) { }

	[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
	[Token(Token = "0x6000E00")]
	public void set_checkFor2DOcclusion(bool value) { }

	[Address(RVA = "0x1E075F0", Offset = "0x1E069F0", Length = "0x4")]
	[Token(Token = "0x6000DFE")]
	public void set_checkFor3DOcclusion(bool value) { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[Token(Token = "0x6000E02")]
	public void set_ignoreReversedGraphics(bool value) { }

	[Address(RVA = "0x1BBC1D0", Offset = "0x1BBB5D0", Length = "0x6")]
	[Token(Token = "0x6000E04")]
	public void set_maxDistance(float value) { }

	[Address(RVA = "0x29E7CE0", Offset = "0x29E70E0", Length = "0x591")]
	[Token(Token = "0x6000E09")]
	private void SortedRaycastGraphics(Canvas canvas, Ray ray, List<RaycastHitData> results) { }

}

