namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Physics Raycaster")]
[RequireComponent(typeof(Camera))]
[Token(Token = "0x20000CA")]
public class PhysicsRaycaster : BaseRaycaster
{
	[Token(Token = "0x20000CB")]
	private class RaycastHitComparer : IComparer<RaycastHit>
	{
		[Token(Token = "0x4000373")]
		public static RaycastHitComparer instance; //Field offset: 0x0

		[Address(RVA = "0x346F760", Offset = "0x346EB60", Length = "0x67")]
		[Token(Token = "0x600079A")]
		private static RaycastHitComparer() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000799")]
		public RaycastHitComparer() { }

		[Address(RVA = "0x346F710", Offset = "0x346EB10", Length = "0x41")]
		[Token(Token = "0x6000798")]
		public override int Compare(RaycastHit x, RaycastHit y) { }

	}

	[Token(Token = "0x400036D")]
	protected const int kNoEventMaskSet = -1; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400036E")]
	protected Camera m_EventCamera; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400036F")]
	protected LayerMask m_EventMask; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000370")]
	protected int m_MaxRayIntersections; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000371")]
	protected int m_LastMaxRayIntersections; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000372")]
	private RaycastHit[] m_Hits; //Field offset: 0x40

	[Token(Token = "0x17000204")]
	public override int depth
	{
		[Address(RVA = "0x346BA30", Offset = "0x346AE30", Length = "0xB1")]
		[Token(Token = "0x6000790")]
		 get { } //Length: 177
	}

	[Token(Token = "0x17000203")]
	public virtual Camera eventCamera
	{
		[Address(RVA = "0x346BAF0", Offset = "0x346AEF0", Length = "0xC8")]
		[Token(Token = "0x600078F")]
		 get { } //Length: 200
	}

	[Token(Token = "0x17000206")]
	public LayerMask eventMask
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000792")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x6000793")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000205")]
	public int finalEventMask
	{
		[Address(RVA = "0x346BBC0", Offset = "0x346AFC0", Length = "0xBB")]
		[Token(Token = "0x6000791")]
		 get { } //Length: 187
	}

	[Token(Token = "0x17000207")]
	public int maxRayIntersections
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6000794")]
		 get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[Token(Token = "0x6000795")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x346B090", Offset = "0x346A490", Length = "0x27")]
	[Token(Token = "0x600078E")]
	protected PhysicsRaycaster() { }

	[Address(RVA = "0x346B0C0", Offset = "0x346A4C0", Length = "0x402")]
	[Token(Token = "0x6000796")]
	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane) { }

	[Address(RVA = "0x346BA30", Offset = "0x346AE30", Length = "0xB1")]
	[Token(Token = "0x6000790")]
	public override int get_depth() { }

	[Address(RVA = "0x346BAF0", Offset = "0x346AEF0", Length = "0xC8")]
	[Token(Token = "0x600078F")]
	public virtual Camera get_eventCamera() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000792")]
	public LayerMask get_eventMask() { }

	[Address(RVA = "0x346BBC0", Offset = "0x346AFC0", Length = "0xBB")]
	[Token(Token = "0x6000791")]
	public int get_finalEventMask() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6000794")]
	public int get_maxRayIntersections() { }

	[Address(RVA = "0x346B4D0", Offset = "0x346A8D0", Length = "0x55A")]
	[Token(Token = "0x6000797")]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x6000793")]
	public void set_eventMask(LayerMask value) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[Token(Token = "0x6000795")]
	public void set_maxRayIntersections(int value) { }

}

