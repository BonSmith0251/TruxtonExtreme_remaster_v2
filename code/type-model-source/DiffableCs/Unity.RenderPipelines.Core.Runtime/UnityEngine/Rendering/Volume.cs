namespace UnityEngine.Rendering;

[AddComponentMenu("Miscellaneous/Volume")]
[ExecuteAlways]
[Token(Token = "0x20001F1")]
public class Volume : MonoBehaviour, IVolume
{
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("isGlobal")]
	[SerializeField]
	[Token(Token = "0x4000965")]
	private bool m_IsGlobal; //Field offset: 0x20
	[Delayed]
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("m_Priority")]
	[Token(Token = "0x4000966")]
	public float priority; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_BlendDistance")]
	[Token(Token = "0x4000967")]
	public float blendDistance; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[FormerlySerializedAs("m_Weight")]
	[Range(0, 1)]
	[Token(Token = "0x4000968")]
	public float weight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000969")]
	public VolumeProfile sharedProfile; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400096A")]
	private readonly List<Collider> m_Colliders; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400096B")]
	private GameObject m_CachedGameObject; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400096C")]
	private int m_PreviousLayer; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400096D")]
	private float m_PreviousPriority; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400096E")]
	private VolumeProfile m_InternalProfile; //Field offset: 0x50

	[Token(Token = "0x170001E3")]
	internal GameObject cachedGameObject
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000EC7")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001E2")]
	public override List<Collider> colliders
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000EC6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001E0")]
	public override bool isGlobal
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6000EC2")]
		 get { } //Length: 5
		[Address(RVA = "0x2C6BA20", Offset = "0x2C6AE20", Length = "0x49")]
		[Token(Token = "0x6000EC3")]
		 set { } //Length: 73
	}

	[Token(Token = "0x170001E1")]
	public VolumeProfile profile
	{
		[Address(RVA = "0x2C6B760", Offset = "0x2C6AB60", Length = "0x2BE")]
		[Token(Token = "0x6000EC4")]
		 get { } //Length: 702
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x6000EC5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001E4")]
	internal VolumeProfile profileRef
	{
		[Address(RVA = "0x2C6B6E0", Offset = "0x2C6AAE0", Length = "0x71")]
		[Token(Token = "0x6000EC8")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x2C6B650", Offset = "0x2C6AA50", Length = "0x82")]
	[Token(Token = "0x6000ED1")]
	public Volume() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000EC7")]
	internal GameObject get_cachedGameObject() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000EC6")]
	public override List<Collider> get_colliders() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6000EC2")]
	public override bool get_isGlobal() { }

	[Address(RVA = "0x2C6B760", Offset = "0x2C6AB60", Length = "0x2BE")]
	[Token(Token = "0x6000EC4")]
	public VolumeProfile get_profile() { }

	[Address(RVA = "0x2C6B6E0", Offset = "0x2C6AAE0", Length = "0x71")]
	[Token(Token = "0x6000EC8")]
	internal VolumeProfile get_profileRef() { }

	[Address(RVA = "0x2C6B1F0", Offset = "0x2C6A5F0", Length = "0x50")]
	[Token(Token = "0x6000EC9")]
	public bool HasInstantiatedProfile() { }

	[Address(RVA = "0x2C6B240", Offset = "0x2C6A640", Length = "0x5E")]
	[Token(Token = "0x6000ECB")]
	private void OnDisable() { }

	[Address(RVA = "0x2C6B2A0", Offset = "0x2C6A6A0", Length = "0xBA")]
	[Token(Token = "0x6000ECA")]
	private void OnEnable() { }

	[Address(RVA = "0x2C6B360", Offset = "0x2C6A760", Length = "0x14")]
	[Token(Token = "0x6000ED0")]
	private void OnValidate() { }

	[Address(RVA = "0x2C6BA20", Offset = "0x2C6AE20", Length = "0x49")]
	[Token(Token = "0x6000EC3")]
	public override void set_isGlobal(bool value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x6000EC5")]
	public void set_profile(VolumeProfile value) { }

	[Address(RVA = "0x2C6B520", Offset = "0x2C6A920", Length = "0x12B")]
	[Token(Token = "0x6000ECC")]
	private void Update() { }

	[Address(RVA = "0x2C6B380", Offset = "0x2C6A780", Length = "0x3D")]
	[Token(Token = "0x6000ECD")]
	public void UpdateColliders() { }

	[Address(RVA = "0x2C6B3C0", Offset = "0x2C6A7C0", Length = "0x90")]
	[Token(Token = "0x6000ECE")]
	internal void UpdateLayer() { }

	[Address(RVA = "0x2C6B460", Offset = "0x2C6A860", Length = "0xB1")]
	[Token(Token = "0x6000ECF")]
	internal void UpdatePriority() { }

}

